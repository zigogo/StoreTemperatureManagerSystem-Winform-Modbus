namespace STMS.store
{
    partial class FrmStoreRegionManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnStoreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStoreRegionNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStoreNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRegionCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAllowLowTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllowHighTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTemperState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uPanelMenu = new STMS.UControl.UPanel();
            this.comboBoxMenuState = new System.Windows.Forms.ComboBox();
            this.comboBoxMenuStore = new System.Windows.Forms.ComboBox();
            this.labelMenuTip2 = new System.Windows.Forms.Label();
            this.labelMenuTip3 = new System.Windows.Forms.Label();
            this.uCircleBtnSwitchContent = new STMS.UControls.UCircleButton();
            this.textBoxWordOfSearch = new System.Windows.Forms.TextBox();
            this.uCircleButtonDelete = new STMS.UControls.UCircleButton();
            this.labelMenuTip1 = new System.Windows.Forms.Label();
            this.uCircleButtonNew = new STMS.UControls.UCircleButton();
            this.uPanelHead = new STMS.UControl.UPanel();
            this.uCircleButtonRefresh = new STMS.UControls.UCircleButton();
            this.labeltitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.uPanelMenu.SuspendLayout();
            this.uPanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(155)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 35;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCheck,
            this.ColumnStoreId,
            this.ColumnRegionName,
            this.ColumnStoreRegionNo,
            this.ColumnStoreNo,
            this.ColumnRegionCount,
            this.ColumnAllowLowTemperature,
            this.AllowHighTemperature,
            this.ColumnTemperState,
            this.ColumnRemark,
            this.ColumnEdit,
            this.ColumnDelete,
            this.ColumnRecover,
            this.ColumnRemove});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 254);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1432, 874);
            this.dataGridView.TabIndex = 4;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.FillWeight = 40.72007F;
            this.ColumnCheck.HeaderText = "选择";
            this.ColumnCheck.MinimumWidth = 8;
            this.ColumnCheck.Name = "ColumnCheck";
            // 
            // ColumnStoreId
            // 
            this.ColumnStoreId.DataPropertyName = "SRegionId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnStoreId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnStoreId.FillWeight = 40.72007F;
            this.ColumnStoreId.HeaderText = "编号ID";
            this.ColumnStoreId.MinimumWidth = 8;
            this.ColumnStoreId.Name = "ColumnStoreId";
            this.ColumnStoreId.ReadOnly = true;
            // 
            // ColumnRegionName
            // 
            this.ColumnRegionName.DataPropertyName = "SRegionName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnRegionName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnRegionName.FillWeight = 67.86679F;
            this.ColumnRegionName.HeaderText = "分区名";
            this.ColumnRegionName.MinimumWidth = 8;
            this.ColumnRegionName.Name = "ColumnRegionName";
            this.ColumnRegionName.ReadOnly = true;
            // 
            // ColumnStoreRegionNo
            // 
            this.ColumnStoreRegionNo.DataPropertyName = "SRegionNo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnStoreRegionNo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnStoreRegionNo.FillWeight = 67.86679F;
            this.ColumnStoreRegionNo.HeaderText = "仓库分区编号";
            this.ColumnStoreRegionNo.MinimumWidth = 8;
            this.ColumnStoreRegionNo.Name = "ColumnStoreRegionNo";
            this.ColumnStoreRegionNo.ReadOnly = true;
            // 
            // ColumnStoreNo
            // 
            this.ColumnStoreNo.DataPropertyName = "StoreName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnStoreNo.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnStoreNo.FillWeight = 54.29343F;
            this.ColumnStoreNo.HeaderText = "仓库名称";
            this.ColumnStoreNo.MinimumWidth = 8;
            this.ColumnStoreNo.Name = "ColumnStoreNo";
            this.ColumnStoreNo.ReadOnly = true;
            // 
            // ColumnRegionCount
            // 
            this.ColumnRegionCount.DataPropertyName = "SRTemperature";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnRegionCount.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnRegionCount.FillWeight = 47.50675F;
            this.ColumnRegionCount.HeaderText = "室内温度";
            this.ColumnRegionCount.MinimumWidth = 8;
            this.ColumnRegionCount.Name = "ColumnRegionCount";
            this.ColumnRegionCount.ReadOnly = true;
            // 
            // ColumnAllowLowTemperature
            // 
            this.ColumnAllowLowTemperature.DataPropertyName = "AllowLowTemperature";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnAllowLowTemperature.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnAllowLowTemperature.FillWeight = 67.86679F;
            this.ColumnAllowLowTemperature.HeaderText = "低温";
            this.ColumnAllowLowTemperature.MinimumWidth = 8;
            this.ColumnAllowLowTemperature.Name = "ColumnAllowLowTemperature";
            this.ColumnAllowLowTemperature.ReadOnly = true;
            // 
            // AllowHighTemperature
            // 
            this.AllowHighTemperature.DataPropertyName = "AllowHighTemprature";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.AllowHighTemperature.DefaultCellStyle = dataGridViewCellStyle8;
            this.AllowHighTemperature.FillWeight = 67.86679F;
            this.AllowHighTemperature.HeaderText = "高温";
            this.AllowHighTemperature.MinimumWidth = 8;
            this.AllowHighTemperature.Name = "AllowHighTemperature";
            this.AllowHighTemperature.ReadOnly = true;
            // 
            // ColumnTemperState
            // 
            this.ColumnTemperState.DataPropertyName = "TemperState";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnTemperState.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnTemperState.FillWeight = 67.86679F;
            this.ColumnTemperState.HeaderText = "状态";
            this.ColumnTemperState.MinimumWidth = 8;
            this.ColumnTemperState.Name = "ColumnTemperState";
            this.ColumnTemperState.ReadOnly = true;
            // 
            // ColumnRemark
            // 
            this.ColumnRemark.DataPropertyName = "Remark";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnRemark.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnRemark.FillWeight = 60F;
            this.ColumnRemark.HeaderText = "描述";
            this.ColumnRemark.MinimumWidth = 8;
            this.ColumnRemark.Name = "ColumnRemark";
            this.ColumnRemark.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle11.NullValue = "修改";
            this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColumnEdit.FillWeight = 40.72007F;
            this.ColumnEdit.HeaderText = "修改";
            this.ColumnEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ColumnEdit.MinimumWidth = 8;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.TrackVisitedState = false;
            // 
            // ColumnDelete
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle12.NullValue = "删除";
            this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColumnDelete.FillWeight = 40.72007F;
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ColumnDelete.MinimumWidth = 8;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.TrackVisitedState = false;
            // 
            // ColumnRecover
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle13.NullValue = "恢复";
            this.ColumnRecover.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColumnRecover.FillWeight = 40.72007F;
            this.ColumnRecover.HeaderText = "恢复";
            this.ColumnRecover.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ColumnRecover.MinimumWidth = 8;
            this.ColumnRecover.Name = "ColumnRecover";
            this.ColumnRecover.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnRecover.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnRecover.TrackVisitedState = false;
            // 
            // ColumnRemove
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle14.NullValue = "移除";
            this.ColumnRemove.DefaultCellStyle = dataGridViewCellStyle14;
            this.ColumnRemove.FillWeight = 40.72007F;
            this.ColumnRemove.HeaderText = "移除";
            this.ColumnRemove.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ColumnRemove.MinimumWidth = 8;
            this.ColumnRemove.Name = "ColumnRemove";
            this.ColumnRemove.TrackVisitedState = false;
            // 
            // uPanelMenu
            // 
            this.uPanelMenu.BgColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.uPanelMenu.BgColor2 = System.Drawing.Color.Transparent;
            this.uPanelMenu.BorderColor = System.Drawing.Color.Red;
            this.uPanelMenu.Controls.Add(this.comboBoxMenuState);
            this.uPanelMenu.Controls.Add(this.comboBoxMenuStore);
            this.uPanelMenu.Controls.Add(this.labelMenuTip2);
            this.uPanelMenu.Controls.Add(this.labelMenuTip3);
            this.uPanelMenu.Controls.Add(this.uCircleBtnSwitchContent);
            this.uPanelMenu.Controls.Add(this.textBoxWordOfSearch);
            this.uPanelMenu.Controls.Add(this.uCircleButtonDelete);
            this.uPanelMenu.Controls.Add(this.labelMenuTip1);
            this.uPanelMenu.Controls.Add(this.uCircleButtonNew);
            this.uPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uPanelMenu.Location = new System.Drawing.Point(0, 128);
            this.uPanelMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uPanelMenu.Name = "uPanelMenu";
            this.uPanelMenu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.uPanelMenu.Size = new System.Drawing.Size(2070, 126);
            this.uPanelMenu.TabIndex = 3;
            // 
            // comboBoxMenuState
            // 
            this.comboBoxMenuState.FormattingEnabled = true;
            this.comboBoxMenuState.Location = new System.Drawing.Point(557, 44);
            this.comboBoxMenuState.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxMenuState.Name = "comboBoxMenuState";
            this.comboBoxMenuState.Size = new System.Drawing.Size(180, 35);
            this.comboBoxMenuState.TabIndex = 11;
            this.comboBoxMenuState.TextChanged += new System.EventHandler(this.comboBoxMenuState_TextChanged);
            // 
            // comboBoxMenuStore
            // 
            this.comboBoxMenuStore.FormattingEnabled = true;
            this.comboBoxMenuStore.Location = new System.Drawing.Point(263, 45);
            this.comboBoxMenuStore.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxMenuStore.Name = "comboBoxMenuStore";
            this.comboBoxMenuStore.Size = new System.Drawing.Size(180, 35);
            this.comboBoxMenuStore.TabIndex = 10;
            this.comboBoxMenuStore.TextChanged += new System.EventHandler(this.comboBoxMenuStore_TextChanged);
            // 
            // labelMenuTip2
            // 
            this.labelMenuTip2.AutoSize = true;
            this.labelMenuTip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.labelMenuTip2.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelMenuTip2.ForeColor = System.Drawing.Color.White;
            this.labelMenuTip2.Location = new System.Drawing.Point(467, 44);
            this.labelMenuTip2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMenuTip2.Name = "labelMenuTip2";
            this.labelMenuTip2.Size = new System.Drawing.Size(84, 39);
            this.labelMenuTip2.TabIndex = 9;
            this.labelMenuTip2.Text = "状态:";
            // 
            // labelMenuTip3
            // 
            this.labelMenuTip3.AutoSize = true;
            this.labelMenuTip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.labelMenuTip3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelMenuTip3.ForeColor = System.Drawing.Color.White;
            this.labelMenuTip3.Location = new System.Drawing.Point(171, 44);
            this.labelMenuTip3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMenuTip3.Name = "labelMenuTip3";
            this.labelMenuTip3.Size = new System.Drawing.Size(84, 39);
            this.labelMenuTip3.TabIndex = 8;
            this.labelMenuTip3.Text = "仓库:";
            // 
            // uCircleBtnSwitchContent
            // 
            this.uCircleBtnSwitchContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uCircleBtnSwitchContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleBtnSwitchContent.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleBtnSwitchContent.BgColor2 = System.Drawing.Color.CornflowerBlue;
            this.uCircleBtnSwitchContent.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleBtnSwitchContent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleBtnSwitchContent.FlatAppearance.BorderSize = 0;
            this.uCircleBtnSwitchContent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleBtnSwitchContent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleBtnSwitchContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleBtnSwitchContent.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleBtnSwitchContent.ForeColor = System.Drawing.Color.White;
            this.uCircleBtnSwitchContent.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleBtnSwitchContent.Location = new System.Drawing.Point(1811, 26);
            this.uCircleBtnSwitchContent.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleBtnSwitchContent.Name = "uCircleBtnSwitchContent";
            this.uCircleBtnSwitchContent.Radius = 1;
            this.uCircleBtnSwitchContent.Size = new System.Drawing.Size(229, 68);
            this.uCircleBtnSwitchContent.TabIndex = 7;
            this.uCircleBtnSwitchContent.Text = "显示已删除数据";
            this.uCircleBtnSwitchContent.UseVisualStyleBackColor = false;
            this.uCircleBtnSwitchContent.Click += new System.EventHandler(this.uCircleBtnSwitchContent_Click);
            // 
            // textBoxWordOfSearch
            // 
            this.textBoxWordOfSearch.Location = new System.Drawing.Point(1053, 44);
            this.textBoxWordOfSearch.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.textBoxWordOfSearch.Name = "textBoxWordOfSearch";
            this.textBoxWordOfSearch.Size = new System.Drawing.Size(226, 38);
            this.textBoxWordOfSearch.TabIndex = 6;
            this.textBoxWordOfSearch.TextChanged += new System.EventHandler(this.textBoxWordOfSearch_TextChanged);
            // 
            // uCircleButtonDelete
            // 
            this.uCircleButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonDelete.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonDelete.BgColor2 = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonDelete.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonDelete.FlatAppearance.BorderSize = 0;
            this.uCircleButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonDelete.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonDelete.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonDelete.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleButtonDelete.Location = new System.Drawing.Point(1344, 30);
            this.uCircleButtonDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonDelete.Name = "uCircleButtonDelete";
            this.uCircleButtonDelete.Radius = 1;
            this.uCircleButtonDelete.Size = new System.Drawing.Size(114, 68);
            this.uCircleButtonDelete.TabIndex = 5;
            this.uCircleButtonDelete.Text = "删除";
            this.uCircleButtonDelete.UseVisualStyleBackColor = false;
            this.uCircleButtonDelete.Click += new System.EventHandler(this.uCircleButtonDelete_Click);
            // 
            // labelMenuTip1
            // 
            this.labelMenuTip1.AutoSize = true;
            this.labelMenuTip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.labelMenuTip1.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelMenuTip1.ForeColor = System.Drawing.Color.White;
            this.labelMenuTip1.Location = new System.Drawing.Point(751, 45);
            this.labelMenuTip1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMenuTip1.Name = "labelMenuTip1";
            this.labelMenuTip1.Size = new System.Drawing.Size(277, 39);
            this.labelMenuTip1.TabIndex = 3;
            this.labelMenuTip1.Text = "仓库分区名称/编码:";
            // 
            // uCircleButtonNew
            // 
            this.uCircleButtonNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonNew.BgColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonNew.BgColor2 = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonNew.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.uCircleButtonNew.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonNew.FlatAppearance.BorderSize = 0;
            this.uCircleButtonNew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(44)))), ((int)(((byte)(102)))));
            this.uCircleButtonNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uCircleButtonNew.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uCircleButtonNew.ForeColor = System.Drawing.Color.White;
            this.uCircleButtonNew.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.uCircleButtonNew.Location = new System.Drawing.Point(42, 28);
            this.uCircleButtonNew.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonNew.Name = "uCircleButtonNew";
            this.uCircleButtonNew.Radius = 2;
            this.uCircleButtonNew.Size = new System.Drawing.Size(103, 64);
            this.uCircleButtonNew.TabIndex = 2;
            this.uCircleButtonNew.Text = "新增";
            this.uCircleButtonNew.UseVisualStyleBackColor = false;
            this.uCircleButtonNew.Click += new System.EventHandler(this.uCircleButtonNew_Click);
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
            this.uPanelHead.TabIndex = 2;
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
            this.uCircleButtonRefresh.Location = new System.Drawing.Point(1876, 32);
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
            this.labeltitle.Size = new System.Drawing.Size(360, 55);
            this.labeltitle.TabIndex = 0;
            this.labeltitle.Text = "仓库分区管理页面";
            // 
            // FrmStoreRegionManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(2070, 1190);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.uPanelMenu);
            this.Controls.Add(this.uPanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmStoreRegionManage";
            this.Text = "仓库分区信息管理界面";
            this.Load += new System.EventHandler(this.FrmStoreRegionManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.uPanelMenu.ResumeLayout(false);
            this.uPanelMenu.PerformLayout();
            this.uPanelHead.ResumeLayout(false);
            this.uPanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private UControl.UPanel uPanelHead;
        private UControls.UCircleButton uCircleButtonRefresh;
        private System.Windows.Forms.Label labeltitle;
        private UControl.UPanel uPanelMenu;
        private UControls.UCircleButton uCircleBtnSwitchContent;
        private System.Windows.Forms.TextBox textBoxWordOfSearch;
        private UControls.UCircleButton uCircleButtonDelete;
        private System.Windows.Forms.Label labelMenuTip1;
        private UControls.UCircleButton uCircleButtonNew;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBoxMenuState;
        private System.Windows.Forms.ComboBox comboBoxMenuStore;
        private System.Windows.Forms.Label labelMenuTip2;
        private System.Windows.Forms.Label labelMenuTip3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStoreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStoreRegionNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStoreNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRegionCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAllowLowTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllowHighTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTemperState;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnRemark;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRecover;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRemove;
    }
}