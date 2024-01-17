namespace STMS.UControls
{
    partial class UPageButton
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
            this.btnlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlabel
            // 
            this.btnlabel.BackColor = System.Drawing.Color.Transparent;
            this.btnlabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnlabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlabel.ForeColor = System.Drawing.Color.White;
            this.btnlabel.Location = new System.Drawing.Point(0, 0);
            this.btnlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnlabel.Name = "btnlabel";
            this.btnlabel.Size = new System.Drawing.Size(186, 48);
            this.btnlabel.TabIndex = 0;
            this.btnlabel.Text = "仓库管理页面";
            this.btnlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnlabel.Click += new System.EventHandler(this.btnlabel_Click);
            
            // 
            // UPageButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::STMS.Properties.Resources.btnbg01;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btnlabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UPageButton";
            this.Size = new System.Drawing.Size(186, 48);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnlabel;
    }
}
