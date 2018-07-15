namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance
{
    partial class FunctionDepartmentForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Clear_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Exit_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Delete_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.FunctionName_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.FunctionCode_txt = new Com.Nidec.Mes.Framework.TextBoxCommon();
            this.DeptCode_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.DeptCode_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.functioncode_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.functionname_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.FunctionDeptDetails_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.colFunctionDeptId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartmentCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFunctionDeptCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFunctionDeptName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistrationUserCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRegistrationDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFactoryCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FunctionDeptDetails_dgv)).BeginInit();
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
            this.Exit_btn.Location = new System.Drawing.Point(652, 543);
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
            this.Delete_btn.Location = new System.Drawing.Point(558, 543);
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
            this.Update_btn.Location = new System.Drawing.Point(464, 543);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(80, 33);
            this.Update_btn.TabIndex = 20;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
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
            // FunctionName_txt
            // 
            this.FunctionName_txt.ControlId = null;
            this.FunctionName_txt.Font = new System.Drawing.Font("Arial", 9F);
            this.FunctionName_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.FunctionName_txt.Location = new System.Drawing.Point(130, 181);
            this.FunctionName_txt.MaxLength = 32;
            this.FunctionName_txt.Name = "FunctionName_txt";
            this.FunctionName_txt.Size = new System.Drawing.Size(187, 21);
            this.FunctionName_txt.TabIndex = 15;
            // 
            // FunctionCode_txt
            // 
            this.FunctionCode_txt.ControlId = null;
            this.FunctionCode_txt.Font = new System.Drawing.Font("Arial", 9F);
            this.FunctionCode_txt.InputType = Com.Nidec.Mes.Framework.TextBoxCommon.InputTypeList.All;
            this.FunctionCode_txt.Location = new System.Drawing.Point(130, 151);
            this.FunctionCode_txt.MaxLength = 32;
            this.FunctionCode_txt.Name = "FunctionCode_txt";
            this.FunctionCode_txt.Size = new System.Drawing.Size(187, 21);
            this.FunctionCode_txt.TabIndex = 13;
            // 
            // DeptCode_lbl
            // 
            this.DeptCode_lbl.AutoSize = true;
            this.DeptCode_lbl.ControlId = null;
            this.DeptCode_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.DeptCode_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeptCode_lbl.Location = new System.Drawing.Point(54, 123);
            this.DeptCode_lbl.Name = "DeptCode_lbl";
            this.DeptCode_lbl.Size = new System.Drawing.Size(66, 15);
            this.DeptCode_lbl.TabIndex = 12;
            this.DeptCode_lbl.Text = "Dept Code";
            // 
            // DeptCode_cmb
            // 
            this.DeptCode_cmb.ControlId = null;
            this.DeptCode_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeptCode_cmb.FormattingEnabled = true;
            this.DeptCode_cmb.Location = new System.Drawing.Point(130, 120);
            this.DeptCode_cmb.Name = "DeptCode_cmb";
            this.DeptCode_cmb.Size = new System.Drawing.Size(187, 23);
            this.DeptCode_cmb.TabIndex = 23;
            // 
            // functioncode_lbl
            // 
            this.functioncode_lbl.AutoSize = true;
            this.functioncode_lbl.ControlId = null;
            this.functioncode_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.functioncode_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.functioncode_lbl.Location = new System.Drawing.Point(33, 155);
            this.functioncode_lbl.Name = "functioncode_lbl";
            this.functioncode_lbl.Size = new System.Drawing.Size(87, 15);
            this.functioncode_lbl.TabIndex = 24;
            this.functioncode_lbl.Text = "Fucntion Code";
            // 
            // functionname_lbl
            // 
            this.functionname_lbl.AutoSize = true;
            this.functionname_lbl.ControlId = null;
            this.functionname_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.functionname_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.functionname_lbl.Location = new System.Drawing.Point(30, 181);
            this.functionname_lbl.Name = "functionname_lbl";
            this.functionname_lbl.Size = new System.Drawing.Size(91, 15);
            this.functionname_lbl.TabIndex = 25;
            this.functionname_lbl.Text = "Function Name";
            // 
            // FunctionDeptDetails_dgv
            // 
            this.FunctionDeptDetails_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FunctionDeptDetails_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.FunctionDeptDetails_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FunctionDeptDetails_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.FunctionDeptDetails_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFunctionDeptId,
            this.colDepartmentCode,
            this.colFunctionDeptCode,
            this.colFunctionDeptName,
            this.colRegistrationUserCode,
            this.colRegistrationDateTime,
            this.colFactoryCode});
            this.FunctionDeptDetails_dgv.ControlId = null;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FunctionDeptDetails_dgv.DefaultCellStyle = dataGridViewCellStyle5;
            this.FunctionDeptDetails_dgv.Location = new System.Drawing.Point(2, 218);
            this.FunctionDeptDetails_dgv.Name = "FunctionDeptDetails_dgv";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FunctionDeptDetails_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.FunctionDeptDetails_dgv.Size = new System.Drawing.Size(733, 319);
            this.FunctionDeptDetails_dgv.TabIndex = 76;
            // 
            // colFunctionDeptId
            // 
            this.colFunctionDeptId.DataPropertyName = "FunctionDeptId";
            this.colFunctionDeptId.HeaderText = "Function Dept Id";
            this.colFunctionDeptId.Name = "colFunctionDeptId";
            this.colFunctionDeptId.Width = 121;
            // 
            // colDepartmentCode
            // 
            this.colDepartmentCode.DataPropertyName = "DepartmentCode";
            this.colDepartmentCode.HeaderText = "Department Code";
            this.colDepartmentCode.Name = "colDepartmentCode";
            this.colDepartmentCode.Width = 130;
            // 
            // colFunctionDeptCode
            // 
            this.colFunctionDeptCode.DataPropertyName = "FunctionDeptCode";
            this.colFunctionDeptCode.HeaderText = "Function Dept Code";
            this.colFunctionDeptCode.Name = "colFunctionDeptCode";
            this.colFunctionDeptCode.Width = 141;
            // 
            // colFunctionDeptName
            // 
            this.colFunctionDeptName.DataPropertyName = "FunctionDeptName";
            this.colFunctionDeptName.HeaderText = "Function Dept Name";
            this.colFunctionDeptName.Name = "colFunctionDeptName";
            this.colFunctionDeptName.Width = 145;
            // 
            // colRegistrationUserCode
            // 
            this.colRegistrationUserCode.DataPropertyName = "RegistrationUserCode";
            this.colRegistrationUserCode.HeaderText = "RegistrationUserCode";
            this.colRegistrationUserCode.Name = "colRegistrationUserCode";
            this.colRegistrationUserCode.Width = 156;
            // 
            // colRegistrationDateTime
            // 
            this.colRegistrationDateTime.DataPropertyName = "RegistrationDateTime";
            this.colRegistrationDateTime.HeaderText = "RegistrationDateTime";
            this.colRegistrationDateTime.Name = "colRegistrationDateTime";
            this.colRegistrationDateTime.Width = 153;
            // 
            // colFactoryCode
            // 
            this.colFactoryCode.DataPropertyName = "FactoryCode";
            this.colFactoryCode.HeaderText = "FactoryCode";
            this.colFactoryCode.Name = "colFactoryCode";
            this.colFactoryCode.Width = 101;
            // 
            // FunctionDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(735, 588);
            this.Controls.Add(this.FunctionDeptDetails_dgv);
            this.Controls.Add(this.functionname_lbl);
            this.Controls.Add(this.functioncode_lbl);
            this.Controls.Add(this.DeptCode_cmb);
            this.Controls.Add(this.Clear_btn);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.FunctionName_txt);
            this.Controls.Add(this.FunctionCode_txt);
            this.Controls.Add(this.DeptCode_lbl);
            this.Name = "FunctionDepartmentForm";
            this.Load += new System.EventHandler(this.FunctionDepartmentForm_Load);
            this.Controls.SetChildIndex(this.DeptCode_lbl, 0);
            this.Controls.SetChildIndex(this.FunctionCode_txt, 0);
            this.Controls.SetChildIndex(this.FunctionName_txt, 0);
            this.Controls.SetChildIndex(this.Search_btn, 0);
            this.Controls.SetChildIndex(this.Add_btn, 0);
            this.Controls.SetChildIndex(this.Update_btn, 0);
            this.Controls.SetChildIndex(this.Delete_btn, 0);
            this.Controls.SetChildIndex(this.Exit_btn, 0);
            this.Controls.SetChildIndex(this.Clear_btn, 0);
            this.Controls.SetChildIndex(this.DeptCode_cmb, 0);
            this.Controls.SetChildIndex(this.functioncode_lbl, 0);
            this.Controls.SetChildIndex(this.functionname_lbl, 0);
            this.Controls.SetChildIndex(this.FunctionDeptDetails_dgv, 0);
            ((System.ComponentModel.ISupportInitialize)(this.FunctionDeptDetails_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.ButtonCommon Clear_btn;
        private Framework.ButtonCommon Exit_btn;
        private Framework.ButtonCommon Delete_btn;
        private Framework.ButtonCommon Update_btn;
        private Framework.ButtonCommon Add_btn;
        private Framework.ButtonCommon Search_btn;
        private Framework.TextBoxCommon FunctionName_txt;
        private Framework.TextBoxCommon FunctionCode_txt;
        private Framework.LabelCommon DeptCode_lbl;
        private Framework.ComboBoxCommon DeptCode_cmb;
        private Framework.LabelCommon functioncode_lbl;
        private Framework.LabelCommon functionname_lbl;
        private Framework.DataGridViewCommon FunctionDeptDetails_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunctionDeptId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartmentCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunctionDeptCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunctionDeptName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegistrationUserCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRegistrationDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFactoryCode;
    }
}
