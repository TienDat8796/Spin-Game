
namespace SpinGamePlay
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnSpin = new System.Windows.Forms.Button();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSpin = new System.Windows.Forms.Label();
            this.lblKQ1 = new System.Windows.Forms.Label();
            this.lblKQ2 = new System.Windows.Forms.Label();
            this.lblKQ3 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lblScore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMusic = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhacOn = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNhacOff = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiSpin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiSpin100Score = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiSpin200Score = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiSpin300Score = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiSpin500Score = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiSpin1000Score = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSpin
            // 
            this.btnSpin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSpin.BackColor = System.Drawing.Color.Transparent;
            this.btnSpin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpin.BackgroundImage")));
            this.btnSpin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSpin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSpin.FlatAppearance.BorderSize = 0;
            this.btnSpin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSpin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSpin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpin.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.ForeColor = System.Drawing.Color.Transparent;
            this.btnSpin.Location = new System.Drawing.Point(22, 362);
            this.btnSpin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(96, 49);
            this.btnSpin.TabIndex = 0;
            this.btnSpin.UseVisualStyleBackColor = false;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.BackgroundImage")));
            this.pictureEdit1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(39, 27);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(206, 89);
            this.pictureEdit1.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSpin
            // 
            this.lblSpin.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSpin.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpin.ForeColor = System.Drawing.Color.White;
            this.lblSpin.Image = ((System.Drawing.Image)(resources.GetObject("lblSpin.Image")));
            this.lblSpin.Location = new System.Drawing.Point(0, 23);
            this.lblSpin.Name = "lblSpin";
            this.lblSpin.Size = new System.Drawing.Size(234, 36);
            this.lblSpin.TabIndex = 6;
            this.lblSpin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKQ1
            // 
            this.lblKQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblKQ1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKQ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblKQ1.Font = new System.Drawing.Font("VNI-Couri", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKQ1.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblKQ1.Location = new System.Drawing.Point(22, 157);
            this.lblKQ1.Name = "lblKQ1";
            this.lblKQ1.Size = new System.Drawing.Size(74, 105);
            this.lblKQ1.TabIndex = 7;
            this.lblKQ1.Text = "7";
            this.lblKQ1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKQ2
            // 
            this.lblKQ2.BackColor = System.Drawing.Color.Yellow;
            this.lblKQ2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKQ2.Font = new System.Drawing.Font("VNI-Couri", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblKQ2.ForeColor = System.Drawing.Color.Violet;
            this.lblKQ2.Location = new System.Drawing.Point(102, 157);
            this.lblKQ2.Name = "lblKQ2";
            this.lblKQ2.Size = new System.Drawing.Size(74, 105);
            this.lblKQ2.TabIndex = 8;
            this.lblKQ2.Text = "7";
            this.lblKQ2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKQ3
            // 
            this.lblKQ3.BackColor = System.Drawing.Color.Chartreuse;
            this.lblKQ3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKQ3.Font = new System.Drawing.Font("VNI-Couri", 50.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblKQ3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblKQ3.Location = new System.Drawing.Point(182, 157);
            this.lblKQ3.Name = "lblKQ3";
            this.lblKQ3.Size = new System.Drawing.Size(74, 105);
            this.lblKQ3.TabIndex = 9;
            this.lblKQ3.Text = "7";
            this.lblKQ3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnNewGame.BackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNewGame.BackgroundImage")));
            this.btnNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewGame.FlatAppearance.BorderSize = 0;
            this.btnNewGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewGame.Location = new System.Drawing.Point(90, 414);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(96, 49);
            this.btnNewGame.TabIndex = 11;
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnStop
            // 
            this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnStop.BackColor = System.Drawing.Color.Transparent;
            this.btnStop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStop.BackgroundImage")));
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderSize = 0;
            this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Transparent;
            this.btnStop.Location = new System.Drawing.Point(160, 362);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(96, 49);
            this.btnStop.TabIndex = 12;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "20",
            "40",
            "50",
            "80",
            "100",
            "200",
            "500",
            "1000"});
            this.comboBox1.Location = new System.Drawing.Point(135, 332);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Baybuom", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 333);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mức Cược";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl1.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.Appearance.Options.UseBorderColor = true;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl1.Controls.Add(this.lblSpin);
            this.groupControl1.Location = new System.Drawing.Point(22, 265);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(234, 59);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "Spin";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.groupControl2.Appearance.BorderColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            this.groupControl2.Appearance.Options.UseBackColor = true;
            this.groupControl2.Appearance.Options.UseBorderColor = true;
            this.groupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.groupControl2.Controls.Add(this.lblScore);
            this.groupControl2.Location = new System.Drawing.Point(22, 105);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(234, 49);
            this.groupControl2.TabIndex = 17;
            this.groupControl2.Text = "Score";
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.LightCoral;
            this.lblScore.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Image = ((System.Drawing.Image)(resources.GetObject("lblScore.Image")));
            this.lblScore.Location = new System.Drawing.Point(0, 23);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(234, 26);
            this.lblScore.TabIndex = 6;
            this.lblScore.Text = "0";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHuongDan,
            this.mnuMusic,
            this.mnuDoiSpin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHuongDan
            // 
            this.mnuHuongDan.Image = ((System.Drawing.Image)(resources.GetObject("mnuHuongDan.Image")));
            this.mnuHuongDan.Name = "mnuHuongDan";
            this.mnuHuongDan.Size = new System.Drawing.Size(95, 20);
            this.mnuHuongDan.Text = "Hướng Dẫn";
            this.mnuHuongDan.Click += new System.EventHandler(this.mnuHuongDan_Click);
            // 
            // mnuMusic
            // 
            this.mnuMusic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNhacOn,
            this.mnuNhacOff});
            this.mnuMusic.Image = ((System.Drawing.Image)(resources.GetObject("mnuMusic.Image")));
            this.mnuMusic.Name = "mnuMusic";
            this.mnuMusic.Size = new System.Drawing.Size(62, 20);
            this.mnuMusic.Text = "Nhạc";
            // 
            // mnuNhacOn
            // 
            this.mnuNhacOn.BackColor = System.Drawing.Color.Black;
            this.mnuNhacOn.ForeColor = System.Drawing.Color.White;
            this.mnuNhacOn.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhacOn.Image")));
            this.mnuNhacOn.Name = "mnuNhacOn";
            this.mnuNhacOn.Size = new System.Drawing.Size(90, 22);
            this.mnuNhacOn.Text = "On";
            this.mnuNhacOn.Click += new System.EventHandler(this.mnuNhacOn_Click);
            // 
            // mnuNhacOff
            // 
            this.mnuNhacOff.BackColor = System.Drawing.Color.White;
            this.mnuNhacOff.Image = ((System.Drawing.Image)(resources.GetObject("mnuNhacOff.Image")));
            this.mnuNhacOff.Name = "mnuNhacOff";
            this.mnuNhacOff.Size = new System.Drawing.Size(90, 22);
            this.mnuNhacOff.Text = "Off";
            this.mnuNhacOff.Click += new System.EventHandler(this.mnuNhacOff_Click);
            // 
            // mnuDoiSpin
            // 
            this.mnuDoiSpin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDoiSpin100Score,
            this.mnuDoiSpin200Score,
            this.mnuDoiSpin300Score,
            this.mnuDoiSpin500Score,
            this.mnuDoiSpin1000Score});
            this.mnuDoiSpin.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiSpin.Image")));
            this.mnuDoiSpin.Name = "mnuDoiSpin";
            this.mnuDoiSpin.Size = new System.Drawing.Size(79, 20);
            this.mnuDoiSpin.Text = "Đổi Spin";
            this.mnuDoiSpin.Click += new System.EventHandler(this.mnuDoiSpin_Click);
            // 
            // mnuDoiSpin100Score
            // 
            this.mnuDoiSpin100Score.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiSpin100Score.Image")));
            this.mnuDoiSpin100Score.Name = "mnuDoiSpin100Score";
            this.mnuDoiSpin100Score.Size = new System.Drawing.Size(196, 22);
            this.mnuDoiSpin100Score.Text = "100 Score / 150 Spin";
            this.mnuDoiSpin100Score.Click += new System.EventHandler(this.mnuDoiSpin100Score_Click);
            // 
            // mnuDoiSpin200Score
            // 
            this.mnuDoiSpin200Score.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiSpin200Score.Image")));
            this.mnuDoiSpin200Score.Name = "mnuDoiSpin200Score";
            this.mnuDoiSpin200Score.Size = new System.Drawing.Size(196, 22);
            this.mnuDoiSpin200Score.Text = "200 Score / 300 Spin";
            this.mnuDoiSpin200Score.Click += new System.EventHandler(this.mnuDoiSpin200Score_Click);
            // 
            // mnuDoiSpin300Score
            // 
            this.mnuDoiSpin300Score.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiSpin300Score.Image")));
            this.mnuDoiSpin300Score.Name = "mnuDoiSpin300Score";
            this.mnuDoiSpin300Score.Size = new System.Drawing.Size(196, 22);
            this.mnuDoiSpin300Score.Text = "300 Score / 500 Spin";
            this.mnuDoiSpin300Score.Click += new System.EventHandler(this.mnuDoiSpin300Score_Click);
            // 
            // mnuDoiSpin500Score
            // 
            this.mnuDoiSpin500Score.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiSpin500Score.Image")));
            this.mnuDoiSpin500Score.Name = "mnuDoiSpin500Score";
            this.mnuDoiSpin500Score.Size = new System.Drawing.Size(196, 22);
            this.mnuDoiSpin500Score.Text = "500 Score / 1100 Spin";
            this.mnuDoiSpin500Score.Click += new System.EventHandler(this.mnuDoiSpin500Score_Click);
            // 
            // mnuDoiSpin1000Score
            // 
            this.mnuDoiSpin1000Score.Image = ((System.Drawing.Image)(resources.GetObject("mnuDoiSpin1000Score.Image")));
            this.mnuDoiSpin1000Score.Name = "mnuDoiSpin1000Score";
            this.mnuDoiSpin1000Score.Size = new System.Drawing.Size(196, 22);
            this.mnuDoiSpin1000Score.Text = "1000 Score / 10000 Spin";
            this.mnuDoiSpin1000Score.Click += new System.EventHandler(this.mnuDoiSpin1000Score_Click);
            // 
            // Form1
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.ForeColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImageStore")));
            this.ClientSize = new System.Drawing.Size(281, 466);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblKQ3);
            this.Controls.Add(this.lblKQ2);
            this.Controls.Add(this.lblKQ1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("Form1.IconOptions.Image")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spin Game Play";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        public System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSpin;
        private System.Windows.Forms.Label lblKQ1;
        private System.Windows.Forms.Label lblKQ2;
        private System.Windows.Forms.Label lblKQ3;
        public System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHuongDan;
        private System.Windows.Forms.ToolStripMenuItem mnuMusic;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiSpin;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ToolStripMenuItem mnuNhacOn;
        private System.Windows.Forms.ToolStripMenuItem mnuNhacOff;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiSpin100Score;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiSpin200Score;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiSpin300Score;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiSpin500Score;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiSpin1000Score;
    }
}

