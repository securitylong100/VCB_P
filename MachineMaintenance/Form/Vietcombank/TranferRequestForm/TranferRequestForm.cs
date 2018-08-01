using System;
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
            TranferRequest_dgv.AutoGenerateColumns = false;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            AddTranferRequestForm addtrffer = new AddTranferRequestForm();
            addtrffer.ShowDialog();
        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
            GridBind();
        }
        private void GridBind()
        {
            try
            {
                TranferRequestVo invo = new TranferRequestVo()
                {
                };
                ValueObjectList<TranferRequestVo> listvo = (ValueObjectList<TranferRequestVo>)DefaultCbmInvoker.Invoke(new Cbm.SearchTranferRequestVCBCbm(), invo);
                TranferRequest_dgv.DataSource = listvo.GetList();

            }
            catch (Framework.ApplicationException exception)
            {
                popUpMessage.ApplicationError(exception.GetMessageData(), Text);
                logger.Error(exception.GetMessageData());
            }
        }

        private void TranferRequestForm_Load(object sender, EventArgs e)
        {

        }
    }


}
