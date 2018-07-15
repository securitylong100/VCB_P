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

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    public partial class WarehouseMainForm : FormCommonNCVP
    {
        public WarehouseMainForm()
        {
            InitializeComponent();
            warehouse_main_dgv.AutoGenerateColumns = false;
            account_depreciation_dgv.AutoGenerateColumns = false;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            account_depreciation_dgv.Visible = false;
            warehouse_main_dgv.Visible = true;
            warehouse_main_dgv.DataSource = null;
            GridBind();
        }
        private void GridBind()
        {
            try
            {
                WareHouseMainVo whvos = new WareHouseMainVo()
                {
                    AssetCode = asset_Code_txt.Text,
                    RankCode = rank_code_cbm.Text,
                    AssetType = asset_type_cbm.Text,
                    AccountCodeCode = detail_position_cmb.Text,
                    AccountLocationCode = select_search_cbm.Text,
                    AssetInvoice = invoice_cbm.Text,
                    AssetModel = asset_model_cbm.Text,
                    AfterLocationCd = location_cbm.Text,
                    AssetName = asset_name_cbm.Text,
                    DetailPositionCd = detail_position_cmb.Text,

                    //AssetNo = 
                };

                if (select_search_cbm.Text == "Search History")
                {
                    ValueObjectList<WareHouseMainVo> listvo = (ValueObjectList<WareHouseMainVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchWareHouseMainCbm(), whvos);
                    warehouse_main_dgv.DataSource = listvo.GetList();
                }
                else if (select_search_cbm.Text == "Search List")
                {
                    ValueObjectList<WareHouseMainVo> listvo = (ValueObjectList<WareHouseMainVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchListWareHouseMainCbm(), whvos);
                    warehouse_main_dgv.DataSource = listvo.GetList();
                }
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            AddWareHouseMainForm addaccountmain = new AddWareHouseMainForm();
            addaccountmain.ShowDialog();
        }

        private void WareHouseMainForm_Load(object sender, EventArgs e)
        {
            AcceptButton = search_btn;
            select_search_cbm.Items.Add("Search History");
            select_search_cbm.Items.Add("Search List");
            select_search_cbm.Text = "Search History";

            {
                account_depreciation_dgv.DefaultCellStyle.Font = new Font("Arial", 9);
                account_depreciation_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                warehouse_main_dgv.DefaultCellStyle.Font = new Font("Arial", 9);
                warehouse_main_dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            }


            AcceptButton = search_btn;
            ValueObjectList<RankVo> rankcode = (ValueObjectList<RankVo>)DefaultCbmInvoker.Invoke(new GetRankCbm(), new RankVo());
            rank_code_cbm.DisplayMember = "RankCode";
            rank_code_cbm.DataSource = rankcode.GetList();
            rank_code_cbm.Text = "";

            ValueObjectList<AssetVo> assetvotype = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetTypeCbm(), new AssetVo());
            asset_type_cbm.DisplayMember = "AssetType";
            asset_type_cbm.DataSource = assetvotype.GetList();
            asset_type_cbm.Text = "";

            // account_code
            ValueObjectList<DetailPositionVo> detailposition = (ValueObjectList<DetailPositionVo>)DefaultCbmInvoker.Invoke(new GetDetailPositionCbm(), new DetailPositionVo());
            detail_position_cmb.DisplayMember = "DetailPositionCode";
            detail_position_cmb.DataSource = detailposition.GetList();
            detail_position_cmb.Text = "";

          

            ValueObjectList<AssetVo> assetvoinvoice = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetInvoiceCbm(), new AssetVo());
            invoice_cbm.DisplayMember = "AssetInvoice";
            invoice_cbm.DataSource = assetvoinvoice.GetList();
            invoice_cbm.Text = "";

            ValueObjectList<AssetVo> assetvomodel = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetModelCbm(), new AssetVo());
            asset_model_cbm.DisplayMember = "AssetModel";
            asset_model_cbm.DataSource = assetvomodel.GetList();
            asset_model_cbm.Text = "";

            ValueObjectList<AssetVo> assetvoname = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetNameCbm(), new AssetVo());
            asset_name_cbm.DisplayMember = "AssetName";
            asset_name_cbm.DataSource = assetvoname.GetList();
            asset_name_cbm.Text = "";

            LocationVo Locationvo = (LocationVo)DefaultCbmInvoker.Invoke(new GetLocationMasterMntCbm(), new LocationVo());
            location_cbm.DisplayMember = "LocationCode";
            location_cbm.DataSource = Locationvo.LocationListVo;
            location_cbm.Text = "";
        }
        public void trimcode()
        {
            if (full_asset_Code_txt.TextLength >= 10)
            {
                asset_Code_txt.Text = full_asset_Code_txt.Text.Substring(0, 10);
                asset_Code_txt.Enabled = false;
            }
            else
            {
                asset_Code_txt.Enabled = true;
                asset_Code_txt.Text = "";
            }
        }

        private void full_asset_Code_txt_TextChanged(object sender, EventArgs e)
        {
            trimcode();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (warehouse_main_dgv.SelectedCells.Count > 0)
            {
                WareHouseMainVo selectedvo = (WareHouseMainVo)warehouse_main_dgv.CurrentRow.DataBoundItem;

                if (new AddWareHouseMainForm { WareHouseMainVo = selectedvo, }.ShowDialog() == DialogResult.OK)
                { GridBind(); }
            }
        }

        private void depreciation_btn_Click(object sender, EventArgs e)
        {
            account_depreciation_dgv.Visible = true;
            warehouse_main_dgv.Visible = false;
            account_depreciation_dgv.DataSource = null;

            account_depreciation_dgv.Columns[0].HeaderText = "Account Name";

            try
            {
                WareHouseMainVo whvos = new WareHouseMainVo()
                {

                };
                ValueObjectList<WareHouseMainVo> listvo = (ValueObjectList<WareHouseMainVo>)DefaultCbmInvoker.Invoke(new Cbm.TotalDEPWareHouseMainCbm(), whvos);
                account_depreciation_dgv.DataSource = listvo.GetList();
               
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }

        }

        private void Rank_Dep_btn_Click(object sender, EventArgs e)
        {
            account_depreciation_dgv.Visible = true;
            warehouse_main_dgv.Visible = false;
            account_depreciation_dgv.DataSource = null;
            account_depreciation_dgv.Columns[0].HeaderText = "Rank Name";
            try
            {
                WareHouseMainVo whvos = new WareHouseMainVo()
                {

                };
                ValueObjectList<WareHouseMainVo> listvo = (ValueObjectList<WareHouseMainVo>)DefaultCbmInvoker.Invoke(new Cbm.TotalRankDEPWareHouseMainCbm(), whvos);
                account_depreciation_dgv.DataSource = listvo.GetList();
            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }

        }

        private void exportexcel_btn_Click(object sender, EventArgs e)
        {
            if (account_depreciation_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.Excel_Class exportexcel = new Common.Excel_Class();
                exportexcel.exportexcel(ref account_depreciation_dgv, linksave_txt.Text, account_depreciation_dgv.Columns[0].HeaderText);
            }
            else if (warehouse_main_dgv.Visible == true)
            {
                Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.Excel_Class exportexcel = new Common.Excel_Class();
                exportexcel.exportexcel(ref warehouse_main_dgv, linksave_txt.Text, this.Text);

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
    }
}
