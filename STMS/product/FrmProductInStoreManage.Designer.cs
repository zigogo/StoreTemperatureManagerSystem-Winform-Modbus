namespace STMS.product
{
    partial class FrmProductInStoreManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.labelTipStoreRegion = new System.Windows.Forms.Label();
            this.numericUpDownProductCount = new System.Windows.Forms.NumericUpDown();
            this.comboBoxStoreRegion = new System.Windows.Forms.ComboBox();
            this.comboBoxStoreName = new System.Windows.Forms.ComboBox();
            this.comboBoxProductName = new System.Windows.Forms.ComboBox();
            this.labelStoreRegion = new System.Windows.Forms.Label();
            this.labelProductCount = new System.Windows.Forms.Label();
            this.labelTipStore = new System.Windows.Forms.Label();
            this.labelTipProductName = new System.Windows.Forms.Label();
            this.labelStoreName = new System.Windows.Forms.Label();
            this.labelProductName = new System.Windows.Forms.Label();
            this.ColumnProductCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStoreName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProStoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.uCircleButtonClear = new STMS.UControls.UCircleButton();
            this.uCircleButtonSubmit = new STMS.UControls.UCircleButton();
            this.uCircleButtonProductInStore = new STMS.UControls.UCircleButton();
            this.uCircleButtonProductStockInfo = new STMS.UControls.UCircleButton();
            this.uPanelHead = new STMS.UControl.UPanel();
            this.uCircleButtonRefresh = new STMS.UControls.UCircleButton();
            this.labeltitle = new System.Windows.Forms.Label();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.uPanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(12, 171);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(272, 46);
            this.label.TabIndex = 4;
            this.label.Text = "产品入库信息：";
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.groupBox.Controls.Add(this.labelTipStoreRegion);
            this.groupBox.Controls.Add(this.numericUpDownProductCount);
            this.groupBox.Controls.Add(this.comboBoxStoreRegion);
            this.groupBox.Controls.Add(this.comboBoxStoreName);
            this.groupBox.Controls.Add(this.comboBoxProductName);
            this.groupBox.Controls.Add(this.labelStoreRegion);
            this.groupBox.Controls.Add(this.labelProductCount);
            this.groupBox.Controls.Add(this.uCircleButtonClear);
            this.groupBox.Controls.Add(this.uCircleButtonSubmit);
            this.groupBox.Controls.Add(this.labelTipStore);
            this.groupBox.Controls.Add(this.labelTipProductName);
            this.groupBox.Controls.Add(this.labelStoreName);
            this.groupBox.Controls.Add(this.labelProductName);
            this.groupBox.ForeColor = System.Drawing.Color.White;
            this.groupBox.Location = new System.Drawing.Point(699, 249);
            this.groupBox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox.Size = new System.Drawing.Size(730, 682);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "产品入库设置";
            // 
            // labelTipStoreRegion
            // 
            this.labelTipStoreRegion.AutoSize = true;
            this.labelTipStoreRegion.Font = new System.Drawing.Font("宋体", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTipStoreRegion.ForeColor = System.Drawing.Color.Red;
            this.labelTipStoreRegion.Location = new System.Drawing.Point(530, 280);
            this.labelTipStoreRegion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipStoreRegion.Name = "labelTipStoreRegion";
            this.labelTipStoreRegion.Size = new System.Drawing.Size(98, 33);
            this.labelTipStoreRegion.TabIndex = 17;
            this.labelTipStoreRegion.Text = "*必填";
            // 
            // numericUpDownProductCount
            // 
            this.numericUpDownProductCount.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownProductCount.Location = new System.Drawing.Point(244, 367);
            this.numericUpDownProductCount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownProductCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownProductCount.Name = "numericUpDownProductCount";
            this.numericUpDownProductCount.Size = new System.Drawing.Size(276, 50);
            this.numericUpDownProductCount.TabIndex = 16;
            this.numericUpDownProductCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxStoreRegion
            // 
            this.comboBoxStoreRegion.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStoreRegion.FormattingEnabled = true;
            this.comboBoxStoreRegion.Location = new System.Drawing.Point(244, 271);
            this.comboBoxStoreRegion.Name = "comboBoxStoreRegion";
            this.comboBoxStoreRegion.Size = new System.Drawing.Size(276, 49);
            this.comboBoxStoreRegion.TabIndex = 15;
            this.comboBoxStoreRegion.TextChanged += new System.EventHandler(this.comboBoxStoreRegion_TextChanged);
            // 
            // comboBoxStoreName
            // 
            this.comboBoxStoreName.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxStoreName.FormattingEnabled = true;
            this.comboBoxStoreName.Location = new System.Drawing.Point(244, 176);
            this.comboBoxStoreName.Name = "comboBoxStoreName";
            this.comboBoxStoreName.Size = new System.Drawing.Size(276, 49);
            this.comboBoxStoreName.TabIndex = 14;
            this.comboBoxStoreName.TextChanged += new System.EventHandler(this.comboBoxStoreName_TextChanged);
            // 
            // comboBoxProductName
            // 
            this.comboBoxProductName.Font = new System.Drawing.Font("微软雅黑", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxProductName.FormattingEnabled = true;
            this.comboBoxProductName.Location = new System.Drawing.Point(244, 79);
            this.comboBoxProductName.Name = "comboBoxProductName";
            this.comboBoxProductName.Size = new System.Drawing.Size(276, 49);
            this.comboBoxProductName.TabIndex = 13;
            this.comboBoxProductName.TextChanged += new System.EventHandler(this.comboBoxProductName_TextChanged);
            // 
            // labelStoreRegion
            // 
            this.labelStoreRegion.AutoSize = true;
            this.labelStoreRegion.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStoreRegion.Location = new System.Drawing.Point(65, 271);
            this.labelStoreRegion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStoreRegion.Name = "labelStoreRegion";
            this.labelStoreRegion.Size = new System.Drawing.Size(178, 41);
            this.labelStoreRegion.TabIndex = 12;
            this.labelStoreRegion.Text = "仓库分区：";
            // 
            // labelProductCount
            // 
            this.labelProductCount.AutoSize = true;
            this.labelProductCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProductCount.Location = new System.Drawing.Point(65, 368);
            this.labelProductCount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProductCount.Name = "labelProductCount";
            this.labelProductCount.Size = new System.Drawing.Size(178, 41);
            this.labelProductCount.TabIndex = 11;
            this.labelProductCount.Text = "入库数量：";
            // 
            // labelTipStore
            // 
            this.labelTipStore.AutoSize = true;
            this.labelTipStore.Font = new System.Drawing.Font("宋体", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTipStore.ForeColor = System.Drawing.Color.Red;
            this.labelTipStore.Location = new System.Drawing.Point(530, 183);
            this.labelTipStore.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipStore.Name = "labelTipStore";
            this.labelTipStore.Size = new System.Drawing.Size(98, 33);
            this.labelTipStore.TabIndex = 8;
            this.labelTipStore.Text = "*必填";
            // 
            // labelTipProductName
            // 
            this.labelTipProductName.AutoSize = true;
            this.labelTipProductName.Font = new System.Drawing.Font("宋体", 10.66667F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTipProductName.ForeColor = System.Drawing.Color.Red;
            this.labelTipProductName.Location = new System.Drawing.Point(530, 89);
            this.labelTipProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTipProductName.Name = "labelTipProductName";
            this.labelTipProductName.Size = new System.Drawing.Size(98, 33);
            this.labelTipProductName.TabIndex = 6;
            this.labelTipProductName.Text = "*必填";
            // 
            // labelStoreName
            // 
            this.labelStoreName.AutoSize = true;
            this.labelStoreName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelStoreName.Location = new System.Drawing.Point(65, 177);
            this.labelStoreName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelStoreName.Name = "labelStoreName";
            this.labelStoreName.Size = new System.Drawing.Size(178, 41);
            this.labelStoreName.TabIndex = 1;
            this.labelStoreName.Text = "入库仓库：";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelProductName.Location = new System.Drawing.Point(65, 81);
            this.labelProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(178, 41);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "入库产品：";
            // 
            // ColumnProductCount
            // 
            this.ColumnProductCount.DataPropertyName = "ProductCount";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProductCount.DefaultCellStyle = dataGridViewCellStyle19;
            this.ColumnProductCount.FillWeight = 60F;
            this.ColumnProductCount.HeaderText = "库存数量";
            this.ColumnProductCount.MinimumWidth = 8;
            this.ColumnProductCount.Name = "ColumnProductCount";
            this.ColumnProductCount.ReadOnly = true;
            // 
            // ColumnSRegionName
            // 
            this.ColumnSRegionName.DataPropertyName = "SRegionName";
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnSRegionName.DefaultCellStyle = dataGridViewCellStyle20;
            this.ColumnSRegionName.FillWeight = 60F;
            this.ColumnSRegionName.HeaderText = "仓库分区";
            this.ColumnSRegionName.MinimumWidth = 8;
            this.ColumnSRegionName.Name = "ColumnSRegionName";
            this.ColumnSRegionName.ReadOnly = true;
            // 
            // ColumnStoreName
            // 
            this.ColumnStoreName.DataPropertyName = "StoreName";
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnStoreName.DefaultCellStyle = dataGridViewCellStyle21;
            this.ColumnStoreName.FillWeight = 60F;
            this.ColumnStoreName.HeaderText = "所属仓库";
            this.ColumnStoreName.MinimumWidth = 8;
            this.ColumnStoreName.Name = "ColumnStoreName";
            this.ColumnStoreName.ReadOnly = true;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProductName.DefaultCellStyle = dataGridViewCellStyle22;
            this.ColumnProductName.FillWeight = 60F;
            this.ColumnProductName.HeaderText = "产品名称";
            this.ColumnProductName.MinimumWidth = 8;
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            // 
            // ColumnProStoreId
            // 
            this.ColumnProStoreId.DataPropertyName = "ProStoreId";
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProStoreId.DefaultCellStyle = dataGridViewCellStyle23;
            this.ColumnProStoreId.FillWeight = 50F;
            this.ColumnProStoreId.HeaderText = "编号ID";
            this.ColumnProStoreId.MinimumWidth = 8;
            this.ColumnProStoreId.Name = "ColumnProStoreId";
            this.ColumnProStoreId.ReadOnly = true;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProStoreId,
            this.ColumnProductName,
            this.ColumnStoreName,
            this.ColumnSRegionName,
            this.ColumnProductCount});
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle25.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle25.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle25;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 249);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(672, 942);
            this.dataGridView.TabIndex = 7;
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
            this.uCircleButtonClear.Location = new System.Drawing.Point(422, 510);
            this.uCircleButtonClear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonClear.Name = "uCircleButtonClear";
            this.uCircleButtonClear.Radius = 3;
            this.uCircleButtonClear.Size = new System.Drawing.Size(132, 56);
            this.uCircleButtonClear.TabIndex = 10;
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
            this.uCircleButtonSubmit.Location = new System.Drawing.Point(129, 510);
            this.uCircleButtonSubmit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonSubmit.Name = "uCircleButtonSubmit";
            this.uCircleButtonSubmit.Radius = 3;
            this.uCircleButtonSubmit.Size = new System.Drawing.Size(132, 56);
            this.uCircleButtonSubmit.TabIndex = 9;
            this.uCircleButtonSubmit.Text = "确定";
            this.uCircleButtonSubmit.UseVisualStyleBackColor = true;
            this.uCircleButtonSubmit.Click += new System.EventHandler(this.uCircleButtonSubmit_Click);
            // 
            // uCircleButtonProductInStore
            // 
            this.uCircleButtonProductInStore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductInStore.BgColor = System.Drawing.Color.MediumBlue;
            this.uCircleButtonProductInStore.BgColor2 = System.Drawing.Color.MediumBlue;
            this.uCircleButtonProductInStore.BorderColor = System.Drawing.Color.Black;
            this.uCircleButtonProductInStore.BorderWidth = 2;
            this.uCircleButtonProductInStore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductInStore.FlatAppearance.BorderSize = 0;
            this.uCircleButtonProductInStore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductInStore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductInStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonProductInStore.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonProductInStore.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonProductInStore.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleButtonProductInStore.Location = new System.Drawing.Point(313, 153);
            this.uCircleButtonProductInStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonProductInStore.Name = "uCircleButtonProductInStore";
            this.uCircleButtonProductInStore.Radius = 2;
            this.uCircleButtonProductInStore.Size = new System.Drawing.Size(241, 64);
            this.uCircleButtonProductInStore.TabIndex = 6;
            this.uCircleButtonProductInStore.Text = "产品入库记录";
            this.uCircleButtonProductInStore.UseVisualStyleBackColor = false;
            this.uCircleButtonProductInStore.Click += new System.EventHandler(this.uCircleButtonProductInStore_Click);
            // 
            // uCircleButtonProductStockInfo
            // 
            this.uCircleButtonProductStockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductStockInfo.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonProductStockInfo.BgColor2 = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonProductStockInfo.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonProductStockInfo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductStockInfo.FlatAppearance.BorderSize = 0;
            this.uCircleButtonProductStockInfo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductStockInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonProductStockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonProductStockInfo.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonProductStockInfo.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonProductStockInfo.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleButtonProductStockInfo.Location = new System.Drawing.Point(637, 153);
            this.uCircleButtonProductStockInfo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonProductStockInfo.Name = "uCircleButtonProductStockInfo";
            this.uCircleButtonProductStockInfo.Radius = 2;
            this.uCircleButtonProductStockInfo.Size = new System.Drawing.Size(241, 64);
            this.uCircleButtonProductStockInfo.TabIndex = 5;
            this.uCircleButtonProductStockInfo.Text = "产品库存列表";
            this.uCircleButtonProductStockInfo.UseVisualStyleBackColor = false;
            this.uCircleButtonProductStockInfo.Click += new System.EventHandler(this.uCircleButtonProductStockInfo_Click);
            // 
            // uPanelHead
            // 
            this.uPanelHead.BackColor = System.Drawing.Color.Transparent;
            this.uPanelHead.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uPanelHead.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanelHead.BorderColor = System.Drawing.Color.Transparent;
            this.uPanelHead.Controls.Add(this.uCircleButtonRefresh);
            this.uPanelHead.Controls.Add(this.labeltitle);
            this.uPanelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.uPanelHead.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uPanelHead.ForeColor = System.Drawing.Color.Transparent;
            this.uPanelHead.Location = new System.Drawing.Point(0, 0);
            this.uPanelHead.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uPanelHead.Name = "uPanelHead";
            this.uPanelHead.Size = new System.Drawing.Size(2070, 128);
            this.uPanelHead.TabIndex = 3;
            // 
            // uCircleButtonRefresh
            // 
            this.uCircleButtonRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uCircleButtonRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonRefresh.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonRefresh.BgColor2 = System.Drawing.Color.MidnightBlue;
            this.uCircleButtonRefresh.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonRefresh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonRefresh.FlatAppearance.BorderSize = 0;
            this.uCircleButtonRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonRefresh.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonRefresh.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonRefresh.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleButtonRefresh.Location = new System.Drawing.Point(1764, 29);
            this.uCircleButtonRefresh.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonRefresh.Name = "uCircleButtonRefresh";
            this.uCircleButtonRefresh.Radius = 6;
            this.uCircleButtonRefresh.Size = new System.Drawing.Size(114, 68);
            this.uCircleButtonRefresh.TabIndex = 1;
            this.uCircleButtonRefresh.Text = "刷新";
            this.uCircleButtonRefresh.UseVisualStyleBackColor = false;
            this.uCircleButtonRefresh.Click += new System.EventHandler(this.uCircleButtonRefresh_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.labeltitle.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labeltitle.ForeColor = System.Drawing.Color.White;
            this.labeltitle.Location = new System.Drawing.Point(19, 32);
            this.labeltitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(276, 55);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "产品入库页面";
            // 
            // FrmProductInStoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(2070, 1190);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.uCircleButtonProductInStore);
            this.Controls.Add(this.uCircleButtonProductStockInfo);
            this.Controls.Add(this.label);
            this.Controls.Add(this.uPanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmProductInStoreManage";
            this.Load += new System.EventHandler(this.FrmProductInStoreManage_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProductCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.uPanelHead.ResumeLayout(false);
            this.uPanelHead.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UControl.UPanel uPanelHead;
        private UControls.UCircleButton uCircleButtonRefresh;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Label label;
        private UControls.UCircleButton uCircleButtonProductStockInfo;
        private UControls.UCircleButton uCircleButtonProductInStore;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label labelTipStore;
        private System.Windows.Forms.Label labelTipProductName;
        private System.Windows.Forms.Label labelStoreName;
        private System.Windows.Forms.Label labelProductName;
        private UControls.UCircleButton uCircleButtonClear;
        private UControls.UCircleButton uCircleButtonSubmit;
        private System.Windows.Forms.Label labelStoreRegion;
        private System.Windows.Forms.Label labelProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStoreName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProStoreId;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.NumericUpDown numericUpDownProductCount;
        private System.Windows.Forms.ComboBox comboBoxStoreRegion;
        private System.Windows.Forms.ComboBox comboBoxStoreName;
        private System.Windows.Forms.ComboBox comboBoxProductName;
        private System.Windows.Forms.Label labelTipStoreRegion;
    }
}