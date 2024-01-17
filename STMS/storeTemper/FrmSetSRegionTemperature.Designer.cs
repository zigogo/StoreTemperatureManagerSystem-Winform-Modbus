namespace STMS.storeTemper
{
    partial class FrmSetSRegionTemperature
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAdjustWayText = new System.Windows.Forms.Label();
            this.uCircleButtonCancel = new STMS.UControls.UCircleButton();
            this.uCircleButtonSubmit = new STMS.UControls.UCircleButton();
            this.checkedListBoxAdjustWay = new System.Windows.Forms.CheckedListBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.numericUpDownTemper = new System.Windows.Forms.NumericUpDown();
            this.labelTipAdjustWay = new System.Windows.Forms.Label();
            this.labelTipTemper = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemper)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(66, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "调整方式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(66, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "目标室温：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "调整方式：";
            // 
            // labelAdjustWayText
            // 
            this.labelAdjustWayText.AutoSize = true;
            this.labelAdjustWayText.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelAdjustWayText.ForeColor = System.Drawing.Color.Red;
            this.labelAdjustWayText.Location = new System.Drawing.Point(250, 29);
            this.labelAdjustWayText.Name = "labelAdjustWayText";
            this.labelAdjustWayText.Size = new System.Drawing.Size(82, 41);
            this.labelAdjustWayText.TabIndex = 3;
            this.labelAdjustWayText.Text = "升温";
            // 
            // uCircleButtonCancel
            // 
            this.uCircleButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonCancel.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonCancel.BgColor2 = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonCancel.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonCancel.FlatAppearance.BorderSize = 0;
            this.uCircleButtonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonCancel.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonCancel.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleButtonCancel.Location = new System.Drawing.Point(251, 559);
            this.uCircleButtonCancel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonCancel.Name = "uCircleButtonCancel";
            this.uCircleButtonCancel.Radius = 1;
            this.uCircleButtonCancel.Size = new System.Drawing.Size(114, 68);
            this.uCircleButtonCancel.TabIndex = 6;
            this.uCircleButtonCancel.Text = "取消";
            this.uCircleButtonCancel.UseVisualStyleBackColor = false;
            this.uCircleButtonCancel.Click += new System.EventHandler(this.uCircleButtonCancel_Click);
            // 
            // uCircleButtonSubmit
            // 
            this.uCircleButtonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonSubmit.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonSubmit.BgColor2 = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonSubmit.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonSubmit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonSubmit.FlatAppearance.BorderSize = 0;
            this.uCircleButtonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonSubmit.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonSubmit.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonSubmit.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleButtonSubmit.Location = new System.Drawing.Point(49, 559);
            this.uCircleButtonSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonSubmit.Name = "uCircleButtonSubmit";
            this.uCircleButtonSubmit.Radius = 1;
            this.uCircleButtonSubmit.Size = new System.Drawing.Size(114, 68);
            this.uCircleButtonSubmit.TabIndex = 7;
            this.uCircleButtonSubmit.Text = "确定";
            this.uCircleButtonSubmit.UseVisualStyleBackColor = false;
            this.uCircleButtonSubmit.Click += new System.EventHandler(this.uCircleButtonSubmit_Click);
            // 
            // checkedListBoxAdjustWay
            // 
            this.checkedListBoxAdjustWay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.checkedListBoxAdjustWay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxAdjustWay.CheckOnClick = true;
            this.checkedListBoxAdjustWay.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkedListBoxAdjustWay.ForeColor = System.Drawing.Color.White;
            this.checkedListBoxAdjustWay.FormattingEnabled = true;
            this.checkedListBoxAdjustWay.Location = new System.Drawing.Point(73, 253);
            this.checkedListBoxAdjustWay.Name = "checkedListBoxAdjustWay";
            this.checkedListBoxAdjustWay.Size = new System.Drawing.Size(355, 208);
            this.checkedListBoxAdjustWay.TabIndex = 8;
            this.checkedListBoxAdjustWay.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxAdjustWay_SelectedIndexChanged);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.listBox.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox.ForeColor = System.Drawing.Color.White;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 36;
            this.listBox.Location = new System.Drawing.Point(550, 33);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(620, 436);
            this.listBox.TabIndex = 9;
            // 
            // numericUpDownTemper
            // 
            this.numericUpDownTemper.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownTemper.Location = new System.Drawing.Point(236, 112);
            this.numericUpDownTemper.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownTemper.Name = "numericUpDownTemper";
            this.numericUpDownTemper.Size = new System.Drawing.Size(192, 49);
            this.numericUpDownTemper.TabIndex = 11;
            this.numericUpDownTemper.ValueChanged += new System.EventHandler(this.numericUpDownTemper_ValueChanged);
            // 
            // labelTipAdjustWay
            // 
            this.labelTipAdjustWay.AutoSize = true;
            this.labelTipAdjustWay.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTipAdjustWay.ForeColor = System.Drawing.Color.Red;
            this.labelTipAdjustWay.Location = new System.Drawing.Point(66, 488);
            this.labelTipAdjustWay.Name = "labelTipAdjustWay";
            this.labelTipAdjustWay.Size = new System.Drawing.Size(242, 41);
            this.labelTipAdjustWay.TabIndex = 12;
            this.labelTipAdjustWay.Text = "请选择调整方式";
            // 
            // labelTipTemper
            // 
            this.labelTipTemper.AutoSize = true;
            this.labelTipTemper.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTipTemper.ForeColor = System.Drawing.Color.Red;
            this.labelTipTemper.Location = new System.Drawing.Point(89, 164);
            this.labelTipTemper.Name = "labelTipTemper";
            this.labelTipTemper.Size = new System.Drawing.Size(339, 35);
            this.labelTipTemper.TabIndex = 13;
            this.labelTipTemper.Text = "目标温度不可低于最低温度";
            // 
            // FrmSetSRegionTemperature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(1204, 661);
            this.Controls.Add(this.labelTipTemper);
            this.Controls.Add(this.labelTipAdjustWay);
            this.Controls.Add(this.numericUpDownTemper);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.checkedListBoxAdjustWay);
            this.Controls.Add(this.uCircleButtonSubmit);
            this.Controls.Add(this.uCircleButtonCancel);
            this.Controls.Add(this.labelAdjustWayText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmSetSRegionTemperature";
            this.Text = "调整仓库温度";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSetSRegionTemperature_FormClosing);
            this.Load += new System.EventHandler(this.FrmSetSRegionTemperature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemper)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAdjustWayText;
        private UControls.UCircleButton uCircleButtonCancel;
        private UControls.UCircleButton uCircleButtonSubmit;
        private System.Windows.Forms.CheckedListBox checkedListBoxAdjustWay;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.NumericUpDown numericUpDownTemper;
        private System.Windows.Forms.Label labelTipAdjustWay;
        private System.Windows.Forms.Label labelTipTemper;
    }
}