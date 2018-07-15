namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class WareHouseForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.asset_code_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.ware_house_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.col_warehouseid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltimestart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colassetcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colrankcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colassetname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colassetmodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colassetsupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coluserlocationname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colregistrationdatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colbeforelocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colafterlocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcomments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setting_gbc = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.linksave_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.exportexcel_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.browser_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.clear_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.asset_name_cbm = new System.Windows.Forms.ComboBox();
            this.asset_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.asset_model_cbm = new System.Windows.Forms.ComboBox();
            this.asset_model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.rank_code_cbm = new System.Windows.Forms.ComboBox();
            this.rank_code_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.asset_type_cbm = new System.Windows.Forms.ComboBox();
            this.asset_type_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.full_asset_code_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.full_asset_Code_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.asset_Code_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.select_search_cbm = new System.Windows.Forms.ComboBox();
            this.select_search_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.Invoice_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.invoice_cbm = new System.Windows.Forms.ComboBox();
            this.select_after_location_cbm = new System.Windows.Forms.ComboBox();
            this.select_location_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            ((System.ComponentModel.ISupportInitialize)(this.ware_house_dgv)).BeginInit();
            this.setting_gbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // asset_code_lbl
            // 
            this.asset_code_lbl.AutoSize = true;
            this.asset_code_lbl.ControlId = null;
            this.asset_code_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.asset_code_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asset_code_lbl.Location = new System.Drawing.Point(22, 157);
            this.asset_code_lbl.Name = "asset_code_lbl";
            this.asset_code_lbl.Size = new System.Drawing.Size(74, 15);
            this.asset_code_lbl.TabIndex = 6;
            this.asset_code_lbl.Text = "Asset Code:";
            // 
            // ware_house_dgv
            // 
            this.ware_house_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ware_house_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ware_house_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ware_house_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ware_house_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_warehouseid,
            this.coltimestart,
            this.colassetcode,
            this.colrankcode,
            this.colassetname,
            this.colqty,
            this.colunit,
            this.colassetmodel,
            this.colassetsupplier,
            this.coluserlocationname,
            this.colregistrationdatetime,
            this.colbeforelocation,
            this.colafterlocation,
            this.colcomments});
            this.ware_house_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ware_house_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.ware_house_dgv.Location = new System.Drawing.Point(0, 252);
            this.ware_house_dgv.Name = "ware_house_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ware_house_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.ware_house_dgv.Size = new System.Drawing.Size(1284, 447);
            this.ware_house_dgv.TabIndex = 45;
            // 
            // col_warehouseid
            // 
            this.col_warehouseid.DataPropertyName = "WareHouseId";
            this.col_warehouseid.HeaderText = "Ware House Id";
            this.col_warehouseid.Name = "col_warehouseid";
            this.col_warehouseid.ReadOnly = true;
            this.col_warehouseid.Visible = false;
            this.col_warehouseid.Width = 114;
            // 
            // coltimestart
            // 
            this.coltimestart.DataPropertyName = "TimeStart";
            this.coltimestart.HeaderText = "Time Born";
            this.coltimestart.Name = "coltimestart";
            this.coltimestart.Width = 89;
            // 
            // colassetcode
            // 
            this.colassetcode.DataPropertyName = "AssetCode";
            this.colassetcode.HeaderText = "Asset Code";
            this.colassetcode.Name = "colassetcode";
            this.colassetcode.Width = 96;
            // 
            // colrankcode
            // 
            this.colrankcode.DataPropertyName = "RankName";
            this.colrankcode.HeaderText = "Rank Name";
            this.colrankcode.Name = "colrankcode";
            this.colrankcode.ReadOnly = true;
            this.colrankcode.Width = 98;
            // 
            // colassetname
            // 
            this.colassetname.DataPropertyName = "AssetName";
            this.colassetname.HeaderText = "Asset Name";
            this.colassetname.Name = "colassetname";
            // 
            // colqty
            // 
            this.colqty.DataPropertyName = "Qty";
            this.colqty.HeaderText = "Qty";
            this.colqty.Name = "colqty";
            this.colqty.Width = 49;
            // 
            // colunit
            // 
            this.colunit.DataPropertyName = "Unit";
            this.colunit.HeaderText = "Unit";
            this.colunit.Name = "colunit";
            this.colunit.Width = 54;
            // 
            // colassetmodel
            // 
            this.colassetmodel.DataPropertyName = "AssetModel";
            this.colassetmodel.HeaderText = "Asset Model";
            this.colassetmodel.Name = "colassetmodel";
            this.colassetmodel.Width = 99;
            // 
            // colassetsupplier
            // 
            this.colassetsupplier.DataPropertyName = "AssetSupplier";
            this.colassetsupplier.HeaderText = "Asset Supplier";
            this.colassetsupplier.Name = "colassetsupplier";
            this.colassetsupplier.Width = 112;
            // 
            // coluserlocationname
            // 
            this.coluserlocationname.DataPropertyName = "UserLocationName";
            this.coluserlocationname.HeaderText = "User Location Name";
            this.coluserlocationname.Name = "coluserlocationname";
            this.coluserlocationname.Width = 146;
            // 
            // colregistrationdatetime
            // 
            this.colregistrationdatetime.DataPropertyName = "RegistrationDateTime";
            this.colregistrationdatetime.HeaderText = "Date Check";
            this.colregistrationdatetime.Name = "colregistrationdatetime";
            this.colregistrationdatetime.Width = 96;
            // 
            // colbeforelocation
            // 
            this.colbeforelocation.DataPropertyName = "BeforeLocation";
            this.colbeforelocation.HeaderText = "Before Location";
            this.colbeforelocation.Name = "colbeforelocation";
            this.colbeforelocation.Width = 118;
            // 
            // colafterlocation
            // 
            this.colafterlocation.DataPropertyName = "AfterLocation";
            this.colafterlocation.HeaderText = "After Location";
            this.colafterlocation.Name = "colafterlocation";
            this.colafterlocation.Width = 106;
            // 
            // colcomments
            // 
            this.colcomments.DataPropertyName = "Comments";
            this.colcomments.HeaderText = "Remark";
            this.colcomments.Name = "colcomments";
            this.colcomments.Width = 76;
            // 
            // setting_gbc
            // 
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.linksave_txt);
            this.setting_gbc.Controls.Add(this.update_btn);
            this.setting_gbc.Controls.Add(this.add_btn);
            this.setting_gbc.Controls.Add(this.exportexcel_btn);
            this.setting_gbc.Controls.Add(this.browser_btn);
            this.setting_gbc.Controls.Add(this.clear_btn);
            this.setting_gbc.Controls.Add(this.search_btn);
            this.setting_gbc.Font = new System.Drawing.Font("Arial", 9F);
            this.setting_gbc.Location = new System.Drawing.Point(25, 182);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.Size = new System.Drawing.Size(848, 64);
            this.setting_gbc.TabIndex = 46;
            this.setting_gbc.TabStop = false;
            // 
            // linksave_txt
            // 
            this.linksave_txt.ControlId = null;
            this.linksave_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksave_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.linksave_txt.Location = new System.Drawing.Point(499, 26);
            this.linksave_txt.Name = "linksave_txt";
            this.linksave_txt.Size = new System.Drawing.Size(212, 21);
            this.linksave_txt.TabIndex = 55;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.update_btn.ControlId = "";
            this.update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_btn.Location = new System.Drawing.Point(187, 20);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(80, 33);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_btn.ControlId = "";
            this.add_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_btn.Location = new System.Drawing.Point(101, 20);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(80, 33);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // exportexcel_btn
            // 
            this.exportexcel_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exportexcel_btn.ControlId = null;
            this.exportexcel_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.exportexcel_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exportexcel_btn.Location = new System.Drawing.Point(730, 20);
            this.exportexcel_btn.Name = "exportexcel_btn";
            this.exportexcel_btn.Size = new System.Drawing.Size(91, 33);
            this.exportexcel_btn.TabIndex = 10;
            this.exportexcel_btn.Text = "Export Excel";
            this.exportexcel_btn.UseVisualStyleBackColor = false;
            this.exportexcel_btn.Click += new System.EventHandler(this.exportexcel_btn_Click);
            // 
            // browser_btn
            // 
            this.browser_btn.BackColor = System.Drawing.SystemColors.Control;
            this.browser_btn.ControlId = null;
            this.browser_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.browser_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.browser_btn.Location = new System.Drawing.Point(399, 20);
            this.browser_btn.Name = "browser_btn";
            this.browser_btn.Size = new System.Drawing.Size(80, 33);
            this.browser_btn.TabIndex = 10;
            this.browser_btn.Text = "Browser:";
            this.browser_btn.UseVisualStyleBackColor = false;
            this.browser_btn.Click += new System.EventHandler(this.browser_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_btn.ControlId = null;
            this.clear_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.clear_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clear_btn.Location = new System.Drawing.Point(273, 20);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(80, 33);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.search_btn.ControlId = null;
            this.search_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.search_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.search_btn.Location = new System.Drawing.Point(15, 20);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(80, 33);
            this.search_btn.TabIndex = 10;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // asset_name_cbm
            // 
            this.asset_name_cbm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.asset_name_cbm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.asset_name_cbm.FormattingEnabled = true;
            this.asset_name_cbm.Location = new System.Drawing.Point(863, 154);
            this.asset_name_cbm.Name = "asset_name_cbm";
            this.asset_name_cbm.Size = new System.Drawing.Size(152, 21);
            this.asset_name_cbm.TabIndex = 47;
            // 
            // asset_name_lbl
            // 
            this.asset_name_lbl.AutoSize = true;
            this.asset_name_lbl.ControlId = null;
            this.asset_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.asset_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asset_name_lbl.Location = new System.Drawing.Point(781, 156);
            this.asset_name_lbl.Name = "asset_name_lbl";
            this.asset_name_lbl.Size = new System.Drawing.Size(78, 15);
            this.asset_name_lbl.TabIndex = 48;
            this.asset_name_lbl.Text = "Asset Name:";
            // 
            // asset_model_cbm
            // 
            this.asset_model_cbm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.asset_model_cbm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.asset_model_cbm.FormattingEnabled = true;
            this.asset_model_cbm.Location = new System.Drawing.Point(603, 157);
            this.asset_model_cbm.Name = "asset_model_cbm";
            this.asset_model_cbm.Size = new System.Drawing.Size(152, 21);
            this.asset_model_cbm.TabIndex = 47;
            // 
            // asset_model_lbl
            // 
            this.asset_model_lbl.AutoSize = true;
            this.asset_model_lbl.ControlId = null;
            this.asset_model_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.asset_model_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asset_model_lbl.Location = new System.Drawing.Point(521, 163);
            this.asset_model_lbl.Name = "asset_model_lbl";
            this.asset_model_lbl.Size = new System.Drawing.Size(77, 15);
            this.asset_model_lbl.TabIndex = 48;
            this.asset_model_lbl.Text = "Asset Model:";
            // 
            // rank_code_cbm
            // 
            this.rank_code_cbm.FormattingEnabled = true;
            this.rank_code_cbm.Location = new System.Drawing.Point(352, 113);
            this.rank_code_cbm.Name = "rank_code_cbm";
            this.rank_code_cbm.Size = new System.Drawing.Size(152, 21);
            this.rank_code_cbm.TabIndex = 47;
            // 
            // rank_code_lbl
            // 
            this.rank_code_lbl.AutoSize = true;
            this.rank_code_lbl.ControlId = null;
            this.rank_code_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.rank_code_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rank_code_lbl.Location = new System.Drawing.Point(270, 118);
            this.rank_code_lbl.Name = "rank_code_lbl";
            this.rank_code_lbl.Size = new System.Drawing.Size(72, 15);
            this.rank_code_lbl.TabIndex = 48;
            this.rank_code_lbl.Text = "Rank Code:";
            // 
            // asset_type_cbm
            // 
            this.asset_type_cbm.FormattingEnabled = true;
            this.asset_type_cbm.Location = new System.Drawing.Point(352, 155);
            this.asset_type_cbm.Name = "asset_type_cbm";
            this.asset_type_cbm.Size = new System.Drawing.Size(152, 21);
            this.asset_type_cbm.TabIndex = 47;
            // 
            // asset_type_lbl
            // 
            this.asset_type_lbl.AutoSize = true;
            this.asset_type_lbl.ControlId = null;
            this.asset_type_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.asset_type_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asset_type_lbl.Location = new System.Drawing.Point(276, 157);
            this.asset_type_lbl.Name = "asset_type_lbl";
            this.asset_type_lbl.Size = new System.Drawing.Size(66, 15);
            this.asset_type_lbl.TabIndex = 48;
            this.asset_type_lbl.Text = "Asset Type";
            // 
            // full_asset_code_lbl
            // 
            this.full_asset_code_lbl.AutoSize = true;
            this.full_asset_code_lbl.ControlId = null;
            this.full_asset_code_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.full_asset_code_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.full_asset_code_lbl.Location = new System.Drawing.Point(7, 119);
            this.full_asset_code_lbl.Name = "full_asset_code_lbl";
            this.full_asset_code_lbl.Size = new System.Drawing.Size(93, 15);
            this.full_asset_code_lbl.TabIndex = 6;
            this.full_asset_code_lbl.Text = "Full Asset Code";
            // 
            // full_asset_Code_txt
            // 
            this.full_asset_Code_txt.ControlId = null;
            this.full_asset_Code_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.full_asset_Code_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.full_asset_Code_txt.Location = new System.Drawing.Point(102, 115);
            this.full_asset_Code_txt.Name = "full_asset_Code_txt";
            this.full_asset_Code_txt.Size = new System.Drawing.Size(152, 21);
            this.full_asset_Code_txt.TabIndex = 54;
            this.full_asset_Code_txt.TextChanged += new System.EventHandler(this.full_asset_Code_txt_TextChanged);
            // 
            // asset_Code_txt
            // 
            this.asset_Code_txt.ControlId = null;
            this.asset_Code_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asset_Code_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.asset_Code_txt.Location = new System.Drawing.Point(102, 154);
            this.asset_Code_txt.Name = "asset_Code_txt";
            this.asset_Code_txt.Size = new System.Drawing.Size(152, 21);
            this.asset_Code_txt.TabIndex = 54;
            // 
            // select_search_cbm
            // 
            this.select_search_cbm.FormattingEnabled = true;
            this.select_search_cbm.Location = new System.Drawing.Point(1122, 112);
            this.select_search_cbm.Name = "select_search_cbm";
            this.select_search_cbm.Size = new System.Drawing.Size(152, 21);
            this.select_search_cbm.TabIndex = 47;
            // 
            // select_search_lbl
            // 
            this.select_search_lbl.AutoSize = true;
            this.select_search_lbl.ControlId = null;
            this.select_search_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.select_search_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select_search_lbl.Location = new System.Drawing.Point(1035, 115);
            this.select_search_lbl.Name = "select_search_lbl";
            this.select_search_lbl.Size = new System.Drawing.Size(87, 15);
            this.select_search_lbl.TabIndex = 48;
            this.select_search_lbl.Text = "Status Search:";
            // 
            // Invoice_lbl
            // 
            this.Invoice_lbl.AutoSize = true;
            this.Invoice_lbl.ControlId = null;
            this.Invoice_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.Invoice_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Invoice_lbl.Location = new System.Drawing.Point(526, 119);
            this.Invoice_lbl.Name = "Invoice_lbl";
            this.Invoice_lbl.Size = new System.Drawing.Size(67, 15);
            this.Invoice_lbl.TabIndex = 57;
            this.Invoice_lbl.Text = "Invoice No:";
            // 
            // invoice_cbm
            // 
            this.invoice_cbm.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.invoice_cbm.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.invoice_cbm.FormattingEnabled = true;
            this.invoice_cbm.Location = new System.Drawing.Point(603, 113);
            this.invoice_cbm.Name = "invoice_cbm";
            this.invoice_cbm.Size = new System.Drawing.Size(152, 21);
            this.invoice_cbm.TabIndex = 56;
            // 
            // select_after_location_cbm
            // 
            this.select_after_location_cbm.FormattingEnabled = true;
            this.select_after_location_cbm.Location = new System.Drawing.Point(860, 113);
            this.select_after_location_cbm.Name = "select_after_location_cbm";
            this.select_after_location_cbm.Size = new System.Drawing.Size(152, 21);
            this.select_after_location_cbm.TabIndex = 47;
            // 
            // select_location_lbl
            // 
            this.select_location_lbl.AutoSize = true;
            this.select_location_lbl.ControlId = null;
            this.select_location_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.select_location_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.select_location_lbl.Location = new System.Drawing.Point(773, 116);
            this.select_location_lbl.Name = "select_location_lbl";
            this.select_location_lbl.Size = new System.Drawing.Size(85, 15);
            this.select_location_lbl.TabIndex = 48;
            this.select_location_lbl.Text = "Now Location:";
            // 
            // WareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1276, 699);
            this.Controls.Add(this.Invoice_lbl);
            this.Controls.Add(this.invoice_cbm);
            this.Controls.Add(this.asset_Code_txt);
            this.Controls.Add(this.full_asset_Code_txt);
            this.Controls.Add(this.select_location_lbl);
            this.Controls.Add(this.select_search_lbl);
            this.Controls.Add(this.asset_model_lbl);
            this.Controls.Add(this.rank_code_lbl);
            this.Controls.Add(this.asset_type_lbl);
            this.Controls.Add(this.asset_name_lbl);
            this.Controls.Add(this.asset_type_cbm);
            this.Controls.Add(this.asset_name_cbm);
            this.Controls.Add(this.select_after_location_cbm);
            this.Controls.Add(this.select_search_cbm);
            this.Controls.Add(this.asset_model_cbm);
            this.Controls.Add(this.rank_code_cbm);
            this.Controls.Add(this.setting_gbc);
            this.Controls.Add(this.ware_house_dgv);
            this.Controls.Add(this.full_asset_code_lbl);
            this.Controls.Add(this.asset_code_lbl);
            this.Name = "WareHouseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Warehouse";
            this.TitleText = "Warehouse";
            this.Load += new System.EventHandler(this.WareHouseForm_Load);
            this.Controls.SetChildIndex(this.asset_code_lbl, 0);
            this.Controls.SetChildIndex(this.full_asset_code_lbl, 0);
            this.Controls.SetChildIndex(this.ware_house_dgv, 0);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.rank_code_cbm, 0);
            this.Controls.SetChildIndex(this.asset_model_cbm, 0);
            this.Controls.SetChildIndex(this.select_search_cbm, 0);
            this.Controls.SetChildIndex(this.select_after_location_cbm, 0);
            this.Controls.SetChildIndex(this.asset_name_cbm, 0);
            this.Controls.SetChildIndex(this.asset_type_cbm, 0);
            this.Controls.SetChildIndex(this.asset_name_lbl, 0);
            this.Controls.SetChildIndex(this.asset_type_lbl, 0);
            this.Controls.SetChildIndex(this.rank_code_lbl, 0);
            this.Controls.SetChildIndex(this.asset_model_lbl, 0);
            this.Controls.SetChildIndex(this.select_search_lbl, 0);
            this.Controls.SetChildIndex(this.select_location_lbl, 0);
            this.Controls.SetChildIndex(this.full_asset_Code_txt, 0);
            this.Controls.SetChildIndex(this.asset_Code_txt, 0);
            this.Controls.SetChildIndex(this.invoice_cbm, 0);
            this.Controls.SetChildIndex(this.Invoice_lbl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ware_house_dgv)).EndInit();
            this.setting_gbc.ResumeLayout(false);
            this.setting_gbc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.LabelCommon asset_code_lbl;
        private Framework.DataGridViewCommon ware_house_dgv;
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon update_btn;
        private Framework.ButtonCommon add_btn;
        private Framework.ButtonCommon clear_btn;
        private Framework.ButtonCommon search_btn;
        private System.Windows.Forms.ComboBox asset_name_cbm;
        private Framework.LabelCommon asset_name_lbl;
        private System.Windows.Forms.ComboBox asset_model_cbm;
        private Framework.LabelCommon asset_model_lbl;
        private System.Windows.Forms.ComboBox rank_code_cbm;
        private Framework.LabelCommon rank_code_lbl;
        private System.Windows.Forms.ComboBox asset_type_cbm;
        private Framework.LabelCommon asset_type_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_warehouseid;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltimestart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colassetcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colrankcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colassetname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colassetmodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colassetsupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn coluserlocationname;
        private System.Windows.Forms.DataGridViewTextBoxColumn colregistrationdatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colbeforelocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colafterlocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcomments;
        private Framework.LabelCommon full_asset_code_lbl;
        private Framework.TextBoxCommon full_asset_Code_txt;
        private Framework.TextBoxCommon asset_Code_txt;
        private System.Windows.Forms.ComboBox select_search_cbm;
        private Framework.LabelCommon select_search_lbl;
        private Framework.LabelCommon Invoice_lbl;
        private System.Windows.Forms.ComboBox invoice_cbm;
        private System.Windows.Forms.ComboBox select_after_location_cbm;
        private Framework.LabelCommon select_location_lbl;
        private Framework.TextBoxCommon linksave_txt;
        private Framework.ButtonCommon exportexcel_btn;
        private Framework.ButtonCommon browser_btn;
    }
}
