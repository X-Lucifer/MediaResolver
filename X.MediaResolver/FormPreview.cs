using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls.Controls;
using HZH_Controls.Forms;
using LibVLCSharp.Shared;

namespace X.MediaResolver
{
    public partial class FormPreview : FrmWithTitle
    {
        private readonly LibVLC _libvlc;
        private readonly MediaPlayer _player;
        public string VideoUrl = "";
        public FormPreview()
        {
            if (!DesignMode)
            {
                Core.Initialize();
            }
            InitializeComponent();
            _libvlc = new LibVLC();
            _player = new MediaPlayer(_libvlc)
            {
                EnableHardwareDecoding = true,
                EnableMouseInput = true,
                EnableKeyInput = true,
                FileCaching = 3000,
                NetworkCaching = 3000,
                Volume = 80,
                Position = 0
            };
            videoPlayer.MediaPlayer = _player;
            tbarVolume.Value = _player.Volume;
        }

        private async void FormPreview_Load(object sender, EventArgs e)
        {
            try
            {
                var result = _player.Play(new Media(_libvlc, VideoUrl, FromType.FromLocation));
                int i = 0;
                while (!result && i <= 3)
                {
                    await Task.Delay(1000);
                    i++;
                }
            }
            catch (Exception)
            {
                FrmTips.ShowTipsWarning(this, "出现未知错误");
            }
        }

        private void FormPreview_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_player.IsPlaying)
            {
                _player.Stop();
            }
            _player.Dispose();
            _libvlc.Dispose();
        }

        private void btnReload_BtnClick(object sender, EventArgs e)
        {
            if (_player.IsPlaying)
            {
                _player.Stop();
            }
            FormPreview_Load(sender, e);
        }

        private void tbarVolume_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                UCTrackBar bar = (UCTrackBar)sender;
                var value = Convert.ToInt32(bar.Value);
                _player.Volume = value;
            }
            catch (Exception)
            {
                FrmTips.ShowTipsWarning(this, "出现未知错误");
            }
        }
    }
}