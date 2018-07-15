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
    public partial class AddWareHouseMainForm : FormCommonNCVP
    {
        public AddWareHouseMainForm()
        {
            InitializeComponent();
        }
        public WareHouseMainVo WareHouseMainVo = new WareHouseMainVo(); //dv
        private void AddWareHouseMainForm_Load(object sender, EventArgs e)
        {
            user_location_name_cmb.Enabled = false;
            asset_model_cmb.Enabled = false;
            no_cbm.Enabled = false;
            no_lbl.Enabled = false;
            //rank
            ValueObjectList<RankVo> rankname = (ValueObjectList<RankVo>)DefaultCbmInvoker.Invoke(new GetRankCbm(), new RankVo());
            rank_code_cmb.DisplayMember = "RankCode";
            rank_code_cmb.DataSource = rankname.GetList();
            rank_code_cmb.Text = "";


            //location 
            LocationVo Locationvo = (LocationVo)DefaultCbmInvoker.Invoke(new GetLocationMasterMntCbm(), new LocationVo());
            before_location_cmb.DataSource = Locationvo.LocationListVo;
            before_location_cmb.DisplayMember = "LocationCode";
            before_location_cmb.Text = "";

            // account_code
            ValueObjectList<AccountCodeVo> accountcodevo = (ValueObjectList<AccountCodeVo>)DefaultCbmInvoker.Invoke(new GetAccountCodeCbm(), new AccountCodeVo());
            account_code_cmb.DisplayMember = "AccountCodeCode";
            account_code_cmb.DataSource = accountcodevo.GetList();
            account_code_cmb.Text = "";

            //accountlocationcode
            ValueObjectList<AccountLocationVo> accountlocationcodevo = (ValueObjectList<AccountLocationVo>)DefaultCbmInvoker.Invoke(new GetAccountLocationCbm(), new AccountLocationVo());
            section_cd_cmb.DisplayMember = "AccountLocationCode";
            section_cd_cmb.DataSource = accountlocationcodevo.GetList();
            section_cd_cmb.Text = "";


            //cau cua dang
            ValueObjectList<AssetVo> assetmodelvo = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetCbm(), new AssetVo());
            no_cbm.DisplayMember = "AssetNo";
            no_cbm.ValueMember = "AssetId";
            no_cbm.DataSource = assetmodelvo.GetList();
            //end

            {
                unit_cmb.Items.Add("m");
                unit_cmb.Items.Add("pcs");
                unit_cmb.Items.Add("box");
                unit_cmb.Items.Add("pallet");
                unit_cmb.Items.Add("unit");
                unit_cmb.Items.Add("set");
                unit_cmb.Text = "";
            }

            {
                user_location_name_cmb.Enabled = false;
                asset_model_cmb.Enabled = false;
                end_depreciation_dtp.Enabled = false;
                asset_life_cmb.Enabled = false;
                acquisition_cost_cmb.Enabled = false;
                current_depreciation_txt.Enabled = false;
                monthl_depreciation_txt.Enabled = false;
                accum_depreciation_txt.Enabled = false;
                net_value_txt.Enabled = false;
                start_depreciation_dtp.Enabled = false;
            }
            if (WareHouseMainVo.WareHouseMainId > 0)
            {
                asset_code_txt.Enabled = false;
              
                before_location_cmb.Text = WareHouseMainVo.BeforeLocationCd;
                after_location_cmb.Text = WareHouseMainVo.AfterLocationCd;
                detail_position_cmb.Text = WareHouseMainVo.DetailPositionCd;
                no_cbm.Text = WareHouseMainVo.AssetNo.ToString();
                asset_code_txt.Text = WareHouseMainVo.AssetCode;
                asset_model_cmb.Text = WareHouseMainVo.AssetModel;
                rank_code_cmb.Text = WareHouseMainVo.RankCode;
                account_code_cmb.Text = WareHouseMainVo.AccountCodeCode;
                section_cd_cmb.Text = WareHouseMainVo.AccountLocationCode;               
                qty_txt.Text = WareHouseMainVo.QTY.ToString();
                unit_cmb.Text = WareHouseMainVo.Unit;
                start_depreciation_dtp.Value = WareHouseMainVo.StartDepreciation;
                end_depreciation_dtp.Value = WareHouseMainVo.EndDepreciation;
                asset_life_cmb.Text = WareHouseMainVo.AssetLife.ToString();
                acquisition_cost_cmb.Text = WareHouseMainVo.AcquisitionCost.ToString();
                current_depreciation_txt.Text = WareHouseMainVo.CurrentDepreciation.ToString();
                monthl_depreciation_txt.Text = WareHouseMainVo.MonthlyDepreciation.ToString();
                accum_depreciation_txt.Text = WareHouseMainVo.AccumDepreciation.ToString();
                net_value_txt.Text = WareHouseMainVo.NetValue.ToString();

                // unit_cmb.SelectedItem = null;
                //int assetid = 0;
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
            //location 
            LocationVo Locationvo = (LocationVo)DefaultCbmInvoker.Invoke(new GetLocationMasterMntCbm(), new LocationVo());
            after_location_cmb.DataSource = Locationvo.LocationListVo;
            after_location_cmb.DisplayMember = "LocationCode";
          

            ValueObjectList<DetailPositionVo> detailposition = (ValueObjectList<DetailPositionVo>)DefaultCbmInvoker.Invoke(new GetDetailPositionCbm(), new DetailPositionVo());
            detail_position_cmb.DisplayMember = "DetailPositionCode";
            detail_position_cmb.DataSource = detailposition.GetList();
            detail_position_cmb.Text = "";

        }
        private void ok_btn_Click(object sender, EventArgs e)
        {
            if (Checkdata())
            {
                WareHouseMainVo outVo = new WareHouseMainVo();
                WareHouseMainVo inVo = new WareHouseMainVo()
                {

                    WareHouseMainId = WareHouseMainVo.WareHouseMainId,
                    ///
                    BeforeLocationId = ((LocationVo)this.before_location_cmb.SelectedItem).LocationId,
                    DetailPositionId = ((DetailPositionVo)this.detail_position_cmb.SelectedItem).DetailPositionId,
                    AfterLocationId = ((LocationVo)this.after_location_cmb.SelectedItem).LocationId,
                    AssetId = ((AssetVo)this.no_cbm.SelectedItem).AssetId,
                    QTY = Int16.Parse(qty_txt.Text),
                    Unit = unit_cmb.Text,
                    AssetNo = Int16.Parse(no_cbm.Text),
                    AccountCodeId = ((AccountCodeVo)this.account_code_cmb.SelectedItem).AccountCodeId,
                    AccountLocationId = ((AccountLocationVo)this.section_cd_cmb.SelectedItem).AccountLocationId,
                    RankId = ((RankVo)this.rank_code_cmb.SelectedItem).RankId,
                    CommnetsData = comments_txt.Text,
                    StartDepreciation = start_depreciation_dtp.Value,
                    EndDepreciation = end_depreciation_dtp.Value,
                    CurrentDepreciation = double.Parse(current_depreciation_txt.Text),
                    MonthlyDepreciation = double.Parse(monthl_depreciation_txt.Text),
                    AccumDepreciation = double.Parse(accum_depreciation_txt.Text),
                    NetValue = double.Parse(net_value_txt.Text),
                  //  LocationId = ((LocationVo)this.location_cmb.SelectedItem).LocationId,
                    UserLocationId = ((UserLocationVo)this.user_location_name_cmb.SelectedItem).UserLocationId,
                    RegistrationDateTime = DateTime.Now,
                    FactoryCode = UserData.GetUserData().FactoryCode,
                    RegistrationUserCode = UserData.GetUserData().UserCode
                };
                try
                {
                    if (inVo.WareHouseMainId > 0)
                    {
                        outVo = (WareHouseMainVo)DefaultCbmInvoker.Invoke(new Cbm.AddWareHouseMainCbm(), inVo);
                        //  outVo = (WareHouseVo)DefaultCbmInvoker.Invoke(new Cbm.AddWareHouseCbm(), inVo);
                    }
                    else
                    {
                        outVo = (WareHouseMainVo)DefaultCbmInvoker.Invoke(new Cbm.AddWareHouseMainCbm(), inVo);
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

        private void user_location_code_txt_TextChanged(object sender, EventArgs e)
        {
            if ((user_location_code_txt.Text.Length == 13) || (user_location_code_txt.Text.Length == 10))
            {
                WareHouseMainVo inVo = new WareHouseMainVo()
                {
                    UserTem = user_location_code_txt.Text
                };
                ValueObjectList<UserLocationVo> userlocationvo = (ValueObjectList<UserLocationVo>)DefaultCbmInvoker.Invoke(new GetUserLocationCbm(), new UserLocationVo { UserLocationCode = inVo.UserTem });
                user_location_name_cmb.DisplayMember = "UserLocationName";
                user_location_name_cmb.DataSource = userlocationvo.GetList();
            }
            else
            {
                user_location_name_cmb.Text = "";
                user_location_name_cmb.SelectedItem = null;
            }
        }

        private void unit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            no_cbm.Enabled = true;
            no_lbl.Enabled = true;
            try
            {
                //process asset code
                if (asset_code_txt.TextLength >= 10)
                {
                    asset_code_txt.Text = asset_code_txt.Text.Substring(0, 10);
                    start_depreciation_dtp.Enabled = true;
                }

                callvaluecost(sender, e);
                if (WareHouseMainVo.WareHouseMainId <= 0)
                {
                    ValueObjectList<AssetVo> assetmodelvo1 = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetCbm(), new AssetVo { AssetCode = asset_code_txt.Text });
                    no_cbm.DisplayMember = "AssetNo";
                    no_cbm.ValueMember = "AssetId";
                    no_cbm.DataSource = assetmodelvo1.GetList();
                }
                else
                {
                    ValueObjectList<AssetVo> assetmodelvo1 = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetCbm(), new AssetVo { AssetCode = asset_code_txt.Text });
                    asset_model_cmb.DisplayMember = "AssetModel";
                    asset_model_cmb.DataSource = assetmodelvo1.GetList();
                    asset_model_cmb.DataSource = assetmodelvo1.GetList();
                    no_cbm.Enabled = false;

                }

            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
                return;
            }
        }
        //call value cost
        private void callvaluecost(object sender, EventArgs e)
        {
            //call asset model ok
            ValueObjectList<AssetVo> assetmodelvo = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetCbm(), new AssetVo { AssetId = int.Parse(no_cbm.SelectedValue.ToString()) });

            asset_model_cmb.DisplayMember = "AssetModel";
            asset_model_cmb.DataSource = assetmodelvo.GetList();

            //life                    
            asset_life_cmb.DisplayMember = "AssetLife";
            asset_life_cmb.DataSource = assetmodelvo.GetList();
            //AcquistionCost                    
            acquisition_cost_cmb.DisplayMember = "AcquistionCost";
            acquisition_cost_cmb.DataSource = assetmodelvo.GetList();
            //call again datetime
            start_depreciation_dtp_CloseUp(sender, e);
            //call vaule
        }

        private void start_depreciation_dtp_CloseUp(object sender, EventArgs e)
        {
            DateTime dt = start_depreciation_dtp.Value.Date.AddMonths(int.Parse(asset_life_cmb.Text) * 12);
            end_depreciation_dtp.Value = dt;
            // WareHouseMainVo
            int YearNow = int.Parse(datetime_view_dtp.Value.ToString("yyyy"));
            int MonthNow = int.Parse(datetime_view_dtp.Value.ToString("MM"));
            int YearStart = int.Parse(start_depreciation_dtp.Value.ToString("yyyy"));
            int MonthStart = int.Parse(start_depreciation_dtp.Value.ToString("MM"));
            WareHouseMainVo.MonthCounter = ((YearNow - YearStart) * 12) + (MonthNow - MonthStart);

            //callmonthly dep 
            monthl_depreciation_txt.Text = Math.Round(((double.Parse(acquisition_cost_cmb.Text) / (double.Parse(asset_life_cmb.Text) * 12))), 2).ToString();

            //call current_depreciation_txt
            current_depreciation_txt.Text = Math.Round((WareHouseMainVo.MonthCounter * (double.Parse(monthl_depreciation_txt.Text))), 2).ToString();
            //call accum_depreciation_txt
            accum_depreciation_txt.Text = Math.Round((double.Parse(current_depreciation_txt.Text) + double.Parse(monthl_depreciation_txt.Text)), 2).ToString();
            //call net_value_txt
            net_value_txt.Text = Math.Round((double.Parse(acquisition_cost_cmb.Text) - (double.Parse(accum_depreciation_txt.Text))), 2).ToString();
        }
        /*
        thuat toan
        A = acquisition_cost_cmb.Text
        B = current_depreciation_txt.Text
        C =  monthl_depreciation_txt.Text
        D = accum_depreciation_txt.Text
        E = net_value_txt.Text
        WareHouseMainVo.MonthCounter = y nhu tren
        TL = asset_life_cmb.Text
        ==>
        C= A/(TL*12)
        B = WareHouseMainVo.MonthCounter*c
        D = B+ C
        E = A -D
        */
        bool Checkdata()
        {
            if (user_location_code_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, UserCode_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                user_location_code_txt.Focus();
                return false;
            }
            if (asset_code_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, asset_code_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                asset_code_txt.Focus();
                return false;
            }
            if (rank_code_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, rank_code_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                rank_code_cmb.Focus();
                return false;
            }
            if (account_code_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, account_code_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                account_code_cmb.Focus();
                return false;
            }
            if (section_cd_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, section_cd_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                section_cd_cmb.Focus();
                return false;
            }
            if (after_location_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, location_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                after_location_cmb.Focus();
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
            if (detail_position_cmb.SelectedItem == null)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, detail_position_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                detail_position_cmb.Focus();
                return false;
            }
            if (qty_txt.Text.Trim().Length == 0)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, qty_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                qty_txt.Focus();
                return false;
            }

            if (end_depreciation_dtp.Value <= start_depreciation_dtp.Value)
            {
                messageData = new MessageData("mmcc00005", Properties.Resources.mmcc00005, end_depreciation_lbl.Text);
                popUpMessage.Warning(messageData, Text);
                end_depreciation_dtp.Focus();
                return false;
            }
            return true;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void no_cbm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string no = this.no_cbm.SelectedValue.ToString();
        }


    }
}
