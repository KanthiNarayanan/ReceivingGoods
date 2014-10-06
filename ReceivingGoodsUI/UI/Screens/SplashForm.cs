using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Resources;
using System.Reflection;
using System.Windows.Forms;
using Kits.RecvGoods.UI.Resources;

namespace Kits.RecvGoods.UI
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            loadingLabel.Text = UIResources.ResourceManager.GetString("Splash Loading");
            waitLabel.Text = UIResources.ResourceManager.GetString("PleaseWait");
            versionLabel.Text = UIResources.ResourceManager.GetString("Version");
            versionTextBox.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        

        private void label1_ParentChanged(object sender, EventArgs e)
        {

        }
    }
}