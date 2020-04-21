namespace 后台SuperMarketManager.ProducFrm
{
    partial class FrmInventory商品库存
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventory商品库存));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMinCount = new SuperMarketCommon.SuperTextbox(this.components);
            this.txtMaxCount = new SuperMarketCommon.SuperTextbox(this.components);
            this.txtCount = new SuperMarketCommon.SuperTextbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.btnLowMin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnHeightMax = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtWhere = new SuperMarketCommon.SuperTextbox(this.components);
            this.btnQueryWhere = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvProductList = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdateCount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnRefreshCount = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMax = new SuperMarketCommon.SuperTextbox(this.components);
            this.txtMin = new SuperMarketCommon.SuperTextbox(this.components);
            this.txtCurrentCount = new SuperMarketCommon.SuperTextbox(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.txtMinCount);
            this.groupBox2.Controls.Add(this.txtMaxCount);
            this.groupBox2.Controls.Add(this.txtCount);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnLowMin);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.linkLabel1);
            this.groupBox2.Controls.Add(this.btnHeightMax);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(13, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1263, 98);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "【库存预警信息】";
            // 
            // txtMinCount
            // 
            this.txtMinCount.Location = new System.Drawing.Point(936, 43);
            this.txtMinCount.Name = "txtMinCount";
            this.txtMinCount.Size = new System.Drawing.Size(170, 34);
            this.txtMinCount.TabIndex = 12;
            // 
            // txtMaxCount
            // 
            this.txtMaxCount.Location = new System.Drawing.Point(458, 43);
            this.txtMaxCount.Name = "txtMaxCount";
            this.txtMaxCount.Size = new System.Drawing.Size(162, 34);
            this.txtMaxCount.TabIndex = 11;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(120, 44);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(197, 34);
            this.txtCount.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(796, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "低于库存下限:";
            // 
            // btnLowMin
            // 
            this.btnLowMin.Image = ((System.Drawing.Image)(resources.GetObject("btnLowMin.Image")));
            this.btnLowMin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLowMin.Location = new System.Drawing.Point(1119, 36);
            this.btnLowMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLowMin.Name = "btnLowMin";
            this.btnLowMin.Size = new System.Drawing.Size(130, 45);
            this.btnLowMin.TabIndex = 9;
            this.btnLowMin.Text = "低于库存";
            this.btnLowMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLowMin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "超出库存上限:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(192, 0);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(186, 27);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "[刷新库存预警信息]";
            // 
            // btnHeightMax
            // 
            this.btnHeightMax.Image = ((System.Drawing.Image)(resources.GetObject("btnHeightMax.Image")));
            this.btnHeightMax.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHeightMax.Location = new System.Drawing.Point(646, 38);
            this.btnHeightMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnHeightMax.Name = "btnHeightMax";
            this.btnHeightMax.Size = new System.Drawing.Size(130, 45);
            this.btnHeightMax.TabIndex = 4;
            this.btnHeightMax.Text = "超出库存";
            this.btnHeightMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHeightMax.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "预警总数：";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.txtWhere);
            this.groupBox1.Controls.Add(this.btnQueryWhere);
            this.groupBox1.Controls.Add(this.cmbCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1110, 98);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "【商品库存查询】";
            // 
            // txtWhere
            // 
            this.txtWhere.Location = new System.Drawing.Point(135, 33);
            this.txtWhere.Name = "txtWhere";
            this.txtWhere.Size = new System.Drawing.Size(354, 34);
            this.txtWhere.TabIndex = 5;
            // 
            // btnQueryWhere
            // 
            this.btnQueryWhere.Image = ((System.Drawing.Image)(resources.GetObject("btnQueryWhere.Image")));
            this.btnQueryWhere.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQueryWhere.Location = new System.Drawing.Point(970, 30);
            this.btnQueryWhere.Margin = new System.Windows.Forms.Padding(4);
            this.btnQueryWhere.Name = "btnQueryWhere";
            this.btnQueryWhere.Size = new System.Drawing.Size(130, 45);
            this.btnQueryWhere.TabIndex = 4;
            this.btnQueryWhere.Text = "提交查询";
            this.btnQueryWhere.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQueryWhere.UseVisualStyleBackColor = true;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(650, 33);
            this.cmbCategory.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(238, 35);
            this.cmbCategory.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "商品分类：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "查询条件：";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1155, 13);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 45);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "关闭窗口";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvProductList
            // 
            this.dgvProductList.AllowUserToAddRows = false;
            this.dgvProductList.AllowUserToDeleteRows = false;
            this.dgvProductList.AllowUserToResizeColumns = false;
            this.dgvProductList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvProductList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvProductList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductList.ColumnHeadersHeight = 30;
            this.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.Unit,
            this.UnitPrice,
            this.Discount,
            this.Inventory,
            this.ProductType});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductList.EnableHeadersVisualStyles = false;
            this.dgvProductList.Location = new System.Drawing.Point(13, 220);
            this.dgvProductList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductList.MultiSelect = false;
            this.dgvProductList.Name = "dgvProductList";
            this.dgvProductList.ReadOnly = true;
            this.dgvProductList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductList.RowHeadersVisible = false;
            this.dgvProductList.RowHeadersWidth = 62;
            this.dgvProductList.RowTemplate.Height = 23;
            this.dgvProductList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductList.Size = new System.Drawing.Size(1262, 333);
            this.dgvProductList.TabIndex = 17;
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "SalesPersonId";
            this.ProductId.HeaderText = "商品编号";
            this.ProductId.MinimumWidth = 8;
            this.ProductId.Name = "ProductId";
            this.ProductId.ReadOnly = true;
            this.ProductId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ProductId.Width = 160;
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "SPName";
            this.ProductName.HeaderText = "商品名称";
            this.ProductName.MinimumWidth = 8;
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 160;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "计量单位";
            this.Unit.MinimumWidth = 8;
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 80;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 80F;
            this.UnitPrice.HeaderText = "最小库存";
            this.UnitPrice.MinimumWidth = 8;
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 110;
            // 
            // Discount
            // 
            this.Discount.FillWeight = 80F;
            this.Discount.HeaderText = "当前库存";
            this.Discount.MinimumWidth = 8;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 110;
            // 
            // Inventory
            // 
            this.Inventory.FillWeight = 80F;
            this.Inventory.HeaderText = "最大库存";
            this.Inventory.MinimumWidth = 8;
            this.Inventory.Name = "Inventory";
            this.Inventory.ReadOnly = true;
            this.Inventory.Width = 110;
            // 
            // ProductType
            // 
            this.ProductType.FillWeight = 80F;
            this.ProductType.HeaderText = "库存状态";
            this.ProductType.MinimumWidth = 8;
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            this.ProductType.Width = 150;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.txtCurrentCount);
            this.groupBox4.Controls.Add(this.btnUpdateCount);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.Location = new System.Drawing.Point(801, 553);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(474, 100);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "【调整商品库存】";
            // 
            // btnUpdateCount
            // 
            this.btnUpdateCount.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateCount.Image")));
            this.btnUpdateCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateCount.Location = new System.Drawing.Point(320, 30);
            this.btnUpdateCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateCount.Name = "btnUpdateCount";
            this.btnUpdateCount.Size = new System.Drawing.Size(132, 40);
            this.btnUpdateCount.TabIndex = 11;
            this.btnUpdateCount.Text = "修改库存";
            this.btnUpdateCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateCount.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 40);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 27);
            this.label9.TabIndex = 7;
            this.label9.Text = "当前库存：";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.txtMin);
            this.groupBox3.Controls.Add(this.txtMax);
            this.groupBox3.Controls.Add(this.btnRefreshCount);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(13, 553);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(778, 100);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "【库存预警设置】";
            // 
            // btnRefreshCount
            // 
            this.btnRefreshCount.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCount.Image")));
            this.btnRefreshCount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefreshCount.Location = new System.Drawing.Point(618, 33);
            this.btnRefreshCount.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefreshCount.Name = "btnRefreshCount";
            this.btnRefreshCount.Size = new System.Drawing.Size(132, 40);
            this.btnRefreshCount.TabIndex = 11;
            this.btnRefreshCount.Text = "更新设置";
            this.btnRefreshCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefreshCount.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 27);
            this.label7.TabIndex = 9;
            this.label7.Text = "最小库存：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 27);
            this.label6.TabIndex = 7;
            this.label6.Text = "最大库存：";
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(122, 37);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(197, 34);
            this.txtMax.TabIndex = 13;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(423, 36);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(176, 34);
            this.txtMin.TabIndex = 14;
            // 
            // txtCurrentCount
            // 
            this.txtCurrentCount.Location = new System.Drawing.Point(121, 33);
            this.txtCurrentCount.Name = "txtCurrentCount";
            this.txtCurrentCount.Size = new System.Drawing.Size(179, 34);
            this.txtCurrentCount.TabIndex = 15;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 666);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvProductList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmInventory";
            this.Text = "商品库存查询管理";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductList)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnLowMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnHeightMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnQueryWhere;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private SuperMarketCommon.SuperTextbox txtMinCount;
        private SuperMarketCommon.SuperTextbox txtMaxCount;
        private SuperMarketCommon.SuperTextbox txtCount;
        private SuperMarketCommon.SuperTextbox txtWhere;
        private System.Windows.Forms.DataGridView dgvProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdateCount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnRefreshCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private SuperMarketCommon.SuperTextbox txtCurrentCount;
        private SuperMarketCommon.SuperTextbox txtMin;
        private SuperMarketCommon.SuperTextbox txtMax;
    }
}