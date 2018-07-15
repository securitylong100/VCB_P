namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddNewMachineVT
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
            this.exit_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.ok_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.rfid_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.rfid_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_cd_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_cd_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.location_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.location_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.supplier_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.qty_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.qty_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.invoice_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.invoice_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.cost_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.cost_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.serial_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.type_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.serial_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.labelCommon2 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.checktime_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.checktime_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon3 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon4 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.checkid_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.machine_name_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.labelCommon1 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.labelCommon5 = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_supplier_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exit_btn.ControlId = null;
            this.exit_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_btn.Location = new System.Drawing.Point(390, 415);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(80, 33);
            this.exit_btn.TabIndex = 51;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // ok_btn
            // 
            this.ok_btn.BackColor = System.Drawing.SystemColors.Control;
            this.ok_btn.ControlId = null;
            this.ok_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.ok_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ok_btn.Location = new System.Drawing.Point(273, 415);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(80, 33);
            this.ok_btn.TabIndex = 50;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // rfid_txt
            // 
            this.rfid_txt.ControlId = null;
            this.rfid_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfid_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.rfid_txt.Location = new System.Drawing.Point(113, 160);
            this.rfid_txt.MaxLength = 10;
            this.rfid_txt.Name = "rfid_txt";
            this.rfid_txt.Size = new System.Drawing.Size(223, 21);
            this.rfid_txt.TabIndex = 74;
            // 
            // rfid_lbl
            // 
            this.rfid_lbl.AutoSize = true;
            this.rfid_lbl.ControlId = null;
            this.rfid_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.rfid_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rfid_lbl.Location = new System.Drawing.Point(21, 163);
            this.rfid_lbl.Name = "rfid_lbl";
            this.rfid_lbl.Size = new System.Drawing.Size(86, 15);
            this.rfid_lbl.TabIndex = 73;
            this.rfid_lbl.Text = "RFID Number:";
            // 
            // machine_cd_lbl
            // 
            this.machine_cd_lbl.AutoSize = true;
            this.machine_cd_lbl.ControlId = null;
            this.machine_cd_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_cd_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_cd_lbl.Location = new System.Drawing.Point(21, 203);
            this.machine_cd_lbl.Name = "machine_cd_lbl";
            this.machine_cd_lbl.Size = new System.Drawing.Size(89, 15);
            this.machine_cd_lbl.TabIndex = 73;
            this.machine_cd_lbl.Text = "Machine Code:";
            // 
            // machine_cd_txt
            // 
            this.machine_cd_txt.ControlId = null;
            this.machine_cd_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_cd_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.machine_cd_txt.Location = new System.Drawing.Point(113, 200);
            this.machine_cd_txt.Name = "machine_cd_txt";
            this.machine_cd_txt.Size = new System.Drawing.Size(223, 21);
            this.machine_cd_txt.TabIndex = 74;
            this.machine_cd_txt.Text = "New";
            // 
            // location_lbl
            // 
            this.location_lbl.AutoSize = true;
            this.location_lbl.ControlId = null;
            this.location_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.location_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.location_lbl.Location = new System.Drawing.Point(438, 160);
            this.location_lbl.Name = "location_lbl";
            this.location_lbl.Size = new System.Drawing.Size(57, 15);
            this.location_lbl.TabIndex = 73;
            this.location_lbl.Text = "Location:";
            // 
            // location_txt
            // 
            this.location_txt.ControlId = null;
            this.location_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.location_txt.Location = new System.Drawing.Point(495, 157);
            this.location_txt.Name = "location_txt";
            this.location_txt.Size = new System.Drawing.Size(152, 21);
            this.location_txt.TabIndex = 74;
            // 
            // supplier_lbl
            // 
            this.supplier_lbl.AutoSize = true;
            this.supplier_lbl.ControlId = null;
            this.supplier_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.supplier_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.supplier_lbl.Location = new System.Drawing.Point(433, 200);
            this.supplier_lbl.Name = "supplier_lbl";
            this.supplier_lbl.Size = new System.Drawing.Size(56, 15);
            this.supplier_lbl.TabIndex = 73;
            this.supplier_lbl.Text = "Supplier:";
            // 
            // machine_name_lbl
            // 
            this.machine_name_lbl.AutoSize = true;
            this.machine_name_lbl.ControlId = null;
            this.machine_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_name_lbl.Location = new System.Drawing.Point(12, 283);
            this.machine_name_lbl.Name = "machine_name_lbl";
            this.machine_name_lbl.Size = new System.Drawing.Size(93, 15);
            this.machine_name_lbl.TabIndex = 73;
            this.machine_name_lbl.Text = "Machine Name:";
            // 
            // qty_lbl
            // 
            this.qty_lbl.AutoSize = true;
            this.qty_lbl.ControlId = null;
            this.qty_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.qty_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.qty_lbl.Location = new System.Drawing.Point(462, 319);
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Size = new System.Drawing.Size(27, 15);
            this.qty_lbl.TabIndex = 73;
            this.qty_lbl.Text = "Qty:";
            // 
            // qty_txt
            // 
            this.qty_txt.ControlId = null;
            this.qty_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qty_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.Numeric;
            this.qty_txt.Location = new System.Drawing.Point(495, 313);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(152, 21);
            this.qty_txt.TabIndex = 74;
            this.qty_txt.Text = "1";
            // 
            // invoice_lbl
            // 
            this.invoice_lbl.AutoSize = true;
            this.invoice_lbl.ControlId = null;
            this.invoice_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.invoice_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.invoice_lbl.Location = new System.Drawing.Point(441, 240);
            this.invoice_lbl.Name = "invoice_lbl";
            this.invoice_lbl.Size = new System.Drawing.Size(48, 15);
            this.invoice_lbl.TabIndex = 73;
            this.invoice_lbl.Text = "Invoice:";
            // 
            // invoice_txt
            // 
            this.invoice_txt.ControlId = null;
            this.invoice_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.invoice_txt.Location = new System.Drawing.Point(495, 234);
            this.invoice_txt.Name = "invoice_txt";
            this.invoice_txt.Size = new System.Drawing.Size(152, 21);
            this.invoice_txt.TabIndex = 74;
            this.invoice_txt.Text = "\"\"";
            // 
            // cost_lbl
            // 
            this.cost_lbl.AutoSize = true;
            this.cost_lbl.ControlId = null;
            this.cost_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.cost_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cost_lbl.Location = new System.Drawing.Point(420, 277);
            this.cost_lbl.Name = "cost_lbl";
            this.cost_lbl.Size = new System.Drawing.Size(69, 15);
            this.cost_lbl.TabIndex = 73;
            this.cost_lbl.Text = "Cost Value:";
            // 
            // cost_txt
            // 
            this.cost_txt.ControlId = null;
            this.cost_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.Numeric;
            this.cost_txt.Location = new System.Drawing.Point(495, 274);
            this.cost_txt.Name = "cost_txt";
            this.cost_txt.Size = new System.Drawing.Size(152, 21);
            this.cost_txt.TabIndex = 74;
            this.cost_txt.Text = "0";
            // 
            // serial_lbl
            // 
            this.serial_lbl.AutoSize = true;
            this.serial_lbl.ControlId = null;
            this.serial_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.serial_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.serial_lbl.Location = new System.Drawing.Point(65, 357);
            this.serial_lbl.Name = "serial_lbl";
            this.serial_lbl.Size = new System.Drawing.Size(42, 15);
            this.serial_lbl.TabIndex = 73;
            this.serial_lbl.Text = "Serial:";
            // 
            // type_lbl
            // 
            this.type_lbl.AutoSize = true;
            this.type_lbl.ControlId = null;
            this.type_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.type_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.type_lbl.Location = new System.Drawing.Point(59, 238);
            this.type_lbl.Name = "type_lbl";
            this.type_lbl.Size = new System.Drawing.Size(43, 15);
            this.type_lbl.TabIndex = 73;
            this.type_lbl.Text = "Model:";
            // 
            // serial_txt
            // 
            this.serial_txt.ControlId = null;
            this.serial_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serial_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.serial_txt.Location = new System.Drawing.Point(113, 359);
            this.serial_txt.Name = "serial_txt";
            this.serial_txt.Size = new System.Drawing.Size(223, 21);
            this.serial_txt.TabIndex = 74;
            // 
            // labelCommon2
            // 
            this.labelCommon2.AutoSize = true;
            this.labelCommon2.ControlId = null;
            this.labelCommon2.Font = new System.Drawing.Font("Arial", 9F);
            this.labelCommon2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCommon2.Location = new System.Drawing.Point(349, 283);
            this.labelCommon2.Name = "labelCommon2";
            this.labelCommon2.Size = new System.Drawing.Size(20, 15);
            this.labelCommon2.TabIndex = 76;
            this.labelCommon2.Text = "(*)";
            // 
            // checktime_txt
            // 
            this.checktime_txt.ControlId = null;
            this.checktime_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checktime_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.Numeric;
            this.checktime_txt.Location = new System.Drawing.Point(113, 319);
            this.checktime_txt.MaxLength = 2;
            this.checktime_txt.Name = "checktime_txt";
            this.checktime_txt.Size = new System.Drawing.Size(223, 21);
            this.checktime_txt.TabIndex = 78;
            // 
            // checktime_lbl
            // 
            this.checktime_lbl.AutoSize = true;
            this.checktime_lbl.ControlId = null;
            this.checktime_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.checktime_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checktime_lbl.Location = new System.Drawing.Point(31, 322);
            this.checktime_lbl.Name = "checktime_lbl";
            this.checktime_lbl.Size = new System.Drawing.Size(76, 15);
            this.checktime_lbl.TabIndex = 77;
            this.checktime_lbl.Text = "Check Time:";
            // 
            // labelCommon3
            // 
            this.labelCommon3.AutoSize = true;
            this.labelCommon3.ControlId = null;
            this.labelCommon3.Font = new System.Drawing.Font("Arial", 9F);
            this.labelCommon3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCommon3.Location = new System.Drawing.Point(643, 316);
            this.labelCommon3.Name = "labelCommon3";
            this.labelCommon3.Size = new System.Drawing.Size(20, 15);
            this.labelCommon3.TabIndex = 79;
            this.labelCommon3.Text = "(*)";
            // 
            // labelCommon4
            // 
            this.labelCommon4.AutoSize = true;
            this.labelCommon4.ControlId = null;
            this.labelCommon4.Font = new System.Drawing.Font("Arial", 9F);
            this.labelCommon4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCommon4.Location = new System.Drawing.Point(349, 323);
            this.labelCommon4.Name = "labelCommon4";
            this.labelCommon4.Size = new System.Drawing.Size(20, 15);
            this.labelCommon4.TabIndex = 80;
            this.labelCommon4.Text = "(*)";
            // 
            // checkid_cmb
            // 
            this.checkid_cmb.ControlId = null;
            this.checkid_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkid_cmb.FormattingEnabled = true;
            this.checkid_cmb.Location = new System.Drawing.Point(495, 356);
            this.checkid_cmb.Name = "checkid_cmb";
            this.checkid_cmb.Size = new System.Drawing.Size(152, 23);
            this.checkid_cmb.TabIndex = 81;
            this.checkid_cmb.Visible = false;
            // 
            // machine_name_cmb
            // 
            this.machine_name_cmb.ControlId = null;
            this.machine_name_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_name_cmb.FormattingEnabled = true;
            this.machine_name_cmb.Location = new System.Drawing.Point(113, 276);
            this.machine_name_cmb.Name = "machine_name_cmb";
            this.machine_name_cmb.Size = new System.Drawing.Size(223, 23);
            this.machine_name_cmb.TabIndex = 82;
            // 
            // model_cmb
            // 
            this.model_cmb.ControlId = null;
            this.model_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.model_cmb.FormattingEnabled = true;
            this.model_cmb.Location = new System.Drawing.Point(113, 235);
            this.model_cmb.Name = "model_cmb";
            this.model_cmb.Size = new System.Drawing.Size(223, 23);
            this.model_cmb.TabIndex = 83;
            this.model_cmb.SelectedIndexChanged += new System.EventHandler(this.model_cmb_SelectedIndexChanged);
            // 
            // labelCommon1
            // 
            this.labelCommon1.AutoSize = true;
            this.labelCommon1.ControlId = null;
            this.labelCommon1.Font = new System.Drawing.Font("Arial", 9F);
            this.labelCommon1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCommon1.Location = new System.Drawing.Point(653, 163);
            this.labelCommon1.Name = "labelCommon1";
            this.labelCommon1.Size = new System.Drawing.Size(20, 15);
            this.labelCommon1.TabIndex = 84;
            this.labelCommon1.Text = "(*)";
            // 
            // labelCommon5
            // 
            this.labelCommon5.AutoSize = true;
            this.labelCommon5.ControlId = null;
            this.labelCommon5.Font = new System.Drawing.Font("Arial", 9F);
            this.labelCommon5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCommon5.Location = new System.Drawing.Point(349, 362);
            this.labelCommon5.Name = "labelCommon5";
            this.labelCommon5.Size = new System.Drawing.Size(20, 15);
            this.labelCommon5.TabIndex = 85;
            this.labelCommon5.Text = "(*)";
            // 
            // machine_supplier_cmb
            // 
            this.machine_supplier_cmb.ControlId = null;
            this.machine_supplier_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_supplier_cmb.FormattingEnabled = true;
            this.machine_supplier_cmb.Location = new System.Drawing.Point(495, 194);
            this.machine_supplier_cmb.Name = "machine_supplier_cmb";
            this.machine_supplier_cmb.Size = new System.Drawing.Size(152, 23);
            this.machine_supplier_cmb.TabIndex = 86;
            // 
            // AddNewMachineVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(766, 475);
            this.Controls.Add(this.machine_supplier_cmb);
            this.Controls.Add(this.labelCommon5);
            this.Controls.Add(this.labelCommon1);
            this.Controls.Add(this.model_cmb);
            this.Controls.Add(this.machine_name_cmb);
            this.Controls.Add(this.checkid_cmb);
            this.Controls.Add(this.labelCommon4);
            this.Controls.Add(this.labelCommon3);
            this.Controls.Add(this.checktime_txt);
            this.Controls.Add(this.checktime_lbl);
            this.Controls.Add(this.labelCommon2);
            this.Controls.Add(this.cost_txt);
            this.Controls.Add(this.serial_txt);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.machine_cd_txt);
            this.Controls.Add(this.cost_lbl);
            this.Controls.Add(this.type_lbl);
            this.Controls.Add(this.qty_lbl);
            this.Controls.Add(this.supplier_lbl);
            this.Controls.Add(this.machine_cd_lbl);
            this.Controls.Add(this.invoice_txt);
            this.Controls.Add(this.invoice_lbl);
            this.Controls.Add(this.serial_lbl);
            this.Controls.Add(this.machine_name_lbl);
            this.Controls.Add(this.location_txt);
            this.Controls.Add(this.location_lbl);
            this.Controls.Add(this.rfid_txt);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.ok_btn);
            this.Name = "AddNewMachineVT";
            this.Text = "Add New Machine";
            this.TitleText = "Add New Machine";
            this.Load += new System.EventHandler(this.AddNewMachineVT_Load);
            this.Controls.SetChildIndex(this.ok_btn, 0);
            this.Controls.SetChildIndex(this.exit_btn, 0);
            this.Controls.SetChildIndex(this.rfid_lbl, 0);
            this.Controls.SetChildIndex(this.rfid_txt, 0);
            this.Controls.SetChildIndex(this.location_lbl, 0);
            this.Controls.SetChildIndex(this.location_txt, 0);
            this.Controls.SetChildIndex(this.machine_name_lbl, 0);
            this.Controls.SetChildIndex(this.serial_lbl, 0);
            this.Controls.SetChildIndex(this.invoice_lbl, 0);
            this.Controls.SetChildIndex(this.invoice_txt, 0);
            this.Controls.SetChildIndex(this.machine_cd_lbl, 0);
            this.Controls.SetChildIndex(this.supplier_lbl, 0);
            this.Controls.SetChildIndex(this.qty_lbl, 0);
            this.Controls.SetChildIndex(this.type_lbl, 0);
            this.Controls.SetChildIndex(this.cost_lbl, 0);
            this.Controls.SetChildIndex(this.machine_cd_txt, 0);
            this.Controls.SetChildIndex(this.qty_txt, 0);
            this.Controls.SetChildIndex(this.serial_txt, 0);
            this.Controls.SetChildIndex(this.cost_txt, 0);
            this.Controls.SetChildIndex(this.labelCommon2, 0);
            this.Controls.SetChildIndex(this.checktime_lbl, 0);
            this.Controls.SetChildIndex(this.checktime_txt, 0);
            this.Controls.SetChildIndex(this.labelCommon3, 0);
            this.Controls.SetChildIndex(this.labelCommon4, 0);
            this.Controls.SetChildIndex(this.checkid_cmb, 0);
            this.Controls.SetChildIndex(this.machine_name_cmb, 0);
            this.Controls.SetChildIndex(this.model_cmb, 0);
            this.Controls.SetChildIndex(this.labelCommon1, 0);
            this.Controls.SetChildIndex(this.labelCommon5, 0);
            this.Controls.SetChildIndex(this.machine_supplier_cmb, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.ButtonCommon exit_btn;
        private Framework.ButtonCommon ok_btn;
        private Framework.TextBoxCommon rfid_txt;
        private Framework.LabelCommon rfid_lbl;
        private Framework.LabelCommon machine_cd_lbl;
        private Framework.TextBoxCommon machine_cd_txt;
        private Framework.LabelCommon location_lbl;
        private Framework.TextBoxCommon location_txt;
        private Framework.LabelCommon supplier_lbl;
        private Framework.LabelCommon machine_name_lbl;
        private Framework.LabelCommon qty_lbl;
        private Framework.TextBoxCommon qty_txt;
        private Framework.LabelCommon invoice_lbl;
        private Framework.TextBoxCommon invoice_txt;
        private Framework.LabelCommon cost_lbl;
        private Framework.TextBoxCommon cost_txt;
        private Framework.LabelCommon serial_lbl;
        private Framework.LabelCommon type_lbl;
        private Framework.TextBoxCommon serial_txt;
        private Framework.LabelCommon labelCommon2;
        private Framework.TextBoxCommon checktime_txt;
        private Framework.LabelCommon checktime_lbl;
        private Framework.LabelCommon labelCommon3;
        private Framework.LabelCommon labelCommon4;
        private Framework.ComboBoxCommon checkid_cmb;
        private Framework.ComboBoxCommon machine_name_cmb;
        private Framework.ComboBoxCommon model_cmb;
        private Framework.LabelCommon labelCommon1;
        private Framework.LabelCommon labelCommon5;
        private Framework.ComboBoxCommon machine_supplier_cmb;
    }
}
