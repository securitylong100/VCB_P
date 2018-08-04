using System;
using System.Windows.Forms;
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
            GridBind(3);
        }
        private void GridBind(int sent_reiceive)
        {
            try
            {
                TranferRequestVo invo = new TranferRequestVo()
                {
                    FunctionDeptName = function_cmb.Text,
                    DepartmentName = department_cbm.Text,
                    SentReceive = sent_reiceive,
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
            GridBind(3);
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
                            GridBind(3);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn không có quyền xóa dòng này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {

                }
            }
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {

        }

        private void sent_btn_Click(object sender, EventArgs e)//SentReceive = 1
        {
            GridBind(1);
        }

        private void receive_btn_Click(object sender, EventArgs e)
        {
            GridBind(2);
        }

        private void TranferRequest_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = TranferRequest_dgv.CurrentCell.RowIndex;
            //if(TranferRequest_dgv.Rows[rowIndex].Cells["colStatus"].Selected)
            //{
                DataGridViewCheckBoxCell cellkbox = TranferRequest_dgv.Rows[rowIndex].Cells["colStatus"] as DataGridViewCheckBoxCell;
                if(cellkbox != null)
                {
                    if(cellkbox.Value == cellkbox.TrueValue)
                    {
                        MessageBox.Show(cellkbox.Value.ToString());
                    }
                }
                
                //string a = TranferRequest_dgv.Rows[rowIndex].Cells["colStatus"].Value.ToString();
                //if (bool.Parse(TranferRequest_dgv.Rows[rowIndex].Cells["colStatus"].Value.ToString()) == false)
                //{
                //    DateTime dt = DateTime.Now;
                //    TranferRequest_dgv.Rows[rowIndex].Cells["colDateConfirm"].Value = dt;
                //}
                //else if (bool.Parse(TranferRequest_dgv.Rows[rowIndex].Cells["colStatus"].Value.ToString()) == true)
                //{
                //    TranferRequest_dgv.Rows[rowIndex].Cells["colDateConfirm"].Value = "";
                //}
            //}
        }
    }


}
