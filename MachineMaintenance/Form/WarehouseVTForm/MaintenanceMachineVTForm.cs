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
    public partial class MaintenanceMachineVTForm : FormCommonNCVP
    {


        public MaintenanceMachineVTForm()
        {
            InitializeComponent();
            mainternance_vt_dgv.AutoGenerateColumns = false;
            mainternance_vt_dgv.ReadOnly = true;
            checkboxHeader.Visible = false;
        }

        private void MaintenanceMachineVTForm_Load(object sender, EventArgs e)
        {

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

        private void machine_model_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (machine_model_cmb.Text.Length != 0)
            {
                ValueObjectList<WarehouseVTVo> model = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new SearchMachineCbm(), new WarehouseVTVo { MachineModel = machine_model_cmb.Text });
                machine_serial_cmb.DisplayMember = "MachineSerial";
                machine_serial_cmb.DataSource = model.GetList();
            }
            machine_serial_cmb.Text = "";
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            mainternance_vt_dgv.Columns["col_machineid"].DataPropertyName = "MachineId";
            mainternance_vt_dgv.Columns["col_rfid"].DataPropertyName = "RFId";
            mainternance_vt_dgv.Columns["col_machineserial"].DataPropertyName = "MachineSerial";
            mainternance_vt_dgv.Columns["col_machinename"].DataPropertyName = "MachineName";
            mainternance_vt_dgv.Columns["col_machinemodel"].DataPropertyName = "MachineModel";
            mainternance_vt_dgv.Columns["col_machineqty"].DataPropertyName = "MachineQty";
            mainternance_vt_dgv.Columns["col_machinelocation"].DataPropertyName = "MachineLocation";
            mainternance_vt_dgv.Columns["col_machinesupplier"].DataPropertyName = "MachineSupplier";
            mainternance_vt_dgv.Columns["col_machinestatus"].DataPropertyName = "MachineStatus";
            mainternance_vt_dgv.Columns["col_factorycd"].DataPropertyName = "FactoryCode";
            mainternance_vt_dgv.Columns["col_machinecostvalue"].DataPropertyName = "MachineCostValue";
            mainternance_vt_dgv.Columns["col_datetime"].DataPropertyName = "RegistrationDateTime";
            //change header
            mainternance_vt_dgv.Columns["col_machineqty"].HeaderText = "Qty";
            mainternance_vt_dgv.Columns["col_factorycd"].HeaderText = "Factory";
            mainternance_vt_dgv.Columns["col_machinecostvalue"].HeaderText = "Cost";

            mainternance_vt_dgv.Columns["col_checkstatus"].Visible = false;

            checkboxHeader.Visible = false;
            mainternance_vt_dgv.DataSource = null;
            GridBind();
            //mainternance_vt_dgv.Columns["colEndday"].DataPropertyName = "MachineSerial";
            //mainternance_vt_dgv.Columns["colStartDay"].Visible = false;
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
                mainternance_vt_dgv.DataSource = listvo.GetList();

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
            if (mainternance_vt_dgv.DataSource != null)
            {
                AddMaintenanceMachineVTForm ad = new AddMaintenanceMachineVTForm(ref mainternance_vt_dgv, machine_model_cmb.Text);
                ad.ShowDialog();
            }
        }
        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < mainternance_vt_dgv.RowCount; i++)
            {
                mainternance_vt_dgv.Rows[i].Cells["col_checkstatus"].Value = ((CheckBox)mainternance_vt_dgv.Controls.Find("checkboxHeader", true)[0]).Checked;
            }
            mainternance_vt_dgv.EndEdit();
        }
        CheckBox checkboxHeader = new CheckBox();
        void addcheckboxheader()
        {
            //DataGridViewCheckBoxColumn checkboxColumn = new DataGridViewCheckBoxColumn();
            //checkboxColumn.Width = 30;
            //checkboxColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //mainternance_vt_dgv.Columns.Insert(0, checkboxColumn);

            // add checkbox header
            Rectangle rect = mainternance_vt_dgv.GetCellDisplayRectangle(0, -1, true);
            // set checkbox header to center of header cell. +1 pixel to position correctly.
            rect.X = rect.Location.X + (rect.Width / 4);

            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(25, 25);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);
            mainternance_vt_dgv.Controls.Add(checkboxHeader);

        }
        private void search_info_btn_Click(object sender, EventArgs e)
        {
            checkboxHeader.Visible = true;
            addcheckboxheader();
            mainternance_vt_dgv.DataSource = null;
            mainternance_vt_dgv.ReadOnly = false;
            //change datasourch
            mainternance_vt_dgv.Columns["col_machineid"].DataPropertyName = "MainternanceId";
            mainternance_vt_dgv.Columns["col_rfid"].DataPropertyName = "RFId";
            mainternance_vt_dgv.Columns["col_machineserial"].DataPropertyName = "MachineSerial";
            mainternance_vt_dgv.Columns["col_machinename"].DataPropertyName = "MachineName";
            mainternance_vt_dgv.Columns["col_machinemodel"].DataPropertyName = "MachineModel";
            mainternance_vt_dgv.Columns["col_machineqty"].DataPropertyName = "MonthRepeat";
            mainternance_vt_dgv.Columns["col_machinelocation"].DataPropertyName = "MachineLocation";
            mainternance_vt_dgv.Columns["col_machinesupplier"].DataPropertyName = "MachineSupplier";
            mainternance_vt_dgv.Columns["col_machinestatus"].DataPropertyName = "MachineStatus";
            mainternance_vt_dgv.Columns["col_factorycd"].DataPropertyName = "StartDay";
            mainternance_vt_dgv.Columns["col_machinecostvalue"].DataPropertyName = "RegistrationUserCode";
            mainternance_vt_dgv.Columns["col_datetime"].DataPropertyName = "RegistrationDateTime";

            //change header
            mainternance_vt_dgv.Columns["col_machineqty"].HeaderText = "Month Repeat";
            mainternance_vt_dgv.Columns["col_factorycd"].HeaderText = "Start Day";
            mainternance_vt_dgv.Columns["col_machinecostvalue"].HeaderText = "User Add";
            //change status 
            mainternance_vt_dgv.Columns["col_checkstatus"].DataPropertyName = "CheckStatus";
            mainternance_vt_dgv.Columns["col_checkstatus"].Visible = true;
            mainternance_vt_dgv.Columns["col_rfid"].Visible = false;

            try
            {
                MaintenanceMachineVTVo inVo = new MaintenanceMachineVTVo
                {
                    MachineSerial = machine_serial_cmb.Text,
                    MachineLocation = location_cmb.Text,
                    RFId = rfid_txt.Text,
                    MachineModel = machine_model_cmb.Text,
                    MachineSupplier = machine_supplier_cmb.Text,
                    MachineStatus = machine_status_cmb.Text

                };
                ValueObjectList<MaintenanceMachineVTVo> listvo = (ValueObjectList<MaintenanceMachineVTVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchMainternanceMachineVTCbm(), inVo);
                mainternance_vt_dgv.DataSource = listvo.GetList();

                caculatorDatePlan();
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }

        private void update_info_btn_Click(object sender, EventArgs e)
        {
            if (mainternance_vt_dgv.RowCount > 0)
            {
                try
                {
                    for (int i = 0; i < mainternance_vt_dgv.RowCount; i++)
                    {
                        MaintenanceMachineVTVo inVo = (MaintenanceMachineVTVo)mainternance_vt_dgv.Rows[i].DataBoundItem;
                        MaintenanceMachineVTVo outVo = new MaintenanceMachineVTVo();
                        outVo = (MaintenanceMachineVTVo)DefaultCbmInvoker.Invoke(new Cbm.UpdateinfoMainternanceMachineVTCbm(), inVo);
                    }
                    messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, "UPDATE: " + " : " + "LIST");
                    logger.Info(messageData);
                    popUpMessage.Information(messageData, Text);

                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());

                }
            }
        }
        void caculatorDatePlan()
        {
            //   mainternance_vt_dgv.Columns["col_factorycd"]
            // mainternance_vt_dgv.Columns["col_machineqty"]
            //  mainternance_vt_dgv.Columns["col_checkstatus"]
            for (int i = 0; i < mainternance_vt_dgv.RowCount; i++)
            {
                DateTime startdatetime = DateTime.Parse(mainternance_vt_dgv.Rows[i].Cells["col_factorycd"].Value.ToString());
                int monthrepeat = int.Parse(mainternance_vt_dgv.Rows[i].Cells["col_machineqty"].Value.ToString());
                DateTime compareDateTime = startdatetime.AddDays(monthrepeat);
                bool checkstatus = bool.Parse(mainternance_vt_dgv.Rows[i].Cells["col_checkstatus"].Value.ToString());
                DateTime NowDateTime = DateTime.Now;
                if(compareDateTime > NowDateTime.AddDays(-7))
                {
                    //vang   
                    mainternance_vt_dgv.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                }
                if (compareDateTime > NowDateTime)
                {
                    //do
                    mainternance_vt_dgv.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                }


            }

        }
    }
}
