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
using System.Security.Cryptography;
using System.Threading;
using System.IO;
using System.Threading;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{//WarehouseVTCheckForm
    public partial class WarehouseVTCheckForm : FormCommonNCVP
    {
        public WarehouseVTCheckForm()
        {
            InitializeComponent();
            warehouse_vt_dgv.AutoGenerateColumns = false;
            warehouse_list_dgv.AutoGenerateColumns = false;
            datalost_dgv.AutoGenerateColumns = false;

        }
        public string insert_update = "";
        private void Countrow()
        {
            rowcount_cmb.DataSource = null;
            //WarehouseVTListVo outVo = new WarehouseVTListVo();
            WarehouseVTListVo inVo = new WarehouseVTListVo()
            {
                CheckTime = int.Parse(checktime_cmb.Text),
                MachineSerial = machine_serial_cmb.Text,
                RFId = rfid_txt.Text,

            };

            ValueObjectList<WarehouseVTListVo> assetvotype = (ValueObjectList<WarehouseVTListVo>)DefaultCbmInvoker.Invoke(new SearchCountRowVTListCbm(), inVo);
            rowcount_cmb.DisplayMember = "CounterRow";
            rowcount_cmb.DataSource = assetvotype.GetList();



            string counter = rowcount_cmb.Text;
            if (counter == "0")
            {
                insert_update = "Insert"; //insert data 

            }
            else if (counter == "1")
            {
                insert_update = "Update";

            }
            else
            {
                insert_update = "NA";
                //tnhong bao tao thích do là cc gi t
                //
            }

        }

        private void click_btn_Click(object sender, EventArgs e)
        {
            warehouse_vt_dgv.DataSource = null;
            warehouse_list_dgv.Visible = true;
            warehouse_vt_dgv.Visible = false;
            datalost_dgv.Visible = false;
            if (checktime_cmb.SelectedItem != null && (rfid_txt.Text.Length == 10 || machine_serial_cmb.Text != ""))
            {
                Countrow();
                warehouse_vt_dgv.DataSource = null;
                GridBind();
                if ((warehouse_vt_dgv.Rows.Count == 1) && (insert_update == "Insert"))
                {
                    warehouse_vt_dgv.Visible = false;
                    WarehouseVTListVo outVo = new WarehouseVTListVo();
                    WarehouseVTListVo inVo = new WarehouseVTListVo()
                    {
                        MachineSerial = warehouse_vt_dgv.Rows[0].Cells[7].Value.ToString(),
                        ValueCheck = true,
                        CheckTime = int.Parse(checktime_cmb.Text),
                        RegistrationUserCode = UserData.GetUserData().UserName,
                        RegistrationDateTime = DateTime.Now
                    };
                    try
                    {
                        outVo = (WarehouseVTListVo)DefaultCbmInvoker.Invoke(new Cbm.AddNewListCheckVTCbm(), inVo);
                        warehouse_list_dgv.DataSource = null;
                        GridBindList();

                        WarehouseVTVo outVo2 = new WarehouseVTVo();
                        WarehouseVTVo inVo2 = new WarehouseVTVo
                        {
                            MachineSerial = warehouse_vt_dgv.Rows[0].Cells[7].Value.ToString(), //load machine serial
                            TimeCheck = int.Parse(checktime_cmb.Text),
                        };
                        outVo2 = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new Cbm.UpdateCheckTimeVTCbm(), inVo2);

                        machine_serial_cmb.Text = "";
                        rfid_txt.Text = "";
                        //   checktime_cmb.Text = "";
                    }
                    catch (Framework.ApplicationException exception)
                    {
                        popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                        logger.Error(exception.GetMessageData());

                    }

                    warehouse_list_dgv.Visible = true;
                }
                //update
                else if ((warehouse_vt_dgv.Rows.Count == 1) && (insert_update == "Update"))
                {
                    MessageBox.Show("Máy này đã check với check time lần thứ: " + checktime_cmb.Text, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridBindList();
                    machine_serial_cmb.Text = "";
                    rfid_txt.Text = "";
                    // checktime_cmb.Text = "";
                }
                ///////////////////////////////
                else if (warehouse_vt_dgv.Rows.Count == 0)
                {
                    WarehouseVTListVo selectedvo = new WarehouseVTListVo
                    {
                        RFId = rfid_txt.Text,
                        MachineSerial = machine_serial_cmb.Text,
                        CheckTime = int.Parse(checktime_cmb.Text),
                    };
                    machine_serial_cmb.Text = "";
                    rfid_txt.Text = "";

                    if (new AddCommentDatalostVT { WareHouseVTListVo = selectedvo, }.ShowDialog() == DialogResult.OK)
                    {
                        GridBind();
                    }
                }
                else if (warehouse_vt_dgv.Rows.Count > 2)
                {
                    MessageBox.Show("RFId code đang bị trùng hãy xóa bớt 1 dòng trên database rồi dán lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn đầy đủ thông tin để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            warehouse_list_dgv.Visible = false;

            if (checktime_cmb.Text != "" && (value_cmb.Text == "True" || value_cmb.Text == "False"))
            {
                warehouse_vt_dgv.Visible = true;
                datalost_dgv.Visible = false;
                try
                {
                    WarehouseVTVo whvos = new WarehouseVTVo()
                    {
                        MachineSerial = machine_serial_cmb.Text,
                        RFId = rfid_txt.Text,
                        TimeCheck = int.Parse(checktime_cmb.Text),
                        ValueResult = value_cmb.Text,

                    };

                    ValueObjectList<WarehouseVTVo> listvo = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchResuftCheckVTCbm(), whvos);
                    warehouse_vt_dgv.DataSource = listvo.GetList();
                    if (value_cmb.Text == "True")
                    {
                        valueTrue_lbl.Text = warehouse_vt_dgv.RowCount.ToString();
                    }
                    if (value_cmb.Text == "False")
                    {
                        valueFalse_lbl.Text = warehouse_vt_dgv.RowCount.ToString();
                    }
                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                }
            }
            else if (value_cmb.Text == "NoData")
            {
                warehouse_vt_dgv.Visible = false;
                warehouse_list_dgv.Visible = false;
                datalost_dgv.Visible = true;
                try
                {
                    WarehouseVTListVo whvos = new WarehouseVTListVo();

                    ValueObjectList<WarehouseVTListVo> listvo = (ValueObjectList<WarehouseVTListVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchDatalostVTListCbm(), whvos);
                    datalost_dgv.DataSource = listvo.GetList();

                    valueNodata_lbl.Text = datalost_dgv.RowCount.ToString();

                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn đầy đủ thông tin để tiếp tục", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void GridBind()
        {
            try
            {
                WarehouseVTVo whvos = new WarehouseVTVo()
                {
                    MachineSerial = machine_serial_cmb.Text,
                    RFId = rfid_txt.Text
                };


                ValueObjectList<WarehouseVTVo> listvo = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchMachineCbm(), whvos);
                warehouse_vt_dgv.DataSource = listvo.GetList();

            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }


        private void GridBindList()
        {
            try
            {
                WarehouseVTListVo whvos = new WarehouseVTListVo()
                {
                    MachineSerial = warehouse_vt_dgv.Rows[0].Cells[7].Value.ToString(),
                    CheckTime = int.Parse(checktime_cmb.Text),
                };


                ValueObjectList<WarehouseVTListVo> listvo = (ValueObjectList<WarehouseVTListVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchMachineListVTCbm(), whvos);
                warehouse_list_dgv.DataSource = listvo.GetList();

            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
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

            //GetMD5(callmac.maclist.Substring(0, 10)); //edit cho khach hàng thanh 10
            //if (str_md5 == mac_cmb.Text)
            {
                AcceptButton = check_btn;
                warehouse_vt_dgv.DefaultCellStyle.Font = new Font("Arial", 9);
                warehouse_vt_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                ValueObjectList<WarehouseVTVo> machineseial = (ValueObjectList<WarehouseVTVo>)DefaultCbmInvoker.Invoke(new GetMachineSerialCbm(), new WarehouseVTVo());
                machine_serial_cmb.DisplayMember = "MachineSerial";
                machine_serial_cmb.DataSource = machineseial.GetList();
                machine_serial_cmb.Text = "";
                warehouse_vt_dgv.Visible = true;
                datalost_dgv.Visible = false;
                warehouse_list_dgv.Visible = false;
            }
            //else
            //{
            //    this.Close();
            //}

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


        private void Rank_Dep_btn_Click(object sender, EventArgs e)
        {


        }
        private void exportcsv_btn_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("yyMMdd_HHmm");
            if (warehouse_list_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.csvclass exportexcel = new Common.csvclass();
                exportexcel.exportcsv(ref warehouse_list_dgv, linksave_txt.Text, this.TitleText + "_" + value_cmb.Text + "_" + datetime);
            }
            else if (datalost_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.csvclass exportexcel = new Common.csvclass();
                exportexcel.exportcsv(ref datalost_dgv, linksave_txt.Text, this.TitleText + "_" + value_cmb.Text + datetime);
            }
            else if (warehouse_vt_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.csvclass exportexcel = new Common.csvclass();
                exportexcel.exportcsv(ref warehouse_vt_dgv, linksave_txt.Text, this.TitleText + "_" + value_cmb.Text + datetime);
            }
        }
        private void exportexcel_btn_Click(object sender, EventArgs e)
        {
            string datetime = DateTime.Now.ToString("yyMMdd_HHmm");
            if (warehouse_list_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.Excel_Class exportexcel = new Common.Excel_Class();
                exportexcel.exportexcel(ref warehouse_list_dgv, linksave_txt.Text, this.TitleText + "_" + value_cmb.Text + "_" + datetime);
            }
            else if (datalost_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.Excel_Class exportexcel = new Common.Excel_Class();
                exportexcel.exportexcel(ref datalost_dgv, linksave_txt.Text, this.TitleText + "_" + value_cmb.Text + datetime);
            }
            else if (warehouse_vt_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.Excel_Class exportexcel = new Common.Excel_Class();
                exportexcel.exportexcel(ref warehouse_vt_dgv, linksave_txt.Text, this.TitleText + "_" + value_cmb.Text + datetime);
            }

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
        private void AutoCheck_btn_Click(object sender, EventArgs e)
        {
            if (checktime_cmb.Text != "")
            {
                if (AutoCheck_btn.Text == "Stop Auto")
                {
                    AutoCheck_btn.Text = "Starting Auto";
                    MessageBox.Show("Bắt đầu chạy tư động ");
                    timer1.Interval = 2000;
                    timer1.Enabled = true;
                }
                else
                {
                    AutoCheck_btn.Text = "Stop Auto";
                    MessageBox.Show("Dừng chế độ tư động ");
                    timer1.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Làm ơn chọn checktime");
                return;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (File.Exists(@"D:\VT CP\received.txt"))
            {             
                string text = System.IO.File.ReadAllText(@"D:\VT CP\received.txt");
                rfid_txt.Text = text;

                //code phan search copy qua
                {
                    warehouse_vt_dgv.DataSource = null;
                    warehouse_list_dgv.Visible = true;
                    warehouse_vt_dgv.Visible = false;
                    datalost_dgv.Visible = false;
                    if (checktime_cmb.SelectedItem != null && (rfid_txt.Text.Length == 10 || machine_serial_cmb.Text != ""))
                    {
                        Countrow();
                        warehouse_vt_dgv.DataSource = null;
                        GridBind();
                        if ((warehouse_vt_dgv.Rows.Count == 1) && (insert_update == "Insert"))
                        {
                            warehouse_vt_dgv.Visible = false;
                            WarehouseVTListVo outVo = new WarehouseVTListVo();
                            WarehouseVTListVo inVo = new WarehouseVTListVo()
                            {
                                MachineSerial = warehouse_vt_dgv.Rows[0].Cells[7].Value.ToString(),
                                ValueCheck = true,
                                CheckTime = int.Parse(checktime_cmb.Text),
                                RegistrationUserCode = UserData.GetUserData().UserName,
                                RegistrationDateTime = DateTime.Now
                            };
                            try
                            {
                                outVo = (WarehouseVTListVo)DefaultCbmInvoker.Invoke(new Cbm.AddNewListCheckVTCbm(), inVo);
                                warehouse_list_dgv.DataSource = null;
                                GridBindList();
                                exporttxtfile();
                                WarehouseVTVo outVo2 = new WarehouseVTVo();
                                WarehouseVTVo inVo2 = new WarehouseVTVo
                                {
                                    MachineSerial = warehouse_vt_dgv.Rows[0].Cells[7].Value.ToString(),
                                    TimeCheck = int.Parse(checktime_cmb.Text),
                                };
                                outVo2 = (WarehouseVTVo)DefaultCbmInvoker.Invoke(new Cbm.UpdateCheckTimeVTCbm(), inVo2);
                            }
                            catch
                            {
                                string textdatafaile = "May chu bi su co, kiem tra lai chuong trinh may chu";
                                exporttxtfile_mesger(textdatafaile);
                            }
                            warehouse_list_dgv.Visible = true;
                        }
                        //update
                        else if ((warehouse_vt_dgv.Rows.Count == 1) && (insert_update == "Update"))
                        {
                            string textduplicate = "Data bi trung, da check roi";
                            exporttxtfile_mesger(textduplicate);
                        }
                        ///////////////////////////////
                        else if (warehouse_vt_dgv.Rows.Count == 0)
                        {
                            string textdatalost = "May nay khong có trong danh sach database";
                            exporttxtfile_mesger(textdatalost);
                        }
                        else if (warehouse_vt_dgv.Rows.Count > 2)
                        {
                            string textdatafaile = "database sai cau truc, kiem tra lai database"; //sua lai
                            exporttxtfile_mesger(textdatafaile);
                        }
                    }
                    else
                    {
                        string textdatafaile = "Hệ thông có dữ liệu mới, hệ thống đang online";
                        exporttxtfile_mesger(textdatafaile);
                    }
                }
                File.Delete(@"D:\VT CP\received.txt");
            }
            {
                machine_serial_cmb.Text = "";
                rfid_txt.Text = "";
            }
        }
        void exporttxtfile()
        {
            if (!Directory.Exists(@"D:\VT CP"))
            {
                Directory.CreateDirectory(@"D:\VT CP");
            }

            TextWriter sw = new StreamWriter(@"D:\VT CP\transit.txt");
            int rowcount = warehouse_list_dgv.Rows.Count;

            sw.WriteLine("- Ma RFID: " + warehouse_list_dgv.Rows[0].Cells[1].Value.ToString() + "," + Environment.NewLine
                         + "- Thong Bao: " + warehouse_list_dgv.Rows[0].Cells[2].Value.ToString() + "," + Environment.NewLine
                         + "- User Check: " + warehouse_list_dgv.Rows[0].Cells[3].Value.ToString() + "," + Environment.NewLine
                         + "- Check Time: " + warehouse_list_dgv.Rows[0].Cells[4].Value.ToString() + "," + Environment.NewLine
                         + "- DateTime: " + warehouse_list_dgv.Rows[0].Cells[6].Value.ToString() + "<EOF>"
                          );
            sw.Close();
        }

        void exporttxtfile_mesger(string mesger)
        {
            //if (!Directory.Exists(@"D:\VT CP\transit.txt"))
            //{
            //    return;             
            //}
            if (!Directory.Exists(@"D:\VT CP"))
            {
                Directory.CreateDirectory(@"D:\VT CP");
            }
            TextWriter sw = new StreamWriter(@"D:\VT CP\transit.txt");
            int rowcount = warehouse_list_dgv.Rows.Count;

            sw.WriteLine("- Ma RFID: " + rfid_txt.Text + "," + Environment.NewLine
                         + "- Thong Bao: " + mesger + "," + Environment.NewLine
                         + "- User Check: " + UserData.GetUserData().UserName + "," + Environment.NewLine
                         + "- Check Time: " + checktime_cmb.Text + "," + Environment.NewLine
                         + "- DateTime: " + DateTime.Now.ToString() + "<EOF>"
                          );
            sw.Close();
        }
    }
}
