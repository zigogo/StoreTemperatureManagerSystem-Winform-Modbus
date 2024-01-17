namespace STMS
{
    partial class FrmLogin
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
            this.panelFrmLogin1 = new System.Windows.Forms.Panel();
            this.btnLogin = new STMS.UControls.UCircleButton();
            this.uPanel2 = new STMS.UControl.UPanel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelFrmLogin3 = new System.Windows.Forms.Label();
            this.uPanel1 = new STMS.UControl.UPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelFrmLogin2 = new System.Windows.Forms.Label();
            this.labelFrmLogin1 = new System.Windows.Forms.Label();
            this.panelFrmLogin1.SuspendLayout();
            this.uPanel2.SuspendLayout();
            this.uPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelFrmLogin1
            // 
            this.panelFrmLogin1.BackColor = System.Drawing.Color.Transparent;
            this.panelFrmLogin1.BackgroundImage = global::STMS.Properties.Resources.loginbgin;
            this.panelFrmLogin1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelFrmLogin1.Controls.Add(this.btnLogin);
            this.panelFrmLogin1.Controls.Add(this.uPanel2);
            this.panelFrmLogin1.Controls.Add(this.uPanel1);
            this.panelFrmLogin1.Controls.Add(this.labelFrmLogin1);
            this.panelFrmLogin1.Location = new System.Drawing.Point(180, 166);
            this.panelFrmLogin1.Name = "panelFrmLogin1";
            this.panelFrmLogin1.Size = new System.Drawing.Size(789, 410);
            this.panelFrmLogin1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BgColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(39)))), ((int)(((byte)(112)))));
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(88, 322);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Radius = 10;
            this.btnLogin.Size = new System.Drawing.Size(623, 56);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // uPanel2
            // 
            this.uPanel2.BgColor = System.Drawing.Color.Transparent;
            this.uPanel2.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.uPanel2.BorderWidth = 1;
            this.uPanel2.Controls.Add(this.textBox2);
            this.uPanel2.Controls.Add(this.labelFrmLogin3);
            this.uPanel2.Location = new System.Drawing.Point(88, 233);
            this.uPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.uPanel2.Name = "uPanel2";
            this.uPanel2.Size = new System.Drawing.Size(623, 62);
            this.uPanel2.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.DarkBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("宋体", 12F);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(104, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(487, 35);
            this.textBox2.TabIndex = 3;
            // 
            // labelFrmLogin3
            // 
            this.labelFrmLogin3.AutoSize = true;
            this.labelFrmLogin3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFrmLogin3.ForeColor = System.Drawing.Color.Transparent;
            this.labelFrmLogin3.Location = new System.Drawing.Point(16, 19);
            this.labelFrmLogin3.Name = "labelFrmLogin3";
            this.labelFrmLogin3.Size = new System.Drawing.Size(82, 24);
            this.labelFrmLogin3.TabIndex = 2;
            this.labelFrmLogin3.Text = "密码：";
            // 
            // uPanel1
            // 
            this.uPanel1.BgColor = System.Drawing.Color.Transparent;
            this.uPanel1.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.uPanel1.BorderWidth = 1;
            this.uPanel1.Controls.Add(this.textBox1);
            this.uPanel1.Controls.Add(this.labelFrmLogin2);
            this.uPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.uPanel1.Location = new System.Drawing.Point(88, 150);
            this.uPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.uPanel1.Name = "uPanel1";
            this.uPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.uPanel1.Size = new System.Drawing.Size(623, 62);
            this.uPanel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(104, 15);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(487, 35);
            this.textBox1.TabIndex = 4;
            // 
            // labelFrmLogin2
            // 
            this.labelFrmLogin2.AutoSize = true;
            this.labelFrmLogin2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFrmLogin2.Location = new System.Drawing.Point(16, 21);
            this.labelFrmLogin2.Name = "labelFrmLogin2";
            this.labelFrmLogin2.Size = new System.Drawing.Size(82, 24);
            this.labelFrmLogin2.TabIndex = 1;
            this.labelFrmLogin2.Text = "账号：";
            // 
            // labelFrmLogin1
            // 
            this.labelFrmLogin1.AutoSize = true;
            this.labelFrmLogin1.Font = new System.Drawing.Font("微软雅黑", 25.8F);
            this.labelFrmLogin1.ForeColor = System.Drawing.Color.White;
            this.labelFrmLogin1.Location = new System.Drawing.Point(130, 27);
            this.labelFrmLogin1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFrmLogin1.Name = "labelFrmLogin1";
            this.labelFrmLogin1.Size = new System.Drawing.Size(549, 67);
            this.labelFrmLogin1.TabIndex = 0;
            this.labelFrmLogin1.Text = "仓库温度监控系统登录";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::STMS.Properties.Resources.logbg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1122, 728);
            this.Controls.Add(this.panelFrmLogin1);
            this.ForeColor = System.Drawing.Color.IndianRed;
            this.Name = "FrmLogin";
            this.Text = "仓库温度监控系统登录界面";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmLogin_FormClosing);
            this.Resize += new System.EventHandler(this.FrmLogin_Resize);
            this.panelFrmLogin1.ResumeLayout(false);
            this.panelFrmLogin1.PerformLayout();
            this.uPanel2.ResumeLayout(false);
            this.uPanel2.PerformLayout();
            this.uPanel1.ResumeLayout(false);
            this.uPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFrmLogin1;
        private System.Windows.Forms.Label labelFrmLogin1;
        private UControls.UCircleButton btnLogin;
        private UControl.UPanel uPanel2;
        private UControl.UPanel uPanel1;
        private System.Windows.Forms.Label labelFrmLogin2;
        private System.Windows.Forms.Label labelFrmLogin3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

