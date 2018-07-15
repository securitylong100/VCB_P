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
    public partial class AddCommentDatalostVT : FormCommonNCVP
    {
        public AddCommentDatalostVT()
        {
            InitializeComponent();
        }
        public WarehouseVTListVo WareHouseVTListVo = new WarehouseVTListVo(); //dv
        private void AddNewMachineVT_Load(object sender, EventArgs e)
        {
           
            rfid_txt.Text = WareHouseVTListVo.RFId;
            machine_serial_txt.Text = WareHouseVTListVo.MachineSerial;
            checktime_txt.Text = WareHouseVTListVo.CheckTime.ToString();
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (checkdata())
            {
                WarehouseVTListVo outVo = new WarehouseVTListVo();
                WarehouseVTListVo inVo = new WarehouseVTListVo()
                {
                    RFId = rfid_txt.Text,
                    MachineSerial = machine_serial_txt.Text,
                    CheckTime = int.Parse(checktime_txt.Text),
                    Comment = comment_txt.Text
                };
                try
                {
                        outVo = (WarehouseVTListVo)DefaultCbmInvoker.Invoke(new Cbm.AddListDatalostVTCbm(), inVo);

                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                    return;
                }
                if (outVo.AffectedCount > 0)    
                {
                    messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, machine_serial_txt.Text + " : " + machine_serial_txt.Text);
                    logger.Info(messageData);
                    popUpMessage.Information(messageData, Text);
                    return;
                }
            }

        }
          bool checkdata()
        {       
       
            if (checktime_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, checktime_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                checktime_txt.Focus();
                return false;
            }
            if (comment_txt.Text.Length <5)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, comment_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                comment_txt.Focus();
                return false;
            }
            return  true;
        } 

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
