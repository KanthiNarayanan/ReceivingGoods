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
    public partial class WaterMarkTextBox : TextBox
    {
        private Color waterMarkColor = Color.Gray;
        private string waterMarkText;
        private string waterMarkDisplayText;
        private bool waterMarkTextEnabled;
        public Color WaterMarkColor
        {
            get { return waterMarkColor; }
            set
            {
                waterMarkColor = value; Invalidate();
            }
        }
        public string WaterMarkText
        {
            get { return waterMarkText; }
            set { waterMarkText = value;
            waterMarkDisplayText = value;
            this.Text = value;
                Invalidate(); }
        }
        public WaterMarkTextBox()
        {
            InitializeComponent();
        }
        void WaterMarkTextBox_TextChanged(object sender, System.EventArgs e)
        {
            ToggleWaterMark();
        }
        void WaterMarkTextBox_GotFocus(object sender, System.EventArgs e)
        {
            ToggleWaterMark();
        }
        private void ToggleWaterMark()
        {
            if (this.Text.Length <= 0)
                EnableWaterMark();
            else
                DisableWaterMark();
        }
        private void EnableWaterMark()
        {
            this.Invalidate();
            this.Update();
            //Triger OnPaint immediatly
            Refresh();
        }

        private void DisableWaterMark()
        {
            //Disbale OnPaint event handler
            waterMarkTextEnabled = false;
            this.Invalidate();
            this.Update();
            //Triger OnPaint immediatly
            Refresh();
        }
        //Override OnPaint
        protected override void OnPaint(PaintEventArgs args)
        {
            
            // Use the same font that was defined in base class
            System.Drawing.Font drawFont = new System.Drawing.Font(FontFamily.GenericSansSerif,
                Font.Size, Font.Style);
            //Create new brush with gray color or 
            SolidBrush drawBrush = new SolidBrush(WaterMarkColor);//use Water mark color
            //Draw Text or WaterMark
            args.Graphics.DrawString((waterMarkTextEnabled ? WaterMarkText : Text),
                drawFont, drawBrush, 4,4);
            base.OnPaint(args);
        }
    }

}
