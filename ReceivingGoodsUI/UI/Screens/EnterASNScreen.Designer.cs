namespace Kits.RecvGoods.UI
{
    partial class EnterASNScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Kits.CommonControls.WaterMarkTextBox WMTxtASN;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.WMTxtASN = new Kits.CommonControls.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // WMTxtASN
            // 
            this.WMTxtASN.ForeColor = System.Drawing.Color.DarkGray;
            this.WMTxtASN.Location = new System.Drawing.Point(3, 27);
            this.WMTxtASN.MaxLength = 20;
            this.WMTxtASN.Name = "WMTxtASN";
            this.WMTxtASN.Size = new System.Drawing.Size(234, 21);
            this.WMTxtASN.TabIndex = 2;
            this.WMTxtASN.Text = "Scan or Enter Delivery Number";
            this.WMTxtASN.WaterMarkColor = System.Drawing.Color.Gray;
            this.WMTxtASN.WaterMarkText = "Scan or Enter Delivery Number";
            // 
            // EnterASNScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.Controls.Add(this.WMTxtASN);
            this.Name = "EnterASNScreen";
            this.Controls.SetChildIndex(this.WMTxtASN, 0);
            this.ResumeLayout(false);

        }

        #endregion



    }
}