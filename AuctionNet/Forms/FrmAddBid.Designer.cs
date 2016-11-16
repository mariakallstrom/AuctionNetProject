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
            this.lblCustomerId.Location = new System.Drawing.Point(27, 25);
            this.lblCustomerId.Name = "lblCustomerId";
            this.lblCustomerId.Size = new System.Drawing.Size(52, 17);
            this.lblCustomerId.TabIndex = 0;
            this.lblCustomerId.Text = "KundId";
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(30, 59);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(162, 22);
            this.txtCustomerId.TabIndex = 1;
            // 
            // txtAuctionId
            // 
            this.txtAuctionId.Location = new System.Drawing.Point(30, 149);
            this.txtAuctionId.Name = "txtAuctionId";
            this.txtAuctionId.Size = new System.Drawing.Size(162, 22);
            this.txtAuctionId.TabIndex = 3;
            // 
            // lblAuctionId
            // 
            this.lblAuctionId.AutoSize = true;
            this.lblAuctionId.Location = new System.Drawing.Point(27, 115);
            this.lblAuctionId.Name = "lblAuctionId";
            this.lblAuctionId.Size = new System.Drawing.Size(73, 17);
            this.lblAuctionId.TabIndex = 2;
            this.lblAuctionId.Text = "AuktionsId";
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(30, 243);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(162, 22);
            this.txtBid.TabIndex = 5;
            // 
            // lblBid
            // 
            this.lblBid.AutoSize = true;
            this.lblBid.Location = new System.Drawing.Point(27, 209);
            this.lblBid.Name = "lblBid";
            this.lblBid.Size = new System.Drawing.Size(52, 17);
            this.lblBid.TabIndex = 4;
            this.lblBid.Text = "Belopp";
            // 
            // btnAddBid
            // 
            this.btnAddBid.Location = new System.Drawing.Point(269, 115);
            this.btnAddBid.Name = "btnAddBid";
            this.btnAddBid.Size = new System.Drawing.Size(135, 56);
            this.btnAddBid.TabIndex = 6;
            this.btnAddBid.Text = "Spara Bud";
            this.btnAddBid.UseVisualStyleBackColor = true;
            // 
            // FrmAddBid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 303);
            this.Controls.Add(this.btnAddBid);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.lblBid);
            this.Controls.Add(this.txtAuctionId);
            this.Controls.Add(this.lblAuctionId);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.lblCustomerId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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