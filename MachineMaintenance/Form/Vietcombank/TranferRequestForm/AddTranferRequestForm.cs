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
using System.Text;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance
{
    public partial class AddTranferRequestForm : FormCommonNCVP
    {
        public TranferRequestVo tranfertrquestVo = new TranferRequestVo();
        public AddTranferRequestForm()
        {
            InitializeComponent();
            ListUser_dgv.ReadOnly = true;
            To_radio.Checked = true;
        }

        private void AddTranferRequestForm_Load(object sender, EventArgs e)
        {
            ValueObjectList<DepartmentVo> machineserial = (ValueObjectList<DepartmentVo>)DefaultCbmInvoker.Invoke(new GetDepartmentVCBCbm(), new DepartmentVo());
            DeptCode_cmb.DisplayMember = "DepartmentCode";
            DeptCode_cmb.DataSource = machineserial.GetList();
            DeptCode_cmb.Text = "";


        }


        private void DeptCode_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueObjectList<FunctionDeptVo> machineserial = (ValueObjectList<FunctionDeptVo>)DefaultCbmInvoker.Invoke(new SearchFunctionDeptVCBCbm(), new FunctionDeptVo() { DepartmentCode = DeptCode_cmb.Text, });
            FunctionCode_cmb.DisplayMember = "FunctionDeptCode";
            FunctionCode_cmb.DataSource = machineserial.GetList();
            FunctionCode_cmb.Text = "";
        }

        private void FunctionCode_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValueObjectList<FunctionDeptVo> machineserial = (ValueObjectList<FunctionDeptVo>)DefaultCbmInvoker.Invoke(new SearchFunctionDeptVCBCbm(), new FunctionDeptVo() { FunctionDeptCode = FunctionCode_cmb.Text, DepartmentCode = DeptCode_cmb.Text, });
            UserName_cmb.DisplayMember = "UserName";
            UserName_cmb.DataSource = machineserial.GetList();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (DeptCode_cmb.Text != "" && FunctionCode_cmb.Text != "" && UserName_cmb.Text != "")
            {
                FunctionDeptVo idvo = new FunctionDeptVo() { FunctionDeptId = ((FunctionDeptVo)this.UserName_cmb.SelectedItem).FunctionDeptId };
                int id = idvo.FunctionDeptId;
                if (To_radio.Checked == true)
                {
                    ListUser_dgv.Rows.Add(id, DeptCode_cmb.Text, FunctionCode_cmb.Text, UserName_cmb.Text, To_radio.Text);
                }
                else if (CC_radio.Checked == true)
                {
                    ListUser_dgv.Rows.Add(id, DeptCode_cmb.Text, FunctionCode_cmb.Text, UserName_cmb.Text, CC_radio.Text);
                }
            }
            else
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, "Other avariable is null, pls, fill data");
                popUpMessage.Warning(messageData, Text);
            }
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            if (ListUser_dgv.RowCount > 0)
            {
                ListUser_dgv.Rows.RemoveAt(this.ListUser_dgv.CurrentRow.Index);
            }
        }

        void requestcode()
        {
            tranfertrquestVo = (TranferRequestVo)DefaultCbmInvoker.Invoke(new Cbm.GetMaxCodeTranferRequestCbm(), new TranferRequestVo());
            string datetime = DateTime.Now.ToString("yyMMdd");
            string requestcodefull = DeptCode_cmb.Text + "_" + datetime + "_" + (tranfertrquestVo.RequestCode).ToString();

        }
        public int checkTo = 0;
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListUser_dgv.RowCount; i++)
            {
                if (ListUser_dgv.Rows[i].Cells["colType"].Value.ToString() == "To")
                {
                    checkTo = checkTo + 1;
                }
            }
            tranfertrquestVo = (TranferRequestVo)DefaultCbmInvoker.Invoke(new Cbm.GetMaxCodeTranferRequestCbm(), new TranferRequestVo());
            if (checkdata())
            {
                for (int i = 0; i < ListUser_dgv.RowCount; i++)
                {
                    TranferRequestVo outvoList = new TranferRequestVo();
                    TranferRequestVo invoList = new TranferRequestVo()
                    {
                        RequestCode = tranfertrquestVo.RequestCode,
                        FunctionDeptId = int.Parse(ListUser_dgv.Rows[i].Cells["colIdfunctiondept"].Value.ToString()),
                        TypeList = ListUser_dgv.Rows[i].Cells["colType"].Value.ToString(),
                    };
                    outvoList = (TranferRequestVo)DefaultCbmInvoker.Invoke(new Cbm.AddTranferListCbm(), invoList);
                }
                TranferRequestVo outvoTranfer = new TranferRequestVo();
                
                TranferRequestVo invoTranfer = new TranferRequestVo()
                {
                    RequestCode = tranfertrquestVo.RequestCode,
                    UserNameRequest = UserData.GetUserData().UserName,
                    //FunctionDeptRequestId = 0 ,
                    RequestHeader = headerinfo_txt.Text,
                    RequestContents = contentinfo_txt.Text,
                    ProcessStatusCheck = false,
                };
                outvoTranfer = (TranferRequestVo)DefaultCbmInvoker.Invoke(new Cbm.AddTranferRequestCbm(), invoTranfer);

                if (outvoTranfer.AffectedCount > 0)
                {
                    messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, " Header Mail: " + headerinfo_txt.Text);
                    logger.Info(messageData);
                    popUpMessage.Information(messageData, Text);

                    DeptCode_cmb.Text = "";
                    FunctionCode_cmb.Text = "";
                    UserName_cmb.Text = "";
                    headerinfo_txt.Text = "";
                    contentinfo_txt.Text = "";
                }
            }
        }
        bool checkdata()
        {
            if (headerinfo_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, headerinfo_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                headerinfo_txt.Focus();
                return false;
            }
            if (contentinfo_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, contentinfo_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                contentinfo_txt.Focus();
                return false;
            }
            if (ListUser_dgv.RowCount == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, "Select mail address");
                popUpMessage.Warning(messageData, Text);
                return false;
            }
            if (checkTo > 1)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, "Address mail have many To Type: " + checkTo.ToString());
                popUpMessage.Warning(messageData, Text);
                checkTo = 0;
                return false;
            }
            return true;
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
