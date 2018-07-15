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
    public partial class DepartmentForm : FormCommonNCVP
    {
        public DepartmentForm()
        {
            InitializeComponent();
        }
        private void GridBind()
        {
            DeptDetails_dgv.DataSource = null;
            try
            {
                DepartmentVo vo = new DepartmentVo
                {
                    DepartmentCode = DeptCode_txt.Text,
                    DepartmentName = DeptName_txt.Text
                };

                ValueObjectList<DepartmentVo> volist = (ValueObjectList<DepartmentVo>)DefaultCbmInvoker.Invoke(new GetDepartmentVCBCbm(), vo);
                if (volist.GetList() != null && volist.GetList().Count > 0)
                {
                    DeptDetails_dgv.AutoGenerateColumns = false;
                    BindingSource bindingsource = new BindingSource(volist.GetList(), null);
                    DeptDetails_dgv.DataSource = bindingsource;
                }
                else
                {
                    messageData = new MessageData("mmci00006", Properties.Resources.mmci00006, null);
                    logger.Info(messageData);
                    popUpMessage.Information(messageData, Text);
                }
                DeptDetails_dgv.ClearSelection();
                Update_btn.Enabled = false;
                Delete_btn.Enabled = false;
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }
        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddDepartmentForm Formadd = new AddDepartmentForm();
            Formadd.vo = new DepartmentVo();
            if (Formadd.ShowDialog() == DialogResult.OK)
            {
                GridBind();
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {

            DeptCode_txt.Text = string.Empty;
            DeptName_txt.Text = string.Empty;
            DeptDetails_dgv.DataSource = null;
            Update_btn.Enabled = Delete_btn.Enabled = false;
            DeptCode_txt.Select();

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (DeptDetails_dgv.SelectedRows.Count > 0)
            {
                BindUpdateCavityData();
            }
        }
        private void BindUpdateCavityData()
        {
            int selectedrowindex = DeptDetails_dgv.SelectedCells[0].RowIndex;

            DepartmentVo vo = (DepartmentVo)DeptDetails_dgv.Rows[selectedrowindex].DataBoundItem;

            AddDepartmentForm addform = new AddDepartmentForm();
            addform.vo = vo;
            addform.ShowDialog();
            if (addform.IntSuccess > 0)
            {
                messageData = new MessageData("mmci00002", Properties.Resources.mmci00002, null);
                logger.Info(messageData);
                popUpMessage.Information(messageData, Text);

                GridBind();
            }
            else if (addform.IntSuccess == 0)
            {
                messageData = new MessageData("mmci00007", Properties.Resources.mmci00007, null);
                logger.Info(messageData);
                popUpMessage.Information(messageData, Text);
                GridBind();
            }


        }
        private void Delete_btn_Click(object sender, EventArgs e)
        {

            if (DeptDetails_dgv.SelectedRows.Count > 0)
            {
                int selectedrowindex = DeptDetails_dgv.SelectedCells[0].RowIndex;

                DepartmentVo vo = (DepartmentVo)DeptDetails_dgv.Rows[selectedrowindex].DataBoundItem;

                messageData = new MessageData("mmcc00004", Properties.Resources.mmcc00004, vo.DepartmentCode);
                logger.Info(messageData);
                DialogResult dialogResult = popUpMessage.ConfirmationOkCancel(messageData, Text);

                if (dialogResult == DialogResult.OK)
                {
                    try
                    {
                        DepartmentVo outVo = (DepartmentVo)DefaultCbmInvoker.Invoke(new DeleteDepartmentVCBCbm(), vo);

                        if (outVo.AffectedCount > 0)
                        {
                            messageData = new MessageData("mmci00003", Properties.Resources.mmci00003, null);
                            logger.Info(messageData);
                            popUpMessage.Information(messageData, Text);

                            GridBind();
                        }
                        else if (outVo.AffectedCount == 0)
                        {
                            messageData = new MessageData("mmci00007", Properties.Resources.mmci00007, null);
                            logger.Info(messageData);
                            popUpMessage.Information(messageData, Text);
                            GridBind();
                        }
                    }
                    catch (Com.Nidec.Mes.Framework.ApplicationException exception)
                    {
                        popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                        logger.Error(exception.GetMessageData());
                    }
                }
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void Search_btn_Click(object sender, EventArgs e)
        {
            GridBind();
        }

        private void DepartmentDetails_dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Update_btn.Enabled = Delete_btn.Enabled = DeptDetails_dgv.SelectedRows.Count > 0;
        }

        private void DepartmentDetails_dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DeptDetails_dgv.SelectedRows.Count > 0)
            {
                BindUpdateCavityData();
            }
        }
    }
}
