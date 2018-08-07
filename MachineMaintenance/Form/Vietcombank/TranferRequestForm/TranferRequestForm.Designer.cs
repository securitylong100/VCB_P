namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance
{
    partial class TranferRequestForm
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
            this.Exit_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Delete_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Update_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Add_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.Search_btn = new Com.Nidec.Mes.Framework.ButtonCommon();
            this.TranferRequest_dgv = new Com.Nidec.Mes.Framework.DataGridViewCommon();
            this.colRequestId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserNameRequest = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRequestDateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserNameProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFunction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateConfirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.function_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.functionname_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.department_cbm = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.department_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            this.sent_rei_cmb = new Com.Nidec.Mes.Framework.ComboBoxCommon();
            this.sent_rei_lbl = new Com.Nidec.Mes.Framework.LabelCommon();
            ((System.ComponentModel.ISupportInitialize)(this.TranferRequest_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Exit_btn.ControlId = null;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit_btn.Location = new System.Drawing.Point(516, 174);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 33);
            this.Exit_btn.TabIndex = 22;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_btn.ControlId = null;
            this.Delete_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Delete_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_btn.Location = new System.Drawing.Point(371, 174);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(80, 33);
            this.Delete_btn.TabIndex = 21;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Update_btn.ControlId = null;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Update_btn.Location = new System.Drawing.Point(243, 174);
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
            this.Add_btn.Location = new System.Drawing.Point(138, 174);
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
            this.Search_btn.Location = new System.Drawing.Point(30, 174);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(80, 33);
            this.Search_btn.TabIndex = 16;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // TranferRequest_dgv
            // 
            this.TranferRequest_dgv.AllowUserToAddRows = false;
            this.TranferRequest_dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TranferRequest_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.TranferRequest_dgv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TranferRequest_dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TranferRequest_dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRequestId,
            this.colRequestCode,
            this.colUserNameRequest,
            this.colDepartment,
            this.colRequestDateTime,
            this.colUserNameProcess,
            this.colFunction,
            this.colType,
            this.colHeader,
            this.colContent,
            this.colStatus,
            this.colComment,
            this.colDateConfirm});
            this.TranferRequest_dgv.ControlId = null;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TranferRequest_dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.TranferRequest_dgv.Location = new System.Drawing.Point(0, 213);
            this.TranferRequest_dgv.Name = "TranferRequest_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TranferRequest_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TranferRequest_dgv.RowHeadersWidth = 15;
            this.TranferRequest_dgv.Size = new System.Drawing.Size(1165, 375);
            this.TranferRequest_dgv.TabIndex = 76;
            this.TranferRequest_dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TranferRequest_dgv_CellClick);
            // 
            // colRequestId
            // 
            this.colRequestId.DataPropertyName = "RequestId";
            this.colRequestId.HeaderText = "RequestId";
            this.colRequestId.Name = "colRequestId";
            this.colRequestId.Visible = false;
            this.colRequestId.Width = 89;
            // 
            // colRequestCode
            // 
            this.colRequestCode.DataPropertyName = "RequestCode";
            this.colRequestCode.HeaderText = "RequestCode";
            this.colRequestCode.Name = "colRequestCode";
            this.colRequestCode.Width = 109;
            // 
            // colUserNameRequest
            // 
            this.colUserNameRequest.DataPropertyName = "UserNameRequest";
            this.colUserNameRequest.HeaderText = "User Request";
            this.colUserNameRequest.Name = "colUserNameRequest";
            this.colUserNameRequest.Width = 109;
            // 
            // colDepartment
            // 
            this.colDepartment.DataPropertyName = "DepartmentName";
            this.colDepartment.HeaderText = "Department Request";
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.Width = 147;
            // 
            // colRequestDateTime
            // 
            this.colRequestDateTime.DataPropertyName = "RequestDateTime";
            this.colRequestDateTime.HeaderText = "DateTime Request";
            this.colRequestDateTime.Name = "colRequestDateTime";
            this.colRequestDateTime.Width = 136;
            // 
            // colUserNameProcess
            // 
            this.colUserNameProcess.DataPropertyName = "UserNameProcess";
            this.colUserNameProcess.HeaderText = "User Name Process";
            this.colUserNameProcess.Name = "colUserNameProcess";
            this.colUserNameProcess.Width = 145;
            // 
            // colFunction
            // 
            this.colFunction.DataPropertyName = "FunctionDeptName";
            this.colFunction.HeaderText = "Function";
            this.colFunction.Name = "colFunction";
            this.colFunction.Width = 79;
            // 
            // colType
            // 
            this.colType.DataPropertyName = "TypeList";
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            this.colType.Width = 57;
            // 
            // colHeader
            // 
            this.colHeader.DataPropertyName = "RequestHeader";
            this.colHeader.HeaderText = "Header";
            this.colHeader.Name = "colHeader";
            this.colHeader.Width = 73;
            // 
            // colContent
            // 
            this.colContent.DataPropertyName = "RequestContents";
            this.colContent.HeaderText = "Content";
            this.colContent.Name = "colContent";
            this.colContent.Width = 75;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "ProcessStatusCheck";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colStatus.Width = 67;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "ProcessComments";
            this.colComment.HeaderText = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Width = 87;
            // 
            // colDateConfirm
            // 
            this.colDateConfirm.DataPropertyName = "ProcessDateTime";
            this.colDateConfirm.HeaderText = "Date Confirm";
            this.colDateConfirm.Name = "colDateConfirm";
            this.colDateConfirm.Width = 105;
            // 
            // function_cmb
            // 
            this.function_cmb.ControlId = null;
            this.function_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.function_cmb.FormattingEnabled = true;
            this.function_cmb.Location = new System.Drawing.Point(30, 135);
            this.function_cmb.Name = "function_cmb";
            this.function_cmb.Size = new System.Drawing.Size(128, 23);
            this.function_cmb.TabIndex = 80;
            // 
            // functionname_lbl
            // 
            this.functionname_lbl.AutoSize = true;
            this.functionname_lbl.ControlId = null;
            this.functionname_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.functionname_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.functionname_lbl.Location = new System.Drawing.Point(27, 117);
            this.functionname_lbl.Name = "functionname_lbl";
            this.functionname_lbl.Size = new System.Drawing.Size(91, 15);
            this.functionname_lbl.TabIndex = 79;
            this.functionname_lbl.Text = "Function Name";
            // 
            // department_cbm
            // 
            this.department_cbm.ControlId = null;
            this.department_cbm.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_cbm.FormattingEnabled = true;
            this.department_cbm.Location = new System.Drawing.Point(207, 135);
            this.department_cbm.Name = "department_cbm";
            this.department_cbm.Size = new System.Drawing.Size(128, 23);
            this.department_cbm.TabIndex = 82;
            // 
            // department_lbl
            // 
            this.department_lbl.AutoSize = true;
            this.department_lbl.ControlId = null;
            this.department_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.department_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.department_lbl.Location = new System.Drawing.Point(204, 117);
            this.department_lbl.Name = "department_lbl";
            this.department_lbl.Size = new System.Drawing.Size(122, 15);
            this.department_lbl.TabIndex = 81;
            this.department_lbl.Text = "Department Request";
            // 
            // sent_rei_cmb
            // 
            this.sent_rei_cmb.ControlId = null;
            this.sent_rei_cmb.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sent_rei_cmb.FormattingEnabled = true;
            this.sent_rei_cmb.Items.AddRange(new object[] {
            "Sent",
            "Received"});
            this.sent_rei_cmb.Location = new System.Drawing.Point(371, 135);
            this.sent_rei_cmb.Name = "sent_rei_cmb";
            this.sent_rei_cmb.Size = new System.Drawing.Size(128, 23);
            this.sent_rei_cmb.TabIndex = 86;
            this.sent_rei_cmb.Text = "Received";
            // 
            // sent_rei_lbl
            // 
            this.sent_rei_lbl.AutoSize = true;
            this.sent_rei_lbl.ControlId = null;
            this.sent_rei_lbl.Font = new System.Drawing.Font("Arial", 9F);
            this.sent_rei_lbl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.sent_rei_lbl.Location = new System.Drawing.Point(368, 117);
            this.sent_rei_lbl.Name = "sent_rei_lbl";
            this.sent_rei_lbl.Size = new System.Drawing.Size(86, 15);
            this.sent_rei_lbl.TabIndex = 85;
            this.sent_rei_lbl.Text = "Sent/Received";
            // 
            // TranferRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1165, 588);
            this.Controls.Add(this.sent_rei_cmb);
            this.Controls.Add(this.sent_rei_lbl);
            this.Controls.Add(this.department_cbm);
            this.Controls.Add(this.department_lbl);
            this.Controls.Add(this.function_cmb);
            this.Controls.Add(this.functionname_lbl);
            this.Controls.Add(this.TranferRequest_dgv);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.Search_btn);
            this.Name = "TranferRequestForm";
            this.TitleText = "FormCommon";
            this.Load += new System.EventHandler(this.TranferRequestForm_Load);
            this.Controls.SetChildIndex(this.Search_btn, 0);
            this.Controls.SetChildIndex(this.Add_btn, 0);
            this.Controls.SetChildIndex(this.Update_btn, 0);
            this.Controls.SetChildIndex(this.Delete_btn, 0);
            this.Controls.SetChildIndex(this.Exit_btn, 0);
            this.Controls.SetChildIndex(this.TranferRequest_dgv, 0);
            this.Controls.SetChildIndex(this.functionname_lbl, 0);
            this.Controls.SetChildIndex(this.function_cmb, 0);
            this.Controls.SetChildIndex(this.department_lbl, 0);
            this.Controls.SetChildIndex(this.department_cbm, 0);
            this.Controls.SetChildIndex(this.sent_rei_lbl, 0);
            this.Controls.SetChildIndex(this.sent_rei_cmb, 0);
            ((System.ComponentModel.ISupportInitialize)(this.TranferRequest_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Framework.ButtonCommon Exit_btn;
        private Framework.ButtonCommon Delete_btn;
        private Framework.ButtonCommon Update_btn;
        private Framework.ButtonCommon Add_btn;
        private Framework.ButtonCommon Search_btn;
        private Framework.DataGridViewCommon TranferRequest_dgv;
        private Framework.ComboBoxCommon function_cmb;
        private Framework.LabelCommon functionname_lbl;
        private Framework.ComboBoxCommon department_cbm;
        private Framework.LabelCommon department_lbl;
        private Framework.ComboBoxCommon sent_rei_cmb;
        private Framework.LabelCommon sent_rei_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserNameRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestDateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserNameProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunction;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateConfirm;
    }
}
