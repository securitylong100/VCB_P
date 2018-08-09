﻿using System;
using System.Windows.Forms;
using System.Drawing;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance
{
    public partial class TranferRequestForm : FormCommonNCVP
    {
        public TranferRequestForm()
        {
            InitializeComponent();
            TranferRequest_dgv.AutoGenerateColumns = false;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddTranferRequestForm addtrffer = new AddTranferRequestForm();
            addtrffer.ShowDialog();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            GridBind();
            alarmcolor();
            editGridBindsent();
        }
        void editGridBindsent()
        {
            if (TranferRequest_dgv.RowCount > 1 && sent_rei_cmb.Text == "Sent")
                for (int i = 0; i < TranferRequest_dgv.RowCount - 1; i++)
                {
                    for (int j = 0; j < TranferRequest_dgv.ColumnCount; j++)
                    {
                        if (j != 7)
                        {
                            if (TranferRequest_dgv.Rows[i].Cells[j].Value.ToString() == TranferRequest_dgv.Rows[i + 1].Cells[j].Value.ToString())
                            { //
                                if (TranferRequest_dgv.Rows[i].Cells["colType"].Value.ToString() == "cc")
                                    TranferRequest_dgv.Rows.RemoveAt(this.TranferRequest_dgv.SelectedRows[i].Index);
                            }
                        }
                    }
                }

        }
        void alarmcolor()
        {
            if (TranferRequest_dgv.RowCount > 0)
            {
                for (int i = 0; i < TranferRequest_dgv.RowCount; i++)

                {
                    if (sent_rei_cmb.Text == "Sent" && TranferRequest_dgv.Rows[i].Cells["colStatus"].Value.ToString() == "False" && TranferRequest_dgv.Rows[i].Cells["colType"].Value.ToString() == "To") //mail sent chua check
                        TranferRequest_dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(0, 206, 209);
                    if (sent_rei_cmb.Text == "Received" && TranferRequest_dgv.Rows[i].Cells["colStatus"].Value.ToString() == "False" && TranferRequest_dgv.Rows[i].Cells["colType"].Value.ToString() == "To")//mail nhan ma chua check cua to
                        TranferRequest_dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 69, 0);
                    if (sent_rei_cmb.Text == "Received" && TranferRequest_dgv.Rows[i].Cells["colStatus"].Value.ToString() == "False" && TranferRequest_dgv.Rows[i].Cells["colType"].Value.ToString() == "cc")//mail nhan ma chua check cua cc
                        TranferRequest_dgv.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(255, 193, 37);
                }
            }
        }
        private void GridBind()
        {
            try
            {
                TranferRequestVo invo = new TranferRequestVo()
                {
                    FunctionDeptName = function_cmb.Text,
                    DepartmentName = department_cbm.Text,
                    SentReceive = sent_rei_cmb.Text,
                };
                ValueObjectList<TranferRequestVo> listvo = (ValueObjectList<TranferRequestVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchTranferRequestVCBCbm(), invo);
                TranferRequest_dgv.DataSource = listvo.GetList();

            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }

        private void TranferRequestForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<TranferRequestVo> function = (ValueObjectList<TranferRequestVo>)DefaultCbmInvoker.Invoke(new GetFunctionNameCbm(), new TranferRequestVo());
            function_cmb.DataSource = function.GetList();
            function_cmb.DisplayMember = "FunctionDeptName";
            function_cmb.Text = "";

            ValueObjectList<TranferRequestVo> department = (ValueObjectList<TranferRequestVo>)DefaultCbmInvoker.Invoke(new GetDepartMentCbm(), new TranferRequestVo());
            department_cbm.DataSource = department.GetList();
            department_cbm.DisplayMember = "DepartmentName";
            department_cbm.Text = "";
            GridBind();
            alarmcolor();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (TranferRequest_dgv.RowCount > 0 && TranferRequest_dgv.DataSource != null)
            {
                try
                {
                    int rowIndex = TranferRequest_dgv.CurrentCell.RowIndex;
                    string user = TranferRequest_dgv.Rows[rowIndex].Cells["colUserNameRequest"].Value.ToString();
                    if (user == UserData.GetUserData().UserName)
                    {
                        if (MessageBox.Show("Do you want to delete this rows !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            TranferRequestVo transfervo = (TranferRequestVo)TranferRequest_dgv.CurrentRow.DataBoundItem;
                            TranferRequestVo outVo = (TranferRequestVo)DefaultCbmInvoker.Invoke(new DeleteTransferRequestCbm(), transfervo);
                            if (outVo.AffectedCount > 0)
                            {
                                messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, "Error");
                                logger.Info(messageData);
                                popUpMessage.Information(messageData, Text);
                            }
                            GridBind();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền xóa dòng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                }
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (TranferRequest_dgv.RowCount > 0 && sent_rei_cmb.Text == "Received")
            {
                TranferRequestVo updatevo = (TranferRequestVo)TranferRequest_dgv.CurrentRow.DataBoundItem;
                if (updatevo.TypeList == "To")
                {
                    TranferRequestVo update = (TranferRequestVo)DefaultCbmInvoker.Invoke(new UpdateTransferVCBCbm(), updatevo);

                }

            }
            else
            {
                MessageBox.Show("Bạn không có quyền Update dòng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TranferRequest_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = TranferRequest_dgv.CurrentCell.RowIndex;
            //if(TranferRequest_dgv.Rows[rowIndex].Cells["colStatus"].Selected)
            //{
            DataGridViewCheckBoxCell cellkbox = TranferRequest_dgv.Rows[rowIndex].Cells["colStatus"] as DataGridViewCheckBoxCell;
            if (cellkbox != null)
            {
                if (cellkbox.Value == cellkbox.TrueValue)
                {
                    MessageBox.Show(cellkbox.Value.ToString());
                }
            }
        }
    }
}
