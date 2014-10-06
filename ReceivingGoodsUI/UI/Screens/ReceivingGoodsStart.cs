using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Kits.CommonUtils;
using Kits.CommonControls;
using Kits.RecvGoods.UI.Resources;
namespace Kits.RecvGoods.UI
{
    public partial class ReceivingGoodsStart : BasePanel
    {
        public ReceivingGoodsStart()
        {
            InitializeComponent();
            this.picBoxMenu.Image = UIResources.Menu_icon;
            this.picBoxSettings.Image = UIResources.Settings_icon;
            this.picBoxGoodsReceipt.Image = UIResources.GoodsReceipt_icon;
            this.picBoxLocMgmt.Image = UIResources.LocationMgmt_icon;
            this.picBoxPricing.Image = UIResources.Pricing_icon;
            this.picBoxStockCount.Image = UIResources.StockCount_icon;
        }

        
        public override void OnPanelActive()
        {
            this.Focus();
        }
        
        protected override string PanelTitle
        {
            get
            {
                return UIResources.ResourceManager.GetString("HomeScreenTitle");
            }
        }
        protected override bool ShowScreenHeader
        {
            get
            {
                return false;
            }
        }
        public override void InitializePanel()
        {
            
        }
        protected override MenuItem CreateLeftMenu()
        {
            MenuItem leftMenuItem = new MenuItem();
            leftMenuItem.Text = "Exit Application";
            leftMenuItem.Click += delegate(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.WaitCursor;
                WorkFlowManager.ActiveWorkFlow.Exit();    
                Cursor.Current = Cursors.Default;
            };
            return leftMenuItem;
        }
        protected override MenuItem CreateRightMenu()
        {
            MenuItem rightMenuItem = new MenuItem();
            rightMenuItem.Text = "";
            return rightMenuItem;
        }
        private void picBoxGoodsReceipt_Click(object sender, System.EventArgs e)
        {
            WorkFlowManager.ActiveWorkFlow.ShowNextPanel(typeof(EnterASNScreen));
        }
    }
}