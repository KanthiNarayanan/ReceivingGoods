using System.Windows.Forms;
namespace Kits.RecvGoods.UI
{
    partial class ReceivingGoodsStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
       // private System.Windows.Forms.MainMenu mainMenu;

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
        protected void InitializeComponent()
        {
            this.picBoxMenu = new System.Windows.Forms.PictureBox();
            this.picBoxSettings = new System.Windows.Forms.PictureBox();
            this.picBoxGoodsReceipt = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxLocMgmt = new System.Windows.Forms.PictureBox();
            this.picBoxPricing = new System.Windows.Forms.PictureBox();
            this.picBoxStockCount = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // picBoxMenu
            // 
            this.picBoxMenu.BackColor = System.Drawing.Color.White;
            this.picBoxMenu.Location = new System.Drawing.Point(3, 3);
            this.picBoxMenu.Name = "picBoxMenu";
            this.picBoxMenu.Size = new System.Drawing.Size(113, 52);
            this.picBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // picBoxSettings
            // 
            this.picBoxSettings.BackColor = System.Drawing.Color.White;
            this.picBoxSettings.Location = new System.Drawing.Point(122, 3);
            this.picBoxSettings.Name = "picBoxSettings";
            this.picBoxSettings.Size = new System.Drawing.Size(115, 52);
            this.picBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // picBoxGoodsReceipt
            // 
            this.picBoxGoodsReceipt.BackColor = System.Drawing.Color.White;
            this.picBoxGoodsReceipt.Location = new System.Drawing.Point(3, 81);
            this.picBoxGoodsReceipt.Name = "picBoxGoodsReceipt";
            this.picBoxGoodsReceipt.Size = new System.Drawing.Size(234, 38);
            this.picBoxGoodsReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxGoodsReceipt.Click += new System.EventHandler(this.picBoxGoodsReceipt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 18);
            this.label1.Text = "Favourites";
            // 
            // picBoxLocMgmt
            // 
            this.picBoxLocMgmt.BackColor = System.Drawing.Color.White;
            this.picBoxLocMgmt.Location = new System.Drawing.Point(3, 125);
            this.picBoxLocMgmt.Name = "picBoxLocMgmt";
            this.picBoxLocMgmt.Size = new System.Drawing.Size(234, 38);
            this.picBoxLocMgmt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // picBoxPricing
            // 
            this.picBoxPricing.BackColor = System.Drawing.Color.White;
            this.picBoxPricing.Location = new System.Drawing.Point(2, 169);
            this.picBoxPricing.Name = "picBoxPricing";
            this.picBoxPricing.Size = new System.Drawing.Size(234, 38);
            this.picBoxPricing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // picBoxStockCount
            // 
            this.picBoxStockCount.BackColor = System.Drawing.Color.White;
            this.picBoxStockCount.Location = new System.Drawing.Point(2, 213);
            this.picBoxStockCount.Name = "picBoxStockCount";
            this.picBoxStockCount.Size = new System.Drawing.Size(234, 38);
            this.picBoxStockCount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // ReceivingGoodsStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.picBoxStockCount);
            this.Controls.Add(this.picBoxPricing);
            this.Controls.Add(this.picBoxLocMgmt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxSettings);
            this.Controls.Add(this.picBoxMenu);
            this.Controls.Add(this.picBoxGoodsReceipt);
            this.Name = "ReceivingGoodsStart";
            this.Size = new System.Drawing.Size(240, 268);
            this.Controls.SetChildIndex(this.picBoxGoodsReceipt, 0);
            this.Controls.SetChildIndex(this.picBoxMenu, 0);
            this.Controls.SetChildIndex(this.picBoxSettings, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.picBoxLocMgmt, 0);
            this.Controls.SetChildIndex(this.picBoxPricing, 0);
            this.Controls.SetChildIndex(this.picBoxStockCount, 0);
            this.ResumeLayout(false);

        }

        
        #endregion

        private System.Windows.Forms.PictureBox picBoxMenu;
        private System.Windows.Forms.PictureBox picBoxSettings;
        private System.Windows.Forms.PictureBox picBoxGoodsReceipt;
        private Label label1;
        private PictureBox picBoxLocMgmt;
        private PictureBox picBoxPricing;
        private PictureBox picBoxStockCount;


    }
}