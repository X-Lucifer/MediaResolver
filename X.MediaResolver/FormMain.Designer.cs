namespace X.MediaResolver
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btnConfig = new HZH_Controls.Controls.UCBtnImg();
            this.btnAnalysis = new HZH_Controls.Controls.UCBtnExt();
            this.txtLink = new HZH_Controls.Controls.UCTextBoxEx();
            this.ucSplitLine_H2 = new HZH_Controls.Controls.UCSplitLine_H();
            this.ucSplitLine_H3 = new HZH_Controls.Controls.UCSplitLine_H();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.txtUserid = new System.Windows.Forms.RichTextBox();
            this.txtNickname = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.ucProcess = new HZH_Controls.Controls.UCProcessLine();
            this.btnDownload = new HZH_Controls.Controls.UCBtnExt();
            this.ucSplitLine_H5 = new HZH_Controls.Controls.UCSplitLine_H();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.BtnFont = new System.Drawing.Font("微软雅黑", 15F);
            this.btnConfig.BtnForeColor = System.Drawing.Color.Transparent;
            this.btnConfig.BtnText = "";
            this.btnConfig.ConerRadius = 10;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.EnabledMouseEffect = true;
            this.btnConfig.FillColor = System.Drawing.Color.Transparent;
            this.btnConfig.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnConfig.Image = ((System.Drawing.Image)(resources.GetObject("btnConfig.Image")));
            this.btnConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfig.ImageFontIcons = ((object)(resources.GetObject("btnConfig.ImageFontIcons")));
            this.btnConfig.IsRadius = true;
            this.btnConfig.IsShowRect = true;
            this.btnConfig.IsShowTips = false;
            this.btnConfig.Location = new System.Drawing.Point(779, -1);
            this.btnConfig.Margin = new System.Windows.Forms.Padding(0);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.RectColor = System.Drawing.Color.Transparent;
            this.btnConfig.RectWidth = 0;
            this.btnConfig.Size = new System.Drawing.Size(57, 60);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.TabStop = false;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnConfig.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnConfig.TipsText = "";
            this.btnConfig.BtnClick += new System.EventHandler(this.btnConfig_BtnClick);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.BackColor = System.Drawing.Color.Transparent;
            this.btnAnalysis.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnAnalysis.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAnalysis.BtnForeColor = System.Drawing.Color.White;
            this.btnAnalysis.BtnText = "解析";
            this.btnAnalysis.ConerRadius = 10;
            this.btnAnalysis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnalysis.EnabledMouseEffect = true;
            this.btnAnalysis.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnAnalysis.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnAnalysis.IsRadius = true;
            this.btnAnalysis.IsShowRect = false;
            this.btnAnalysis.IsShowTips = false;
            this.btnAnalysis.Location = new System.Drawing.Point(592, 85);
            this.btnAnalysis.Margin = new System.Windows.Forms.Padding(0);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.RectColor = System.Drawing.Color.Gainsboro;
            this.btnAnalysis.RectWidth = 1;
            this.btnAnalysis.Size = new System.Drawing.Size(108, 47);
            this.btnAnalysis.TabIndex = 9;
            this.btnAnalysis.TabStop = false;
            this.btnAnalysis.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnAnalysis.TipsText = "";
            this.btnAnalysis.BtnClick += new System.EventHandler(this.btnAnalysis_BtnClick);
            // 
            // txtLink
            // 
            this.txtLink.BackColor = System.Drawing.Color.Transparent;
            this.txtLink.ConerRadius = 5;
            this.txtLink.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLink.DecLength = 2;
            this.txtLink.FillColor = System.Drawing.Color.Empty;
            this.txtLink.FocusBorderColor = System.Drawing.SystemColors.Control;
            this.txtLink.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLink.InputText = "";
            this.txtLink.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtLink.IsFocusColor = true;
            this.txtLink.IsRadius = true;
            this.txtLink.IsShowClearBtn = true;
            this.txtLink.IsShowKeyboard = false;
            this.txtLink.IsShowRect = true;
            this.txtLink.IsShowSearchBtn = false;
            this.txtLink.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txtLink.Location = new System.Drawing.Point(164, 84);
            this.txtLink.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLink.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtLink.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtLink.Name = "txtLink";
            this.txtLink.Padding = new System.Windows.Forms.Padding(5);
            this.txtLink.PasswordChar = '\0';
            this.txtLink.PromptColor = System.Drawing.Color.Gray;
            this.txtLink.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtLink.PromptText = "";
            this.txtLink.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtLink.RectWidth = 1;
            this.txtLink.RegexPattern = "";
            this.txtLink.Size = new System.Drawing.Size(403, 48);
            this.txtLink.TabIndex = 8;
            // 
            // ucSplitLine_H2
            // 
            this.ucSplitLine_H2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSplitLine_H2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_H2.Location = new System.Drawing.Point(32, 155);
            this.ucSplitLine_H2.Name = "ucSplitLine_H2";
            this.ucSplitLine_H2.Size = new System.Drawing.Size(800, 1);
            this.ucSplitLine_H2.TabIndex = 10;
            this.ucSplitLine_H2.TabStop = false;
            // 
            // ucSplitLine_H3
            // 
            this.ucSplitLine_H3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_H3.Location = new System.Drawing.Point(432, 166);
            this.ucSplitLine_H3.Name = "ucSplitLine_H3";
            this.ucSplitLine_H3.Size = new System.Drawing.Size(1, 424);
            this.ucSplitLine_H3.TabIndex = 11;
            this.ucSplitLine_H3.TabStop = false;
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.picVideo);
            this.panelLeft.Location = new System.Drawing.Point(32, 166);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(394, 424);
            this.panelLeft.TabIndex = 12;
            // 
            // picVideo
            // 
            this.picVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picVideo.Location = new System.Drawing.Point(17, 7);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(360, 406);
            this.picVideo.TabIndex = 3;
            this.picVideo.TabStop = false;
            this.picVideo.MouseHover += new System.EventHandler(this.picVideo_MouseHover);
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.txtUserid);
            this.panelRight.Controls.Add(this.txtNickname);
            this.panelRight.Controls.Add(this.txtDescription);
            this.panelRight.Controls.Add(this.picAvatar);
            this.panelRight.Controls.Add(this.ucProcess);
            this.panelRight.Controls.Add(this.btnDownload);
            this.panelRight.Controls.Add(this.ucSplitLine_H5);
            this.panelRight.Location = new System.Drawing.Point(439, 166);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(393, 424);
            this.panelRight.TabIndex = 13;
            // 
            // txtUserid
            // 
            this.txtUserid.BackColor = System.Drawing.Color.White;
            this.txtUserid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserid.Location = new System.Drawing.Point(200, 79);
            this.txtUserid.Name = "txtUserid";
            this.txtUserid.ReadOnly = true;
            this.txtUserid.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtUserid.Size = new System.Drawing.Size(167, 46);
            this.txtUserid.TabIndex = 18;
            this.txtUserid.Text = "";
            // 
            // txtNickname
            // 
            this.txtNickname.BackColor = System.Drawing.Color.White;
            this.txtNickname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNickname.Location = new System.Drawing.Point(200, 22);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.ReadOnly = true;
            this.txtNickname.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtNickname.Size = new System.Drawing.Size(167, 43);
            this.txtNickname.TabIndex = 17;
            this.txtNickname.Text = "";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Location = new System.Drawing.Point(25, 199);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtDescription.Size = new System.Drawing.Size(342, 93);
            this.txtDescription.TabIndex = 16;
            this.txtDescription.Text = "";
            // 
            // picAvatar
            // 
            this.picAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picAvatar.Location = new System.Drawing.Point(23, 22);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(160, 160);
            this.picAvatar.TabIndex = 15;
            this.picAvatar.TabStop = false;
            // 
            // ucProcess
            // 
            this.ucProcess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ucProcess.ForeColor = System.Drawing.Color.White;
            this.ucProcess.Location = new System.Drawing.Point(54, 326);
            this.ucProcess.MaxValue = 100;
            this.ucProcess.Name = "ucProcess";
            this.ucProcess.Size = new System.Drawing.Size(285, 30);
            this.ucProcess.TabIndex = 12;
            this.ucProcess.Value = 0;
            this.ucProcess.ValueBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucProcess.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucProcess.ValueTextType = HZH_Controls.Controls.ValueTextType.Percent;
            this.ucProcess.Visible = false;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.Transparent;
            this.btnDownload.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnDownload.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDownload.BtnForeColor = System.Drawing.Color.White;
            this.btnDownload.BtnText = "下载";
            this.btnDownload.ConerRadius = 10;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.EnabledMouseEffect = true;
            this.btnDownload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnDownload.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.IsRadius = true;
            this.btnDownload.IsShowRect = false;
            this.btnDownload.IsShowTips = false;
            this.btnDownload.Location = new System.Drawing.Point(142, 366);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(0);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.RectColor = System.Drawing.Color.Gainsboro;
            this.btnDownload.RectWidth = 1;
            this.btnDownload.Size = new System.Drawing.Size(108, 47);
            this.btnDownload.TabIndex = 13;
            this.btnDownload.TabStop = false;
            this.btnDownload.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnDownload.TipsText = "";
            this.btnDownload.Visible = false;
            this.btnDownload.BtnClick += new System.EventHandler(this.btnDownload_BtnClick);
            // 
            // ucSplitLine_H5
            // 
            this.ucSplitLine_H5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ucSplitLine_H5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucSplitLine_H5.Location = new System.Drawing.Point(7, 310);
            this.ucSplitLine_H5.Name = "ucSplitLine_H5";
            this.ucSplitLine_H5.Size = new System.Drawing.Size(379, 1);
            this.ucSplitLine_H5.TabIndex = 12;
            this.ucSplitLine_H5.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 605);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.ucSplitLine_H3);
            this.Controls.Add(this.ucSplitLine_H2);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.btnConfig);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "FormMain";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "";
            this.Title = "视频解析";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Controls.SetChildIndex(this.btnConfig, 0);
            this.Controls.SetChildIndex(this.txtLink, 0);
            this.Controls.SetChildIndex(this.btnAnalysis, 0);
            this.Controls.SetChildIndex(this.ucSplitLine_H2, 0);
            this.Controls.SetChildIndex(this.ucSplitLine_H3, 0);
            this.Controls.SetChildIndex(this.panelLeft, 0);
            this.Controls.SetChildIndex(this.panelRight, 0);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCBtnImg btnConfig;
        private HZH_Controls.Controls.UCBtnExt btnAnalysis;
        private HZH_Controls.Controls.UCTextBoxEx txtLink;
        private HZH_Controls.Controls.UCSplitLine_H ucSplitLine_H2;
        private HZH_Controls.Controls.UCSplitLine_H ucSplitLine_H3;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.PictureBox picVideo;
        private HZH_Controls.Controls.UCSplitLine_H ucSplitLine_H5;
        private HZH_Controls.Controls.UCBtnExt btnDownload;
        private HZH_Controls.Controls.UCProcessLine ucProcess;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.RichTextBox txtDescription;
        private System.Windows.Forms.RichTextBox txtNickname;
        private System.Windows.Forms.RichTextBox txtUserid;
    }
}

