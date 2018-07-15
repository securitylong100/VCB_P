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
    public partial class MovingMachineVTForm : FormCommonNCVP
    {


        public MovingMachineVTForm()
        {
            InitializeComponent();
            vt_search_moving_dgv.AutoGenerateColumns = false;
            vt_search_moving_dgv.ReadOnly = true;
        }
        private void MovingMachineVTForm_Load(object sender, EventArgs e)
        {
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
        private void code_status_cmb_SelectedIndexChanged(object sender, EventArgs e) //call disctint codename from each codestatus
        {
            ValueObjectList<MovingMachineVTVo> codename = (ValueObjectList<MovingMachineVTVo>)DefaultCbmInvoker.Invoke(new GetCodeNameMovingVTCbm(), new MovingMachineVTVo { CodeStatus = code_status_cmb.Text });
            code_name_cmb.DisplayMember = "CodeName";
            code_name_cmb.DataSource = codename.GetList();
            code_name_cmb.Text = "";
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            GridBind();
            codecheckCODESTATUS();

        }
        void GridBind()
        {
            try
            {
                MovingMachineVTVo inVo = new MovingMachineVTVo
                {
                    MachineSerial = machine_serial_cmb.Text,
                    ReceivedFactoryName = factory_received_cmb.Text,
                    TranferFactoryName = factory_tranfer_cmb.Text,
                    CodeStatus = code_status_cmb.Text,
                    CodeName = code_name_cmb.Text,
                };
                ValueObjectList<MovingMachineVTVo> listvo = (ValueObjectList<MovingMachineVTVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchMovingVTCbm(), inVo);
                vt_search_moving_dgv.DataSource = listvo.GetList();
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }
        public string applyupdate = "";
        void codecheckCODESTATUS()
        {
            if (vt_search_moving_dgv.RowCount > 1)
            {
                for (int i = 0; i < vt_search_moving_dgv.RowCount - 1; i++)
                {
                    if (vt_search_moving_dgv.Rows[i].Cells["col_code_name"].Value.ToString() == vt_search_moving_dgv.Rows[i + 1].Cells["col_code_name"].Value.ToString())
                    {
                        applyupdate = "0";
                    }
                    else
                    {
                        applyupdate = "1";
                        i = vt_search_moving_dgv.RowCount - 1;
                    }
                }
            }
            else
            {
                applyupdate = "0";
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            AddMovingMachineVTForm addmovingform = new AddMovingMachineVTForm();
            addmovingform.ShowDialog();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (vt_search_moving_dgv.SelectedCells.Count > 0 && applyupdate == "0") //khong che cung 1 loai codename moi cho update
            {
                MovingMachineVTVo selectedvo = (MovingMachineVTVo)vt_search_moving_dgv.CurrentRow.DataBoundItem;

                if (new AddMovingMachineVTForm { movingmachineVo = selectedvo, }.ShowDialog() == DialogResult.OK)
                { GridBind(); }
            }
        }
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (vt_search_moving_dgv.Rows.Count > 0 && vt_search_moving_dgv.DataSource != null)
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc xóa thiết bị này !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                    {
                        MovingMachineVTVo selectedvo = (MovingMachineVTVo)vt_search_moving_dgv.CurrentRow.DataBoundItem;
                        MovingMachineVTVo outVo = new MovingMachineVTVo();
                        outVo = (MovingMachineVTVo)DefaultCbmInvoker.Invoke(new Cbm.DeleteMovingVTCbm(), selectedvo);

                        if (outVo.AffectedCount > 0)
                        {
                            messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, machine_serial_lbl + " : " + machine_serial_cmb.Text);
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

        private void delete_all_btn_Click(object sender, EventArgs e)
        {
            if (vt_search_moving_dgv.Rows.Count > 0 && vt_search_moving_dgv.DataSource != null && applyupdate == "0")
            {
                try
                {
                    if (MessageBox.Show("Bạn có chắc xóa mã code: " + code_status_cmb.Text + ": " + code_name_cmb.Text + " này !", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

                    {
                        MovingMachineVTVo inVo = new MovingMachineVTVo
                        {
                            CodeName = code_name_cmb.Text,
                            CodeStatus = code_status_cmb.Text

                        };
                        MovingMachineVTVo outVo = new MovingMachineVTVo();
                        outVo = (MovingMachineVTVo)DefaultCbmInvoker.Invoke(new Cbm.DeleteMovingVTCbm(), inVo);

                        if (outVo.AffectedCount > 0)
                        {
                            messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, machine_serial_lbl + " : " + machine_serial_cmb.Text);
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

        private void exportexcel_btn_Click(object sender, EventArgs e)
        {
            if (vt_search_moving_dgv.Rows.Count > 0 && vt_search_moving_dgv.DataSource != null && applyupdate == "0")
            {
                Common.ExportMovingFile export = new Common.ExportMovingFile();
                export.exportmoving(ref vt_search_moving_dgv, code_status_cmb.Text);
            }
            else
            {
                search_btn_Click(sender, e);
            }
        }
     
    }
}
