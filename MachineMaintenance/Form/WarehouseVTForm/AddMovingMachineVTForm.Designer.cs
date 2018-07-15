namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddMovingMachineVTForm
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
            this.cancel_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Ok_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.machine_serial_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.serialmachine_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_received_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_received_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.factory_tranfer_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.factory_tranfer_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.rfid_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.rfid_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.code_name_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.code_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.code_status_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.code_status_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.dgv_maxcode = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.colBG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_machine_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.status_machine_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.comments_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.comments_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.reason_tranfer_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.reason_tranfer_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.confirm_received_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.confirm_received_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_name_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machine_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.cost_value_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.cost_value_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.setting_gbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maxcode)).BeginInit();
            this.SuspendLayout();
            // 
            // setting_gbc
            // 
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.cancel_btn);
            this.setting_gbc.Controls.Add(this.Ok_btn);
            this.setting_gbc.Font = new System.Drawing.Font("Arial", 9F);
            this.setting_gbc.Location = new System.Drawing.Point(281, 432);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.Size = new System.Drawing.Size(306, 77);
            this.setting_gbc.TabIndex = 60;
            this.setting_gbc.TabStop = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_btn.ControlId = "";
            this.cancel_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.cancel_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel_btn.Location = new System.Drawing.Point(178, 20);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(88, 43);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Ok_btn
            // 
            this.Ok_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Ok_btn.ControlId = null;
            this.Ok_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Ok_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ok_btn.Location = new System.Drawing.Point(25, 20);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(88, 43);
            this.Ok_btn.TabIndex = 10;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = false;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // machine_serial_cmb
            // 
            this.machine_serial_cmb.ControlId = null;
            this.machine_serial_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_serial_cmb.FormattingEnabled = true;
            this.machine_serial_cmb.Location = new System.Drawing.Point(19, 219);
            this.machine_serial_cmb.Name = "machine_serial_cmb";
            this.machine_serial_cmb.Size = new System.Drawing.Size(183, 23);
            this.machine_serial_cmb.TabIndex = 80;
            this.machine_serial_cmb.SelectedIndexChanged += new System.EventHandler(this.machine_serial_cmb_SelectedIndexChanged);
            this.machine_serial_cmb.TextChanged += new System.EventHandler(this.machine_serial_cmb_TextChanged);

            // 
            // serialmachine_lbl
            // 
            this.serialmachine_lbl.AutoSize = true;
            this.serialmachine_lbl.ControlId = null;
            this.serialmachine_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.serialmachine_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serialmachine_lbl.Location = new System.Drawing.Point(19, 201);
            this.serialmachine_lbl.Name = "serialmachine_lbl";
            this.serialmachine_lbl.Size = new System.Drawing.Size(88, 15);
            this.serialmachine_lbl.TabIndex = 81;
            this.serialmachine_lbl.Text = "Serial Machine";
            // 
            // factory_received_lbl
            // 
            this.factory_received_lbl.AutoSize = true;
            this.factory_received_lbl.ControlId = null;
            this.factory_received_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.factory_received_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.factory_received_lbl.Location = new System.Drawing.Point(226, 261);
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
            this.factory_received_cmb.Location = new System.Drawing.Point(228, 279);
            this.factory_received_cmb.Name = "factory_received_cmb";
            this.factory_received_cmb.Size = new System.Drawing.Size(183, 23);
            this.factory_received_cmb.TabIndex = 84;
            // 
            // factory_tranfer_lbl
            // 
            this.factory_tranfer_lbl.AutoSize = true;
            this.factory_tranfer_lbl.ControlId = null;
            this.factory_tranfer_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.factory_tranfer_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.factory_tranfer_lbl.Location = new System.Drawing.Point(19, 261);
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
            this.factory_tranfer_cmb.Location = new System.Drawing.Point(19, 279);
            this.factory_tranfer_cmb.Name = "factory_tranfer_cmb";
            this.factory_tranfer_cmb.Size = new System.Drawing.Size(183, 23);
            this.factory_tranfer_cmb.TabIndex = 86;
            // 
            // rfid_txt
            // 
            this.rfid_txt.ControlId = null;
            this.rfid_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.rfid_txt.Location = new System.Drawing.Point(19, 164);
            this.rfid_txt.Multiline = true;
            this.rfid_txt.Name = "rfid_txt";
            this.rfid_txt.Size = new System.Drawing.Size(183, 24);
            this.rfid_txt.TabIndex = 99;
            this.rfid_txt.TextChanged += new System.EventHandler(this.rfid_txt_TextChanged);
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.ControlId = null;
            this.rfid_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.rfid_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rfid_lbl.Location = new System.Drawing.Point(19, 148);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(83, 15);
            this.rfid_lbl.TabIndex = 101;
            this.rfid_lbl.Text = "RFID Number";
            // 
            // code_name_txt
            // 
            this.code_name_txt.ControlId = null;
            this.code_name_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_name_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.code_name_txt.Location = new System.Drawing.Point(757, 279);
            this.code_name_txt.Multiline = true;
            this.code_name_txt.Name = "code_name_txt";
            this.code_name_txt.Size = new System.Drawing.Size(141, 23);
            this.code_name_txt.TabIndex = 102;
            // 
            // code_name_lbl
            // 
            this.code_name_lbl.AutoSize = true;
            this.code_name_lbl.ControlId = null;
            this.code_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.code_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.code_name_lbl.Location = new System.Drawing.Point(787, 261);
            this.code_name_lbl.Name = "code_name_lbl";
            this.code_name_lbl.Size = new System.Drawing.Size(77, 15);
            this.code_name_lbl.TabIndex = 103;
            this.code_name_lbl.Text = "Code Name:";
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
            this.code_status_cmb.Location = new System.Drawing.Point(594, 279);
            this.code_status_cmb.Name = "code_status_cmb";
            this.code_status_cmb.Size = new System.Drawing.Size(141, 23);
            this.code_status_cmb.TabIndex = 84;
            this.code_status_cmb.SelectedIndexChanged += new System.EventHandler(this.code_status_cmb_SelectedIndexChanged);
            // 
            // code_status_lbl
            // 
            this.code_status_lbl.AutoSize = true;
            this.code_status_lbl.ControlId = null;
            this.code_status_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.code_status_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.code_status_lbl.Location = new System.Drawing.Point(596, 261);
            this.code_status_lbl.Name = "code_status_lbl";
            this.code_status_lbl.Size = new System.Drawing.Size(75, 15);
            this.code_status_lbl.TabIndex = 85;
            this.code_status_lbl.Text = "Code Status";
            // 
            // dgv_maxcode
            // 
            this.dgv_maxcode.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_maxcode.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_maxcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_maxcode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBG,
            this.colM,
            this.colT,
            this.colTH});
            this.dgv_maxcode.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_maxcode.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_maxcode.Location = new System.Drawing.Point(676, 148);
            this.dgv_maxcode.Name = "dgv_maxcode";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_maxcode.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_maxcode.Size = new System.Drawing.Size(222, 48);
            this.dgv_maxcode.TabIndex = 104;
            // 
            // colBG
            // 
            this.colBG.DataPropertyName = "BGCode";
            this.colBG.HeaderText = "BG";
            this.colBG.Name = "colBG";
            this.colBG.Width = 49;
            // 
            // colM
            // 
            this.colM.DataPropertyName = "MCode";
            this.colM.HeaderText = "M";
            this.colM.Name = "colM";
            this.colM.Width = 41;
            // 
            // colT
            // 
            this.colT.DataPropertyName = "TCode";
            this.colT.HeaderText = "T";
            this.colT.Name = "colT";
            this.colT.Width = 39;
            // 
            // colTH
            // 
            this.colTH.DataPropertyName = "THCode";
            this.colTH.HeaderText = "TH";
            this.colTH.Name = "colTH";
            this.colTH.Width = 48;
            // 
            // status_machine_cmb
            // 
            this.status_machine_cmb.ControlId = null;
            this.status_machine_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_machine_cmb.FormattingEnabled = true;
            this.status_machine_cmb.Items.AddRange(new object[] {
            "OK",
            "NG"});
            this.status_machine_cmb.Location = new System.Drawing.Point(433, 279);
            this.status_machine_cmb.Name = "status_machine_cmb";
            this.status_machine_cmb.Size = new System.Drawing.Size(141, 23);
            this.status_machine_cmb.TabIndex = 84;
            this.status_machine_cmb.SelectedIndexChanged += new System.EventHandler(this.code_status_cmb_SelectedIndexChanged);
            // 
            // status_machine_lbl
            // 
            this.status_machine_lbl.AutoSize = true;
            this.status_machine_lbl.ControlId = null;
            this.status_machine_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.status_machine_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.status_machine_lbl.Location = new System.Drawing.Point(434, 261);
            this.status_machine_lbl.Name = "status_machine_lbl";
            this.status_machine_lbl.Size = new System.Drawing.Size(91, 15);
            this.status_machine_lbl.TabIndex = 85;
            this.status_machine_lbl.Text = "Status Machine";
            // 
            // comments_lbl
            // 
            this.comments_lbl.AutoSize = true;
            this.comments_lbl.ControlId = null;
            this.comments_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.comments_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comments_lbl.Location = new System.Drawing.Point(20, 318);
            this.comments_lbl.Name = "comments_lbl";
            this.comments_lbl.Size = new System.Drawing.Size(69, 15);
            this.comments_lbl.TabIndex = 106;
            this.comments_lbl.Text = "Comments";
            // 
            // comments_txt
            // 
            this.comments_txt.ControlId = null;
            this.comments_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.comments_txt.Location = new System.Drawing.Point(19, 336);
            this.comments_txt.Multiline = true;
            this.comments_txt.Name = "comments_txt";
            this.comments_txt.Size = new System.Drawing.Size(270, 79);
            this.comments_txt.TabIndex = 105;
            // 
            // reason_tranfer_txt
            // 
            this.reason_tranfer_txt.ControlId = null;
            this.reason_tranfer_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reason_tranfer_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.reason_tranfer_txt.Location = new System.Drawing.Point(327, 336);
            this.reason_tranfer_txt.Multiline = true;
            this.reason_tranfer_txt.Name = "reason_tranfer_txt";
            this.reason_tranfer_txt.Size = new System.Drawing.Size(270, 79);
            this.reason_tranfer_txt.TabIndex = 105;
            // 
            // reason_tranfer_lbl
            // 
            this.reason_tranfer_lbl.AutoSize = true;
            this.reason_tranfer_lbl.ControlId = null;
            this.reason_tranfer_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.reason_tranfer_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.reason_tranfer_lbl.Location = new System.Drawing.Point(328, 318);
            this.reason_tranfer_lbl.Name = "reason_tranfer_lbl";
            this.reason_tranfer_lbl.Size = new System.Drawing.Size(89, 15);
            this.reason_tranfer_lbl.TabIndex = 106;
            this.reason_tranfer_lbl.Text = "Reason tranfer";
            // 
            // confirm_received_txt
            // 
            this.confirm_received_txt.ControlId = null;
            this.confirm_received_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_received_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.confirm_received_txt.Location = new System.Drawing.Point(628, 336);
            this.confirm_received_txt.Multiline = true;
            this.confirm_received_txt.Name = "confirm_received_txt";
            this.confirm_received_txt.Size = new System.Drawing.Size(270, 79);
            this.confirm_received_txt.TabIndex = 105;
            // 
            // confirm_received_lbl
            // 
            this.confirm_received_lbl.AutoSize = true;
            this.confirm_received_lbl.ControlId = null;
            this.confirm_received_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.confirm_received_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.confirm_received_lbl.Location = new System.Drawing.Point(629, 318);
            this.confirm_received_lbl.Name = "confirm_received_lbl";
            this.confirm_received_lbl.Size = new System.Drawing.Size(105, 15);
            this.confirm_received_lbl.TabIndex = 106;
            this.confirm_received_lbl.Text = "Confirm Received";
            // 
            // machine_name_cmb
            // 
            this.machine_name_cmb.ControlId = null;
            this.machine_name_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_name_cmb.FormattingEnabled = true;
            this.machine_name_cmb.Location = new System.Drawing.Point(228, 165);
            this.machine_name_cmb.Name = "machine_name_cmb";
            this.machine_name_cmb.Size = new System.Drawing.Size(404, 23);
            this.machine_name_cmb.TabIndex = 80;
            // 
            // machine_name_lbl
            // 
            this.machine_name_lbl.AutoSize = true;
            this.machine_name_lbl.ControlId = null;
            this.machine_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_name_lbl.Location = new System.Drawing.Point(225, 148);
            this.machine_name_lbl.Name = "machine_name_lbl";
            this.machine_name_lbl.Size = new System.Drawing.Size(90, 15);
            this.machine_name_lbl.TabIndex = 81;
            this.machine_name_lbl.Text = "Machine Name";
            // 
            // machine_model_lbl
            // 
            this.machine_model_lbl.AutoSize = true;
            this.machine_model_lbl.ControlId = null;
            this.machine_model_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_model_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_model_lbl.Location = new System.Drawing.Point(225, 201);
            this.machine_model_lbl.Name = "machine_model_lbl";
            this.machine_model_lbl.Size = new System.Drawing.Size(89, 15);
            this.machine_model_lbl.TabIndex = 108;
            this.machine_model_lbl.Text = "Machine Model";
            // 
            // machine_model_cmb
            // 
            this.machine_model_cmb.ControlId = null;
            this.machine_model_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_model_cmb.FormattingEnabled = true;
            this.machine_model_cmb.Location = new System.Drawing.Point(228, 219);
            this.machine_model_cmb.Name = "machine_model_cmb";
            this.machine_model_cmb.Size = new System.Drawing.Size(404, 23);
            this.machine_model_cmb.TabIndex = 107;
            // 
            // cost_value_cmb
            // 
            this.cost_value_cmb.ControlId = null;
            this.cost_value_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_value_cmb.FormattingEnabled = true;
            this.cost_value_cmb.Location = new System.Drawing.Point(757, 220);
            this.cost_value_cmb.Name = "cost_value_cmb";
            this.cost_value_cmb.Size = new System.Drawing.Size(141, 23);
            this.cost_value_cmb.TabIndex = 80;
            this.cost_value_cmb.SelectedIndexChanged += new System.EventHandler(this.machine_serial_cmb_SelectedIndexChanged);
            // 
            // cost_value_lbl
            // 
            this.cost_value_lbl.AutoSize = true;
            this.cost_value_lbl.ControlId = null;
            this.cost_value_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.cost_value_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cost_value_lbl.Location = new System.Drawing.Point(682, 223);
            this.cost_value_lbl.Name = "cost_value_lbl";
            this.cost_value_lbl.Size = new System.Drawing.Size(69, 15);
            this.cost_value_lbl.TabIndex = 81;
            this.cost_value_lbl.Text = "Cost Value:";
            // 
            // AddMovingMachineVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(925, 524);
            this.Controls.Add(this.machine_model_lbl);
            this.Controls.Add(this.machine_model_cmb);
            this.Controls.Add(this.confirm_received_lbl);
            this.Controls.Add(this.reason_tranfer_lbl);
            this.Controls.Add(this.comments_lbl);
            this.Controls.Add(this.confirm_received_txt);
            this.Controls.Add(this.reason_tranfer_txt);
            this.Controls.Add(this.comments_txt);
            this.Controls.Add(this.dgv_maxcode);
            this.Controls.Add(this.code_name_txt);
            this.Controls.Add(this.code_name_lbl);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.rfid_txt);
            this.Controls.Add(this.factory_tranfer_lbl);
            this.Controls.Add(this.factory_tranfer_cmb);
            this.Controls.Add(this.status_machine_lbl);
            this.Controls.Add(this.code_status_lbl);
            this.Controls.Add(this.factory_received_lbl);
            this.Controls.Add(this.status_machine_cmb);
            this.Controls.Add(this.code_status_cmb);
            this.Controls.Add(this.factory_received_cmb);
            this.Controls.Add(this.machine_name_lbl);
            this.Controls.Add(this.cost_value_lbl);
            this.Controls.Add(this.serialmachine_lbl);
            this.Controls.Add(this.machine_name_cmb);
            this.Controls.Add(this.cost_value_cmb);
            this.Controls.Add(this.machine_serial_cmb);
            this.Controls.Add(this.setting_gbc);
            this.Name = "AddMovingMachineVTForm";
            this.Text = "Add Tranfer Code";
            this.TitleText = "Add Tranfer Code";
            this.Load += new System.EventHandler(this.AddMovingMachineVTForm_Load);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.machine_serial_cmb, 0);
            this.Controls.SetChildIndex(this.cost_value_cmb, 0);
            this.Controls.SetChildIndex(this.machine_name_cmb, 0);
            this.Controls.SetChildIndex(this.serialmachine_lbl, 0);
            this.Controls.SetChildIndex(this.cost_value_lbl, 0);
            this.Controls.SetChildIndex(this.machine_name_lbl, 0);
            this.Controls.SetChildIndex(this.factory_received_cmb, 0);
            this.Controls.SetChildIndex(this.code_status_cmb, 0);
            this.Controls.SetChildIndex(this.status_machine_cmb, 0);
            this.Controls.SetChildIndex(this.factory_received_lbl, 0);
            this.Controls.SetChildIndex(this.code_status_lbl, 0);
            this.Controls.SetChildIndex(this.status_machine_lbl, 0);
            this.Controls.SetChildIndex(this.factory_tranfer_cmb, 0);
            this.Controls.SetChildIndex(this.factory_tranfer_lbl, 0);
            this.Controls.SetChildIndex(this.rfid_txt, 0);
            this.Controls.SetChildIndex(this.rfid_lbl, 0);
            this.Controls.SetChildIndex(this.code_name_lbl, 0);
            this.Controls.SetChildIndex(this.code_name_txt, 0);
            this.Controls.SetChildIndex(this.dgv_maxcode, 0);
            this.Controls.SetChildIndex(this.comments_txt, 0);
            this.Controls.SetChildIndex(this.reason_tranfer_txt, 0);
            this.Controls.SetChildIndex(this.confirm_received_txt, 0);
            this.Controls.SetChildIndex(this.comments_lbl, 0);
            this.Controls.SetChildIndex(this.reason_tranfer_lbl, 0);
            this.Controls.SetChildIndex(this.confirm_received_lbl, 0);
            this.Controls.SetChildIndex(this.machine_model_cmb, 0);
            this.Controls.SetChildIndex(this.machine_model_lbl, 0);
            this.setting_gbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_maxcode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon Ok_btn;
        private Framework.ComboBoxCommon machine_serial_cmb;
        private Framework.LabelCommon serialmachine_lbl;
        private Framework.ButtonCommon cancel_btn;
        private Framework.LabelCommon factory_received_lbl;
        private Framework.ComboBoxCommon factory_received_cmb;
        private Framework.LabelCommon factory_tranfer_lbl;
        private Framework.ComboBoxCommon factory_tranfer_cmb;
        private Framework.TextBoxCommon rfid_txt;
        private Framework.LabelCommon rfid_lbl;
        private Framework.TextBoxCommon code_name_txt;
        private Framework.LabelCommon code_name_lbl;
        private Framework.ComboBoxCommon code_status_cmb;
        private Framework.LabelCommon code_status_lbl;
        private Framework.DataGridViewCommon dgv_maxcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBG;
        private System.Windows.Forms.DataGridViewTextBoxColumn colM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTH;
        private Framework.ComboBoxCommon status_machine_cmb;
        private Framework.LabelCommon status_machine_lbl;
        private Framework.LabelCommon comments_lbl;
        private Framework.TextBoxCommon comments_txt;
        private Framework.TextBoxCommon reason_tranfer_txt;
        private Framework.LabelCommon reason_tranfer_lbl;
        private Framework.TextBoxCommon confirm_received_txt;
        private Framework.LabelCommon confirm_received_lbl;
        private Framework.ComboBoxCommon machine_name_cmb;
        private Framework.LabelCommon machine_name_lbl;
        private Framework.LabelCommon machine_model_lbl;
        private Framework.ComboBoxCommon machine_model_cmb;
        private Framework.ComboBoxCommon cost_value_cmb;
        private Framework.LabelCommon cost_value_lbl;
    }
}
