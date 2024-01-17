namespace STMS.store
{
    partial class FrmStoreInfo
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
            this.uPanelMid = new STMS.UControl.UPanel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelTipNo = new System.Windows.Forms.Label();
            this.labelTipName = new System.Windows.Forms.Label();
            this.textBoxStoreRemark = new System.Windows.Forms.TextBox();
            this.textBoxStoreNo = new System.Windows.Forms.TextBox();
            this.textBoxStoreName = new System.Windows.Forms.TextBox();
            this.labelStoreRemark = new System.Windows.Forms.Label();
            this.labelStoreNo = new System.Windows.Forms.Label();
            this.labelStoreName = new System.Windows.Forms.Label();
            this.panelHead = new System.Windows.Forms.Panel();
            this.uCircleButtonReturn = new STMS.UControls.UCircleButton();
            this.uCircleButtonSubmit = new STMS.UControls.UCircleButton();
            this.uCircleButtonClear = new STMS.UControls.UCircleButton();
            this.uPanelMid.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // uPanelMid
            // 
            this.uPanelMid.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.uPanelMid.BgColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.uPanelMid.BorderColor = System.Drawing.Color.Red;
            this.uPanelMid.Controls.Add(this.groupBox);
            this.uPanelMid.Location = new System.Drawing.Point(19, 132);
            this.uPanelMid.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uPanelMid.Name = "uPanelMid";
            this.uPanelMid.Size = new System.Drawing.Size(977, 484);
            this.uPanelMid.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.groupBox.Controls.Add(this.labelTipNo);
            this.groupBox.Controls.Add(this.labelTipName);
            this.groupBox.Controls.Add(this.textBoxStoreRemark);
            this.groupBox.Controls.Add(this.textBoxStoreNo);
            this.groupBox.Controls.Add(this.textBoxStoreName);
            this.groupBox.Controls.Add(this.labelStoreRemark);
            this.groupBox.Controls.Add(this.labelStoreNo);
            this.groupBox.Controls.Add(this.labelStoreName);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(16, 3);
            this.groupBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox.Size = new System.Drawing.Size(947, 466);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "仓库信息";
            // 
            // labelTipNo
            // 
            this.labelTipNo.AutoSize = true;
            this.labelTipNo.ForeColor = System.Drawing.Color.Red;
            this.labelTipNo.Location = new System.Drawing.Point(507, 148);
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
            this.labelTipName.Location = new System.Drawing.Point(507, 90);
            this.labelTipName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipName.Name = "labelTipName";
            this.labelTipName.Size = new System.Drawing.Size(80, 27);
            this.labelTipName.TabIndex = 6;
            this.labelTipName.Text = "*必填";
            // 
            // textBoxStoreRemark
            // 
            this.textBoxStoreRemark.Location = new System.Drawing.Point(229, 207);
            this.textBoxStoreRemark.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxStoreRemark.Multiline = true;
            this.textBoxStoreRemark.Name = "textBoxStoreRemark";
            this.textBoxStoreRemark.Size = new System.Drawing.Size(542, 187);
            this.textBoxStoreRemark.TabIndex = 5;
            // 
            // textBoxStoreNo
            // 
            this.textBoxStoreNo.Location = new System.Drawing.Point(229, 142);
            this.textBoxStoreNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxStoreNo.Name = "textBoxStoreNo";
            this.textBoxStoreNo.Size = new System.Drawing.Size(268, 38);
            this.textBoxStoreNo.TabIndex = 4;
            this.textBoxStoreNo.TextChanged += new System.EventHandler(this.textBoxStoreNo_TextChanged);
            // 
            // textBoxStoreName
            // 
            this.textBoxStoreName.Location = new System.Drawing.Point(229, 81);
            this.textBoxStoreName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxStoreName.Name = "textBoxStoreName";
            this.textBoxStoreName.Size = new System.Drawing.Size(268, 38);
            this.textBoxStoreName.TabIndex = 3;
            this.textBoxStoreName.TextChanged += new System.EventHandler(this.textBoxStoreName_TextChanged);
            // 
            // labelStoreRemark
            // 
            this.labelStoreRemark.AutoSize = true;
            this.labelStoreRemark.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStoreRemark.Location = new System.Drawing.Point(65, 207);
            this.labelStoreRemark.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStoreRemark.Name = "labelStoreRemark";
            this.labelStoreRemark.Size = new System.Drawing.Size(123, 41);
            this.labelStoreRemark.TabIndex = 2;
            this.labelStoreRemark.Text = "描述 ：";
            // 
            // labelStoreNo
            // 
            this.labelStoreNo.AutoSize = true;
            this.labelStoreNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStoreNo.Location = new System.Drawing.Point(65, 138);
            this.labelStoreNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStoreNo.Name = "labelStoreNo";
            this.labelStoreNo.Size = new System.Drawing.Size(178, 41);
            this.labelStoreNo.TabIndex = 1;
            this.labelStoreNo.Text = "仓库编号：";
            // 
            // labelStoreName
            // 
            this.labelStoreName.AutoSize = true;
            this.labelStoreName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStoreName.Location = new System.Drawing.Point(65, 76);
            this.labelStoreName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStoreName.Name = "labelStoreName";
            this.labelStoreName.Size = new System.Drawing.Size(178, 41);
            this.labelStoreName.TabIndex = 0;
            this.labelStoreName.Text = "仓库名称：";
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.panelHead.Controls.Add(this.uCircleButtonReturn);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(1014, 117);
            this.panelHead.TabIndex = 1;
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
            this.uCircleButtonReturn.Location = new System.Drawing.Point(862, 27);
            this.uCircleButtonReturn.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonReturn.Name = "uCircleButtonReturn";
            this.uCircleButtonReturn.Radius = 4;
            this.uCircleButtonReturn.Size = new System.Drawing.Size(107, 60);
            this.uCircleButtonReturn.TabIndex = 0;
            this.uCircleButtonReturn.Text = "返回";
            this.uCircleButtonReturn.UseVisualStyleBackColor = true;
            this.uCircleButtonReturn.Click += new System.EventHandler(this.uCircleButtonReturn_Click);
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
            this.uCircleButtonSubmit.Location = new System.Drawing.Point(288, 668);
            this.uCircleButtonSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonSubmit.Name = "uCircleButtonSubmit";
            this.uCircleButtonSubmit.Radius = 3;
            this.uCircleButtonSubmit.Size = new System.Drawing.Size(132, 56);
            this.uCircleButtonSubmit.TabIndex = 2;
            this.uCircleButtonSubmit.Text = "确定";
            this.uCircleButtonSubmit.UseVisualStyleBackColor = true;
            this.uCircleButtonSubmit.Click += new System.EventHandler(this.uCircleButtonSubmit_Click);
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
            this.uCircleButtonClear.Location = new System.Drawing.Point(582, 668);
            this.uCircleButtonClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonClear.Name = "uCircleButtonClear";
            this.uCircleButtonClear.Radius = 3;
            this.uCircleButtonClear.Size = new System.Drawing.Size(132, 56);
            this.uCircleButtonClear.TabIndex = 3;
            this.uCircleButtonClear.Text = "清空";
            this.uCircleButtonClear.UseVisualStyleBackColor = true;
            this.uCircleButtonClear.Click += new System.EventHandler(this.uCircleButtonClear_Click);
            // 
            // FrmStoreInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.ClientSize = new System.Drawing.Size(1014, 754);
            this.Controls.Add(this.uCircleButtonClear);
            this.Controls.Add(this.uCircleButtonSubmit);
            this.Controls.Add(this.panelHead);
            this.Controls.Add(this.uPanelMid);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "FrmStoreInfo";
            this.Text = "仓库信息";
            this.Load += new System.EventHandler(this.FrmStoreInfo_Load);
            this.uPanelMid.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.panelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private UControl.UPanel uPanelMid;
        private System.Windows.Forms.Panel panelHead;
        private UControls.UCircleButton uCircleButtonReturn;
        private System.Windows.Forms.GroupBox groupBox;
        private UControls.UCircleButton uCircleButtonSubmit;
        private UControls.UCircleButton uCircleButtonClear;
        private System.Windows.Forms.Label labelStoreName;
        private System.Windows.Forms.TextBox textBoxStoreRemark;
        private System.Windows.Forms.TextBox textBoxStoreNo;
        private System.Windows.Forms.TextBox textBoxStoreName;
        private System.Windows.Forms.Label labelStoreRemark;
        private System.Windows.Forms.Label labelStoreNo;
        private System.Windows.Forms.Label labelTipNo;
        private System.Windows.Forms.Label labelTipName;
    }
}