namespace X.MediaResolver
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ucSwitchPoster = new HZH_Controls.Controls.UCSwitch();
            this.ucSwitchAudio = new HZH_Controls.Controls.UCSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSavepath = new HZH_Controls.Controls.UCBtnImg();
            this.txtSavepath = new HZH_Controls.Controls.UCTextBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new HZH_Controls.Controls.UCBtnExt();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ucSwitchPoster);
            this.groupBox3.Controls.Add(this.ucSwitchAudio);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnSavepath);
            this.groupBox3.Controls.Add(this.txtSavepath);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 170);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "系统配置";
            // 
            // ucSwitchPoster
            // 
            this.ucSwitchPoster.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitchPoster.Checked = false;
            this.ucSwitchPoster.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitchPoster.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitchPoster.Location = new System.Drawing.Point(128, 112);
            this.ucSwitchPoster.Name = "ucSwitchPoster";
            this.ucSwitchPoster.Size = new System.Drawing.Size(59, 31);
            this.ucSwitchPoster.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitchPoster.TabIndex = 5;
            this.ucSwitchPoster.Texts = new string[] {
        "是",
        "否"};
            this.ucSwitchPoster.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ucSwitchPoster.TrueTextColr = System.Drawing.Color.White;
            // 
            // ucSwitchAudio
            // 
            this.ucSwitchAudio.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitchAudio.Checked = true;
            this.ucSwitchAudio.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitchAudio.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitchAudio.Location = new System.Drawing.Point(128, 70);
            this.ucSwitchAudio.Name = "ucSwitchAudio";
            this.ucSwitchAudio.Size = new System.Drawing.Size(59, 31);
            this.ucSwitchAudio.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitchAudio.TabIndex = 4;
            this.ucSwitchAudio.Texts = new string[] {
        "是",
        "否"};
            this.ucSwitchAudio.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.ucSwitchAudio.TrueTextColr = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "下载封面:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "下载音频:";
            // 
            // btnSavepath
            // 
            this.btnSavepath.BackColor = System.Drawing.Color.White;
            this.btnSavepath.BtnBackColor = System.Drawing.Color.White;
            this.btnSavepath.BtnFont = new System.Drawing.Font("微软雅黑", 15F);
            this.btnSavepath.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSavepath.BtnText = "";
            this.btnSavepath.ConerRadius = 10;
            this.btnSavepath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSavepath.EnabledMouseEffect = true;
            this.btnSavepath.FillColor = System.Drawing.Color.White;
            this.btnSavepath.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSavepath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnSavepath.Image = ((System.Drawing.Image)(resources.GetObject("btnSavepath.Image")));
            this.btnSavepath.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSavepath.ImageFontIcons = ((object)(resources.GetObject("btnSavepath.ImageFontIcons")));
            this.btnSavepath.IsRadius = true;
            this.btnSavepath.IsShowRect = true;
            this.btnSavepath.IsShowTips = false;
            this.btnSavepath.Location = new System.Drawing.Point(373, 30);
            this.btnSavepath.Margin = new System.Windows.Forms.Padding(0);
            this.btnSavepath.Name = "btnSavepath";
            this.btnSavepath.RectColor = System.Drawing.Color.Gainsboro;
            this.btnSavepath.RectWidth = 1;
            this.btnSavepath.Size = new System.Drawing.Size(62, 26);
            this.btnSavepath.TabIndex = 2;
            this.btnSavepath.TabStop = false;
            this.btnSavepath.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSavepath.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSavepath.TipsText = "";
            this.btnSavepath.BtnClick += new System.EventHandler(this.btnSavepath_BtnClick);
            // 
            // txtSavepath
            // 
            this.txtSavepath.BackColor = System.Drawing.Color.Transparent;
            this.txtSavepath.ConerRadius = 5;
            this.txtSavepath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSavepath.DecLength = 0;
            this.txtSavepath.Enabled = false;
            this.txtSavepath.FillColor = System.Drawing.Color.Empty;
            this.txtSavepath.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtSavepath.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSavepath.InputText = "";
            this.txtSavepath.InputType = HZH_Controls.TextInputType.NotControl;
            this.txtSavepath.IsFocusColor = true;
            this.txtSavepath.IsRadius = true;
            this.txtSavepath.IsShowClearBtn = true;
            this.txtSavepath.IsShowKeyboard = false;
            this.txtSavepath.IsShowRect = true;
            this.txtSavepath.IsShowSearchBtn = false;
            this.txtSavepath.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.txtSavepath.Location = new System.Drawing.Point(128, 30);
            this.txtSavepath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSavepath.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtSavepath.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.txtSavepath.Name = "txtSavepath";
            this.txtSavepath.Padding = new System.Windows.Forms.Padding(5);
            this.txtSavepath.PasswordChar = '\0';
            this.txtSavepath.PromptColor = System.Drawing.Color.Gray;
            this.txtSavepath.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSavepath.PromptText = "请选择视频保存路径";
            this.txtSavepath.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSavepath.RectWidth = 1;
            this.txtSavepath.RegexPattern = "";
            this.txtSavepath.Size = new System.Drawing.Size(227, 26);
            this.txtSavepath.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "视频保存路径:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BtnBackColor = System.Drawing.Color.Transparent;
            this.btnSave.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.BtnForeColor = System.Drawing.Color.White;
            this.btnSave.BtnText = "保存配置";
            this.btnSave.ConerRadius = 10;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.EnabledMouseEffect = true;
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IsRadius = true;
            this.btnSave.IsShowRect = false;
            this.btnSave.IsShowTips = false;
            this.btnSave.Location = new System.Drawing.Point(209, 287);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.RectColor = System.Drawing.Color.Gainsboro;
            this.btnSave.RectWidth = 1;
            this.btnSave.Size = new System.Drawing.Size(93, 34);
            this.btnSave.TabIndex = 6;
            this.btnSave.TabStop = false;
            this.btnSave.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnSave.TipsText = "";
            this.btnSave.BtnClick += new System.EventHandler(this.btnSave_BtnClick);
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 340);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "FormConfig";
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "";
            this.Title = "系统配置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConfig_FormClosing);
            this.Load += new System.EventHandler(this.FormConfig_Load);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private HZH_Controls.Controls.UCBtnExt btnSave;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCTextBoxEx txtSavepath;
        private HZH_Controls.Controls.UCBtnImg btnSavepath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private HZH_Controls.Controls.UCSwitch ucSwitchPoster;
        private HZH_Controls.Controls.UCSwitch ucSwitchAudio;
    }
}