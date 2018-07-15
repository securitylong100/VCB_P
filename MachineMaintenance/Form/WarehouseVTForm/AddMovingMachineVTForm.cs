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
namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{//WarehouseVTCheckForm
    public partial class AddMovingMachineVTForm : FormCommonNCVP
    {
        public MovingMachineVTVo movingmachineVo = new MovingMachineVTVo();

        public AddMovingMachineVTForm()
        {
            InitializeComponent();

            dgv_maxcode.AutoGenerateColumns = false;
        }
        private void AddMovingMachineVTForm_Load(object sender, EventArgs e)
        {
            code_name_txt.ReadOnly = true;
            dgv_maxcode.ReadOnly = true;

            ValueObjectList<WarehouseVTVo> machineserial = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineSerialCbm(), new WarehouseVTVo());
            machine_serial_cmb.DisplayMember = "MachineSerial";
            machine_serial_cmb.DataSource = machineserial.GetList();
            machine_serial_cmb.Text = "";

            // factory_tranfer_cmb
            FactoryVo factory_tranfer = (FactoryVo)DefaultCbmInvoker.Invoke(new GetFactoryMasterMntCbm(), new FactoryVo());
            factory_tranfer_cmb.DisplayMember = "FactoryName";
            factory_tranfer_cmb.DataSource = factory_tranfer.FactoryListVo;
            factory_tranfer_cmb.Text = "";

            FactoryVo factory_received = (FactoryVo)DefaultCbmInvoker.Invoke(new GetFactoryMasterMntCbm(), new FactoryVo());
            factory_received_cmb.DisplayMember = "FactoryName";
            factory_received_cmb.DataSource = factory_received.FactoryListVo;
            factory_received_cmb.Text = "";

            getmaxcode();
            machine_name_cmb.Text = "";
            machine_model_cmb.Text = "";
            cost_value_cmb.Text = "";

            if (movingmachineVo.MovingId > 0)
            {
                machine_serial_cmb.Text = movingmachineVo.MachineSerial;
                machine_name_cmb.Text = movingmachineVo.MachineName;
                factory_received_cmb.Text = movingmachineVo.ReceivedFactoryName;
                factory_tranfer_cmb.Text = movingmachineVo.TranferFactoryName;
                code_status_cmb.Text = movingmachineVo.CodeStatus;
                status_machine_cmb.Text = movingmachineVo.Status;
                comments_txt.Text = movingmachineVo.CommentsMachine;
                confirm_received_txt.Text = movingmachineVo.ConfirmReceived;
                reason_tranfer_txt.Text = movingmachineVo.ReasonTranfer;
                machine_model_cmb.Text = movingmachineVo.MachineModel;
                cost_value_cmb.Text = movingmachineVo.MachineCostValue.ToString();

                //
                machine_serial_cmb.Enabled = false;
                machine_name_cmb.Enabled = false;
                factory_received_cmb.Enabled = false;
                factory_tranfer_cmb.Enabled = false;
                code_status_cmb.Enabled = false;
                code_name_txt.Visible = true;
                code_name_lbl.Visible = true;
                reason_tranfer_txt.Enabled = false;
                confirm_received_txt.Enabled = false;
                cost_value_cmb.Enabled = false;
                machine_model_cmb.Enabled = false;

            }
        }
        void getmaxcode()
        {
            ValueObjectList<MovingMachineVTVo> listvo = (ValueObjectList<MovingMachineVTVo>)DefaultCbmInvoker.Invoke(new Cbm.GetCodeStatusMovingVTCbm(), new MovingMachineVTVo());
            dgv_maxcode.DataSource = listvo.GetList();
        }
        private void rfid_txt_TextChanged(object sender, EventArgs e)
        {
            if (rfid_txt.TextLength == 10)
            {
                ValueObjectList<WarehouseVTVo> machineserial = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new SearchMachineCbm(), new WarehouseVTVo { RFId = rfid_txt.Text });
                machine_serial_cmb.DisplayMember = "MachineSerial";
                machine_serial_cmb.DataSource = machineserial.GetList();
            }
        }
        private void machine_serial_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (machine_serial_cmb.Text.Length != 0)
            {
                ValueObjectList<WarehouseVTVo> machinename = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new SearchMachineCbm(), new WarehouseVTVo { MachineSerial = machine_serial_cmb.Text });

                machine_name_cmb.DisplayMember = "MachineName";
                machine_name_cmb.DataSource = machinename.GetList();
                machine_name_cmb.Text = "";
                machine_model_cmb.DisplayMember = "MachineModel";
                machine_model_cmb.DataSource = machinename.GetList();
                machine_model_cmb.Text = "";
                cost_value_cmb.DisplayMember = "MachineCostValue";
                cost_value_cmb.DataSource = machinename.GetList();
                cost_value_cmb.Text = "";

            }
        }
        private void machine_serial_cmb_TextChanged(object sender, EventArgs e)
        {
            machine_serial_cmb_SelectedIndexChanged(sender, e);
        }

        public string codeselect = ""; //dung de goi update value to database
        public string codestatus = ""; //not using
        public string BG_code_value = null;
        public string Th_code_value = null;
        public string T_code_value = null;
        public string M_code_value = null;

        private void code_status_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (code_status_cmb.Text == "Bàn Giao")
            {
                if (dgv_maxcode.Rows[0].Cells["colBG"].Value.ToString() != "")
                {
                    codeselect = (int.Parse(dgv_maxcode.Rows[0].Cells["colBG"].Value.ToString()) + 1).ToString();
                }
                else
                {
                    codeselect = "1";
                }
                codestatus = "BG/CĐ";
                BG_code_value = codeselect;
                Th_code_value = null;
                T_code_value = null;
                M_code_value = null;
            }
            else if (code_status_cmb.Text == "Mượn")
            {
                if (dgv_maxcode.Rows[0].Cells["colM"].Value.ToString() != "")
                {
                    codeselect = (int.Parse(dgv_maxcode.Rows[0].Cells["colM"].Value.ToString()) + 1).ToString();
                }
                else
                {
                    codeselect = "1";
                }
                codestatus = "M/CĐ";
                M_code_value = codeselect;
                BG_code_value = null;
                T_code_value = null;
                Th_code_value = null;
            }
            else if (code_status_cmb.Text == "Trả")
            {
                if (dgv_maxcode.Rows[0].Cells["colT"].Value.ToString() != "")
                {
                    codeselect = (int.Parse(dgv_maxcode.Rows[0].Cells["colT"].Value.ToString()) + 1).ToString();
                }
                else
                {
                    codeselect = "1";
                }
                codestatus = "T/CĐ";
                T_code_value = codeselect;
                Th_code_value = null;
                M_code_value = null;
                BG_code_value = null;
            }
            else if (code_status_cmb.Text == "Thuê")
            {
                if (dgv_maxcode.Rows[0].Cells["colTH"].Value.ToString() != "")
                {
                    codeselect = (int.Parse(dgv_maxcode.Rows[0].Cells["colTH"].Value.ToString()) + 1).ToString();
                }
                else
                {
                    codeselect = "1";
                }
                codestatus = "TH/CĐ";
                Th_code_value = codeselect;
                T_code_value = null;
                M_code_value = null;
                BG_code_value = null;
            }
            else
            {
                codeselect = "";
                codestatus = "";
            }
            code_name_txt.Text = codeselect + codestatus;

        }

        private void Ok_btn_Click(object sender, EventArgs e)
        {
            //          code_status_cmb_SelectedIndexChanged(sender, e);

            if (checkdata())
            {
                MovingMachineVTVo outVo = new MovingMachineVTVo();
                MovingMachineVTVo inVo = new MovingMachineVTVo
                {
                    MovingId = movingmachineVo.MovingId,
                    MachineSerial = machine_serial_cmb.Text,
                    TranferFactoryName = factory_tranfer_cmb.Text,
                    ReceivedFactoryName = factory_received_cmb.Text,
                    Status = status_machine_cmb.Text,
                    CommentsMachine = comments_txt.Text,
                    ReasonTranfer = reason_tranfer_txt.Text,
                    ConfirmReceived = confirm_received_txt.Text,
                    BGCode = BG_code_value,
                    TCode = T_code_value,
                    THCode = Th_code_value,
                    MCode = M_code_value,
                };
                try
                {
                    if (movingmachineVo.MovingId > 0)
                    {
                        outVo = (MovingMachineVTVo)DefaultCbmInvoker.Invoke(new Cbm.UpdateMovingVTCbm(), inVo);
                    }
                    else
                    {
                        outVo = (MovingMachineVTVo)DefaultCbmInvoker.Invoke(new Cbm.AddMovingVTCbm(), inVo);
                        if (code_status_cmb.Text == "Bàn Giao")
                        {
                            WarehouseVTVo updateBG = new WarehouseVTVo();
                            updateBG = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new UpdateBGMovingVTCbm(), new WarehouseVTVo() { MachineSerial = inVo.MachineSerial, MachineSupplier = inVo.ReceivedFactoryName, MachineStatus = "Đã Bàn Giao", RegistrationUserCode = inVo.RegistrationUserCode, RegistrationDateTime = DateTime.Now, });
                        }
                        if ((code_status_cmb.Text == "Mượn") && (UserData.GetUserData().FactoryName == inVo.ReceivedFactoryName))//minh di muon thì add thêm
                        {
                            WarehouseVTVo addnewmachine = new WarehouseVTVo();
                            addnewmachine = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new AddNewMachineVTCbm(), new WarehouseVTVo()
                            {
                                RFId = rfid_txt.Text,
                                MachineCode = "",
                                MachineName = machine_name_cmb.Text,
                                MachineQty = 1,
                                MachineModel = machine_model_cmb.Text,
                                MachineSerial = machine_serial_cmb.Text,
                                MachineLocation = "",
                                MachineSupplier = factory_tranfer_cmb.Text,
                                MachineInvoice = "",
                                MachineCostValue = cost_value_cmb.Text,
                                RegistrationUserCode = UserData.GetUserData().UserName,
                                RegistrationDateTime = DateTime.Now,
                                TimeCheck = 1,
                                MachineStatus = "Đã Mượn",
                            });
                        }
                        if ((code_status_cmb.Text == "Mượn") && (UserData.GetUserData().FactoryName == inVo.TranferFactoryName))//minh cho ngta muon, thì update statust
                        {
                            WarehouseVTVo updateBG = new WarehouseVTVo();
                            updateBG = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new UpdateBGMovingVTCbm(), new WarehouseVTVo() { MachineSerial = inVo.MachineSerial, MachineSupplier = inVo.TranferFactoryName, MachineStatus = "Đã Cho Mượn", RegistrationUserCode = inVo.RegistrationUserCode, RegistrationDateTime = DateTime.Now, });
                        }
                        if ((code_status_cmb.Text == "Trả") && (UserData.GetUserData().FactoryName == inVo.TranferFactoryName))//mình trả cho ngta, thì xóa dòng đó.
                        {
                            WarehouseVTVo deletemachine = new WarehouseVTVo();
                            deletemachine = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new DeleteMachineVTCbm(), new WarehouseVTVo() { MachineSerial = inVo.MachineSerial });
                        }
                        if ((code_status_cmb.Text == "Trả") && (UserData.GetUserData().FactoryName == inVo.ReceivedFactoryName))//nguoi ta tra mình, update status
                        {
                            WarehouseVTVo updateBG = new WarehouseVTVo();
                            updateBG = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new UpdateBGMovingVTCbm(), new WarehouseVTVo() { MachineSerial = inVo.MachineSerial, MachineSupplier = inVo.ReceivedFactoryName, MachineStatus = "Máy CTY", RegistrationUserCode = inVo.RegistrationUserCode, RegistrationDateTime = DateTime.Now, });
                        }
                        if ((code_status_cmb.Text == "Thuê") && (UserData.GetUserData().FactoryName == inVo.ReceivedFactoryName))//mình đi thuê thì add thêm
                        {
                            WarehouseVTVo addnewmachine = new WarehouseVTVo();
                            addnewmachine = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new AddNewMachineVTCbm(), new WarehouseVTVo()
                            {
                                RFId = rfid_txt.Text,
                                MachineCode = "",
                                MachineName = machine_name_cmb.Text,
                                MachineQty = 1,
                                MachineModel = machine_model_cmb.Text,
                                MachineSerial = machine_serial_cmb.Text,
                                MachineLocation = "",
                                MachineSupplier = factory_tranfer_cmb.Text,
                                MachineInvoice = "",
                                MachineCostValue = cost_value_cmb.Text,
                                RegistrationUserCode = UserData.GetUserData().UserName,
                                RegistrationDateTime = DateTime.Now,
                                TimeCheck = 1,
                                MachineStatus = "Máy Thuê",
                            });
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
                    messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, machine_serial_cmb.Text + " : " + machine_serial_cmb.Text);
                    logger.Info(messageData);
                    popUpMessage.Information(messageData, Text);

                }
            }
        }
        bool checkdata()
        {
            if (machine_serial_cmb.Text == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, serialmachine_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                machine_serial_cmb.Focus();
                return false;
            }
            if (factory_tranfer_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, factory_tranfer_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                factory_tranfer_cmb.Focus();
                return false;
            }
            if (factory_received_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, factory_received_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                factory_received_cmb.Focus();
                return false;
            }
            if (status_machine_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, status_machine_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                status_machine_cmb.Focus();
                return false;
            }
            if (code_status_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, code_status_cmb.Text);
                popUpMessage.Warning(messageData, Text);
                code_status_cmb.Focus();
                return false;
            }
            if (reason_tranfer_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, reason_tranfer_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                reason_tranfer_txt.Focus();
                return false;
            }
            return true;

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }

}
