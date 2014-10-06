using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;


namespace Kits.RecvGoods.UI.Controls
{
    public partial class EANDescControl : UserControl
    {
        public EANDescControl()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                         Color.Black, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         Color.Black, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         Color.Black, BORDER_SIZE, ButtonBorderStyle.Inset,
                                         Color.Black, BORDER_SIZE, ButtonBorderStyle.Inset);
        }
    }
    
}
