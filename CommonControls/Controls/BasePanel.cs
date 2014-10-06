using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Kits.CommonControls
{
    public partial class BasePanel : UserControl
    {
        private Form mainForm;
        private MenuItem leftMenu;
        private MenuItem rightMenu;
        private string screenHeaderVal;
        private bool showScreenHeader;
        #region Constructors
        public BasePanel()
        {
            InitializeComponent();
            // Scanner setup TODO
            this.BackColor = Color.FromArgb(255, 255, 255);
        }
        #endregion Constructors
        #region Protected Instances
        protected Form MainForm
        {
            get
            {
                if (mainForm == null)
                {
                    mainForm = (Form)TopLevelControl;
                }

                return mainForm;
            }
        }
        protected MenuItem LeftMenu
        {
            get
            {
                if (leftMenu == null)
                {
                    leftMenu = CreateLeftMenu();
                }

                return leftMenu;
            }
            set { leftMenu = value; }
        }
        protected MenuItem RightMenu
        {
            get
            {
                if (rightMenu == null)
                {
                    rightMenu = CreateRightMenu();
                }

                return rightMenu;
            }
            set { rightMenu = value; }

        }
        protected virtual bool ShowScreenHeader {
            set {
                showScreenHeader = value;
            }
            get {
                return showScreenHeader;
            }
        }
        protected virtual string ScreenHeaderVal
        {
            set
            {
                screenHeaderVal = value;
            }
            get
            {
                return screenHeaderVal;
            }
        }
        protected virtual string PanelTitle
        {
            get { return " "; }
        }
        protected virtual MenuItem CreateLeftMenu()
        {
            MenuItem menuItem = new MenuItem();

            menuItem.Enabled = false;
            menuItem.Text = "Back";

            return menuItem;
        }
        protected virtual MenuItem CreateRightMenu()
        {
            MenuItem menuItem = new MenuItem();

            menuItem.Enabled = false;
            menuItem.Text = "Next";

            return menuItem;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            UpdateDisplay();
            base.OnGotFocus(e);
        }
        #endregion
        #region Public instance methods

        public void UpdateDisplay()
        {
            // Set the MainForm's title to the panel's title.
            if (MainForm != null)
            {
                // Set the Panel title to the MainForm title.
                MainForm.Text = PanelTitle;
                lblHeader.Visible = ShowScreenHeader;
                if (ShowScreenHeader)
                {
                    lblHeader.Text = ScreenHeaderVal;
                }
                MainMenu mainMenu = MainForm.Menu;
                mainMenu.MenuItems.Clear();
                mainMenu.MenuItems.Add(LeftMenu);
                mainMenu.MenuItems.Add(RightMenu);
            }
            
            OnPanelActive();
        }
        public virtual void OnPanelActive() { 

        }
        public virtual void InitializePanel()
        {

        }
        public virtual void Clear()
        {
        }
        public virtual void Load()
        {
        }
        #endregion
    }
}