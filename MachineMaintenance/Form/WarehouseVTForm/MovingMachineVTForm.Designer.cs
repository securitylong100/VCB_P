namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class MovingMachineVTForm
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
            this.delete_all_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.delete_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.exportexcel_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.rfid_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.vt_search_moving_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.groupBoxCommon2 = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.rfid_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.machine_serial_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machine_serial_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_received_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_received_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.factory_tranfer_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_tranfer_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.code_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.code_status_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.code_status_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.code_name_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.col_moving_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machine_serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machine_model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machine_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_factory_tranfer_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_factory_received_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_code_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_code_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_status_machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_comments_machine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_reason_tranfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_confirm_received = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_machine_costvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_registration_user_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_registration_date_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_factory_cd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.setting_gbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vt_search_moving_dgv)).BeginInit();
            this.groupBoxCommon2.SuspendLayout();
            this.SuspendLayout();
            // 
            // setting_gbc
            // 
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.delete_all_btn);
            this.setting_gbc.Controls.Add(this.add_btn);
            this.setting_gbc.Controls.Add(this.update_btn);
            this.setting_gbc.Controls.Add(this.delete_btn);
            this.setting_gbc.Controls.Add(this.search_btn);
            this.setting_gbc.Font = new System.Drawing.Font("Arial", 9F);
            this.setting_gbc.Location = new System.Drawing.Point(12, 199);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.Size = new System.Drawing.Size(539, 64);
            this.setting_gbc.TabIndex = 60;
            this.setting_gbc.TabStop = false;
            // 
            // delete_all_btn
            // 
            this.delete_all_btn.BackColor = System.Drawing.SystemColors.Control;
            this.delete_all_btn.ControlId = null;
            this.delete_all_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.delete_all_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.delete_all_btn.Location = new System.Drawing.Point(425, 20);
            this.delete_all_btn.Name = "delete_all_btn";
            this.delete_all_btn.Size = new System.Drawing.Size(90, 33);
            this.delete_all_btn.TabIndex = 12;
            this.delete_all_btn.Text = "Delete All";
            this.delete_all_btn.UseVisualStyleBackColor = false;
            this.delete_all_btn.Click += new System.EventHandler(this.delete_all_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_btn.ControlId = "";
            this.add_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.add_btn.Location = new System.Drawing.Point(114, 20);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(88, 33);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.update_btn.ControlId = "";
            this.update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.update_btn.Location = new System.Drawing.Point(220, 20);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(84, 33);
            this.update_btn.TabIndex = 11;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.SystemColors.Control;
            this.delete_btn.ControlId = null;
            this.delete_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.delete_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.delete_btn.Location = new System.Drawing.Point(320, 20);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(90, 33);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
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
            // exportexcel_btn
            // 
            this.exportexcel_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exportexcel_btn.ControlId = null;
            this.exportexcel_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.exportexcel_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exportexcel_btn.Location = new System.Drawing.Point(13, 20);
            this.exportexcel_btn.Name = "exportexcel_btn";
            this.exportexcel_btn.Size = new System.Drawing.Size(91, 33);
            this.exportexcel_btn.TabIndex = 10;
            this.exportexcel_btn.Text = "Export Excel";
            this.exportexcel_btn.UseVisualStyleBackColor = false;
            this.exportexcel_btn.Click += new System.EventHandler(this.exportexcel_btn_Click);
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
            // vt_search_moving_dgv
            // 
            this.vt_search_moving_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vt_search_moving_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.vt_search_moving_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vt_search_moving_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.vt_search_moving_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_moving_id,
            this.col_machine_serial,
            this.col_machine_model,
            this.col_machine_name,
            this.col_factory_tranfer_cd,
            this.col_factory_received_cd,
            this.col_code_status,
            this.col_code_name,
            this.col_status_machine,
            this.col_comments_machine,
            this.col_reason_tranfer,
            this.col_confirm_received,
            this.col_machine_costvalue,
            this.col_registration_user_cd,
            this.col_registration_date_time,
            this.col_factory_cd});
            this.vt_search_moving_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.vt_search_moving_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.vt_search_moving_dgv.Location = new System.Drawing.Point(4, 269);
            this.vt_search_moving_dgv.Name = "vt_search_moving_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vt_search_moving_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.vt_search_moving_dgv.Size = new System.Drawing.Size(1270, 426);
            this.vt_search_moving_dgv.TabIndex = 75;
            // 
            // groupBoxCommon2
            // 
            this.groupBoxCommon2.ControlId = null;
            this.groupBoxCommon2.Controls.Add(this.exportexcel_btn);
            this.groupBoxCommon2.Font = new System.Drawing.Font("Arial", 9F);
            this.groupBoxCommon2.Location = new System.Drawing.Point(589, 199);
            this.groupBoxCommon2.Name = "groupBoxCommon2";
            this.groupBoxCommon2.Size = new System.Drawing.Size(121, 64);
            this.groupBoxCommon2.TabIndex = 76;
            this.groupBoxCommon2.TabStop = false;
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
            this.rfid_txt.TextChanged += new System.EventHandler(this.rfid_txt_TextChanged);
            // 
            // machine_serial_cmb
            // 
            this.machine_serial_cmb.ControlId = null;
            this.machine_serial_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_serial_cmb.FormattingEnabled = true;
            this.machine_serial_cmb.Location = new System.Drawing.Point(152, 165);
            this.machine_serial_cmb.Name = "machine_serial_cmb";
            this.machine_serial_cmb.Size = new System.Drawing.Size(121, 23);
            this.machine_serial_cmb.TabIndex = 80;
            // 
            // machine_serial_lbl
            // 
            this.machine_serial_lbl.AutoSize = true;
            this.machine_serial_lbl.ControlId = null;
            this.machine_serial_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_serial_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_serial_lbl.Location = new System.Drawing.Point(149, 147);
            this.machine_serial_lbl.Name = "machine_serial_lbl";
            this.machine_serial_lbl.Size = new System.Drawing.Size(88, 15);
            this.machine_serial_lbl.TabIndex = 81;
            this.machine_serial_lbl.Text = "Machine Serial";
            // 
            // factory_received_lbl
            // 
            this.factory_received_lbl.AutoSize = true;
            this.factory_received_lbl.ControlId = null;
            this.factory_received_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.factory_received_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.factory_received_lbl.Location = new System.Drawing.Point(465, 147);
            this.factory_received_lbl.Name = "factory_received_lbl";
            this.factory_received_lbl.Size = new System.Drawing.Size(100, 15);
            this.factory_received_lbl.TabIndex = 85;
            this.factory_received_lbl.Text = "Factory Received";
            // 
            // factory_received_cmb
            // 
            this.factory_received_cmb.ControlId = null;
            this.factory_received_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factory_received_cmb.FormattingEnabled = true;
            this.factory_received_cmb.Location = new System.Drawing.Point(462, 165);
            this.factory_received_cmb.Name = "factory_received_cmb";
            this.factory_received_cmb.Size = new System.Drawing.Size(149, 23);
            this.factory_received_cmb.TabIndex = 84;
            // 
            // factory_tranfer_lbl
            // 
            this.factory_tranfer_lbl.AutoSize = true;
            this.factory_tranfer_lbl.ControlId = null;
            this.factory_tranfer_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.factory_tranfer_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.factory_tranfer_lbl.Location = new System.Drawing.Point(288, 147);
            this.factory_tranfer_lbl.Name = "factory_tranfer_lbl";
            this.factory_tranfer_lbl.Size = new System.Drawing.Size(88, 15);
            this.factory_tranfer_lbl.TabIndex = 87;
            this.factory_tranfer_lbl.Text = "Factory Tranfer";
            // 
            // factory_tranfer_cmb
            // 
            this.factory_tranfer_cmb.ControlId = null;
            this.factory_tranfer_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factory_tranfer_cmb.FormattingEnabled = true;
            this.factory_tranfer_cmb.Location = new System.Drawing.Point(291, 165);
            this.factory_tranfer_cmb.Name = "factory_tranfer_cmb";
            this.factory_tranfer_cmb.Size = new System.Drawing.Size(149, 23);
            this.factory_tranfer_cmb.TabIndex = 86;
            // 
            // code_name_lbl
            // 
            this.code_name_lbl.AutoSize = true;
            this.code_name_lbl.ControlId = null;
            this.code_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.code_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.code_name_lbl.Location = new System.Drawing.Point(778, 147);
            this.code_name_lbl.Name = "code_name_lbl";
            this.code_name_lbl.Size = new System.Drawing.Size(77, 15);
            this.code_name_lbl.TabIndex = 107;
            this.code_name_lbl.Text = "Code Name:";
            // 
            // code_status_lbl
            // 
            this.code_status_lbl.AutoSize = true;
            this.code_status_lbl.ControlId = null;
            this.code_status_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.code_status_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.code_status_lbl.Location = new System.Drawing.Point(635, 147);
            this.code_status_lbl.Name = "code_status_lbl";
            this.code_status_lbl.Size = new System.Drawing.Size(75, 15);
            this.code_status_lbl.TabIndex = 105;
            this.code_status_lbl.Text = "Code Status";
            // 
            // code_status_cmb
            // 
            this.code_status_cmb.ControlId = null;
            this.code_status_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_status_cmb.FormattingEnabled = true;
            this.code_status_cmb.Items.AddRange(new object[] {
            "Bàn Giao",
            "Mượn",
            "Trả",
            "Thuê"});
            this.code_status_cmb.Location = new System.Drawing.Point(634, 165);
            this.code_status_cmb.Name = "code_status_cmb";
            this.code_status_cmb.Size = new System.Drawing.Size(128, 23);
            this.code_status_cmb.TabIndex = 104;
            this.code_status_cmb.SelectedIndexChanged += new System.EventHandler(this.code_status_cmb_SelectedIndexChanged);
            // 
            // code_name_cmb
            // 
            this.code_name_cmb.ControlId = null;
            this.code_name_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_name_cmb.FormattingEnabled = true;
            this.code_name_cmb.Items.AddRange(new object[] {
            "Bàn Giao",
            "Mượn",
            "Trả",
            "Thuê"});
            this.code_name_cmb.Location = new System.Drawing.Point(781, 165);
            this.code_name_cmb.Name = "code_name_cmb";
            this.code_name_cmb.Size = new System.Drawing.Size(128, 23);
            this.code_name_cmb.TabIndex = 108;
            // 
            // col_moving_id
            // 
            this.col_moving_id.DataPropertyName = "MovingId";
            this.col_moving_id.HeaderText = "Moving ID";
            this.col_moving_id.Name = "col_moving_id";
            this.col_moving_id.Visible = false;
            this.col_moving_id.Width = 85;
            // 
            // col_machine_serial
            // 
            this.col_machine_serial.DataPropertyName = "MachineSerial";
            this.col_machine_serial.HeaderText = "Machine Serial";
            this.col_machine_serial.Name = "col_machine_serial";
            this.col_machine_serial.Width = 113;
            // 
            // col_machine_model
            // 
            this.col_machine_model.DataPropertyName = "MachineModel";
            this.col_machine_model.HeaderText = "Model";
            this.col_machine_model.Name = "col_machine_model";
            this.col_machine_model.Width = 65;
            // 
            // col_machine_name
            // 
            this.col_machine_name.DataPropertyName = "MachineName";
            this.col_machine_name.HeaderText = "Machine Name";
            this.col_machine_name.Name = "col_machine_name";
            this.col_machine_name.Width = 115;
            // 
            // col_factory_tranfer_cd
            // 
            this.col_factory_tranfer_cd.DataPropertyName = "TranferFactoryName";
            this.col_factory_tranfer_cd.HeaderText = "TranferFactoryCode";
            this.col_factory_tranfer_cd.Name = "col_factory_tranfer_cd";
            this.col_factory_tranfer_cd.Width = 140;
            // 
            // col_factory_received_cd
            // 
            this.col_factory_received_cd.DataPropertyName = "ReceivedFactoryName";
            this.col_factory_received_cd.HeaderText = "Received Factory";
            this.col_factory_received_cd.Name = "col_factory_received_cd";
            this.col_factory_received_cd.Width = 125;
            // 
            // col_code_status
            // 
            this.col_code_status.DataPropertyName = "CodeStatus";
            this.col_code_status.HeaderText = "Code Status";
            this.col_code_status.Name = "col_code_status";
            // 
            // col_code_name
            // 
            this.col_code_name.DataPropertyName = "CodeName";
            this.col_code_name.HeaderText = "Code Name";
            this.col_code_name.Name = "col_code_name";
            this.col_code_name.Width = 99;
            // 
            // col_status_machine
            // 
            this.col_status_machine.DataPropertyName = "Status";
            this.col_status_machine.HeaderText = "Status";
            this.col_status_machine.Name = "col_status_machine";
            this.col_status_machine.Width = 67;
            // 
            // col_comments_machine
            // 
            this.col_comments_machine.DataPropertyName = "CommentsMachine";
            this.col_comments_machine.HeaderText = "Comments";
            this.col_comments_machine.Name = "col_comments_machine";
            this.col_comments_machine.Width = 94;
            // 
            // col_reason_tranfer
            // 
            this.col_reason_tranfer.DataPropertyName = "ReasonTranfer";
            this.col_reason_tranfer.HeaderText = "Reason Tranfer";
            this.col_reason_tranfer.Name = "col_reason_tranfer";
            this.col_reason_tranfer.Width = 118;
            // 
            // col_confirm_received
            // 
            this.col_confirm_received.DataPropertyName = "ConfirmReceived";
            this.col_confirm_received.HeaderText = "Confirm Received";
            this.col_confirm_received.Name = "col_confirm_received";
            this.col_confirm_received.Width = 130;
            // 
            // col_machine_costvalue
            // 
            this.col_machine_costvalue.DataPropertyName = "MachineCostValue";
            this.col_machine_costvalue.HeaderText = "Cost Value";
            this.col_machine_costvalue.Name = "col_machine_costvalue";
            this.col_machine_costvalue.Width = 91;
            // 
            // col_registration_user_cd
            // 
            this.col_registration_user_cd.DataPropertyName = "RegistrationUserCode";
            this.col_registration_user_cd.HeaderText = "User Code";
            this.col_registration_user_cd.Name = "col_registration_user_cd";
            this.col_registration_user_cd.Width = 92;
            // 
            // col_registration_date_time
            // 
            this.col_registration_date_time.DataPropertyName = "RegistrationDateTime";
            this.col_registration_date_time.HeaderText = "Date Time";
            this.col_registration_date_time.Name = "col_registration_date_time";
            this.col_registration_date_time.Width = 89;
            // 
            // col_factory_cd
            // 
            this.col_factory_cd.DataPropertyName = "FactoryCode";
            this.col_factory_cd.HeaderText = "Factory Code";
            this.col_factory_cd.Name = "col_factory_cd";
            this.col_factory_cd.Width = 104;
            // 
            // MovingMachineVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1277, 699);
            this.Controls.Add(this.code_name_cmb);
            this.Controls.Add(this.code_name_lbl);
            this.Controls.Add(this.code_status_lbl);
            this.Controls.Add(this.code_status_cmb);
            this.Controls.Add(this.factory_tranfer_lbl);
            this.Controls.Add(this.factory_tranfer_cmb);
            this.Controls.Add(this.factory_received_lbl);
            this.Controls.Add(this.factory_received_cmb);
            this.Controls.Add(this.machine_serial_lbl);
            this.Controls.Add(this.machine_serial_cmb);
            this.Controls.Add(this.groupBoxCommon2);
            this.Controls.Add(this.rfid_txt);
            this.Controls.Add(this.setting_gbc);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.vt_search_moving_dgv);
            this.Name = "MovingMachineVTForm";
            this.Text = "Equipments Management";
            this.TitleText = "Equipments Management";
            this.Load += new System.EventHandler(this.MovingMachineVTForm_Load);
            this.Controls.SetChildIndex(this.vt_search_moving_dgv, 0);
            this.Controls.SetChildIndex(this.rfid_lbl, 0);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.rfid_txt, 0);
            this.Controls.SetChildIndex(this.groupBoxCommon2, 0);
            this.Controls.SetChildIndex(this.machine_serial_cmb, 0);
            this.Controls.SetChildIndex(this.machine_serial_lbl, 0);
            this.Controls.SetChildIndex(this.factory_received_cmb, 0);
            this.Controls.SetChildIndex(this.factory_received_lbl, 0);
            this.Controls.SetChildIndex(this.factory_tranfer_cmb, 0);
            this.Controls.SetChildIndex(this.factory_tranfer_lbl, 0);
            this.Controls.SetChildIndex(this.code_status_cmb, 0);
            this.Controls.SetChildIndex(this.code_status_lbl, 0);
            this.Controls.SetChildIndex(this.code_name_lbl, 0);
            this.Controls.SetChildIndex(this.code_name_cmb, 0);
            this.setting_gbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vt_search_moving_dgv)).EndInit();
            this.groupBoxCommon2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon update_btn;
        private Framework.ButtonCommon exportexcel_btn;
        private Framework.ButtonCommon delete_btn;
        private Framework.ButtonCommon search_btn;
        private Framework.LabelCommon rfid_lbl;
        private Framework.DataGridViewCommon vt_search_moving_dgv;
        private Framework.GroupBoxCommon groupBoxCommon2;
        private Framework.TextBoxCommon rfid_txt;
        private Framework.ComboBoxCommon machine_serial_cmb;
        private Framework.LabelCommon machine_serial_lbl;
        private Framework.ButtonCommon add_btn;
        private Framework.LabelCommon factory_received_lbl;
        private Framework.ComboBoxCommon factory_received_cmb;
        private Framework.LabelCommon factory_tranfer_lbl;
        private Framework.ComboBoxCommon factory_tranfer_cmb;
        private Framework.LabelCommon code_name_lbl;
        private Framework.LabelCommon code_status_lbl;
        private Framework.ComboBoxCommon code_status_cmb;
        private Framework.ComboBoxCommon code_name_cmb;
        private Framework.ButtonCommon delete_all_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_moving_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machine_serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machine_model;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machine_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_factory_tranfer_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_factory_received_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_code_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_code_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_status_machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_comments_machine;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_reason_tranfer;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_confirm_received;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_machine_costvalue;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_registration_user_cd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_registration_date_time;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_factory_cd;
    }
}
