namespace STMS
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panelHead = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelPage = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.lblLoginTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLoginUser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.pageBtnSRM = new STMS.UControls.UPageButton();
            this.pageBtnSTM = new STMS.UControls.UPageButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.pageBtnPIS = new STMS.UControls.UPageButton();
            this.pageBtnPM = new STMS.UControls.UPageButton();
            this.pageBtnSM = new STMS.UControls.UPageButton();
            this.uPanelMenu = new STMS.UControl.UPanel();
            this.menuBtnProductManage = new STMS.UControls.UMenuButton();
            this.menuBtnStoreManage = new STMS.UControls.UMenuButton();
            this.menuBtnStoreTemperManage = new STMS.UControls.UMenuButton();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.uPanelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.panelHead.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHead.Controls.Add(this.pictureBox1);
            this.panelHead.Controls.Add(this.label2);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1382, 89);
            this.panelHead.TabIndex = 0;
            this.panelHead.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.panelHead.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::STMS.Properties.Resources.logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 53);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "仓库温度管理系统";
            this.label2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseDown);
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHead_MouseMove);
            // 
            // panelPage
            // 
            this.panelPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(134)))));
            this.panelPage.Location = new System.Drawing.Point(312, 147);
            this.panelPage.Name = "panelPage";
            this.panelPage.Size = new System.Drawing.Size(1058, 583);
            this.panelPage.TabIndex = 0;
            this.panelPage.SizeChanged += new System.EventHandler(this.panelPage_SizeChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.labelTime);
            this.panel2.Controls.Add(this.labelUserName);
            this.panel2.Controls.Add(this.lblLoginTime);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblLoginUser);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(0, 741);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1382, 59);
            this.panel2.TabIndex = 12;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.labelTime.ForeColor = System.Drawing.Color.LightGray;
            this.labelTime.Location = new System.Drawing.Point(416, 15);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(359, 25);
            this.labelTime.TabIndex = 3;
            this.labelTime.Text = "aaaaaaaaaaaaaaaa";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("微软雅黑", 10.8F);
            this.labelUserName.ForeColor = System.Drawing.Color.LightGray;
            this.labelUserName.Location = new System.Drawing.Point(90, 15);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(75, 24);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "ADMIN";
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.AutoSize = true;
            this.lblLoginTime.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginTime.ForeColor = System.Drawing.Color.White;
            this.lblLoginTime.Location = new System.Drawing.Point(435, 14);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(0, 24);
            this.lblLoginTime.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(321, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "登录时间：";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.AutoSize = true;
            this.lblLoginUser.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginUser.ForeColor = System.Drawing.Color.White;
            this.lblLoginUser.Location = new System.Drawing.Point(107, 14);
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(0, 24);
            this.lblLoginUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "登录者：";
            // 
            // panelTop
            // 
            this.panelTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panelTop.Controls.Add(this.pageBtnSRM);
            this.panelTop.Controls.Add(this.pageBtnSTM);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.pageBtnPIS);
            this.panelTop.Controls.Add(this.pageBtnPM);
            this.panelTop.Controls.Add(this.pageBtnSM);
            this.panelTop.Location = new System.Drawing.Point(312, 100);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1058, 40);
            this.panelTop.TabIndex = 8;
            // 
            // pageBtnSRM
            // 
            this.pageBtnSRM.BackColor = System.Drawing.Color.Transparent;
            this.pageBtnSRM.BackgroundImage = global::STMS.Properties.Resources.btnbg02;
            this.pageBtnSRM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageBtnSRM.BtnText = "仓库分区页面";
            this.pageBtnSRM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBtnSRM.Location = new System.Drawing.Point(207, 0);
            this.pageBtnSRM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageBtnSRM.Name = "pageBtnSRM";
            this.pageBtnSRM.Size = new System.Drawing.Size(160, 40);
            this.pageBtnSRM.TabIndex = 6;
            this.pageBtnSRM.Click += new System.EventHandler(this.pageBtnSRM_Click);
            // 
            // pageBtnSTM
            // 
            this.pageBtnSTM.BackColor = System.Drawing.Color.Transparent;
            this.pageBtnSTM.BackgroundImage = global::STMS.Properties.Resources.btnbg05;
            this.pageBtnSTM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageBtnSTM.BtnText = "仓库温控页面";
            this.pageBtnSTM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBtnSTM.Location = new System.Drawing.Point(813, 0);
            this.pageBtnSTM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageBtnSTM.Name = "pageBtnSTM";
            this.pageBtnSTM.Size = new System.Drawing.Size(160, 40);
            this.pageBtnSTM.TabIndex = 5;
            this.pageBtnSTM.Click += new System.EventHandler(this.pageBtnSTM_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1013, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 40);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pageBtnPIS
            // 
            this.pageBtnPIS.BackColor = System.Drawing.Color.Transparent;
            this.pageBtnPIS.BackgroundImage = global::STMS.Properties.Resources.btnbg04;
            this.pageBtnPIS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageBtnPIS.BtnText = " 产品入库页面";
            this.pageBtnPIS.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBtnPIS.Location = new System.Drawing.Point(612, 0);
            this.pageBtnPIS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageBtnPIS.Name = "pageBtnPIS";
            this.pageBtnPIS.Size = new System.Drawing.Size(160, 40);
            this.pageBtnPIS.TabIndex = 3;
            this.pageBtnPIS.Click += new System.EventHandler(this.pageBtnPIS_Click);
            // 
            // pageBtnPM
            // 
            this.pageBtnPM.BackColor = System.Drawing.Color.Transparent;
            this.pageBtnPM.BackgroundImage = global::STMS.Properties.Resources.btnbg03;
            this.pageBtnPM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageBtnPM.BtnText = "产品管理页面";
            this.pageBtnPM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBtnPM.Location = new System.Drawing.Point(407, 0);
            this.pageBtnPM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageBtnPM.Name = "pageBtnPM";
            this.pageBtnPM.Size = new System.Drawing.Size(160, 40);
            this.pageBtnPM.TabIndex = 2;
            this.pageBtnPM.Click += new System.EventHandler(this.pageBtnPM_Click);
            // 
            // pageBtnSM
            // 
            this.pageBtnSM.BackColor = System.Drawing.Color.Transparent;
            this.pageBtnSM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pageBtnSM.BackgroundImage")));
            this.pageBtnSM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pageBtnSM.BtnText = "仓库管理页面";
            this.pageBtnSM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pageBtnSM.Location = new System.Drawing.Point(0, 0);
            this.pageBtnSM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageBtnSM.Name = "pageBtnSM";
            this.pageBtnSM.Size = new System.Drawing.Size(160, 40);
            this.pageBtnSM.TabIndex = 0;
            this.pageBtnSM.Click += new System.EventHandler(this.pageBtnSM_Click);
            // 
            // uPanelMenu
            // 
            this.uPanelMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.uPanelMenu.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanelMenu.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanelMenu.BorderColor = System.Drawing.Color.Transparent;
            this.uPanelMenu.Controls.Add(this.menuBtnProductManage);
            this.uPanelMenu.Controls.Add(this.menuBtnStoreManage);
            this.uPanelMenu.Controls.Add(this.menuBtnStoreTemperManage);
            this.uPanelMenu.Location = new System.Drawing.Point(8, 100);
            this.uPanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uPanelMenu.Name = "uPanelMenu";
            this.uPanelMenu.Size = new System.Drawing.Size(276, 630);
            this.uPanelMenu.TabIndex = 1;
            // 
            // menuBtnProductManage
            // 
            this.menuBtnProductManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.menuBtnProductManage.ButtonImage = global::STMS.Properties.Resources._03;
            this.menuBtnProductManage.ButtonText = "产品管理";
            this.menuBtnProductManage.Location = new System.Drawing.Point(0, 62);
            this.menuBtnProductManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuBtnProductManage.Name = "menuBtnProductManage";
            this.menuBtnProductManage.Size = new System.Drawing.Size(273, 60);
            this.menuBtnProductManage.TabIndex = 1;
            this.menuBtnProductManage.Click += new System.EventHandler(this.menuBtnProductManage_Click);
            // 
            // menuBtnStoreManage
            // 
            this.menuBtnStoreManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.menuBtnStoreManage.ButtonImage = ((System.Drawing.Image)(resources.GetObject("menuBtnStoreManage.ButtonImage")));
            this.menuBtnStoreManage.ButtonText = "仓库管理";
            this.menuBtnStoreManage.Location = new System.Drawing.Point(0, 2);
            this.menuBtnStoreManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuBtnStoreManage.Name = "menuBtnStoreManage";
            this.menuBtnStoreManage.Size = new System.Drawing.Size(273, 60);
            this.menuBtnStoreManage.TabIndex = 0;
            this.menuBtnStoreManage.Click += new System.EventHandler(this.menuBtnStoreManage_Click);
            // 
            // menuBtnStoreTemperManage
            // 
            this.menuBtnStoreTemperManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.menuBtnStoreTemperManage.ButtonImage = global::STMS.Properties.Resources._04;
            this.menuBtnStoreTemperManage.ButtonText = "仓库温控管理";
            this.menuBtnStoreTemperManage.Location = new System.Drawing.Point(0, 123);
            this.menuBtnStoreTemperManage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuBtnStoreTemperManage.Name = "menuBtnStoreTemperManage";
            this.menuBtnStoreTemperManage.Size = new System.Drawing.Size(273, 60);
            this.menuBtnStoreTemperManage.TabIndex = 2;
            this.menuBtnStoreTemperManage.Click += new System.EventHandler(this.menuBtnStoreTemperManage_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(134)))));
            this.ClientSize = new System.Drawing.Size(1382, 800);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelPage);
            this.Controls.Add(this.uPanelMenu);
            this.Controls.Add(this.panelHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "仓库温度控制管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTop.ResumeLayout(false);
            this.uPanelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panelHead;
        private UControl.UPanel uPanelMenu;
        private System.Windows.Forms.Panel panelPage;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoginTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLoginUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private UControls.UMenuButton menuBtnStoreManage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private UControls.UPageButton pageBtnSM;
        private UControls.UPageButton pageBtnPIS;
        private UControls.UPageButton pageBtnPM;
        private UControls.UMenuButton menuBtnStoreTemperManage;
        private UControls.UMenuButton menuBtnProductManage;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelTime;
        private UControls.UPageButton pageBtnSTM;
        private UControls.UPageButton pageBtnSRM;
    }
}