namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddCommentDatalostVT
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
            this.machine_serial_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.machine_serial_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.checktime_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.checktime_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.comment_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.comment_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exit_btn.ControlId = null;
            this.exit_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_btn.Location = new System.Drawing.Point(292, 389);
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
            this.ok_btn.Location = new System.Drawing.Point(175, 389);
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
            this.rfid_txt.Location = new System.Drawing.Point(103, 160);
            this.rfid_txt.Name = "rfid_txt";
            this.rfid_txt.ReadOnly = true;
            this.rfid_txt.Size = new System.Drawing.Size(152, 21);
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
            // machine_serial_lbl
            // 
            this.machine_serial_lbl.AutoSize = true;
            this.machine_serial_lbl.ControlId = null;
            this.machine_serial_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.machine_serial_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.machine_serial_lbl.Location = new System.Drawing.Point(12, 203);
            this.machine_serial_lbl.Name = "machine_serial_lbl";
            this.machine_serial_lbl.Size = new System.Drawing.Size(91, 15);
            this.machine_serial_lbl.TabIndex = 73;
            this.machine_serial_lbl.Text = "Machine Serial:";
            // 
            // machine_serial_txt
            // 
            this.machine_serial_txt.ControlId = null;
            this.machine_serial_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.machine_serial_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.machine_serial_txt.Location = new System.Drawing.Point(103, 200);
            this.machine_serial_txt.Name = "machine_serial_txt";
            this.machine_serial_txt.ReadOnly = true;
            this.machine_serial_txt.Size = new System.Drawing.Size(152, 21);
            this.machine_serial_txt.TabIndex = 74;
            // 
            // checktime_lbl
            // 
            this.checktime_lbl.AutoSize = true;
            this.checktime_lbl.ControlId = null;
            this.checktime_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.checktime_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checktime_lbl.Location = new System.Drawing.Point(290, 163);
            this.checktime_lbl.Name = "checktime_lbl";
            this.checktime_lbl.Size = new System.Drawing.Size(73, 15);
            this.checktime_lbl.TabIndex = 73;
            this.checktime_lbl.Text = "Check Time";
            // 
            // checktime_txt
            // 
            this.checktime_txt.ControlId = null;
            this.checktime_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checktime_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.checktime_txt.Location = new System.Drawing.Point(372, 160);
            this.checktime_txt.Name = "checktime_txt";
            this.checktime_txt.ReadOnly = true;
            this.checktime_txt.Size = new System.Drawing.Size(152, 21);
            this.checktime_txt.TabIndex = 74;
            // 
            // comment_lbl
            // 
            this.comment_lbl.AutoSize = true;
            this.comment_lbl.ControlId = null;
            this.comment_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.comment_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comment_lbl.Location = new System.Drawing.Point(21, 238);
            this.comment_lbl.Name = "comment_lbl";
            this.comment_lbl.Size = new System.Drawing.Size(62, 15);
            this.comment_lbl.TabIndex = 73;
            this.comment_lbl.Text = "Comment";
            // 
            // comment_txt
            // 
            this.comment_txt.ControlId = null;
            this.comment_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comment_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.comment_txt.Location = new System.Drawing.Point(24, 256);
            this.comment_txt.Multiline = true;
            this.comment_txt.Name = "comment_txt";
            this.comment_txt.Size = new System.Drawing.Size(500, 113);
            this.comment_txt.TabIndex = 74;
            // 
            // AddCommentDatalostVT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(562, 436);
            this.Controls.Add(this.comment_txt);
            this.Controls.Add(this.machine_serial_txt);
            this.Controls.Add(this.comment_lbl);
            this.Controls.Add(this.machine_serial_lbl);
            this.Controls.Add(this.checktime_txt);
            this.Controls.Add(this.checktime_lbl);
            this.Controls.Add(this.rfid_txt);
            this.Controls.Add(this.rfid_lbl);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.ok_btn);
            this.Name = "AddCommentDatalostVT";
            this.Text = "Data Lost";
            this.TitleText = "Machine Lost Data";
            this.Load += new System.EventHandler(this.AddNewMachineVT_Load);
            this.Controls.SetChildIndex(this.ok_btn, 0);
            this.Controls.SetChildIndex(this.exit_btn, 0);
            this.Controls.SetChildIndex(this.rfid_lbl, 0);
            this.Controls.SetChildIndex(this.rfid_txt, 0);
            this.Controls.SetChildIndex(this.checktime_lbl, 0);
            this.Controls.SetChildIndex(this.checktime_txt, 0);
            this.Controls.SetChildIndex(this.machine_serial_lbl, 0);
            this.Controls.SetChildIndex(this.comment_lbl, 0);
            this.Controls.SetChildIndex(this.machine_serial_txt, 0);
            this.Controls.SetChildIndex(this.comment_txt, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.ButtonCommon exit_btn;
        private Framework.ButtonCommon ok_btn;
        private Framework.TextBoxCommon rfid_txt;
        private Framework.LabelCommon rfid_lbl;
        private Framework.LabelCommon machine_serial_lbl;
        private Framework.TextBoxCommon machine_serial_txt;
        private Framework.LabelCommon checktime_lbl;
        private Framework.TextBoxCommon checktime_txt;
        private Framework.LabelCommon comment_lbl;
        private Framework.TextBoxCommon comment_txt;
    }
}
