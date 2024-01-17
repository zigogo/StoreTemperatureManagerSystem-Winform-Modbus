namespace STMS.product
{
    partial class FrmProductInfo
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.uCircleButtonClear = new STMS.UControls.UCircleButton();
            this.uCircleButtonSubmit = new STMS.UControls.UCircleButton();
            this.uPanelMid = new STMS.UControl.UPanel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxHighTemper = new System.Windows.Forms.TextBox();
            this.textBoxLowTemper = new System.Windows.Forms.TextBox();
            this.labelFitHighTemperature = new System.Windows.Forms.Label();
            this.labelFitLowTemperature = new System.Windows.Forms.Label();
            this.labelTipNo = new System.Windows.Forms.Label();
            this.labelTipName = new System.Windows.Forms.Label();
            this.textBoxProductNo = new System.Windows.Forms.TextBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelStoreNo = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.uCircleButtonReturn = new STMS.UControls.UCircleButton();
            this.labelTipTemperature = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.uPanelMid.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panelHead.Controls.Add(this.uCircleButtonReturn);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(802, 108);
            this.panelHead.TabIndex = 2;
            // 
            // uCircleButtonClear
            // 
            this.uCircleButtonClear.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonClear.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uCircleButtonClear.FlatAppearance.BorderSize = 0;
            this.uCircleButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uCircleButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uCircleButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonClear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonClear.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonClear.Location = new System.Drawing.Point(432, 609);
            this.uCircleButtonClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonClear.Name = "uCircleButtonClear";
            this.uCircleButtonClear.Radius = 3;
            this.uCircleButtonClear.Size = new System.Drawing.Size(132, 56);
            this.uCircleButtonClear.TabIndex = 5;
            this.uCircleButtonClear.Text = "清空";
            this.uCircleButtonClear.UseVisualStyleBackColor = true;
            this.uCircleButtonClear.Click += new System.EventHandler(this.uCircleButtonClear_Click);
            // 
            // uCircleButtonSubmit
            // 
            this.uCircleButtonSubmit.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonSubmit.BgColor2 = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonSubmit.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uCircleButtonSubmit.FlatAppearance.BorderSize = 0;
            this.uCircleButtonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uCircleButtonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uCircleButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonSubmit.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonSubmit.Location = new System.Drawing.Point(166, 609);
            this.uCircleButtonSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonSubmit.Name = "uCircleButtonSubmit";
            this.uCircleButtonSubmit.Radius = 3;
            this.uCircleButtonSubmit.Size = new System.Drawing.Size(132, 56);
            this.uCircleButtonSubmit.TabIndex = 4;
            this.uCircleButtonSubmit.Text = "确定";
            this.uCircleButtonSubmit.UseVisualStyleBackColor = true;
            this.uCircleButtonSubmit.Click += new System.EventHandler(this.uCircleButtonSubmit_Click);
            // 
            // uPanelMid
            // 
            this.uPanelMid.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.uPanelMid.BgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.uPanelMid.BorderColor = System.Drawing.Color.Red;
            this.uPanelMid.Controls.Add(this.groupBox);
            this.uPanelMid.Location = new System.Drawing.Point(19, 123);
            this.uPanelMid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uPanelMid.Name = "uPanelMid";
            this.uPanelMid.Size = new System.Drawing.Size(755, 458);
            this.uPanelMid.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.groupBox.Controls.Add(this.labelTipTemperature);
            this.groupBox.Controls.Add(this.textBoxHighTemper);
            this.groupBox.Controls.Add(this.textBoxLowTemper);
            this.groupBox.Controls.Add(this.labelFitHighTemperature);
            this.groupBox.Controls.Add(this.labelFitLowTemperature);
            this.groupBox.Controls.Add(this.labelTipNo);
            this.groupBox.Controls.Add(this.labelTipName);
            this.groupBox.Controls.Add(this.textBoxProductNo);
            this.groupBox.Controls.Add(this.textBoxProductName);
            this.groupBox.Controls.Add(this.labelStoreNo);
            this.groupBox.Controls.Add(this.labelProductName);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(16, 3);
            this.groupBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox.Size = new System.Drawing.Size(715, 437);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "产品信息";
            // 
            // textBoxHighTemper
            // 
            this.textBoxHighTemper.Location = new System.Drawing.Point(233, 328);
            this.textBoxHighTemper.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxHighTemper.Name = "textBoxHighTemper";
            this.textBoxHighTemper.Size = new System.Drawing.Size(268, 38);
            this.textBoxHighTemper.TabIndex = 12;
            this.textBoxHighTemper.TextChanged += new System.EventHandler(this.textBoxHighTemper_TextChanged);
            // 
            // textBoxLowTemper
            // 
            this.textBoxLowTemper.Location = new System.Drawing.Point(233, 245);
            this.textBoxLowTemper.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxLowTemper.Name = "textBoxLowTemper";
            this.textBoxLowTemper.Size = new System.Drawing.Size(268, 38);
            this.textBoxLowTemper.TabIndex = 11;
            this.textBoxLowTemper.TextChanged += new System.EventHandler(this.textBoxLowTemper_TextChanged);
            // 
            // labelFitHighTemperature
            // 
            this.labelFitHighTemperature.AutoSize = true;
            this.labelFitHighTemperature.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFitHighTemperature.Location = new System.Drawing.Point(65, 325);
            this.labelFitHighTemperature.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFitHighTemperature.Name = "labelFitHighTemperature";
            this.labelFitHighTemperature.Size = new System.Drawing.Size(178, 41);
            this.labelFitHighTemperature.TabIndex = 10;
            this.labelFitHighTemperature.Text = "最高温度：";
            // 
            // labelFitLowTemperature
            // 
            this.labelFitLowTemperature.AutoSize = true;
            this.labelFitLowTemperature.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelFitLowTemperature.Location = new System.Drawing.Point(65, 242);
            this.labelFitLowTemperature.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelFitLowTemperature.Name = "labelFitLowTemperature";
            this.labelFitLowTemperature.Size = new System.Drawing.Size(178, 41);
            this.labelFitLowTemperature.TabIndex = 9;
            this.labelFitLowTemperature.Text = "最低温度：";
            // 
            // labelTipNo
            // 
            this.labelTipNo.AutoSize = true;
            this.labelTipNo.ForeColor = System.Drawing.Color.Red;
            this.labelTipNo.Location = new System.Drawing.Point(515, 168);
            this.labelTipNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipNo.Name = "labelTipNo";
            this.labelTipNo.Size = new System.Drawing.Size(80, 27);
            this.labelTipNo.TabIndex = 8;
            this.labelTipNo.Text = "*必填";
            // 
            // labelTipName
            // 
            this.labelTipName.AutoSize = true;
            this.labelTipName.ForeColor = System.Drawing.Color.Red;
            this.labelTipName.Location = new System.Drawing.Point(515, 90);
            this.labelTipName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipName.Name = "labelTipName";
            this.labelTipName.Size = new System.Drawing.Size(80, 27);
            this.labelTipName.TabIndex = 6;
            this.labelTipName.Text = "*必填";
            // 
            // textBoxProductNo
            // 
            this.textBoxProductNo.Location = new System.Drawing.Point(233, 161);
            this.textBoxProductNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxProductNo.Name = "textBoxProductNo";
            this.textBoxProductNo.Size = new System.Drawing.Size(268, 38);
            this.textBoxProductNo.TabIndex = 4;
            this.textBoxProductNo.TextChanged += new System.EventHandler(this.textBoxProductNo_TextChanged);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(233, 81);
            this.textBoxProductName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(268, 38);
            this.textBoxProductName.TabIndex = 3;
            this.textBoxProductName.TextChanged += new System.EventHandler(this.textBoxProductName_TextChanged);
            // 
            // labelStoreNo
            // 
            this.labelStoreNo.AutoSize = true;
            this.labelStoreNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStoreNo.Location = new System.Drawing.Point(65, 158);
            this.labelStoreNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStoreNo.Name = "labelStoreNo";
            this.labelStoreNo.Size = new System.Drawing.Size(178, 41);
            this.labelStoreNo.TabIndex = 1;
            this.labelStoreNo.Text = "产品编号：";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProductName.Location = new System.Drawing.Point(65, 76);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(178, 41);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "产品名称：";
            // 
            // uCircleButtonReturn
            // 
            this.uCircleButtonReturn.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uCircleButtonReturn.BgColor2 = System.Drawing.Color.DarkGray;
            this.uCircleButtonReturn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonReturn.FlatAppearance.BorderSize = 0;
            this.uCircleButtonReturn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonReturn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonReturn.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonReturn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(255)))));
            this.uCircleButtonReturn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.uCircleButtonReturn.Location = new System.Drawing.Point(667, 22);
            this.uCircleButtonReturn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonReturn.Name = "uCircleButtonReturn";
            this.uCircleButtonReturn.Radius = 4;
            this.uCircleButtonReturn.Size = new System.Drawing.Size(107, 60);
            this.uCircleButtonReturn.TabIndex = 0;
            this.uCircleButtonReturn.Text = "返回";
            this.uCircleButtonReturn.UseVisualStyleBackColor = true;
            this.uCircleButtonReturn.Click += new System.EventHandler(this.uCircleButtonReturn_Click);
            // 
            // labelTipTemperature
            // 
            this.labelTipTemperature.AutoSize = true;
            this.labelTipTemperature.ForeColor = System.Drawing.Color.Red;
            this.labelTipTemperature.Location = new System.Drawing.Point(228, 390);
            this.labelTipTemperature.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipTemperature.Name = "labelTipTemperature";
            this.labelTipTemperature.Size = new System.Drawing.Size(350, 27);
            this.labelTipTemperature.TabIndex = 13;
            this.labelTipTemperature.Text = "*最低温度不能大于最高温度";
            // 
            // FrmProductInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(802, 720);
            this.Controls.Add(this.uCircleButtonClear);
            this.Controls.Add(this.uCircleButtonSubmit);
            this.Controls.Add(this.uPanelMid);
            this.Controls.Add(this.panelHead);
            this.MaximizeBox = false;
            this.Name = "FrmProductInfo";
            this.Text = "产品信息";
            this.Load += new System.EventHandler(this.FrmProductInfo_Load);
            this.panelHead.ResumeLayout(false);
            this.uPanelMid.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private UControls.UCircleButton uCircleButtonReturn;
        private UControl.UPanel uPanelMid;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelTipNo;
        private System.Windows.Forms.Label labelTipName;
        private System.Windows.Forms.TextBox textBoxProductNo;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label labelStoreNo;
        private System.Windows.Forms.Label labelProductName;
        private UControls.UCircleButton uCircleButtonClear;
        private UControls.UCircleButton uCircleButtonSubmit;
        private System.Windows.Forms.TextBox textBoxHighTemper;
        private System.Windows.Forms.TextBox textBoxLowTemper;
        private System.Windows.Forms.Label labelFitHighTemperature;
        private System.Windows.Forms.Label labelFitLowTemperature;
        private System.Windows.Forms.Label labelTipTemperature;
    }
}