namespace X.MediaResolver
{
    partial class FormPreview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPreview));
            this.videoPlayer = new LibVLCSharp.WinForms.VideoView();
            this.tbarVolume = new HZH_Controls.Controls.UCTrackBar();
            this.btnReload = new HZH_Controls.Controls.UCBtnImg();
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // videoPlayer
            // 
            this.videoPlayer.BackColor = System.Drawing.Color.Black;
            this.videoPlayer.Location = new System.Drawing.Point(0, 63);
            this.videoPlayer.MediaPlayer = null;
            this.videoPlayer.Name = "videoPlayer";
            this.videoPlayer.Size = new System.Drawing.Size(405, 589);
            this.videoPlayer.TabIndex = 7;
            this.videoPlayer.Text = "videoView1";
            // 
            // tbarVolume
            // 
            this.tbarVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tbarVolume.DcimalDigits = 0;
            this.tbarVolume.IsShowTips = true;
            this.tbarVolume.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.tbarVolume.LineWidth = 8F;
            this.tbarVolume.Location = new System.Drawing.Point(38, 656);
            this.tbarVolume.MaxValue = 100F;
            this.tbarVolume.MinValue = 0F;
            this.tbarVolume.Name = "tbarVolume";
            this.tbarVolume.Size = new System.Drawing.Size(250, 39);
            this.tbarVolume.TabIndex = 8;
            this.tbarVolume.TipsFormat = null;
            this.tbarVolume.Value = 50F;
            this.tbarVolume.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.tbarVolume.ValueChanged += new System.EventHandler(this.tbarVolume_ValueChanged);
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnReload.BtnFont = new System.Drawing.Font("微软雅黑", 17F);
            this.btnReload.BtnForeColor = System.Drawing.Color.Transparent;
            this.btnReload.BtnText = "";
            this.btnReload.ConerRadius = 5;
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.EnabledMouseEffect = false;
            this.btnReload.FillColor = System.Drawing.Color.Transparent;
            this.btnReload.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnReload.ForeColor = System.Drawing.Color.Transparent;
            this.btnReload.Image = ((System.Drawing.Image)(resources.GetObject("btnReload.Image")));
            this.btnReload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReload.ImageFontIcons = ((object)(resources.GetObject("btnReload.ImageFontIcons")));
            this.btnReload.IsRadius = true;
            this.btnReload.IsShowRect = false;
            this.btnReload.IsShowTips = false;
            this.btnReload.Location = new System.Drawing.Point(328, 656);
            this.btnReload.Margin = new System.Windows.Forms.Padding(0);
            this.btnReload.Name = "btnReload";
            this.btnReload.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnReload.RectWidth = 0;
            this.btnReload.Size = new System.Drawing.Size(38, 39);
            this.btnReload.TabIndex = 9;
            this.btnReload.TabStop = false;
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnReload.TipsText = "";
            this.btnReload.BtnClick += new System.EventHandler(this.btnReload_BtnClick);
            // 
            // FormPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 703);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.tbarVolume);
            this.Controls.Add(this.videoPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "FormPreview";
            this.Text = "";
            this.Title = "视频预览";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPreview_FormClosing);
            this.Load += new System.EventHandler(this.FormPreview_Load);
            this.Controls.SetChildIndex(this.videoPlayer, 0);
            this.Controls.SetChildIndex(this.tbarVolume, 0);
            this.Controls.SetChildIndex(this.btnReload, 0);
            ((System.ComponentModel.ISupportInitialize)(this.videoPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibVLCSharp.WinForms.VideoView videoPlayer;
        private HZH_Controls.Controls.UCTrackBar tbarVolume;
        private HZH_Controls.Controls.UCBtnImg btnReload;
    }
}