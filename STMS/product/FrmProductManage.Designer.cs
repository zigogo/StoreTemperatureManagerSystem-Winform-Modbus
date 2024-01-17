namespace STMS.product
{
    partial class FrmProductManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ColumnCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFitLowTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFitHighTemperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEdit = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnDelete = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRecover = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnRemove = new System.Windows.Forms.DataGridViewLinkColumn();
            this.uPanelMenu = new STMS.UControl.UPanel();
            this.uCircleBtnSwitchContent = new STMS.UControls.UCircleButton();
            this.textBoxWordOfSearch = new System.Windows.Forms.TextBox();
            this.uCircleButtonDelete = new STMS.UControls.UCircleButton();
            this.labelMenuTip = new System.Windows.Forms.Label();
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
            this.ColumnProductId,
            this.ColumnProductNo,
            this.ColumnProductName,
            this.ColumnFitLowTemperature,
            this.ColumnFitHighTemperature,
            this.ColumnEdit,
            this.ColumnDelete,
            this.ColumnRecover,
            this.ColumnRemove});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 262);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(1437, 874);
            this.dataGridView.TabIndex = 5;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // ColumnCheck
            // 
            this.ColumnCheck.FillWeight = 40F;
            this.ColumnCheck.HeaderText = "选择";
            this.ColumnCheck.MinimumWidth = 8;
            this.ColumnCheck.Name = "ColumnCheck";
            // 
            // ColumnProductId
            // 
            this.ColumnProductId.DataPropertyName = "ProductId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProductId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnProductId.FillWeight = 50F;
            this.ColumnProductId.HeaderText = "编号ID";
            this.ColumnProductId.MinimumWidth = 8;
            this.ColumnProductId.Name = "ColumnProductId";
            this.ColumnProductId.ReadOnly = true;
            // 
            // ColumnProductNo
            // 
            this.ColumnProductNo.DataPropertyName = "ProductNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProductNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnProductNo.FillWeight = 60F;
            this.ColumnProductNo.HeaderText = "产品编号";
            this.ColumnProductNo.MinimumWidth = 8;
            this.ColumnProductNo.Name = "ColumnProductNo";
            this.ColumnProductNo.ReadOnly = true;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "ProductName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnProductName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnProductName.FillWeight = 60F;
            this.ColumnProductName.HeaderText = "产品名称";
            this.ColumnProductName.MinimumWidth = 8;
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.ReadOnly = true;
            // 
            // ColumnFitLowTemperature
            // 
            this.ColumnFitLowTemperature.DataPropertyName = "FitLowTemperature";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnFitLowTemperature.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColumnFitLowTemperature.FillWeight = 60F;
            this.ColumnFitLowTemperature.HeaderText = "最低温度";
            this.ColumnFitLowTemperature.MinimumWidth = 8;
            this.ColumnFitLowTemperature.Name = "ColumnFitLowTemperature";
            this.ColumnFitLowTemperature.ReadOnly = true;
            // 
            // ColumnFitHighTemperature
            // 
            this.ColumnFitHighTemperature.DataPropertyName = "FitHighTemperature";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnFitHighTemperature.DefaultCellStyle = dataGridViewCellStyle6;
            this.ColumnFitHighTemperature.FillWeight = 60F;
            this.ColumnFitHighTemperature.HeaderText = "最高温度";
            this.ColumnFitHighTemperature.MinimumWidth = 8;
            this.ColumnFitHighTemperature.Name = "ColumnFitHighTemperature";
            this.ColumnFitHighTemperature.ReadOnly = true;
            // 
            // ColumnEdit
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle7.NullValue = "修改";
            this.ColumnEdit.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnEdit.FillWeight = 40F;
            this.ColumnEdit.HeaderText = "修改";
            this.ColumnEdit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ColumnEdit.MinimumWidth = 8;
            this.ColumnEdit.Name = "ColumnEdit";
            this.ColumnEdit.TrackVisitedState = false;
            // 
            // ColumnDelete
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle8.NullValue = "删除";
            this.ColumnDelete.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnDelete.FillWeight = 40F;
            this.ColumnDelete.HeaderText = "删除";
            this.ColumnDelete.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ColumnDelete.MinimumWidth = 8;
            this.ColumnDelete.Name = "ColumnDelete";
            this.ColumnDelete.TrackVisitedState = false;
            // 
            // ColumnRecover
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle9.NullValue = "恢复";
            this.ColumnRecover.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnRecover.FillWeight = 40F;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle10.NullValue = "移除";
            this.ColumnRemove.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColumnRemove.FillWeight = 40F;
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
            this.uPanelMenu.Controls.Add(this.uCircleBtnSwitchContent);
            this.uPanelMenu.Controls.Add(this.textBoxWordOfSearch);
            this.uPanelMenu.Controls.Add(this.uCircleButtonDelete);
            this.uPanelMenu.Controls.Add(this.labelMenuTip);
            this.uPanelMenu.Controls.Add(this.uCircleButtonNew);
            this.uPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.uPanelMenu.Location = new System.Drawing.Point(0, 128);
            this.uPanelMenu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uPanelMenu.Name = "uPanelMenu";
            this.uPanelMenu.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.uPanelMenu.Size = new System.Drawing.Size(2140, 126);
            this.uPanelMenu.TabIndex = 6;
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
            this.uCircleBtnSwitchContent.Location = new System.Drawing.Point(1832, 22);
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
            this.textBoxWordOfSearch.Location = new System.Drawing.Point(401, 38);
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
            this.uCircleButtonDelete.Location = new System.Drawing.Point(666, 26);
            this.uCircleButtonDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.uCircleButtonDelete.Name = "uCircleButtonDelete";
            this.uCircleButtonDelete.Radius = 1;
            this.uCircleButtonDelete.Size = new System.Drawing.Size(114, 68);
            this.uCircleButtonDelete.TabIndex = 5;
            this.uCircleButtonDelete.Text = "删除";
            this.uCircleButtonDelete.UseVisualStyleBackColor = false;
            this.uCircleButtonDelete.Click += new System.EventHandler(this.uCircleButtonDelete_Click);
            // 
            // labelMenuTip
            // 
            this.labelMenuTip.AutoSize = true;
            this.labelMenuTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(116)))));
            this.labelMenuTip.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.labelMenuTip.ForeColor = System.Drawing.Color.White;
            this.labelMenuTip.Location = new System.Drawing.Point(159, 40);
            this.labelMenuTip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelMenuTip.Name = "labelMenuTip";
            this.labelMenuTip.Size = new System.Drawing.Size(240, 39);
            this.labelMenuTip.TabIndex = 3;
            this.labelMenuTip.Text = "产品名称/编码：";
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
            this.uCircleButtonNew.Location = new System.Drawing.Point(30, 28);
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
            this.uPanelHead.Size = new System.Drawing.Size(2140, 128);
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
            this.uCircleButtonRefresh.Location = new System.Drawing.Point(1946, 32);
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
            this.labeltitle.Text = "产品管理页面";
            // 
            // FrmProductManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(61)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(2140, 1162);
            this.Controls.Add(this.uPanelMenu);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.uPanelHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProductManage";
            this.Text = "产品信息管理";
            this.Load += new System.EventHandler(this.FrmProductManage_Load);
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
        private System.Windows.Forms.DataGridView dataGridView;
        private UControl.UPanel uPanelMenu;
        private UControls.UCircleButton uCircleBtnSwitchContent;
        private System.Windows.Forms.TextBox textBoxWordOfSearch;
        private UControls.UCircleButton uCircleButtonDelete;
        private System.Windows.Forms.Label labelMenuTip;
        private UControls.UCircleButton uCircleButtonNew;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFitLowTemperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFitHighTemperature;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEdit;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDelete;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRecover;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnRemove;
    }
}