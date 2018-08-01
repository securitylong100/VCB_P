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
            this.colFunctionDeptRequestCd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFunctionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHeader = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colComment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDateConfirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TranferRequest_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Exit_btn.ControlId = null;
            this.Exit_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit_btn.Location = new System.Drawing.Point(516, 193);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(80, 33);
            this.Exit_btn.TabIndex = 22;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            // 
            // Delete_btn
            // 
            this.Delete_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Delete_btn.ControlId = null;
            this.Delete_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Delete_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Delete_btn.Location = new System.Drawing.Point(371, 193);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(80, 33);
            this.Delete_btn.TabIndex = 21;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            // 
            // Update_btn
            // 
            this.Update_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Update_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Update_btn.ControlId = null;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Update_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Update_btn.Location = new System.Drawing.Point(243, 193);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(80, 33);
            this.Update_btn.TabIndex = 20;
            this.Update_btn.Text = "Update";
            this.Update_btn.UseVisualStyleBackColor = true;
            // 
            // Add_btn
            // 
            this.Add_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Add_btn.ControlId = null;
            this.Add_btn.Font = new System.Drawing.Font("Arial", 9F);
            this.Add_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Add_btn.Location = new System.Drawing.Point(124, 193);
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
            this.Search_btn.Location = new System.Drawing.Point(30, 193);
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
            this.colFunctionDeptRequestCd,
            this.colFunctionName,
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
            this.TranferRequest_dgv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TranferRequest_dgv.Location = new System.Drawing.Point(0, 232);
            this.TranferRequest_dgv.Name = "TranferRequest_dgv";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(232)))), ((int)(((byte)(180)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TranferRequest_dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TranferRequest_dgv.Size = new System.Drawing.Size(1165, 356);
            this.TranferRequest_dgv.TabIndex = 76;
            // 
            // colRequestId
            // 
            this.colRequestId.DataPropertyName = "RequestId ";
            this.colRequestId.HeaderText = "RequestId";
            this.colRequestId.Name = "colRequestId";
            this.colRequestId.Width = 89;
            // 
            // colRequestCode
            // 
            this.colRequestCode.HeaderText = "RequestCode";
            this.colRequestCode.Name = "colRequestCode";
            this.colRequestCode.Width = 109;
            // 
            // colFunctionDeptRequestCd
            // 
            this.colFunctionDeptRequestCd.HeaderText = "FunctionDeptRequestCd";
            this.colFunctionDeptRequestCd.Name = "colFunctionDeptRequestCd";
            this.colFunctionDeptRequestCd.Width = 168;
            // 
            // colFunctionName
            // 
            this.colFunctionName.DataPropertyName = "FunctionDeptName ";
            this.colFunctionName.HeaderText = "Function Name";
            this.colFunctionName.Name = "colFunctionName";
            this.colFunctionName.Width = 116;
            // 
            // colHeader
            // 
            this.colHeader.DataPropertyName = "RequestHeader ";
            this.colHeader.HeaderText = "Header";
            this.colHeader.Name = "colHeader";
            this.colHeader.Width = 73;
            // 
            // colContent
            // 
            this.colContent.DataPropertyName = "RequestContents ";
            this.colContent.HeaderText = "Content";
            this.colContent.Name = "colContent";
            this.colContent.Width = 75;
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "ProcessStatusCheck ";
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.Width = 67;
            // 
            // colComment
            // 
            this.colComment.DataPropertyName = "ProcessComments ";
            this.colComment.HeaderText = "Comment";
            this.colComment.Name = "colComment";
            this.colComment.Width = 87;
            // 
            // colDateConfirm
            // 
            this.colDateConfirm.DataPropertyName = "ProcessDateTime ";
            this.colDateConfirm.HeaderText = "Date Confirm";
            this.colDateConfirm.Name = "colDateConfirm";
            this.colDateConfirm.Width = 105;
            // 
            // TranferRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1165, 588);
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
            ((System.ComponentModel.ISupportInitialize)(this.TranferRequest_dgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Framework.ButtonCommon Exit_btn;
        private Framework.ButtonCommon Delete_btn;
        private Framework.ButtonCommon Update_btn;
        private Framework.ButtonCommon Add_btn;
        private Framework.ButtonCommon Search_btn;
        private Framework.DataGridViewCommon TranferRequest_dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRequestCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunctionDeptRequestCd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFunctionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHeader;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colComment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateConfirm;
    }
}
