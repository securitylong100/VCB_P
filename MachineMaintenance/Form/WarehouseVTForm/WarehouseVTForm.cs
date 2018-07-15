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
    public partial class WarehouseVTForm : FormCommonNCVP
    {


        public WarehouseVTForm()
        {
            InitializeComponent();
            warehouse_vt_dgv.AutoGenerateColumns = false;
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            warehouse_vt_dgv.DataSource = null;
            GridBind();
            //if (warehouse_vt_dgv.Rows.Count > 0)
            //{
            //    warehouse_vt_dgv.CurrentCell = warehouse_vt_dgv.Rows[0].Cells[1];
            //}
        }
        private void GridBind()
        {
            try
            {
                WarehouseVTVo whvos = new WarehouseVTVo()
                {
                    MachineSerial = machine_serial_cmb.Text,
                    MachineLocation = location_cmb.Text,
                    RFId = rfid_txt.Text,
                    MachineModel = machine_model_cmb.Text,
                    MachineSupplier = machine_supplier_cmb.Text,
                    MachineStatus = machine_status_cmb.Text
                };


                ValueObjectList<WarehouseVTVo> listvo = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchMachineCbm(), whvos);
                warehouse_vt_dgv.DataSource = listvo.GetList();

                machine_serial_cmb.Text = "";
                rfid_txt.Text = "";

            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            AddNewMachineVT addaccountmain = new AddNewMachineVT();
            addaccountmain.ShowDialog();
            GridBind();
            WarehouseVTForm_Load(sender, e);
        }

        private void WarehouseVTForm_Load(object sender, EventArgs e)
        {
            compairT();

        }

        private void compairT()
        {
            //Common.callmac callmac = new Common.callmac();
            //callmac.LoadMac();
            //ValueObjectList<WarehouseVTVo> macdata = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMacVTCbm(), new WarehouseVTVo());
            //mac_cmb.DisplayMember = "MacLocal";
            //mac_cmb.DataSource = macdata.GetList();
            //GetMD5(callmac.maclist.Substring(0,10));
            //if (str_md5 == mac_cmb.Text)
            {

                AcceptButton = search_btn;
                warehouse_vt_dgv.DefaultCellStyle.Font = new Font("Arial", 9);
                warehouse_vt_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);

                ValueObjectList<WarehouseVTVo> machineserial = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineSerialCbm(), new WarehouseVTVo());
                machine_serial_cmb.DisplayMember = "MachineSerial";
                machine_serial_cmb.DataSource = machineserial.GetList();
                machine_serial_cmb.Text = "";
                ValueObjectList<WarehouseVTVo> machinemodel = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineModelVTCbm(), new WarehouseVTVo());
                machine_model_cmb.DisplayMember = "MachineModel";
                machine_model_cmb.DataSource = machinemodel.GetList();
                machine_model_cmb.Text = "";
                ValueObjectList<WarehouseVTVo> machinesuppiler = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineSupplierCbm(), new WarehouseVTVo());
                machine_supplier_cmb.DisplayMember = "MachineSupplier";
                machine_supplier_cmb.DataSource = machinesuppiler.GetList();
                machine_supplier_cmb.Text = "";
                ValueObjectList<WarehouseVTVo> machinelocation = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineLocationCbm(), new WarehouseVTVo());
                location_cmb.DisplayMember = "MachineLocation";
                location_cmb.DataSource = machinelocation.GetList();
                location_cmb.Text = "";
                ValueObjectList<WarehouseVTVo> machinestatus = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineStatusCbm(), new WarehouseVTVo());
                machine_status_cmb.DisplayMember = "MachineStatus";
                machine_status_cmb.DataSource = machinestatus.GetList();
                machine_status_cmb.Text = "";
            }
            //else
            //{
            //    this.Close();
            //}

        }
        private void machine_model_cmb_Click(object sender, EventArgs e)
        {
        }
        private void machine_model_cmb_TextChanged(object sender, EventArgs e)
        {

            if (machine_model_cmb.Text.Length != 0)
            {
                ValueObjectList<WarehouseVTVo> model = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new SearchMachineCbm(), new WarehouseVTVo { MachineModel = machine_model_cmb.Text });
                machine_serial_cmb.DisplayMember = "MachineSerial";
                machine_serial_cmb.DataSource = model.GetList();

            }
            machine_serial_cmb.Text = "";
        }
        public string str_md5 = "";
        public string GetMD5(string chuoi)
        {

            str_md5 = "";
            byte[] mang = System.Text.Encoding.UTF8.GetBytes(chuoi);

            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            mang = my_md5.ComputeHash(mang);

            foreach (byte b in mang)
            {
                str_md5 += b.ToString("X2");
            }

            return str_md5;

        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (warehouse_vt_dgv.Rows.Count == 1 && warehouse_vt_dgv.DataSource != null)
                {
                    WarehouseVTVo selectedvo = (WarehouseVTVo)warehouse_vt_dgv.CurrentRow.DataBoundItem;

                    WarehouseVTVo outVo = new WarehouseVTVo();
                    outVo = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new Cbm.UpdateRFIdCbm(), selectedvo);

                    if (outVo.AffectedCount > 0)
                    {
                        messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, update_btn.Text + " : " + update_btn.Text);
                        logger.Info(messageData);
                        popUpMessage.Information(messageData, Text);
                        return;
                    }
                    WarehouseVTForm_Load(sender, e);
                    GridBind();
                }
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }

        }

        private void depreciation_btn_Click(object sender, EventArgs e)
        {

        }

        private void Rank_Dep_btn_Click(object sender, EventArgs e)
        {


        }
        private void exportcsv_btn_Click(object sender, EventArgs e)
        {

            string datetime = DateTime.Now.ToString("yyMMdd_HHmm");

            Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.csvclass exportcsv = new Common.csvclass();
            exportcsv.exportcsv(ref warehouse_vt_dgv, linksave_txt.Text, this.TitleText + "_" + datetime);
        }
        private void exportexcel_btn_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("yyMMdd_HHmm");

            Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.Excel_Class exportexcel = new Common.Excel_Class();
            exportexcel.exportexcel(ref warehouse_vt_dgv, linksave_txt.Text, this.TitleText + "_" + datetime);

        }
        private string directorySave = "";
        private void browser_btn_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog fl = new FolderBrowserDialog();
            fl.SelectedPath = "d:\\";
            fl.ShowNewFolderButton = true;
            if (fl.ShowDialog() == DialogResult.OK)
            {
                linksave_txt.Text = fl.SelectedPath;
                directorySave = linksave_txt.Text;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc xóa thiết bị này !",
                "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    //int rowIndex = warehouse_vt_dgv.CurrentCell.RowIndex;
                    if (warehouse_vt_dgv.Rows.Count > 0 && warehouse_vt_dgv.DataSource != null)
                    {
                        WarehouseVTVo selectedvo = (WarehouseVTVo)warehouse_vt_dgv.CurrentRow.DataBoundItem;
                        WarehouseVTVo outVo = new WarehouseVTVo();
                        outVo = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new Cbm.DeleteMachineVTCbm(), selectedvo);

                        if (outVo.AffectedCount > 0)
                        {
                            messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, clear_btn.Text + " : " + clear_btn.Text);
                            logger.Info(messageData);
                            popUpMessage.Information(messageData, Text);
                        }
                    }
                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                }
                WarehouseVTForm_Load(sender, e);
                search_btn_Click(sender, e);
            }
        }
    }
}
