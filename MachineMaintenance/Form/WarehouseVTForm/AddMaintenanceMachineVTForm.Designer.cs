namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddMaintenanceMachineVTForm
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
            this.startday_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.month_repeat_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.start_day_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.month_repeat_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.setting_gbc = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.cancel_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Ok_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.setting_gbc.SuspendLayout();
            this.SuspendLayout();
            // 
            // startday_lbl
            // 
            this.startday_lbl.AutoSize = true;
            this.startday_lbl.ControlId = null;
            this.startday_lbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startday_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startday_lbl.Location = new System.Drawing.Point(79, 153);
            this.startday_lbl.Name = "startday_lbl";
            this.startday_lbl.Size = new System.Drawing.Size(138, 32);
            this.startday_lbl.TabIndex = 92;
            this.startday_lbl.Text = "Start Day:";
            // 
            // month_repeat_lbl
            // 
            this.month_repeat_lbl.AutoSize = true;
            this.month_repeat_lbl.ControlId = null;
            this.month_repeat_lbl.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_repeat_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.month_repeat_lbl.Location = new System.Drawing.Point(22, 220);
            this.month_repeat_lbl.Name = "month_repeat_lbl";
            this.month_repeat_lbl.Size = new System.Drawing.Size(195, 32);
            this.month_repeat_lbl.TabIndex = 93;
            this.month_repeat_lbl.Text = "Month Repeat:";
            // 
            // start_day_dtp
            // 
            this.start_day_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.start_day_dtp.ControlId = null;
            this.start_day_dtp.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.start_day_dtp.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_day_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.start_day_dtp.Location = new System.Drawing.Point(223, 148);
            this.start_day_dtp.Name = "start_day_dtp";
            this.start_day_dtp.Size = new System.Drawing.Size(247, 39);
            this.start_day_dtp.TabIndex = 94;
            // 
            // month_repeat_txt
            // 
            this.month_repeat_txt.ControlId = null;
            this.month_repeat_txt.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_repeat_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.Numeric;
            this.month_repeat_txt.Location = new System.Drawing.Point(223, 220);
            this.month_repeat_txt.Name = "month_repeat_txt";
            this.month_repeat_txt.Size = new System.Drawing.Size(247, 39);
            this.month_repeat_txt.TabIndex = 95;
            // 
            // setting_gbc
            // 
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.cancel_btn);
            this.setting_gbc.Controls.Add(this.Ok_btn);
            this.setting_gbc.Font = new System.Drawing.Font("Arial", 9F);
            this.setting_gbc.Location = new System.Drawing.Point(138, 294);
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.Size = new System.Drawing.Size(313, 77);
            this.setting_gbc.TabIndex = 96;
            this.setting_gbc.TabStop = false;
            // 
            // cancel_btn
            // 
            this.cancel_btn.BackColor = System.Drawing.SystemColors.Control;
            this.cancel_btn.ControlId = "";
            this.cancel_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cancel_btn.Location = new System.Drawing.Point(178, 20);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(100, 43);
            this.cancel_btn.TabIndex = 11;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = false;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // Ok_btn
            // 
            this.Ok_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Ok_btn.ControlId = null;
            this.Ok_btn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ok_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Ok_btn.Location = new System.Drawing.Point(25, 20);
            this.Ok_btn.Name = "Ok_btn";
            this.Ok_btn.Size = new System.Drawing.Size(100, 43);
            this.Ok_btn.TabIndex = 10;
            this.Ok_btn.Text = "OK";
            this.Ok_btn.UseVisualStyleBackColor = false;
            this.Ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // AddMaintenanceMachineVTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(523, 397);
            this.Controls.Add(this.setting_gbc);
            this.Controls.Add(this.month_repeat_txt);
            this.Controls.Add(this.start_day_dtp);
            this.Controls.Add(this.startday_lbl);
            this.Controls.Add(this.month_repeat_lbl);
            this.Name = "AddMaintenanceMachineVTForm";
            this.Text = "Add Plan Day";
            this.TitleText = "Add Plan Day";
            this.Load += new System.EventHandler(this.AddMaintenanceMachineVTForm_Load);
            this.Controls.SetChildIndex(this.month_repeat_lbl, 0);
            this.Controls.SetChildIndex(this.startday_lbl, 0);
            this.Controls.SetChildIndex(this.start_day_dtp, 0);
            this.Controls.SetChildIndex(this.month_repeat_txt, 0);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.setting_gbc.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.LabelCommon startday_lbl;
        private Framework.LabelCommon month_repeat_lbl;
        private Framework.DateTimePickerCommon start_day_dtp;
        private Framework.TextBoxCommon month_repeat_txt;
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon cancel_btn;
        private Framework.ButtonCommon Ok_btn;
    }
}
