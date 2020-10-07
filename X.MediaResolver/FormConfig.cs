using System;
using System.Drawing;
using System.Windows.Forms;
using HZH_Controls.Forms;
using X.MediaResolver.Models;

namespace X.MediaResolver
{
    public partial class FormConfig : FrmWithTitle
    {
        public FormConfig()
        {
            InitializeComponent();
        }

        private void btnSavepath_BtnClick(object sender, EventArgs e)
        {
            FolderBrowserDialog save = new FolderBrowserDialog
            {
                ShowNewFolderButton = true,
                Description = @"请选择视频保存位置",
                RootFolder = Environment.SpecialFolder.MyComputer
            };
            if (save.ShowDialog() == DialogResult.OK)
            {
                txtSavepath.InputText = save.SelectedPath;
            }
        }

        private async void FormConfig_Load(object sender, EventArgs e)
        {
            var config = await Logic.ReadConfig();
            txtSavepath.InputText = config.SavePath;
            ucSwitchAudio.Checked = config.IsDownloadVoice;
            ucSwitchPoster.Checked = config.IsDownloadPoster;
        }

        /// <summary>
        /// 配置更新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public delegate void ConfigRefreshEventHandler(object sender, EventArgs e);

        public event ConfigRefreshEventHandler OnConfigRefreshed;

        public async void btnSave_BtnClick(object sender, EventArgs e)
        {
            var config = new XConfig
            {
                SavePath = txtSavepath.InputText,
                IsDownloadPoster = ucSwitchPoster.Checked,
                IsDownloadVoice = ucSwitchAudio.Checked
            };
            await Logic.WriteConfig(config);
            OnConfigRefreshed?.Invoke(config, e);
            Close();
        }

        private void FormConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
