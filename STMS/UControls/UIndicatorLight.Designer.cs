namespace STMS.UControls
{
    partial class UIndicatorLight
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
            this.uCircleLight = new STMS.UControls.UCircle();
            this.labelState = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uCircleLight
            // 
            this.uCircleLight.Location = new System.Drawing.Point(18, 24);
            this.uCircleLight.Name = "uCircleLight";
            this.uCircleLight.Size = new System.Drawing.Size(50, 50);
            this.uCircleLight.TabIndex = 0;
            // 
            // labelState
            // 
            this.labelState.AutoSize = true;
            this.labelState.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelState.ForeColor = System.Drawing.Color.White;
            this.labelState.Location = new System.Drawing.Point(83, 19);
            this.labelState.Name = "labelState";
            this.labelState.Size = new System.Drawing.Size(108, 55);
            this.labelState.TabIndex = 1;
            this.labelState.Text = "温度";
            // 
            // UIndicatorLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.labelState);
            this.Controls.Add(this.uCircleLight);
            this.Name = "UIndicatorLight";
            this.Size = new System.Drawing.Size(201, 99);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCircle uCircleLight;
        private System.Windows.Forms.Label labelState;
    }
}
