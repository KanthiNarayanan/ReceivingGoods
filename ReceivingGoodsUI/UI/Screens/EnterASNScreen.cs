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
    public partial class EnterASNScreen : BasePanel
    {

        private string InputDeliveryNumber; 
        public EnterASNScreen()
        {
            InitializeComponent();
        }
        public override void OnPanelActive()
        {
            this.Focus();
        }
        protected override bool ShowScreenHeader
        {
            get
            {
                return true;
            }
        }
        protected override string ScreenHeaderVal
        {
            get
            {
                return UIResources.ResourceManager.GetString("GoodsReceiptEnterDeliveryNo");
            }
        } 
        protected override string PanelTitle
        {
            get
            {
                return UIResources.ResourceManager.GetString("GoodsReceiptStartTitle");
            }
        }
        protected override MenuItem CreateLeftMenu()
        {
            MenuItem leftMenuItem = new MenuItem();
            leftMenuItem.Text = "Back";
            leftMenuItem.Click += delegate(object sender, EventArgs e)
            {
                Cursor.Current = Cursors.WaitCursor;
                WorkFlowManager.ActiveWorkFlow.ShowPreviousPanel();
                Cursor.Current = Cursors.Default;
            };
            return leftMenuItem;
        }
        protected override MenuItem CreateRightMenu()
        {
            MenuItem rightMenuItem = new MenuItem();
            InputDeliveryNumber = WMTxtASN.Text;
            rightMenuItem.Text = "Enter";
            rightMenuItem.Click += delegate(object sender, EventArgs e)
                {
                    validateDeliveryNumber(InputDeliveryNumber);
                    
                };
            return rightMenuItem;
        }
        public override void InitializePanel()
        {
            
        }
        

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Click Event");
        }
        public void validateDeliveryNumber(string DelNo) {
            try
            {
                if (DelNo != "")
                {

                }
                else
                {
                    throw new Exception("ASN not Entered");
                }
            }
            catch (Exception ex) { 

            }
        }
        
    }
}