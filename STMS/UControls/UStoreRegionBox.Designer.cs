namespace STMS.UControls
{
    partial class UStoreRegionBox
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHead = new System.Windows.Forms.Panel();
            this.uCircleButton = new STMS.UControls.UCircleButton();
            this.labelSRegionName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.uThermometer = new STMS.UControls.UThermometer();
            this.uCircleTemperatureState = new STMS.UControls.UCircle();
            this.labelLowAndHighTemperature = new System.Windows.Forms.Label();
            this.labelTemperature = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTemperState = new System.Windows.Forms.Label();
            this.panelHead.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(183)))));
            this.panelHead.Controls.Add(this.uCircleButton);
            this.panelHead.Controls.Add(this.labelSRegionName);
            this.panelHead.Controls.Add(this.label1);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(609, 76);
            this.panelHead.TabIndex = 0;
            // 
            // uCircleButton
            // 
            this.uCircleButton.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButton.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.uCircleButton.Location = new System.Drawing.Point(480, 12);
            this.uCircleButton.Name = "uCircleButton";
            this.uCircleButton.Size = new System.Drawing.Size(86, 54);
            this.uCircleButton.TabIndex = 2;
            this.uCircleButton.Text = "升温";
            this.uCircleButton.UseVisualStyleBackColor = true;
            this.uCircleButton.Click += new System.EventHandler(this.uCircleButton_Click);
            // 
            // labelSRegionName
            // 
            this.labelSRegionName.AutoSize = true;
            this.labelSRegionName.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelSRegionName.ForeColor = System.Drawing.Color.White;
            this.labelSRegionName.Location = new System.Drawing.Point(212, 19);
            this.labelSRegionName.Name = "labelSRegionName";
            this.labelSRegionName.Size = new System.Drawing.Size(113, 44);
            this.labelSRegionName.TabIndex = 1;
            this.labelSRegionName.Text = "01-01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "仓库分区";
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(145)))), ((int)(((byte)(239)))));
            this.panelMenu.Controls.Add(this.labelTemperState);
            this.panelMenu.Controls.Add(this.uThermometer);
            this.panelMenu.Controls.Add(this.uCircleTemperatureState);
            this.panelMenu.Controls.Add(this.labelLowAndHighTemperature);
            this.panelMenu.Controls.Add(this.labelTemperature);
            this.panelMenu.Controls.Add(this.labelProductCount);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.label4);
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.label2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMenu.Location = new System.Drawing.Point(0, 76);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(609, 302);
            this.panelMenu.TabIndex = 1;
            // 
            // uThermometer
            // 
            this.uThermometer.BMaxValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uThermometer.BMinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uThermometer.GlassTubeColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.uThermometer.LeftTemperatureUnit = STMS.UControls.UThermometer.TemperatureUnit.C;
            this.uThermometer.Location = new System.Drawing.Point(463, 3);
            this.uThermometer.MaxValue = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.uThermometer.MercuryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.uThermometer.MinValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.uThermometer.Name = "uThermometer";
            this.uThermometer.Size = new System.Drawing.Size(113, 296);
            this.uThermometer.SpCount = 5;
            this.uThermometer.TabIndex = 15;
            this.uThermometer.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.uThermometer.ValueColor = System.Drawing.Color.White;
            this.uThermometer.ValueFont = new System.Drawing.Font("宋体", 10F);
            // 
            // uCircleTemperatureState
            // 
            this.uCircleTemperatureState.Location = new System.Drawing.Point(175, 233);
            this.uCircleTemperatureState.Name = "uCircleTemperatureState";
            this.uCircleTemperatureState.Size = new System.Drawing.Size(30, 30);
            this.uCircleTemperatureState.TabIndex = 14;
            // 
            // labelLowAndHighTemperature
            // 
            this.labelLowAndHighTemperature.AutoSize = true;
            this.labelLowAndHighTemperature.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelLowAndHighTemperature.ForeColor = System.Drawing.Color.White;
            this.labelLowAndHighTemperature.Location = new System.Drawing.Point(162, 156);
            this.labelLowAndHighTemperature.Name = "labelLowAndHighTemperature";
            this.labelLowAndHighTemperature.Size = new System.Drawing.Size(248, 44);
            this.labelLowAndHighTemperature.TabIndex = 13;
            this.labelLowAndHighTemperature.Text = "24.5℃~50.0℃";
            // 
            // labelTemperature
            // 
            this.labelTemperature.AutoSize = true;
            this.labelTemperature.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTemperature.ForeColor = System.Drawing.Color.White;
            this.labelTemperature.Location = new System.Drawing.Point(162, 85);
            this.labelTemperature.Name = "labelTemperature";
            this.labelTemperature.Size = new System.Drawing.Size(121, 44);
            this.labelTemperature.TabIndex = 12;
            this.labelTemperature.Text = "25.5度";
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProductCount.ForeColor = System.Drawing.Color.White;
            this.labelProductCount.Location = new System.Drawing.Point(162, 19);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(79, 44);
            this.labelProductCount.TabIndex = 11;
            this.labelProductCount.Text = "500";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 44);
            this.label5.TabIndex = 10;
            this.label5.Text = "当前状态:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 44);
            this.label4.TabIndex = 9;
            this.label4.Text = "温度范围:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(8, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "室内温度:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 44);
            this.label2.TabIndex = 7;
            this.label2.Text = "产品数量:";
            // 
            // labelTemperState
            // 
            this.labelTemperState.AutoSize = true;
            this.labelTemperState.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTemperState.ForeColor = System.Drawing.Color.White;
            this.labelTemperState.Location = new System.Drawing.Point(212, 226);
            this.labelTemperState.Name = "labelTemperState";
            this.labelTemperState.Size = new System.Drawing.Size(85, 44);
            this.labelTemperState.TabIndex = 17;
            this.labelTemperState.Text = "正常";
            // 
            // UStoreRegionBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHead);
            this.Name = "UStoreRegionBox";
            this.Size = new System.Drawing.Size(609, 378);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private UCircleButton uCircleButton;
        private System.Windows.Forms.Label labelSRegionName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private UCircle uCircleTemperatureState;
        private System.Windows.Forms.Label labelLowAndHighTemperature;
        private System.Windows.Forms.Label labelTemperature;
        private System.Windows.Forms.Label labelProductCount;
        private UThermometer uThermometer;
        private System.Windows.Forms.Label labelTemperState;
    }
}
