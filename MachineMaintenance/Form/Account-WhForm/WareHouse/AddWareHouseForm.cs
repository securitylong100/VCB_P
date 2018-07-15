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
    public partial class AddWareHouseForm : FormCommonNCVP
    {
        public AddWareHouseForm()
        {
            InitializeComponent();
        }
        public WareHouseVo warehousevo = new WareHouseVo();

        private void AddWareHouseForm_Load(object sender, EventArgs e)
        {
          
            WareHouseVo whvo = new WareHouseVo();

            //load rank name
            ValueObjectList<RankVo> rankname = (ValueObjectList<RankVo>)DefaultCbmInvoker.Invoke(new GetRankCbm(), new RankVo());
            rank_name_cmb.DisplayMember = "RankName";
            rank_name_cmb.DataSource = rankname.GetList();

            //before_location_cmb load 
            LocationVo Locationvo = (LocationVo)DefaultCbmInvoker.Invoke(new GetLocationMasterMntCbm(), new LocationVo());
            before_location_cmb.DisplayMember = "LocationCode";
            before_location_cmb.DataSource = Locationvo.LocationListVo;

            qty_txt.Text = "1";
            unit_cmb.Items.Add("m");
            unit_cmb.Items.Add("pcs");
            unit_cmb.Items.Add("box");
            unit_cmb.Items.Add("pallet");
            unit_cmb.Items.Add("unit");

            user_location_name_cbm.Enabled = false;
            comments_txt.Enabled = true;
            if (warehousevo.WareHouseId > 0)
            {
                asset_code_txt.Enabled = false;
                timestart_dtp.Enabled = false;
                unit_cmb.Enabled = false;

                asset_code_txt.Text = warehousevo.AssetCode;
                rank_name_cmb.Text = warehousevo.RankName;
                qty_txt.Text = warehousevo.Qty.ToString();
                unit_cmb.Text = warehousevo.Unit;
                before_location_cmb.Text = warehousevo.BeforeLocation;
                after_location_cmb.Text = warehousevo.AfterLocation;
                timestart_dtp.Value = warehousevo.TimeStart;
                this.TitleText = Com.Nidec.Mes.GlobalMasterMaintenance.CommonConstants.MODE_UPDATE;
            }
            else
            {
                comments_txt.Text = "Add";
               
                this.TitleText = Com.Nidec.Mes.GlobalMasterMaintenance.CommonConstants.MODE_ADD;
            }
        }
        private void before_location_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (before_location_cmb.SelectedItem != null)
            {
                LocationVo Locationvo = (LocationVo)DefaultCbmInvoker.Invoke(new GetLocationMasterMntCbm(), new LocationVo());
                after_location_cmb.DataSource = Locationvo.LocationListVo;
                after_location_cmb.DisplayMember = "LocationCode";
            }
        }
        private void user_location_code_txt_TextChanged(object sender, EventArgs e)
        {
            if ((user_location_code_txt.Text.Length == 13) || (user_location_code_txt.Text.Length == 10) )
            {
                WareHouseVo inVo = new WareHouseVo()
                {
                    UserTem = user_location_code_txt.Text
                };
                ValueObjectList<UserLocationVo> userlocationvo = (ValueObjectList<UserLocationVo>)DefaultCbmInvoker.Invoke(new GetUserLocationCbm(), new UserLocationVo { UserLocationCode = inVo.UserTem });
                user_location_name_cbm.DisplayMember = "UserLocationName";
                user_location_name_cbm.DataSource = userlocationvo.GetList();           
            }
            else
            {
                user_location_name_cbm.Text = "";
                user_location_name_cbm.SelectedItem = null;
            }

        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            // WareHouseVo f = new WareHouseVo();
            if (checkdata())
            {
                WareHouseVo outVo = new WareHouseVo();
                WareHouseVo inVo = new WareHouseVo()
                {

                    WareHouseId = warehousevo.WareHouseId,
                    AssetCode = asset_code_txt.Text,
                    RankId = ((RankVo)this.rank_name_cmb.SelectedItem).RankId,
                    Qty = Int16.Parse(qty_txt.Text),
                    Unit = unit_cmb.Text,
                    UserLocationCode = user_location_code_txt.Text,
                    TimeStart = timestart_dtp.Value,
                    BeforeLocation = ((LocationVo)this.before_location_cmb.SelectedItem).LocationCode,
                    AfterLocation = after_location_cmb.Text,
                    Comments = comments_txt.Text,
                    RegistrationUserCode = UserData.GetUserData().UserCode,
                    FactoryCode = UserData.GetUserData().FactoryCode,
                    RegistrationDateTime = DateTime.Now
                };
                try
                {
                    if (inVo.WareHouseId > 0)
                    {
                        // outVo = (WareHouseVo)DefaultCbmInvoker.Invoke(new Cbm.UpdateWareHouseUserCbm(), inVo);
                        outVo = (WareHouseVo)DefaultCbmInvoker.Invoke(new Cbm.AddWareHouseCbm(), inVo);

                    }
                    else
                    {
                        outVo = (WareHouseVo)DefaultCbmInvoker.Invoke(new Cbm.AddWareHouseCbm(), inVo);

                    }
                }
                catch (Framework.ApplicationException exception)
                {
                    popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                    logger.Error(exception.GetMessageData());
                    return;
                }
                if (outVo.AffectedCount > 0)
                {
                    messageData = new MessageData("mmce00001", Properties.Resources.mmce00001, asset_code_lbl.Text + " : " + asset_code_txt.Text);
                    logger.Info(messageData);
                    popUpMessage.Information(messageData, Text);
                    return;
                }
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void unit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (asset_code_txt.TextLength >= 10)
            {
                asset_code_txt.Text = asset_code_txt.Text.Substring(0, 10);
            }
        }

        bool checkdata()
        {
            if (user_location_name_cbm.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, user_location_name_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                user_location_name_cbm.Focus();
                return false;
            }
         
            if (asset_code_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, asset_code_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                asset_code_txt.Focus();
                return false;
            }
            if (rank_name_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, rank_name_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                rank_name_cmb.Focus();
                return false;
            }
            if (qty_txt.Text == "")
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, qty_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                qty_txt.Focus();
                return false;
            }
            if (unit_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, unit_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                unit_cmb.Focus();
                return false;
            }
            if (before_location_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, before_location_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                before_location_cmb.Focus();
                return false;
            }
            if (after_location_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, after_location_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                after_location_cmb.Focus();
                return false;
            }

            if (timestart_dtp.Value > DateTime.Now)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, "Time Error");
                popUpMessage.Warning(messageData, Text);
                timestart_dtp.Focus();
                return false;
            }
            return true;
        }

      
    }
}
