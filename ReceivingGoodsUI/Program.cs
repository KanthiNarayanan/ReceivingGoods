using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Kits.RecvGoods.UI;
using Kits.CommonUtils;
// added comment
namespace Kits.RecvGoods
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        const string AppName = "ReceivingGoods";
        [MTAThread]
        static void Main()
        {
            using (AppManager execMgr = new AppManager(AppName)) {
                if (execMgr.IsFirstInstance) {
                    try
                    {
                        MainForm mainFrm = new MainForm();
                        Application.Run(mainFrm);
                        mainFrm.Show();
                        if (mainFrm != null)
                        {
                            mainFrm.Close();
                            mainFrm.Dispose();
                        }
                        return;
                    }
                    catch (Exception ex)
                    { 
                        //Log exception //TODO

                    }
                }   
            }
        }
    }
}