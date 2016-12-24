namespace TheHackerThing
{
    partial class frmIP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("127.8.028.116");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("18.048.116.45");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("23.56.125.89");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIP));
            this.lblGettingIP = new System.Windows.Forms.Label();
            this.prbIP = new System.Windows.Forms.ProgressBar();
            this.lsvIPs = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // lblGettingIP
            // 
            this.lblGettingIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGettingIP.Location = new System.Drawing.Point(13, 13);
            this.lblGettingIP.Name = "lblGettingIP";
            this.lblGettingIP.Size = new System.Drawing.Size(258, 33);
            this.lblGettingIP.TabIndex = 0;
            this.lblGettingIP.Text = "IP: xxx.x.xxx.xxx";
            this.lblGettingIP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prbIP
            // 
            this.prbIP.Location = new System.Drawing.Point(13, 49);
            this.prbIP.Name = "prbIP";
            this.prbIP.Size = new System.Drawing.Size(258, 23);
            this.prbIP.TabIndex = 1;
            // 
            // lsvIPs
            // 
            this.lsvIPs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsvIPs.BackColor = System.Drawing.SystemColors.Control;
            this.lsvIPs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsvIPs.Enabled = false;
            this.lsvIPs.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lsvIPs.Location = new System.Drawing.Point(13, 78);
            this.lsvIPs.Name = "lsvIPs";
            this.lsvIPs.Size = new System.Drawing.Size(258, 81);
            this.lsvIPs.TabIndex = 2;
            this.lsvIPs.UseCompatibleStateImageBehavior = false;
            this.lsvIPs.View = System.Windows.Forms.View.List;
            // 
            // frmIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 175);
            this.Controls.Add(this.lsvIPs);
            this.Controls.Add(this.prbIP);
            this.Controls.Add(this.lblGettingIP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Searching for IPs...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblGettingIP;
        private System.Windows.Forms.ProgressBar prbIP;
        private System.Windows.Forms.ListView lsvIPs;
    }
}