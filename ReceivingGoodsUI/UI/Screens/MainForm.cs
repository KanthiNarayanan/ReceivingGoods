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

//included comment
namespace Kits.RecvGoods.UI
{
    public partial class MainForm : Form
    {
        SplashForm splashScreen;
        public MainForm()
        {
           splashScreen= new SplashForm();
           splashScreen.Show();
            
            InitializeComponent();
        }

        void MainForm_Load(object sender, System.EventArgs e)
        {
            
           splashScreen.Close();
            //this.BringToFront();
            //splashScreen = null;
            WorkFlowManager.ActiveWorkFlow = WorkFlowManager.Create("HomeScreen", MainPanel, typeof(ReceivingGoodsStart));
            WorkFlowManager.Activate("HomeScreen");
            WorkFlowManager.ActiveWorkFlow.MainMenuPanel = typeof(ReceivingGoodsStart);
            //Cursor.Current = Cursors.Default; 
           /* Label lbl = new Label();
            lbl.Text = "Sample";
            this.Controls[1].Controls.Add(lbl);
            this.Show();*/

           

        }
        private void menuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_GotFocus(object sender, System.EventArgs e)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                BasePanel basePanel = ((BasePanel)MainPanel.Controls[0]);
                basePanel.OnPanelActive();
            }
        }
          

    }
}