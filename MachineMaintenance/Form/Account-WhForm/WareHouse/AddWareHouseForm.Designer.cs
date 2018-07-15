namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class AddWareHouseForm
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
            this.asset_code_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.rank_name_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.rank_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.qty_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.unit_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.unit_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.before_location_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.after_location_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.after_location_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.before_location_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.asset_code_txt = new System.Windows.Forms.TextBox();
            this.qty_txt = new System.Windows.Forms.TextBox();
            this.exit_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.ok_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.UserCode_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timestart_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timestart_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.comments_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.Comment_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.user_location_code_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.user_location_name_cbm = new System.Windows.Forms.ComboBox();
            this.user_location_name_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.SuspendLayout();
            // 
            // asset_code_lbl
            // 
            this.asset_code_lbl.AutoSize = true;
            this.asset_code_lbl.ControlId = null;
            this.asset_code_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.asset_code_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.asset_code_lbl.Location = new System.Drawing.Point(20, 176);
            this.asset_code_lbl.Name = "asset_code_lbl";
            this.asset_code_lbl.Size = new System.Drawing.Size(74, 15);
            this.asset_code_lbl.TabIndex = 45;
            this.asset_code_lbl.Text = "Asset Code:";
            // 
            // rank_name_cmb
            // 
            this.rank_name_cmb.ControlId = null;
            this.rank_name_cmb.Font = new System.Drawing.Font("Arial", 9F);
            this.rank_name_cmb.FormattingEnabled = true;
            this.rank_name_cmb.Location = new System.Drawing.Point(394, 134);
            this.rank_name_cmb.Name = "rank_name_cmb";
            this.rank_name_cmb.Size = new System.Drawing.Size(152, 23);
            this.rank_name_cmb.TabIndex = 47;
            // 
            // rank_name_lbl
            // 
            this.rank_name_lbl.AutoSize = true;
            this.rank_name_lbl.ControlId = null;
            this.rank_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.rank_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.rank_name_lbl.Location = new System.Drawing.Point(308, 137);
            this.rank_name_lbl.Name = "rank_name_lbl";
            this.rank_name_lbl.Size = new System.Drawing.Size(76, 15);
            this.rank_name_lbl.TabIndex = 48;
            this.rank_name_lbl.Text = "Rank Name:";
            // 
            // qty_lbl
            // 
            this.qty_lbl.AutoSize = true;
            this.qty_lbl.ControlId = null;
            this.qty_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.qty_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.qty_lbl.Location = new System.Drawing.Point(357, 252);
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Size = new System.Drawing.Size(27, 15);
            this.qty_lbl.TabIndex = 45;
            this.qty_lbl.Text = "Qty:";
            // 
            // unit_cmb
            // 
            this.unit_cmb.ControlId = null;
            this.unit_cmb.Font = new System.Drawing.Font("Arial", 9F);
            this.unit_cmb.FormattingEnabled = true;
            this.unit_cmb.Location = new System.Drawing.Point(394, 288);
            this.unit_cmb.Name = "unit_cmb";
            this.unit_cmb.Size = new System.Drawing.Size(152, 23);
            this.unit_cmb.TabIndex = 47;
            this.unit_cmb.SelectedIndexChanged += new System.EventHandler(this.unit_cmb_SelectedIndexChanged);
            // 
            // unit_lbl
            // 
            this.unit_lbl.AutoSize = true;
            this.unit_lbl.ControlId = null;
            this.unit_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.unit_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.unit_lbl.Location = new System.Drawing.Point(352, 291);
            this.unit_lbl.Name = "unit_lbl";
            this.unit_lbl.Size = new System.Drawing.Size(32, 15);
            this.unit_lbl.TabIndex = 48;
            this.unit_lbl.Text = "Unit:";
            // 
            // before_location_lbl
            // 
            this.before_location_lbl.AutoSize = true;
            this.before_location_lbl.ControlId = null;
            this.before_location_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.before_location_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.before_location_lbl.Location = new System.Drawing.Point(288, 178);
            this.before_location_lbl.Name = "before_location_lbl";
            this.before_location_lbl.Size = new System.Drawing.Size(96, 15);
            this.before_location_lbl.TabIndex = 45;
            this.before_location_lbl.Text = "Before Location:";
            // 
            // after_location_cmb
            // 
            this.after_location_cmb.ControlId = null;
            this.after_location_cmb.Font = new System.Drawing.Font("Arial", 9F);
            this.after_location_cmb.FormattingEnabled = true;
            this.after_location_cmb.Location = new System.Drawing.Point(394, 210);
            this.after_location_cmb.Name = "after_location_cmb";
            this.after_location_cmb.Size = new System.Drawing.Size(152, 23);
            this.after_location_cmb.TabIndex = 47;
            // 
            // after_location_lbl
            // 
            this.after_location_lbl.AutoSize = true;
            this.after_location_lbl.ControlId = null;
            this.after_location_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.after_location_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.after_location_lbl.Location = new System.Drawing.Point(300, 213);
            this.after_location_lbl.Name = "after_location_lbl";
            this.after_location_lbl.Size = new System.Drawing.Size(84, 15);
            this.after_location_lbl.TabIndex = 48;
            this.after_location_lbl.Text = "After Location:";
            // 
            // before_location_cmb
            // 
            this.before_location_cmb.ControlId = null;
            this.before_location_cmb.Font = new System.Drawing.Font("Arial", 9F);
            this.before_location_cmb.FormattingEnabled = true;
            this.before_location_cmb.Location = new System.Drawing.Point(394, 173);
            this.before_location_cmb.Name = "before_location_cmb";
            this.before_location_cmb.Size = new System.Drawing.Size(152, 23);
            this.before_location_cmb.TabIndex = 47;
            this.before_location_cmb.SelectedIndexChanged += new System.EventHandler(this.before_location_cmb_SelectedIndexChanged);
            // 
            // asset_code_txt
            // 
            this.asset_code_txt.Location = new System.Drawing.Point(93, 176);
            this.asset_code_txt.MaxLength = 32;
            this.asset_code_txt.Name = "asset_code_txt";
            this.asset_code_txt.Size = new System.Drawing.Size(152, 20);
            this.asset_code_txt.TabIndex = 49;
            // 
            // qty_txt
            // 
            this.qty_txt.Location = new System.Drawing.Point(394, 250);
            this.qty_txt.Name = "qty_txt";
            this.qty_txt.Size = new System.Drawing.Size(152, 20);
            this.qty_txt.TabIndex = 49;
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.exit_btn.ControlId = null;
            this.exit_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.exit_btn.Location = new System.Drawing.Point(309, 444);
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
            this.ok_btn.Location = new System.Drawing.Point(192, 444);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(80, 33);
            this.ok_btn.TabIndex = 50;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // UserCode_lbl
            // 
            this.UserCode_lbl.AutoSize = true;
            this.UserCode_lbl.ControlId = null;
            this.UserCode_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.UserCode_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserCode_lbl.Location = new System.Drawing.Point(24, 136);
            this.UserCode_lbl.Name = "UserCode_lbl";
            this.UserCode_lbl.Size = new System.Drawing.Size(70, 15);
            this.UserCode_lbl.TabIndex = 45;
            this.UserCode_lbl.Text = "User Code:";
            // 
            // timestart_lbl
            // 
            this.timestart_lbl.AutoSize = true;
            this.timestart_lbl.ControlId = null;
            this.timestart_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.timestart_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.timestart_lbl.Location = new System.Drawing.Point(28, 252);
            this.timestart_lbl.Name = "timestart_lbl";
            this.timestart_lbl.Size = new System.Drawing.Size(66, 15);
            this.timestart_lbl.TabIndex = 53;
            this.timestart_lbl.Text = "Time Start:";
            // 
            // timestart_dtp
            // 
            this.timestart_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timestart_dtp.ControlId = null;
            this.timestart_dtp.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.timestart_dtp.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.timestart_dtp.Font = new System.Drawing.Font("Arial", 9F);
            this.timestart_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timestart_dtp.Location = new System.Drawing.Point(93, 249);
            this.timestart_dtp.Name = "timestart_dtp";
            this.timestart_dtp.Size = new System.Drawing.Size(152, 21);
            this.timestart_dtp.TabIndex = 52;
            // 
            // comments_txt
            // 
            this.comments_txt.ControlId = null;
            this.comments_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comments_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.comments_txt.Location = new System.Drawing.Point(91, 327);
            this.comments_txt.Multiline = true;
            this.comments_txt.Name = "comments_txt";
            this.comments_txt.Size = new System.Drawing.Size(453, 88);
            this.comments_txt.TabIndex = 55;
            // 
            // Comment_lbl
            // 
            this.Comment_lbl.AutoSize = true;
            this.Comment_lbl.ControlId = null;
            this.Comment_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comment_lbl.Location = new System.Drawing.Point(24, 318);
            this.Comment_lbl.Name = "Comment_lbl";
            this.Comment_lbl.Size = new System.Drawing.Size(65, 15);
            this.Comment_lbl.TabIndex = 57;
            this.Comment_lbl.Text = "Comment:";
            // 
            // user_location_code_txt
            // 
            this.user_location_code_txt.ControlId = null;
            this.user_location_code_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_location_code_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.user_location_code_txt.Location = new System.Drawing.Point(93, 134);
            this.user_location_code_txt.MaxLength = 13;
            this.user_location_code_txt.Name = "user_location_code_txt";
            this.user_location_code_txt.Size = new System.Drawing.Size(152, 21);
            this.user_location_code_txt.TabIndex = 58;
            this.user_location_code_txt.UseSystemPasswordChar = true;
            this.user_location_code_txt.TextChanged += new System.EventHandler(this.user_location_code_txt_TextChanged);
            // 
            // user_location_name_cbm
            // 
            this.user_location_name_cbm.FormattingEnabled = true;
            this.user_location_name_cbm.Location = new System.Drawing.Point(93, 211);
            this.user_location_name_cbm.Name = "user_location_name_cbm";
            this.user_location_name_cbm.Size = new System.Drawing.Size(152, 21);
            this.user_location_name_cbm.TabIndex = 60;
            // 
            // user_location_name_lbl
            // 
            this.user_location_name_lbl.AutoSize = true;
            this.user_location_name_lbl.ControlId = null;
            this.user_location_name_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.user_location_name_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.user_location_name_lbl.Location = new System.Drawing.Point(20, 213);
            this.user_location_name_lbl.Name = "user_location_name_lbl";
            this.user_location_name_lbl.Size = new System.Drawing.Size(74, 15);
            this.user_location_name_lbl.TabIndex = 59;
            this.user_location_name_lbl.Text = "User Name:";
            // 
            // AddWareHouseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(589, 495);
            this.Controls.Add(this.user_location_name_cbm);
            this.Controls.Add(this.user_location_name_lbl);
            this.Controls.Add(this.user_location_code_txt);
            this.Controls.Add(this.Comment_lbl);
            this.Controls.Add(this.comments_txt);
            this.Controls.Add(this.timestart_lbl);
            this.Controls.Add(this.timestart_dtp);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.qty_txt);
            this.Controls.Add(this.asset_code_txt);
            this.Controls.Add(this.after_location_lbl);
            this.Controls.Add(this.unit_lbl);
            this.Controls.Add(this.rank_name_lbl);
            this.Controls.Add(this.before_location_cmb);
            this.Controls.Add(this.after_location_cmb);
            this.Controls.Add(this.unit_cmb);
            this.Controls.Add(this.rank_name_cmb);
            this.Controls.Add(this.before_location_lbl);
            this.Controls.Add(this.UserCode_lbl);
            this.Controls.Add(this.qty_lbl);
            this.Controls.Add(this.asset_code_lbl);
            this.Name = "AddWareHouseForm";
            this.Text = "Edit Warehouse";
            this.TitleText = "Add Ware House";
            this.Load += new System.EventHandler(this.AddWareHouseForm_Load);
            this.Controls.SetChildIndex(this.asset_code_lbl, 0);
            this.Controls.SetChildIndex(this.qty_lbl, 0);
            this.Controls.SetChildIndex(this.UserCode_lbl, 0);
            this.Controls.SetChildIndex(this.before_location_lbl, 0);
            this.Controls.SetChildIndex(this.rank_name_cmb, 0);
            this.Controls.SetChildIndex(this.unit_cmb, 0);
            this.Controls.SetChildIndex(this.after_location_cmb, 0);
            this.Controls.SetChildIndex(this.before_location_cmb, 0);
            this.Controls.SetChildIndex(this.rank_name_lbl, 0);
            this.Controls.SetChildIndex(this.unit_lbl, 0);
            this.Controls.SetChildIndex(this.after_location_lbl, 0);
            this.Controls.SetChildIndex(this.asset_code_txt, 0);
            this.Controls.SetChildIndex(this.qty_txt, 0);
            this.Controls.SetChildIndex(this.ok_btn, 0);
            this.Controls.SetChildIndex(this.exit_btn, 0);
            this.Controls.SetChildIndex(this.timestart_dtp, 0);
            this.Controls.SetChildIndex(this.timestart_lbl, 0);
            this.Controls.SetChildIndex(this.comments_txt, 0);
            this.Controls.SetChildIndex(this.Comment_lbl, 0);
            this.Controls.SetChildIndex(this.user_location_code_txt, 0);
            this.Controls.SetChildIndex(this.user_location_name_lbl, 0);
            this.Controls.SetChildIndex(this.user_location_name_cbm, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.LabelCommon asset_code_lbl;
        private Framework.ComboBoxCommon rank_name_cmb;
        private Framework.LabelCommon rank_name_lbl;
        private Framework.LabelCommon qty_lbl;
        private Framework.ComboBoxCommon unit_cmb;
        private Framework.LabelCommon unit_lbl;
        private Framework.LabelCommon before_location_lbl;
        private Framework.ComboBoxCommon after_location_cmb;
        private Framework.LabelCommon after_location_lbl;
        private Framework.ComboBoxCommon before_location_cmb;
        private System.Windows.Forms.TextBox asset_code_txt;
        private System.Windows.Forms.TextBox qty_txt;
        private Framework.ButtonCommon exit_btn;
        private Framework.ButtonCommon ok_btn;
        private Framework.LabelCommon UserCode_lbl;
        private Framework.LabelCommon timestart_lbl;
        private Framework.DateTimePickerCommon timestart_dtp;
        private Framework.TextBoxCommon comments_txt;
        private Framework.LabelCommon Comment_lbl;
        private Framework.TextBoxCommon user_location_code_txt;
        private System.Windows.Forms.ComboBox user_location_name_cbm;
        private Framework.LabelCommon user_location_name_lbl;
    }
}
