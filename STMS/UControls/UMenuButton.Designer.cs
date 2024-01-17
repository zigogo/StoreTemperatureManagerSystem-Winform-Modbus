namespace STMS.UControls
{
    partial class UMenuButton
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
            this.buttonImage = new System.Windows.Forms.PictureBox();
            this.buttonText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.buttonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonImage
            // 
            this.buttonImage.Image = global::STMS.Properties.Resources._02;
            this.buttonImage.Location = new System.Drawing.Point(30, 1);
            this.buttonImage.Name = "buttonImage";
            this.buttonImage.Size = new System.Drawing.Size(62, 56);
            this.buttonImage.TabIndex = 0;
            this.buttonImage.TabStop = false;
            this.buttonImage.Click += new System.EventHandler(this.buttonImage_Click);
            this.buttonImage.MouseEnter += new System.EventHandler(this.buttonImage_MouseEnter);
            this.buttonImage.MouseLeave += new System.EventHandler(this.buttonImage_MouseLeave);
            // 
            // buttonText
            // 
            this.buttonText.AutoSize = true;
            this.buttonText.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonText.ForeColor = System.Drawing.Color.White;
            this.buttonText.Location = new System.Drawing.Point(86, 16);
            this.buttonText.Name = "buttonText";
            this.buttonText.Size = new System.Drawing.Size(146, 42);
            this.buttonText.TabIndex = 1;
            this.buttonText.Text = "仓库管理";
            this.buttonText.Click += new System.EventHandler(this.buttonText_Click);
            this.buttonText.MouseEnter += new System.EventHandler(this.buttonText_MouseEnter);
            this.buttonText.MouseLeave += new System.EventHandler(this.buttonText_MouseLeave);
            // 
            // UMenuButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.Controls.Add(this.buttonText);
            this.Controls.Add(this.buttonImage);
            this.Name = "UMenuButton";
            this.Size = new System.Drawing.Size(289, 72);
            ((System.ComponentModel.ISupportInitialize)(this.buttonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonImage;
        private System.Windows.Forms.Label buttonText;
    }
}
