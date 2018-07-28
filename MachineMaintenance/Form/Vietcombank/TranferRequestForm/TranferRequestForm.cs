﻿using System;
using System.Windows.Forms;
using Com.Nidec.Mes.Framework;
using Com.Nidec.Mes.GlobalMasterMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Vo;
using Com.Nidec.Mes.Common.Basic.MachineMaintenance.Cbm;
using Com.Nidec.Mes.GlobalMasterMaintenance;

namespace Com.Nidec.Mes.Common.Basic.MachineMaintenance
{
    public partial class TranferRequestForm : FormCommonNCVP
    {
        public TranferRequestForm()
        {
            InitializeComponent();

        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddTranferRequestForm addtrffer = new AddTranferRequestForm();
            addtrffer.ShowDialog();
        }
    }


}