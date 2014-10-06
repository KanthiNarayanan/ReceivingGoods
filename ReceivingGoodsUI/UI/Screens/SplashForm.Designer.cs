namespace Kits.RecvGoods.UI
{
    partial class SplashForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label waitLabel;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.TextBox versionTextBox;
        private System.Windows.Forms.Timer timer;
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
            this.loadingLabel = new System.Windows.Forms.Label();
            this.waitLabel = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionTextBox = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer();
            this.SuspendLayout();
            // 
            // loadingLabel
            // 
            this.loadingLabel.Location = new System.Drawing.Point(75, 90);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(173, 20);
            this.loadingLabel.Text = "SplashLoading";
            this.loadingLabel.ParentChanged += new System.EventHandler(this.label1_ParentChanged);
            // 
            // waitLabel
            // 
            this.waitLabel.Location = new System.Drawing.Point(75, 122);
            this.waitLabel.Name = "waitLabel";
            this.waitLabel.Size = new System.Drawing.Size(183, 20);
            this.waitLabel.Text = "PleaseWait";
            // 
            // versionLabel
            // 
            this.versionLabel.Location = new System.Drawing.Point(8, 240);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(240, 20);
            this.versionLabel.Text = "Version";
            // 
            // versionTextBox
            // 
            this.versionTextBox.Location = new System.Drawing.Point(8, 272);
            this.versionTextBox.Name = "versionTextBox";
            this.versionTextBox.Size = new System.Drawing.Size(222, 21);
            this.versionTextBox.TabIndex = 3;
            // 
            // SplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(240, 294);
            this.Controls.Add(this.versionTextBox);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.waitLabel);
            this.Controls.Add(this.loadingLabel);
            this.Name = "SplashForm";
            this.ResumeLayout(false);

        }

        #endregion

        
    }
}