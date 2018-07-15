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
    public partial class AddDepartmentForm : FormCommonNCVP
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
        }
        public DepartmentVo vo = null;
        public int IntSuccess = -1;
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            if (checkdate())
            {
                DepartmentVo outvo = new DepartmentVo();
                DepartmentVo invo = new DepartmentVo
                {
                    DepartmentId = vo.DepartmentId,
                    DepartmentCode = DeptCode_txt.Text,
                    DepartmentName = DeptName_txt.Text,
                    FactoryCode = UserData.GetUserData().FactoryCode,
                    RegistrationUserCode = UserData.GetUserData().UserCode
                };
                try
                {
                    if (invo.DepartmentId > 0)
                    {
                        outvo = (DepartmentVo)DefaultCbmInvoker.Invoke(new UpdateDepartmentVCBCbm(), invo);
                    }
                    else
                    {
                        outvo = (DepartmentVo)DefaultCbmInvoker.Invoke(new AddDepartmentVCBCbm(), invo);
                    }
                    {
                        messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, DeptCode_lbl.Text + " : " + DeptCode_txt.Text);
                        logger.Info(messageData);
                        popUpMessage.Information(messageData, Text);
                    }
                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                    return;
                }
            }
        }
        private bool checkdate()
        {

            if (DeptCode_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, DeptCode_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                DeptCode_txt.Focus();
                return false;
            }
            if (DeptName_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, DeptName_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                DeptName_txt.Focus();
                return false;
            }
            DeptCode_txt.Text = DeptCode_txt.Text.Trim();
            DeptName_txt.Text = DeptName_txt.Text.Trim();
            DepartmentVo outVo = new DepartmentVo(),
                inVo = new DepartmentVo { DepartmentId = vo.DepartmentId, DepartmentCode = DeptCode_txt.Text };
            try
            {
                outVo = (DepartmentVo)DefaultCbmInvoker.Invoke(new CheckDepartmentVCBCbm(), inVo);
                if (outVo.AffectedCount > 0)
                {
                    messageData = new MessageData("mmcc00006", Properties.Resources.mmcc00006, DeptCode_lbl.Text);
                    popUpMessage.Warning(messageData, Text);
                    DeptCode_txt.Focus();
                    return false;
                }
            }
            catch (Com.Nidec.Mes.Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
                return false;
            }
            return true;

        }
        private void AddRankForm_Load(object sender, EventArgs e)
        {
            DeptCode_txt.Select();
            if (vo.DepartmentId > 0)
            {
                DeptCode_txt.Text = vo.DepartmentCode;
                DeptName_txt.Text = vo.DepartmentName;
            }
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
