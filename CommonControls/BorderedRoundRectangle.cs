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
    public partial class BorderedRoundRectangle : Panel
    {
        #region Private Members
        private BorderStyle borderStyle = BorderStyle.None;
        private Color borderColor;
        private Color rectangularColor;
        private float borderWidth = 1F;
        #endregion
        #region Properties
        /// <summary>
        /// Gets or Sets the border Style
        /// </summary>
        public BorderStyle BdrStyle
        {
            get { return borderStyle; }
            set { borderStyle = value; }
        }

        /// <summary>
        /// gets or sets the border color
        /// </summary>
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// gets or sets the rectangular color
        /// </summary>
        public Color RectangularColor
        {
            get
            {
                return rectangularColor;
            }
            set
            {
                rectangularColor = value;
                this.Invalidate();
            }
        }

        /// <summary>
        /// gets or sets the border width
        /// </summary>
        public float BorderWidth
        {
            get
            {
                return borderWidth;
            }
            set
            {
                borderWidth = value;
            }
        }
        #endregion
        #region Constructor
        public BorderedRoundRectangle()
        {
            //InitializeComponent();
        }
        #endregion
        #region Overriden Methods
        protected override void OnPaint(PaintEventArgs pe)
        {
            // Calling the base class OnPaint
            base.OnPaint(pe);
            if (borderStyle != BorderStyle.None)
            {
                Pen pen = new Pen(borderColor, borderWidth);
                pe.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
                pen.Dispose();
            }
            Graphics g = pe.Graphics;

            Brush brush = new SolidBrush(RectangularColor);
            this.Height = this.Height;
            this.Width = this.Width;

            int panelWidth = this.Width;
            int panelHeight = this.Height;

            Rectangle topLeftRectangle = new Rectangle(0, 0, 15, 13);
            Rectangle topRightRectangle = new Rectangle(panelWidth - 17, 0, 15, 13);
            Rectangle centerRectangle = new Rectangle(8, 0, panelWidth - 14, panelHeight);

            Rectangle bottomLeftRectangle = new Rectangle(0, panelHeight - 15, 15, 16);
            Rectangle bottomRightRectangle = new Rectangle(panelWidth - 17, panelHeight - 15, 15, 16);
            Rectangle middleCenterRectangle = new Rectangle(0, 7, panelWidth, panelHeight - 14);


            g.FillEllipse(brush, topLeftRectangle);
            g.FillEllipse(brush, topRightRectangle);
            g.FillRectangle(brush, centerRectangle);

            g.FillEllipse(brush, bottomLeftRectangle);
            g.FillEllipse(brush, bottomRightRectangle);
            g.FillRectangle(brush, middleCenterRectangle);

            g.Dispose();
            brush.Dispose();
        }
        #endregion 
    }
}
