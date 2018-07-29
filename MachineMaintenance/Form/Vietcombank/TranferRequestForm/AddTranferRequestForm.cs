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
            if (To_radio.Checked == true)
            {
                ListUser_dgv.Rows.Add(DeptCode_cmb.Text, FunctionCode_cmb.Text, UserName_cmb.Text, To_radio.Text);
            }
            else if (CC_radio.Checked == true)
            {
                ListUser_dgv.Rows.Add(DeptCode_cmb.Text, FunctionCode_cmb.Text, UserName_cmb.Text, CC_radio.Text);
            }

        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            ListUser_dgv.Rows.RemoveAt(this.ListUser_dgv.CurrentRow.Index);
        }

       
        void requestcode()
        {
            tranfertrquestVo = (TranferRequestVo)DefaultCbmInvoker.Invoke(new Cbm.GetMaxCodeTranferRequestCbm(), new TranferRequestVo());
            string datetime = DateTime.Now.ToString("yyMMdd");
            string requestcodefull = DeptCode_cmb.Text + "_" + datetime + "_" + (tranfertrquestVo.RequestCode).ToString();
            MessageBox.Show(requestcodefull);
        }
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            requestcode();
        }
        private void Exit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
