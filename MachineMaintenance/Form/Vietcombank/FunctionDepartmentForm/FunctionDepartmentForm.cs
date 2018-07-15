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
    public partial class FunctionDepartmentForm : FormCommonNCVP
    {
        public FunctionDepartmentForm()
        {
            InitializeComponent();
            FunctionDeptDetails_dgv.AutoGenerateColumns = false;
            FunctionDeptDetails_dgv.ReadOnly = true;
        }
       
        private void FunctionDepartmentForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<DepartmentVo> machineserial = (ValueObjectList<DepartmentVo>)DefaultCbmInvoker.Invoke(new GetDepartmentVCBCbm(), new DepartmentVo());
            DeptCode_cmb.DisplayMember = "DepartmentCode";
            DeptCode_cmb.DataSource = machineserial.GetList();
            DeptCode_cmb.Text = "";
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            FunctionDeptDetails_dgv.DataSource = null;
            GridBind();
        }
        private void GridBind()
        {
            try
            {
                FunctionDeptVo invo = new FunctionDeptVo()
                {
                    DepartmentCode = DeptCode_cmb.Text,
                    FunctionDeptCode = FunctionCode_txt.Text,
                    FunctionDeptName = FunctionName_txt.Text,
                   
                    //AssetNo = 
                };

           
                    ValueObjectList<FunctionDeptVo> listvo = (ValueObjectList<FunctionDeptVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchFunctionDeptVCBCbm(), invo);
                FunctionDeptDetails_dgv.DataSource = listvo.GetList();
              
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }

        private void Clear_btn_Click(object sender, EventArgs e)
        {
            DeptCode_cmb.Text = "";
            FunctionCode_txt.Text = "";
            FunctionName_txt.Text  = "";
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddFuntionDepartmentForm addfunctiondept = new AddFuntionDepartmentForm();
            addfunctiondept.ShowDialog();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (FunctionDeptDetails_dgv.DataSource != null)
            {
                FunctionDeptVo selectedvo = (FunctionDeptVo)FunctionDeptDetails_dgv.CurrentRow.DataBoundItem;
                if (new AddFuntionDepartmentForm { functiondeptvo = selectedvo }.ShowDialog() == DialogResult.OK)
                { GridBind(); }
            }

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            if (FunctionDeptDetails_dgv.Rows.Count > 0 && FunctionDeptDetails_dgv.DataSource != null)
            {
                try
                {
                    if (MessageBox.Show("Do you want to delete this rows !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                    {
                        FunctionDeptVo selectedvo = (FunctionDeptVo)FunctionDeptDetails_dgv.CurrentRow.DataBoundItem;
                        FunctionDeptVo outVo = new FunctionDeptVo();
                        outVo = (FunctionDeptVo)DefaultCbmInvoker.Invoke(new Cbm.DeleteFunctionDeptVCBCbm(), selectedvo);

                        if (outVo.AffectedCount > 0)
                        {
                            messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, functioncode_lbl + " : " + FunctionCode_txt.Text);
                            logger.Info(messageData);
                            popUpMessage.Information(messageData, Text);
                        }
                        GridBind();
                    }
                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                }
            }
        }
    }
}
