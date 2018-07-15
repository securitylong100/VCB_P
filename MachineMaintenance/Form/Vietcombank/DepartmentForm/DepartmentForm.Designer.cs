namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance
{
    partial class DepartmentForm
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
            this.Clear_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Exit_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Delete_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.DeptDetails_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.colDepartmentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.DeptName_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.DeptName_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.DeptCode_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.DeptCode_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            ((System.ComponentModel.ISupportInitialize)(this.DeptDetails_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Clear_btn.ControlId = null;
            this.Clear_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Clear_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Clear_btn.Location = new System.Drawing.Point(655, 137);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(80, 33);
            this.Clear_btn.TabIndex = 18;
            this.Clear_btn.Text = "Clear";
            this.Clear_btn.UseVisualStyleBackColor = true;
            this.Clear_btn.Click += new System.EventHandler(this.Clear_btn_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Exit_btn.ControlId = null;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit_btn.Location = new System.Drawing.Point(652, 434);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 33);
            this.Exit_btn.TabIndex = 22;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_btn.ControlId = null;
            this.Delete_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Delete_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_btn.Location = new System.Drawing.Point(558, 434);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(80, 33);
            this.Delete_btn.TabIndex = 21;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Update_btn.ControlId = null;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Update_btn.Location = new System.Drawing.Point(464, 434);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(80, 33);
            this.Update_btn.TabIndex = 20;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // DeptDetails_dgv
            // 
            this.DeptDetails_dgv.AllowUserToAddRows = false;
            this.DeptDetails_dgv.AllowUserToDeleteRows = false;
            this.DeptDetails_dgv.AllowUserToOrderColumns = true;
            this.DeptDetails_dgv.AllowUserToResizeRows = false;
            this.DeptDetails_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeptDetails_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DeptDetails_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeptDetails_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDepartmentId,
            this.colDepartmentCode,
            this.colDepartmentName});
            this.DeptDetails_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeptDetails_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.DeptDetails_dgv.EnableHeadersVisualStyles = false;
            this.DeptDetails_dgv.Location = new System.Drawing.Point(-2, 176);
            this.DeptDetails_dgv.MultiSelect = false;
            this.DeptDetails_dgv.Name = "DeptDetails_dgv";
            this.DeptDetails_dgv.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeptDetails_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DeptDetails_dgv.RowHeadersVisible = false;
            this.DeptDetails_dgv.RowTemplate.Height = 21;
            this.DeptDetails_dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeptDetails_dgv.Size = new System.Drawing.Size(737, 252);
            this.DeptDetails_dgv.TabIndex = 19;
            this.DeptDetails_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentDetails_dgv_CellClick);
            this.DeptDetails_dgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DepartmentDetails_dgv_CellDoubleClick);
            // 
            // colDepartmentId
            // 
            this.colDepartmentId.DataPropertyName = "DepartmentId";
            this.colDepartmentId.HeaderText = "Department Id";
            this.colDepartmentId.Name = "colDepartmentId";
            this.colDepartmentId.ReadOnly = true;
            this.colDepartmentId.Visible = false;
            // 
            // colDepartmentCode
            // 
            this.colDepartmentCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartmentCode.DataPropertyName = "DepartmentCode";
            this.colDepartmentCode.HeaderText = "Department Code";
            this.colDepartmentCode.Name = "colDepartmentCode";
            this.colDepartmentCode.ReadOnly = true;
            // 
            // colDepartmentName
            // 
            this.colDepartmentName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDepartmentName.DataPropertyName = "DepartmentName";
            this.colDepartmentName.HeaderText = "Department Name";
            this.colDepartmentName.Name = "colDepartmentName";
            this.colDepartmentName.ReadOnly = true;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Add_btn.ControlId = null;
            this.Add_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_btn.Location = new System.Drawing.Point(561, 137);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(80, 33);
            this.Add_btn.TabIndex = 17;
            this.Add_btn.Text = "Add";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Search_btn
            // 
            this.Search_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Search_btn.ControlId = null;
            this.Search_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Search_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Search_btn.Location = new System.Drawing.Point(467, 137);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(80, 33);
            this.Search_btn.TabIndex = 16;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // DeptName_txt
            // 
            this.DeptName_txt.ControlId = null;
            this.DeptName_txt.Font = new System.Drawing.Font("Arial", 9F);
            this.DeptName_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.DeptName_txt.Location = new System.Drawing.Point(98, 143);
            this.DeptName_txt.MaxLength = 32;
            this.DeptName_txt.Name = "DeptName_txt";
            this.DeptName_txt.Size = new System.Drawing.Size(187, 21);
            this.DeptName_txt.TabIndex = 15;
            // 
            // DeptName_lbl
            // 
            this.DeptName_lbl.AutoSize = true;
            this.DeptName_lbl.ControlId = null;
            this.DeptName_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.DeptName_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeptName_lbl.Location = new System.Drawing.Point(12, 146);
            this.DeptName_lbl.Name = "DeptName_lbl";
            this.DeptName_lbl.Size = new System.Drawing.Size(70, 15);
            this.DeptName_lbl.TabIndex = 14;
            this.DeptName_lbl.Text = "Dept Name";
            // 
            // DeptCode_txt
            // 
            this.DeptCode_txt.ControlId = null;
            this.DeptCode_txt.Font = new System.Drawing.Font("Arial", 9F);
            this.DeptCode_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.DeptCode_txt.Location = new System.Drawing.Point(98, 113);
            this.DeptCode_txt.MaxLength = 32;
            this.DeptCode_txt.Name = "DeptCode_txt";
            this.DeptCode_txt.Size = new System.Drawing.Size(187, 21);
            this.DeptCode_txt.TabIndex = 13;
            // 
            // DeptCode_lbl
            // 
            this.DeptCode_lbl.AutoSize = true;
            this.DeptCode_lbl.ControlId = null;
            this.DeptCode_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.DeptCode_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeptCode_lbl.Location = new System.Drawing.Point(12, 116);
            this.DeptCode_lbl.Name = "DeptCode_lbl";
            this.DeptCode_lbl.Size = new System.Drawing.Size(66, 15);
            this.DeptCode_lbl.TabIndex = 12;
            this.DeptCode_lbl.Text = "Dept Code";
            // 
            // DepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(735, 479);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.DeptDetails_dgv);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.DeptName_txt);
            this.Controls.Add(this.DeptName_lbl);
            this.Controls.Add(this.DeptCode_txt);
            this.Controls.Add(this.DeptCode_lbl);
            this.Name = "DepartmentForm";
            this.Controls.SetChildIndex(this.DeptCode_lbl, 0);
            this.Controls.SetChildIndex(this.DeptCode_txt, 0);
            this.Controls.SetChildIndex(this.DeptName_lbl, 0);
            this.Controls.SetChildIndex(this.DeptName_txt, 0);
            this.Controls.SetChildIndex(this.Search_btn, 0);
            this.Controls.SetChildIndex(this.Add_btn, 0);
            this.Controls.SetChildIndex(this.DeptDetails_dgv, 0);
            this.Controls.SetChildIndex(this.Update_btn, 0);
            this.Controls.SetChildIndex(this.Delete_btn, 0);
            this.Controls.SetChildIndex(this.Exit_btn, 0);
            this.Controls.SetChildIndex(this.Clear_btn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DeptDetails_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.ButtonCommon Clear_btn;
        private Framework.ButtonCommon Exit_btn;
        private Framework.ButtonCommon Delete_btn;
        private Framework.ButtonCommon Update_btn;
        internal Framework.DataGridViewCommon DeptDetails_dgv;
        private Framework.ButtonCommon Add_btn;
        private Framework.ButtonCommon Search_btn;
        private Framework.TextBoxCommon DeptName_txt;
        private Framework.LabelCommon DeptName_lbl;
        private Framework.TextBoxCommon DeptCode_txt;
        private Framework.LabelCommon DeptCode_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentName;
    }
}
