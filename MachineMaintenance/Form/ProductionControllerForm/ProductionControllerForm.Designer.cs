namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    partial class ProductionControllerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductionControllerForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.model_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.model_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.line_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.line_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.timeto_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.timeto_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.timefrom_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.clear_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.setting_gbc = new Com.Nidec.Mes.Framework.GroupBoxCommon();
            this.update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.timefrom_dtp = new Com.Nidec.Mes.Framework.DateTimePickerCommon();
            this.date_rab = new Com.Nidec.Mes.Framework.RadioButtonCommon();
            this.time_rab = new Com.Nidec.Mes.Framework.RadioButtonCommon();
            this.production_controller_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.setting_gbc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.production_controller_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // model_lbl
            // 
            resources.ApplyResources(this.model_lbl, "model_lbl");
            this.model_lbl.ControlId = null;
            this.model_lbl.Name = "model_lbl";
            // 
            // model_cmb
            // 
            this.model_cmb.ControlId = null;
            resources.ApplyResources(this.model_cmb, "model_cmb");
            this.model_cmb.FormattingEnabled = true;
            this.model_cmb.Name = "model_cmb";
            // 
            // line_lbl
            // 
            resources.ApplyResources(this.line_lbl, "line_lbl");
            this.line_lbl.ControlId = null;
            this.line_lbl.Name = "line_lbl";
            // 
            // line_cmb
            // 
            this.line_cmb.ControlId = null;
            resources.ApplyResources(this.line_cmb, "line_cmb");
            this.line_cmb.FormattingEnabled = true;
            this.line_cmb.Name = "line_cmb";
            // 
            // timeto_lbl
            // 
            resources.ApplyResources(this.timeto_lbl, "timeto_lbl");
            this.timeto_lbl.ControlId = null;
            this.timeto_lbl.Name = "timeto_lbl";
            // 
            // timeto_dtp
            // 
            this.timeto_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timeto_dtp.ControlId = null;
            resources.ApplyResources(this.timeto_dtp, "timeto_dtp");
            this.timeto_dtp.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.timeto_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeto_dtp.Name = "timeto_dtp";
            // 
            // timefrom_lbl
            // 
            resources.ApplyResources(this.timefrom_lbl, "timefrom_lbl");
            this.timefrom_lbl.ControlId = null;
            this.timefrom_lbl.Name = "timefrom_lbl";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.search_btn.ControlId = null;
            resources.ApplyResources(this.search_btn, "search_btn");
            this.search_btn.Name = "search_btn";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_btn.ControlId = null;
            resources.ApplyResources(this.clear_btn, "clear_btn");
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.UseVisualStyleBackColor = false;
            // 
            // setting_gbc
            // 
            this.setting_gbc.ControlId = null;
            this.setting_gbc.Controls.Add(this.update_btn);
            this.setting_gbc.Controls.Add(this.add_btn);
            this.setting_gbc.Controls.Add(this.clear_btn);
            this.setting_gbc.Controls.Add(this.search_btn);
            resources.ApplyResources(this.setting_gbc, "setting_gbc");
            this.setting_gbc.Name = "setting_gbc";
            this.setting_gbc.TabStop = false;
            // 
            // update_btn
            // 
            this.update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.update_btn.ControlId = "mcfb008";
            resources.ApplyResources(this.update_btn, "update_btn");
            this.update_btn.Name = "update_btn";
            this.update_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.add_btn.ControlId = "mcfb007";
            resources.ApplyResources(this.add_btn, "add_btn");
            this.add_btn.Name = "add_btn";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // timefrom_dtp
            // 
            this.timefrom_dtp.BackColor = System.Drawing.SystemColors.Control;
            this.timefrom_dtp.ControlId = null;
            resources.ApplyResources(this.timefrom_dtp, "timefrom_dtp");
            this.timefrom_dtp.DisplayFormat = Com.Nidec.Mes.Framework.DateTimePickerCommon.DisplayFormatList.ShortDatePattern;
            this.timefrom_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timefrom_dtp.Name = "timefrom_dtp";
            // 
            // date_rab
            // 
            resources.ApplyResources(this.date_rab, "date_rab");
            this.date_rab.ControlId = null;
            this.date_rab.Name = "date_rab";
            this.date_rab.TabStop = true;
            this.date_rab.UseVisualStyleBackColor = true;
            // 
            // time_rab
            // 
            resources.ApplyResources(this.time_rab, "time_rab");
            this.time_rab.ControlId = null;
            this.time_rab.Name = "time_rab";
            this.time_rab.TabStop = true;
            this.time_rab.UseVisualStyleBackColor = true;
            // 
            // production_controller_dgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.production_controller_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.production_controller_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.production_controller_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.production_controller_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            resources.ApplyResources(this.production_controller_dgv, "production_controller_dgv");
            this.production_controller_dgv.Name = "production_controller_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.production_controller_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            // 
            // ProductionControllerForm
            // 
            resources.ApplyResources(this, "$this");
            this.ControlId = "";
            this.Controls.Add(this.production_controller_dgv);
            this.Controls.Add(this.time_rab);
            this.Controls.Add(this.date_rab);
            this.Controls.Add(this.timefrom_dtp);
            this.Controls.Add(this.setting_gbc);
            this.Controls.Add(this.timefrom_lbl);
            this.Controls.Add(this.line_cmb);
            this.Controls.Add(this.timeto_dtp);
            this.Controls.Add(this.timeto_lbl);
            this.Controls.Add(this.line_lbl);
            this.Controls.Add(this.model_cmb);
            this.Controls.Add(this.model_lbl);
            this.Name = "ProductionControllerForm";
            this.TitleText = "Production Controller";
            this.Controls.SetChildIndex(this.model_lbl, 0);
            this.Controls.SetChildIndex(this.model_cmb, 0);
            this.Controls.SetChildIndex(this.line_lbl, 0);
            this.Controls.SetChildIndex(this.timeto_lbl, 0);
            this.Controls.SetChildIndex(this.timeto_dtp, 0);
            this.Controls.SetChildIndex(this.line_cmb, 0);
            this.Controls.SetChildIndex(this.timefrom_lbl, 0);
            this.Controls.SetChildIndex(this.setting_gbc, 0);
            this.Controls.SetChildIndex(this.timefrom_dtp, 0);
            this.Controls.SetChildIndex(this.date_rab, 0);
            this.Controls.SetChildIndex(this.time_rab, 0);
            this.Controls.SetChildIndex(this.production_controller_dgv, 0);
            this.setting_gbc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.production_controller_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.LabelCommon model_lbl;
        private Framework.ComboBoxCommon model_cmb;
        private Framework.LabelCommon line_lbl;
        private Framework.ComboBoxCommon line_cmb;
        private Framework.LabelCommon timeto_lbl;
        private Framework.DateTimePickerCommon timeto_dtp;
        private Framework.LabelCommon timefrom_lbl;
        private Framework.ButtonCommon search_btn;
        private Framework.ButtonCommon clear_btn;
        private Framework.GroupBoxCommon setting_gbc;
        private Framework.ButtonCommon add_btn;
        private Framework.ButtonCommon update_btn;
        private Framework.DateTimePickerCommon timefrom_dtp;
        private Framework.RadioButtonCommon date_rab;
        private Framework.RadioButtonCommon time_rab;
        private Framework.DataGridViewCommon production_controller_dgv;
    }
}
