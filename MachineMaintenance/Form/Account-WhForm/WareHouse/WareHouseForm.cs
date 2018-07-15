using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Excel = Microsoft.Office.Interop.Excel;


namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance.Form
{
    public partial class WareHouseForm : FormCommonNCVP
    {
        public WareHouseForm()
        {
            InitializeComponent();
            ware_house_dgv.AutoGenerateColumns = false;
        }
        private void WareHouseForm_Load(object sender, EventArgs e)
        {
            //this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            //this.Height = Screen.PrimaryScreen.WorkingArea.Height - 300;
            //this.ware_house_dgv.Height = Screen.PrimaryScreen.WorkingArea.Height - 300;

            AcceptButton = search_btn;
            select_search_cbm.Items.Add("Search History");
            select_search_cbm.Items.Add("Search List");
            select_search_cbm.Text = "Search History";
            ware_house_dgv.ReadOnly = true;

            ValueObjectList<RankVo> rankcode = (ValueObjectList<RankVo>)DefaultCbmInvoker.Invoke(new GetRankCbm(), new RankVo());
            rank_code_cbm.DisplayMember = "RankCode";
            rank_code_cbm.DataSource = rankcode.GetList();
            rank_code_cbm.Text = "";

            ValueObjectList<AssetVo> assetvotype = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetTypeCbm(), new AssetVo());
            asset_type_cbm.DisplayMember = "AssetType";
            asset_type_cbm.DataSource = assetvotype.GetList();
            asset_type_cbm.Text = "";

            ValueObjectList<AssetVo> assetvomodel = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetModelCbm(), new AssetVo());
            asset_model_cbm.DisplayMember = "AssetModel";
            asset_model_cbm.DataSource = assetvomodel.GetList();
            asset_model_cbm.Text = "";

            ValueObjectList<AssetVo> assetvoname = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetNameCbm(), new AssetVo());
            asset_name_cbm.DisplayMember = "AssetName";
            asset_name_cbm.DataSource = assetvoname.GetList();
            asset_name_cbm.Text = "";

            ValueObjectList<AssetVo> assetvoinvoice = (ValueObjectList<AssetVo>)DefaultCbmInvoker.Invoke(new GetAssetInvoiceCbm(), new AssetVo());
            invoice_cbm.DisplayMember = "AssetInvoice";
            invoice_cbm.DataSource = assetvoinvoice.GetList();
            invoice_cbm.Text = "";

            LocationVo Locationvo = (LocationVo)DefaultCbmInvoker.Invoke(new GetLocationMasterMntCbm(), new LocationVo());
            select_after_location_cbm.DisplayMember = "LocationCode";
            select_after_location_cbm.DataSource = Locationvo.LocationListVo;
            select_after_location_cbm.Text = "";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

            AddWareHouseForm Formadd = new AddWareHouseForm();


            // Formadd.vo = new WareHouseVo();
            if (Formadd.ShowDialog() == DialogResult.OK)
            {
                //call function
            }
        }
        private void update_btn_Click(object sender, EventArgs e)
        {
            if (ware_house_dgv.SelectedCells.Count > 0)
            {
                WareHouseVo selectedvo = (WareHouseVo)ware_house_dgv.CurrentRow.DataBoundItem;

                if (new AddWareHouseForm { warehousevo = selectedvo, }.ShowDialog() == DialogResult.OK)
                { GridBind(); }
            }
        }

        //search data
        private void search_btn_Click(object sender, EventArgs e)
        {
          
            ware_house_dgv.DataSource = null;
            GridBind();
        }


        private void GridBind()
        {
            try
            {
                WareHouseVo whvos = new WareHouseVo()
                {
                    AssetCode = asset_Code_txt.Text,
                    RankCode = rank_code_cbm.Text,
                    AssetModel = asset_model_cbm.Text,
                    AssetName = asset_name_cbm.Text,
                    Invoice = invoice_cbm.Text,
                    AfterLocation = select_after_location_cbm.Text,
                    AssetType = asset_type_cbm.Text
                };

                if (select_search_cbm.Text == "Search History")
                {
                    ValueObjectList<WareHouseVo> listvo = (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new Cbm.SeachWareHouseCbm(), whvos);
                    ware_house_dgv.DataSource = listvo.GetList();
                }
                else if (select_search_cbm.Text == "Search List")
                {
                    ValueObjectList<WareHouseVo> listvo = (ValueObjectList<WareHouseVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchListWareHouseCbm(), whvos);
                    ware_house_dgv.DataSource = listvo.GetList();
                }

            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ware_house_dgv.DataSource = null;
            asset_Code_txt.Text = null;
            asset_model_cbm.Text = null;
            rank_code_cbm.Text = null;
            asset_name_cbm.Text = null;
            invoice_cbm.Text = null;
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
        private void exportexcel_btn_Click(object sender, EventArgs e)
        {
          Com.Nidec.Mes.Common.Basic.MachineMaintenance.Common.Excel_Class exportexcel = new Common.Excel_Class();
           exportexcel.exportexcel(ref ware_house_dgv, linksave_txt.Text, this.Text);
        }
    }
}
