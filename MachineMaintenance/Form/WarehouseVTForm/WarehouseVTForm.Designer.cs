namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class WarehouseVTForm
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
            this.setting_gbc = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.clear_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.linksave_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.exportexcel_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.browser_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.rfid_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.warehouse_vt_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.col_machineid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_rfid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinecode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_usercode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineqty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineserial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinemodel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinelocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinesupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfactorycd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machineinvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machinecostvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCheckTime_final = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxCommon2 = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.exportcsv_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.rfid_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.mac_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machine_serial_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.serial_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_supplier_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.supplier_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.location_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.location_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machine_status_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_status_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.setting_gbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_vt_dgv)).BeginInit();
            this.groupBoxCommon2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setting_gbc
            // 
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.update_btn);
            this.setting_gbc.Controls.Add(this.add_btn);
            this.setting_gbc.Controls.Add(this.clear_btn);
            this.setting_gbc.Controls.Add(this.search_btn);
            this.setting_gbc.Font = new System.Drawing.Font("Arial", 9F);
            this.setting_gbc.Location = new System.Drawing.Point(12, 199);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.Size = new System.Drawing.Size(513, 64);
            this.setting_gbc.TabIndex = 60;
            this.setting_gbc.TabStop = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.update_btn.ControlId = "";
            this.update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_btn.Location = new System.Drawing.Point(126, 20);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(101, 33);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Add RFID/Edit";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_btn.ControlId = "";
            this.add_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_btn.Location = new System.Drawing.Point(266, 20);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(97, 33);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "New Machine";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_btn.ControlId = null;
            this.clear_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.clear_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clear_btn.Location = new System.Drawing.Point(393, 19);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(103, 33);
            this.clear_btn.TabIndex = 10;
            this.clear_btn.Text = "Delete Machine";
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
            // linksave_txt
            // 
            this.linksave_txt.ControlId = null;
            this.linksave_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linksave_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.linksave_txt.Location = new System.Drawing.Point(100, 25);
            this.linksave_txt.Name = "linksave_txt";
            this.linksave_txt.Size = new System.Drawing.Size(202, 21);
            this.linksave_txt.TabIndex = 55;
            // 
            // exportexcel_btn
            // 
            this.exportexcel_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exportexcel_btn.ControlId = null;
            this.exportexcel_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.exportexcel_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exportexcel_btn.Location = new System.Drawing.Point(307, 19);
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
            this.browser_btn.Location = new System.Drawing.Point(16, 19);
            this.browser_btn.Name = "browser_btn";
            this.browser_btn.Size = new System.Drawing.Size(80, 33);
            this.browser_btn.TabIndex = 10;
            this.browser_btn.Text = "Browser:";
            this.browser_btn.UseVisualStyleBackColor = false;
            this.browser_btn.Click += new System.EventHandler(this.browser_btn_Click);
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.ControlId = null;
            this.rfid_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.rfid_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rfid_lbl.Location = new System.Drawing.Point(15, 149);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(93, 15);
            this.rfid_lbl.TabIndex = 58;
            this.rfid_lbl.Text = "RFID Numbers:";
            // 
            // warehouse_vt_dgv
            // 
            this.warehouse_vt_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.warehouse_vt_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.warehouse_vt_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.warehouse_vt_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.warehouse_vt_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_machineid,
            this.col_rfid,
            this.col_machinecode,
            this.col_machinename,
            this.col_usercode,
            this.col_datetime,
            this.col_machineqty,
            this.col_machineserial,
            this.col_machinemodel,
            this.col_machinelocation,
            this.col_machinesupplier,
            this.col_machinestatus,
            this.colfactorycd,
            this.col_machineinvoice,
            this.col_machinecostvalue,
            this.colCheckTime_final});
            this.warehouse_vt_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.warehouse_vt_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.warehouse_vt_dgv.Location = new System.Drawing.Point(4, 269);
            this.warehouse_vt_dgv.Name = "warehouse_vt_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.warehouse_vt_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.warehouse_vt_dgv.Size = new System.Drawing.Size(1175, 426);
            this.warehouse_vt_dgv.TabIndex = 75;
            // 
            // col_machineid
            // 
            this.col_machineid.DataPropertyName = "MachineId";
            this.col_machineid.HeaderText = "Machine ID";
            this.col_machineid.Name = "col_machineid";
            this.col_machineid.Visible = false;
            this.col_machineid.Width = 93;
            // 
            // col_rfid
            // 
            this.col_rfid.DataPropertyName = "RFId";
            this.col_rfid.HeaderText = "RFID ";
            this.col_rfid.Name = "col_rfid";
            this.col_rfid.Width = 63;
            // 
            // col_machinecode
            // 
            this.col_machinecode.DataPropertyName = "MachineCode";
            this.col_machinecode.HeaderText = "Machine Code";
            this.col_machinecode.Name = "col_machinecode";
            this.col_machinecode.Width = 111;
            // 
            // col_machinename
            // 
            this.col_machinename.DataPropertyName = "MachineName";
            this.col_machinename.HeaderText = "Machine Name";
            this.col_machinename.Name = "col_machinename";
            this.col_machinename.Width = 115;
            // 
            // col_usercode
            // 
            this.col_usercode.DataPropertyName = "RegistrationUserCode";
            this.col_usercode.HeaderText = "User Add";
            this.col_usercode.Name = "col_usercode";
            this.col_usercode.Width = 82;
            // 
            // col_datetime
            // 
            this.col_datetime.DataPropertyName = "RegistrationDateTime";
            this.col_datetime.HeaderText = "Date Time Add";
            this.col_datetime.Name = "col_datetime";
            this.col_datetime.Width = 112;
            // 
            // col_machineqty
            // 
            this.col_machineqty.DataPropertyName = "MachineQty";
            this.col_machineqty.HeaderText = "Machine Qty";
            this.col_machineqty.Name = "col_machineqty";
            this.col_machineqty.Width = 98;
            // 
            // col_machineserial
            // 
            this.col_machineserial.DataPropertyName = "MachineSerial";
            this.col_machineserial.HeaderText = "Machine Serial";
            this.col_machineserial.Name = "col_machineserial";
            this.col_machineserial.Width = 113;
            // 
            // col_machinemodel
            // 
            this.col_machinemodel.DataPropertyName = "MachineModel";
            this.col_machinemodel.HeaderText = "Machine Model";
            this.col_machinemodel.Name = "col_machinemodel";
            this.col_machinemodel.Width = 114;
            // 
            // col_machinelocation
            // 
            this.col_machinelocation.DataPropertyName = "MachineLocation";
            this.col_machinelocation.HeaderText = "Location";
            this.col_machinelocation.Name = "col_machinelocation";
            this.col_machinelocation.Width = 79;
            // 
            // col_machinesupplier
            // 
            this.col_machinesupplier.DataPropertyName = "MachineSupplier";
            this.col_machinesupplier.HeaderText = "Machine Supplier";
            this.col_machinesupplier.Name = "col_machinesupplier";
            this.col_machinesupplier.Width = 127;
            // 
            // col_machinestatus
            // 
            this.col_machinestatus.DataPropertyName = "MachineStatus";
            this.col_machinestatus.HeaderText = "Status";
            this.col_machinestatus.Name = "col_machinestatus";
            this.col_machinestatus.Width = 67;
            // 
            // colfactorycd
            // 
            this.colfactorycd.DataPropertyName = "FactoryCode";
            this.colfactorycd.HeaderText = "Factory";
            this.colfactorycd.Name = "colfactorycd";
            this.colfactorycd.Width = 71;
            // 
            // col_machineinvoice
            // 
            this.col_machineinvoice.DataPropertyName = "MachineInvoice";
            this.col_machineinvoice.HeaderText = "Machine Invoice";
            this.col_machineinvoice.Name = "col_machineinvoice";
            this.col_machineinvoice.Width = 119;
            // 
            // col_machinecostvalue
            // 
            this.col_machinecostvalue.DataPropertyName = "MachineCostValue";
            this.col_machinecostvalue.HeaderText = "Cost";
            this.col_machinecostvalue.Name = "col_machinecostvalue";
            this.col_machinecostvalue.Width = 58;
            // 
            // colCheckTime_final
            // 
            this.colCheckTime_final.DataPropertyName = "TimeCheck";
            this.colCheckTime_final.HeaderText = "Check Time";
            this.colCheckTime_final.Name = "colCheckTime_final";
            this.colCheckTime_final.Width = 98;
            // 
            // groupBoxCommon2
            // 
            this.groupBoxCommon2.ControlId = null;
            this.groupBoxCommon2.Controls.Add(this.exportcsv_btn);
            this.groupBoxCommon2.Controls.Add(this.linksave_txt);
            this.groupBoxCommon2.Controls.Add(this.browser_btn);
            this.groupBoxCommon2.Controls.Add(this.exportexcel_btn);
            this.groupBoxCommon2.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBoxCommon2.Location = new System.Drawing.Point(548, 199);
            this.groupBoxCommon2.Name = "groupBoxCommon2";
            this.groupBoxCommon2.Size = new System.Drawing.Size(532, 64);
            this.groupBoxCommon2.TabIndex = 76;
            this.groupBoxCommon2.TabStop = false;
            // 
            // exportcsv_btn
            // 
            this.exportcsv_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exportcsv_btn.ControlId = null;
            this.exportcsv_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.exportcsv_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exportcsv_btn.Location = new System.Drawing.Point(435, 19);
            this.exportcsv_btn.Name = "exportcsv_btn";
            this.exportcsv_btn.Size = new System.Drawing.Size(91, 33);
            this.exportcsv_btn.TabIndex = 56;
            this.exportcsv_btn.Text = "Export .csv";
            this.exportcsv_btn.UseVisualStyleBackColor = false;
            this.exportcsv_btn.Click += new System.EventHandler(this.exportcsv_btn_Click);
            // 
            // rfid_txt
            // 
            this.rfid_txt.ControlId = null;
            this.rfid_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.rfid_txt.Location = new System.Drawing.Point(12, 167);
            this.rfid_txt.MaxLength = 10;
            this.rfid_txt.Name = "rfid_txt";
            this.rfid_txt.Size = new System.Drawing.Size(121, 21);
            this.rfid_txt.TabIndex = 72;
            // 
            // mac_cmb
            // 
            this.mac_cmb.ControlId = null;
            this.mac_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mac_cmb.FormattingEnabled = true;
            this.mac_cmb.Location = new System.Drawing.Point(1018, 149);
            this.mac_cmb.Name = "mac_cmb";
            this.mac_cmb.Size = new System.Drawing.Size(152, 23);
            this.mac_cmb.TabIndex = 79;
            this.mac_cmb.Visible = false;
            // 
            // machine_serial_cmb
            // 
            this.machine_serial_cmb.ControlId = null;
            this.machine_serial_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_serial_cmb.FormattingEnabled = true;
            this.machine_serial_cmb.Location = new System.Drawing.Point(312, 165);
            this.machine_serial_cmb.Name = "machine_serial_cmb";
            this.machine_serial_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_serial_cmb.TabIndex = 80;
            // 
            // serial_lbl
            // 
            this.serial_lbl.AutoSize = true;
            this.serial_lbl.ControlId = null;
            this.serial_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.serial_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serial_lbl.Location = new System.Drawing.Point(309, 147);
            this.serial_lbl.Name = "serial_lbl";
            this.serial_lbl.Size = new System.Drawing.Size(42, 15);
            this.serial_lbl.TabIndex = 81;
            this.serial_lbl.Text = "Serial:";
            // 
            // machine_model_cmb
            // 
            this.machine_model_cmb.ControlId = null;
            this.machine_model_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_model_cmb.FormattingEnabled = true;
            this.machine_model_cmb.Location = new System.Drawing.Point(157, 165);
            this.machine_model_cmb.Name = "machine_model_cmb";
            this.machine_model_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_model_cmb.TabIndex = 80;
            this.machine_model_cmb.TextChanged += new System.EventHandler(this.machine_model_cmb_TextChanged);
            this.machine_model_cmb.Click += new System.EventHandler(this.machine_model_cmb_Click);
            // 
            // model_lbl
            // 
            this.model_lbl.AutoSize = true;
            this.model_lbl.ControlId = null;
            this.model_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.model_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.model_lbl.Location = new System.Drawing.Point(154, 147);
            this.model_lbl.Name = "model_lbl";
            this.model_lbl.Size = new System.Drawing.Size(43, 15);
            this.model_lbl.TabIndex = 81;
            this.model_lbl.Text = "Model:";
            // 
            // machine_supplier_cmb
            // 
            this.machine_supplier_cmb.ControlId = null;
            this.machine_supplier_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_supplier_cmb.FormattingEnabled = true;
            this.machine_supplier_cmb.Location = new System.Drawing.Point(461, 167);
            this.machine_supplier_cmb.Name = "machine_supplier_cmb";
            this.machine_supplier_cmb.Size = new System.Drawing.Size(147, 23);
            this.machine_supplier_cmb.TabIndex = 80;
            // 
            // supplier_lbl
            // 
            this.supplier_lbl.AutoSize = true;
            this.supplier_lbl.ControlId = null;
            this.supplier_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.supplier_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.supplier_lbl.Location = new System.Drawing.Point(458, 149);
            this.supplier_lbl.Name = "supplier_lbl";
            this.supplier_lbl.Size = new System.Drawing.Size(56, 15);
            this.supplier_lbl.TabIndex = 81;
            this.supplier_lbl.Text = "Suppiler:";
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.ControlId = null;
            this.location_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.location_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.location_lbl.Location = new System.Drawing.Point(640, 147);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(57, 15);
            this.location_lbl.TabIndex = 83;
            this.location_lbl.Text = "Location:";
            // 
            // location_cmb
            // 
            this.location_cmb.ControlId = null;
            this.location_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_cmb.FormattingEnabled = true;
            this.location_cmb.Location = new System.Drawing.Point(643, 165);
            this.location_cmb.Name = "location_cmb";
            this.location_cmb.Size = new System.Drawing.Size(121, 23);
            this.location_cmb.TabIndex = 82;
            // 
            // machine_status_lbl
            // 
            this.machine_status_lbl.AutoSize = true;
            this.machine_status_lbl.ControlId = null;
            this.machine_status_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_status_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_status_lbl.Location = new System.Drawing.Point(785, 147);
            this.machine_status_lbl.Name = "machine_status_lbl";
            this.machine_status_lbl.Size = new System.Drawing.Size(91, 15);
            this.machine_status_lbl.TabIndex = 85;
            this.machine_status_lbl.Text = "Machine Status";
            // 
            // machine_status_cmb
            // 
            this.machine_status_cmb.ControlId = null;
            this.machine_status_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_status_cmb.FormattingEnabled = true;
            this.machine_status_cmb.Location = new System.Drawing.Point(788, 165);
            this.machine_status_cmb.Name = "machine_status_cmb";
            this.machine_status_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_status_cmb.TabIndex = 84;
            // 
            // WarehouseVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1182, 699);
            this.Controls.Add(this.machine_status_lbl);
            this.Controls.Add(this.machine_status_cmb);
            this.Controls.Add(this.location_lbl);
            this.Controls.Add(this.location_cmb);
            this.Controls.Add(this.supplier_lbl);
            this.Controls.Add(this.model_lbl);
            this.Controls.Add(this.serial_lbl);
            this.Controls.Add(this.machine_supplier_cmb);
            this.Controls.Add(this.machine_model_cmb);
            this.Controls.Add(this.machine_serial_cmb);
            this.Controls.Add(this.mac_cmb);
            this.Controls.Add(this.groupBoxCommon2);
            this.Controls.Add(this.rfid_txt);
            this.Controls.Add(this.setting_gbc);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.warehouse_vt_dgv);
            this.Name = "WarehouseVTForm";
            this.Text = "WareHouse System";
            this.TitleText = "WareHouse System";
            this.Load += new System.EventHandler(this.WarehouseVTForm_Load);
            this.Controls.SetChildIndex(this.warehouse_vt_dgv, 0);
            this.Controls.SetChildIndex(this.rfid_lbl, 0);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.rfid_txt, 0);
            this.Controls.SetChildIndex(this.groupBoxCommon2, 0);
            this.Controls.SetChildIndex(this.mac_cmb, 0);
            this.Controls.SetChildIndex(this.machine_serial_cmb, 0);
            this.Controls.SetChildIndex(this.machine_model_cmb, 0);
            this.Controls.SetChildIndex(this.machine_supplier_cmb, 0);
            this.Controls.SetChildIndex(this.serial_lbl, 0);
            this.Controls.SetChildIndex(this.model_lbl, 0);
            this.Controls.SetChildIndex(this.supplier_lbl, 0);
            this.Controls.SetChildIndex(this.location_cmb, 0);
            this.Controls.SetChildIndex(this.location_lbl, 0);
            this.Controls.SetChildIndex(this.machine_status_cmb, 0);
            this.Controls.SetChildIndex(this.machine_status_lbl, 0);
            this.setting_gbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.warehouse_vt_dgv)).EndInit();
            this.groupBoxCommon2.ResumeLayout(false);
            this.groupBoxCommon2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.TextBoxCommon linksave_txt;
        private Framework.ButtonCommon update_btn;
        private Framework.ButtonCommon add_btn;
        private Framework.ButtonCommon exportexcel_btn;
        private Framework.ButtonCommon browser_btn;
        private Framework.ButtonCommon clear_btn;
        private Framework.ButtonCommon search_btn;
        private Framework.LabelCommon rfid_lbl;
        private Framework.DataGridViewCommon warehouse_vt_dgv;
        private Framework.GroupBoxCommon groupBoxCommon2;
        private Framework.TextBoxCommon rfid_txt;
        private Framework.ComboBoxCommon mac_cmb;
        private Framework.ComboBoxCommon machine_serial_cmb;
        private Framework.LabelCommon serial_lbl;
        private Framework.ComboBoxCommon machine_model_cmb;
        private Framework.LabelCommon model_lbl;
        private Framework.ComboBoxCommon machine_supplier_cmb;
        private Framework.LabelCommon supplier_lbl;
        private Framework.ButtonCommon exportcsv_btn;
        private Framework.LabelCommon location_lbl;
        private Framework.ComboBoxCommon location_cmb;
        private Framework.LabelCommon machine_status_lbl;
        private Framework.ComboBoxCommon machine_status_cmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_rfid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinecode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_usercode;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineqty;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineserial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinemodel;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinelocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinesupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfactorycd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machineinvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machinecostvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCheckTime_final;
    }
}
