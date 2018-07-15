using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{//WarehouseVTCheckForm
    public partial class AddMaintenanceMachineVTForm : FormCommonNCVP
    {


        public AddMaintenanceMachineVTForm()
        {
            InitializeComponent();

        }
        public DataGridViewCommon dgv;
        public string machine_model;
        public AddMaintenanceMachineVTForm(ref DataGridViewCommon _dgv, string _machine_model) : this()
        {
            dgv = _dgv;
            machine_model = _machine_model;

        }
        private void AddMaintenanceMachineVTForm_Load(object sender, EventArgs e)
        {

        }
        public MaintenanceMachineVTVo outVo = new MaintenanceMachineVTVo();
        public MaintenanceMachineVTVo CheckoutVo = new MaintenanceMachineVTVo();
        private void Ok_btn_Click(object sender, EventArgs e)
        {
            //col_machineserial
            //col_machinemodel
            if (checkdata())
            try
            {

                for (int i = 0; i < dgv.RowCount; i++)
                {
                    MaintenanceMachineVTVo inVo = new MaintenanceMachineVTVo
                    {
                        MachineModel = dgv.Rows[i].Cells["col_machinemodel"].Value.ToString(),
                        MachineSerial = dgv.Rows[i].Cells["col_machineserial"].Value.ToString(),
                        StartDay = start_day_dtp.Value,
                        MonthRepeat = int.Parse(month_repeat_txt.Text),
                        CheckStatus = false,
                    };
                    CheckoutVo = (MaintenanceMachineVTVo)DefaultCbmInvoker.Invoke(new Cbm.CheckMainternanceMachineVTCbm(), inVo);

                    if (CheckoutVo.AffectedCount == 0)
                    {
                        outVo = (MaintenanceMachineVTVo)DefaultCbmInvoker.Invoke(new Cbm.AddMainternanceMachineVTCbm(), inVo);
                    }
                }
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
            if (outVo.AffectedCount > 0)
            {
                messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, "Model: " + " : " + machine_model);
                logger.Info(messageData);
                popUpMessage.Information(messageData, Text);
            }
        }
        bool checkdata()
        {
            if (month_repeat_txt.Text != "")
            {

                return true;

            }
            else
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, month_repeat_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                month_repeat_lbl.Focus();
                return false;

            }
        }
        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
