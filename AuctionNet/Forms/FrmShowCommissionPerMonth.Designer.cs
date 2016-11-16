namespace AuctionNet.Forms
{
    partial class FrmShowCommissionPerMonth
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
            this.listViewCommission = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewCommission
            // 
            this.listViewCommission.Location = new System.Drawing.Point(0, -2);
            this.listViewCommission.Name = "listViewCommission";
            this.listViewCommission.Size = new System.Drawing.Size(335, 353);
            this.listViewCommission.TabIndex = 0;
            this.listViewCommission.UseCompatibleStateImageBehavior = false;
            // 
            // FrmShowCommissionPerMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 348);
            this.Controls.Add(this.listViewCommission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmShowCommissionPerMonth";
            this.Text = "Provision Per Månad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCommission;
    }
}