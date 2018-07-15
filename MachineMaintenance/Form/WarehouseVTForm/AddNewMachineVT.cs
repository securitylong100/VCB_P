using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Text;
using System.Windows.Forms;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    public partial class AddNewMachineVT : FormCommonNCVP
    {
        public AddNewMachineVT()
        {
            InitializeComponent();
        }

        private void AddNewMachineVT_Load(object sender, EventArgs e)
        {
            ValueObjectList<WarehouseVTVo> machinemodel = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineModelVTCbm(), new WarehouseVTVo());
            model_cmb.DisplayMember = "MachineModel";
            model_cmb.DataSource = machinemodel.GetList();
            model_cmb.Text = "";

            FactoryVo factory_tranfer = (FactoryVo)DefaultCbmInvoker.Invoke(new GetFactoryMasterMntCbm(), new FactoryVo());
            machine_supplier_cmb.DisplayMember = "FactoryName";
            machine_supplier_cmb.DataSource = factory_tranfer.FactoryListVo;
            machine_supplier_cmb.Text = "";
        }
        private void model_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (model_cmb.Text.Length != 0)
            {
                //WarehouseVTVo inVo = new AccountMainVo()
                //{
                //    UserTem = user_location_code_txt.Text
                //};
                ValueObjectList<WarehouseVTVo> model = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new SearchMachineCbm(), new WarehouseVTVo { MachineModel = model_cmb.Text });
                machine_name_cmb.DisplayMember = "MachineName";
                machine_name_cmb.DataSource = model.GetList();
            }
            else
            {
                machine_name_cmb.Text = "";
            }
        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                checkid_cmb.DataSource = null;
                CheckId();
                if (intcheckid == 0)
                {
                    WarehouseVTVo outVo = new WarehouseVTVo();
                    WarehouseVTVo inVo = new WarehouseVTVo()
                    {
                        RFId = rfid_txt.Text,
                        MachineCode = machine_cd_txt.Text,
                        MachineName = machine_name_cmb.Text,
                        MachineQty = int.Parse(qty_txt.Text),
                        MachineModel = model_cmb.Text,
                        MachineSerial = serial_txt.Text,
                        MachineLocation = location_txt.Text,
                        MachineSupplier = machine_supplier_cmb.Text,
                        MachineInvoice = invoice_txt.Text,
                        MachineCostValue = cost_txt.Text,
                        RegistrationUserCode = UserData.GetUserData().UserName,
                        RegistrationDateTime = DateTime.Now,
                        TimeCheck = int.Parse(checktime_txt.Text),
                        MachineStatus = "Máy CTY",
                    };
                    try
                    {
                        outVo = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new Cbm.AddNewMachineVTCbm(), inVo);

                    }
                    catch (Framework.ApplicationException exception)
                    {
                        popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                        logger.Error(exception.GetMessageData());
                    }
                    if (outVo.AffectedCount > 0)
                    {
                        messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, machine_cd_txt.Text + " : " + machine_cd_txt.Text);
                        logger.Info(messageData);
                        popUpMessage.Information(messageData, Text);

                        //delete trong table datalost
                        WarehouseVTListVo outVo2 = new WarehouseVTListVo();
                        WarehouseVTListVo inVo2 = new WarehouseVTListVo()
                        {
                            RFId = rfid_txt.Text,
                            MachineSerial = serial_txt.Text,
                        };
                        try
                        {
                            outVo2 = (WarehouseVTListVo)DefaultCbmInvoker.Invoke(new Cbm.DeleteDatalostVTCbm(), inVo2);
                        }
                        catch (Framework.ApplicationException exception)
                        {
                            popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                            logger.Error(exception.GetMessageData());
                            return;
                        }
                        rfid_txt.Text = "";
                        serial_txt.Text = "";
                    }
                }
                else if (intcheckid > 0)
                { MessageBox.Show("RFId hoặc Machine serial đã tồn tại trong danh sách !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
        }
        public int intcheckid;
        public void CheckId()
        {
            if (rfid_txt.Text != null && machine_cd_txt.Text != null)
            {
                WarehouseVTVo inVo = new WarehouseVTVo()
                {
                    RFId = rfid_txt.Text,
                    MachineCode = machine_cd_txt.Text,
                    MachineSerial = serial_txt.Text
                };
                ValueObjectList<WarehouseVTVo> check = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new CheckIdAddFormVTCbm(), inVo);
                checkid_cmb.DisplayMember = "CheckCountID";
                checkid_cmb.DataSource = check.GetList();
                if (checkid_cmb.Text == "0")
                {
                    intcheckid = 0; //insert data 

                }
                else if (checkid_cmb.Text == "1")
                {
                    intcheckid = 1;

                }
                else
                {
                    intcheckid = 4;
                    //tnhong bao tao thích do là cc gi t
                    //
                }
            }
        }
        bool checkdata()
        {
            if (serial_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, serial_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                serial_txt.Focus();
                return false;
            }
            if (machine_name_cmb.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, machine_name_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                machine_name_cmb.Focus();
                return false;
            }
            if (checktime_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, checktime_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                checktime_txt.Focus();
                return false;
            }
            if (qty_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, qty_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                qty_txt.Focus();
                return false;
            }

            return true;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
