namespace AuctionNet.Forms
{
    partial class FrmAddBid
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
            this.lblCustomerId = new System.Windows.Forms.Label();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtAuctionId = new System.Windows.Forms.TextBox();
            this.lblAuctionId = new System.Windows.Forms.Label();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.lblBid = new System.Windows.Forms.Label();
            this.btnAddBid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustomerId
            // 
            this.lblCustomerId.AutoSize = true;
            this.lblCustomerId.Location = new System.Drawing.Point(30, 31);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(60, 20);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "KundId";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(34, 74);
            this.txtCustomerId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(182, 26);
            this.txtCustomerId.TabIndex = 1;
            // 
            // txtAuctionId
            // 
            this.txtAuctionId.Location = new System.Drawing.Point(34, 186);
            this.txtAuctionId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAuctionId.Name = "txtAuctionId";
            this.txtAuctionId.Size = new System.Drawing.Size(182, 26);
            this.txtAuctionId.TabIndex = 3;
            // 
            // lblAuctionId
            // 
            this.lblAuctionId.AutoSize = true;
            this.lblAuctionId.Location = new System.Drawing.Point(30, 144);
            this.lblAuctionId.Name = "lblAuctionId";
            this.lblAuctionId.Size = new System.Drawing.Size(85, 20);
            this.lblAuctionId.TabIndex = 2;
            this.lblAuctionId.Text = "AuktionsId";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(34, 304);
            this.txtBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(182, 26);
            this.txtBid.TabIndex = 5;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Location = new System.Drawing.Point(30, 261);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(59, 20);
            this.lblBid.TabIndex = 4;
            this.lblBid.Text = "Belopp";
            // 
            // btnAddBid
            // 
            this.btnAddBid.Location = new System.Drawing.Point(303, 144);
            this.btnAddBid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddBid.Name = "btnAddBid";
            this.btnAddBid.Size = new System.Drawing.Size(152, 70);
            this.btnAddBid.TabIndex = 6;
            this.btnAddBid.Text = "Spara Bud";
            this.btnAddBid.UseVisualStyleBackColor = true;
            this.btnAddBid.Click += new System.EventHandler(this.btnAddBid_Click);
            // 
            // FrmAddBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 379);
            this.Controls.Add(this.btnAddBid);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.txtAuctionId);
            this.Controls.Add(this.lblAuctionId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAddBid";
            this.Text = "Lägg till Bud";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerId;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtAuctionId;
        private System.Windows.Forms.Label lblAuctionId;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label lblBid;
        private System.Windows.Forms.Button btnAddBid;
    }
}