using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance
{
    public partial class AddFuntionDepartmentForm : FormCommonNCVP
    {
        public AddFuntionDepartmentForm()
        {
            InitializeComponent();
        }
        public FunctionDeptVo functiondeptvo = new FunctionDeptVo();
        private void AddRankForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<DepartmentVo> machineserial = (ValueObjectList<DepartmentVo>)DefaultCbmInvoker.Invoke(new GetDepartmentVCBCbm(), new DepartmentVo());
            DeptCode_cmb.DisplayMember = "DepartmentCode";
            DeptCode_cmb.DataSource = machineserial.GetList();
            DeptCode_cmb.Text = "";

            DeptCode_cmb.Select();
            if (functiondeptvo.FunctionDeptId > 0)
            {
                DeptCode_cmb.Text = functiondeptvo.DepartmentCode;
                FunctionCode_txt.Text = functiondeptvo.FunctionDeptCode;
                FunctionName_txt.Text = functiondeptvo.FunctionDeptName;
            }


        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                FunctionDeptVo outvo = new FunctionDeptVo();
                FunctionDeptVo invo = new FunctionDeptVo()
                {
                    FunctionDeptId = functiondeptvo.FunctionDeptId,
                    DepartmentId = ((DepartmentVo)this.DeptCode_cmb.SelectedItem).DepartmentId,
                    FunctionDeptCode = FunctionCode_txt.Text,
                    FunctionDeptName = FunctionName_txt.Text,
                    FactoryCode = UserData.GetUserData().FactoryCode,
                    RegistrationUserCode = UserData.GetUserData().UserCode
                };
                try
                {
                    if (invo.FunctionDeptId > 0)
                    {
                        outvo = (FunctionDeptVo)DefaultCbmInvoker.Invoke(new Cbm.UpdateFunctionDeptVCBCbm(), invo);
                    }
                    else
                    {
                        outvo = (FunctionDeptVo)DefaultCbmInvoker.Invoke(new Cbm.AddFunctionDeptVCBCbm(), invo);
                    }
                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                    return;
                }
                if (outvo.AffectedCount > 0)
                {
                    messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, functioncode_lbl.Text + " : " + FunctionCode_txt.Text);
                    logger.Info(messageData);
                    popUpMessage.Information(messageData, Text);
                    return;
                }
            }

        }
        bool checkdata()
        {
            if (DeptCode_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, DeptCode_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                DeptCode_cmb.Focus();
                return false;
            }
            if (FunctionCode_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, functioncode_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                FunctionCode_txt.Focus();
                return false;
            }
            if (FunctionName_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, functionname_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                functionname_lbl.Focus();
                return false;
            }

            return true;
        }
    }
}
