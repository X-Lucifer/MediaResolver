using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Forms;
using X.MediaResolver.Models;
using X.MediaResolver.Properties;

namespace X.MediaResolver
{
    public partial class FormMain : FrmWithTitle
    {
        private XMusic _music;
        private XVideo _video;
        private XAuthor _author;
        private XConfig _config;
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnConfig_BtnClick(object sender, EventArgs e)
        {
            FormConfig form = new FormConfig();
            form.OnConfigRefreshed += Form_OnConfigRefreshed;
            form.ShowDialog(this);
        }

        private void Form_OnConfigRefreshed(object sender, EventArgs e)
        {
            _config = (XConfig) sender;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Init();
        }

        private async void btnAnalysis_BtnClick(object sender, EventArgs e)
        {
            var text = txtLink.InputText.TrimEnd();
            if (string.IsNullOrEmpty(text))
            {
                txtLink.Focus();
                return;
            }

            var url = Logic.GetUrl(text);
            if (string.IsNullOrEmpty(url))
            {
                var result = FrmTips.ShowTipsWarning(this, "请输入分享链接地址");
                result.Closing += (s, x) =>
                {
                    txtLink.InputText = "";
                };
                txtLink.Focus();
                return;
            }

            DisposeAll();
            var douyin = await Logic.GetDouyin(url);
            if (douyin == null || douyin.status_code != 0 || douyin.item_list == null || douyin.item_list.Length <= 0)
            {
                var result = FrmTips.ShowTipsWarning(this, "解析失败");
                result.Closing += (s, x) => { txtLink.InputText = ""; };
                txtLink.Focus();
                return;
            }

            var xdouyin = douyin.item_list.FirstOrDefault();
            if (xdouyin == null)
            {
                var result = FrmTips.ShowTipsWarning(this, "解析失败");
                result.Closing += (s, x) => { txtLink.InputText = ""; };
                txtLink.Focus();
                return;
            }
            string hash = Guid.NewGuid().ToString("N");
            _music = Logic.GetXMusic(xdouyin.music, hash);
            _video = await Logic.GetXVideo(xdouyin.video, hash);
            _author = await Logic.GetXAuthor(xdouyin.author, hash);
            if (_author != null)
            {
                panelRight.Visible = true;
                txtUserid.Text = @"抖音号: " + _author.UniqueId;
                txtNickname.Text = _author.Name;
                picAvatar.Image = _author.Avatar;
                txtDescription.Text = xdouyin.desc ?? "";
            }

            if (_video != null)
            {
                panelLeft.Visible = true;
                picVideo.Image = _video.Poster;
                picVideo.Click += PicVideo_Click;
                if (_video.VideoUrl != null)
                {
                    btnDownload.Visible = true;
                    ucProcess.Visible = true;
                }
            }
        }

        private void PicVideo_Click(object sender, EventArgs e)
        {
            FormPreview preview = new FormPreview
            {
                VideoUrl = _video.VideoUrl
            };
            preview.ShowDialog(this);
        }

        private async void btnDownload_BtnClick(object sender, EventArgs e)
        {
            btnDownload.BtnText = "下载中...";
            btnDownload.Enabled = false;
            ucProcess.Visible = true;
            var downloader = new XDownloader();
            downloader.OnChanged += Downloader_OnChanged;
            downloader.OnFinished += Downloader_OnFinished;
            await downloader.Download(_config, _video.VideoUrl, _video.Hash, "mp4", true);

            if (_config.IsDownloadPoster)
            {
                string ext = Path.GetExtension(_video.PosterUrl) ?? "jpeg";
                var xdown = new XDownloader();
                await xdown.Download(_config, _video.PosterUrl, _video.Hash, ext);
            }

            if (_music != null && _config.IsDownloadVoice)
            {
                string ext = Path.GetExtension(_music.MusicUrl) ?? "mp3";
                var xdown = new XDownloader();
                await xdown.Download(_config, _music.MusicUrl, _music.Hash, ext);
            }
        }

        private void Downloader_OnFinished(object sender, AsyncCompletedEventArgs e)
        {
            btnDownload.Visible = false;
            ucProcess.Visible = false;
        }

        private void Downloader_OnChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            var received = Convert.ToDecimal(e.BytesReceived);
            var total = Convert.ToDecimal(e.TotalBytesToReceive);
            var result = Convert.ToDecimal((received / total).ToString("0.000"));
            var percent = Math.Round(result, 2) * 100;
            if (ucProcess.Value < 100 && e.BytesReceived != e.TotalBytesToReceive)
            {
                ucProcess.Value = percent.ToInt();
            }
            else if (e.BytesReceived==e.TotalBytesToReceive)
            {
                ucProcess.Value = 100;
            }
            else
            {
                ucProcess.Value = 99;
            }
        }

        private void DisposeAll()
        {
            picVideo.Click -= PicVideo_Click;
            picVideo.Image = null;
            picAvatar.Image = null;
            panelLeft.Visible = false;
            panelRight.Visible = false;
            btnDownload.Enabled = true;
            ucProcess.Enabled = true;
            ucProcess.Value = 0;
            btnDownload.BtnText = "下载";
        }

        private async void Init()
        {
            _config = await Logic.ReadConfig();
            panelLeft.Visible = false;
            panelRight.Visible = false;
        }

        private void picVideo_MouseHover(object sender, EventArgs e)
        {
            FrmAnchorTips.ShowTips(picVideo, "点击播放预览", AnchorTipsLocation.TOP,Color.FromArgb(0,150,136));
        }
    }
}