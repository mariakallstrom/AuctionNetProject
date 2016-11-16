namespace AuctionNet
{
    partial class FrmAuctionNetStartPage
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
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnAddAuction = new System.Windows.Forms.Button();
            this.btnViewCurrentAuctions = new System.Windows.Forms.Button();
            this.btnAddBid = new System.Windows.Forms.Button();
            this.btnShowAllCustomers = new System.Windows.Forms.Button();
            this.btnShowMonthlyCommission = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(32, 39);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(175, 38);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Lägg till produkt";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(32, 115);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(175, 38);
            this.btnAddSupplier.TabIndex = 1;
            this.btnAddSupplier.Text = "Lägg till leverantör";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(32, 194);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(175, 38);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Lägg till kund";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnAddAuction
            // 
            this.btnAddAuction.Location = new System.Drawing.Point(32, 269);
            this.btnAddAuction.Name = "btnAddAuction";
            this.btnAddAuction.Size = new System.Drawing.Size(175, 38);
            this.btnAddAuction.TabIndex = 3;
            this.btnAddAuction.Text = "Lägg till auktion";
            this.btnAddAuction.UseVisualStyleBackColor = true;
            this.btnAddAuction.Click += new System.EventHandler(this.btnAddAuction_Click);
            // 
            // btnViewCurrentAuctions
            // 
            this.btnViewCurrentAuctions.Location = new System.Drawing.Point(307, 39);
            this.btnViewCurrentAuctions.Name = "btnViewCurrentAuctions";
            this.btnViewCurrentAuctions.Size = new System.Drawing.Size(272, 38);
            this.btnViewCurrentAuctions.TabIndex = 4;
            this.btnViewCurrentAuctions.Text = "Visa pågående auktioner";
            this.btnViewCurrentAuctions.UseVisualStyleBackColor = true;
            this.btnViewCurrentAuctions.Click += new System.EventHandler(this.btnViewCurrentAuctions_Click);
            // 
            // btnAddBid
            // 
            this.btnAddBid.Location = new System.Drawing.Point(32, 350);
            this.btnAddBid.Name = "btnAddBid";
            this.btnAddBid.Size = new System.Drawing.Size(175, 38);
            this.btnAddBid.TabIndex = 5;
            this.btnAddBid.Text = "Lägg till bud";
            this.btnAddBid.UseVisualStyleBackColor = true;
            this.btnAddBid.Click += new System.EventHandler(this.btnAddBid_Click);
            // 
            // btnShowAllCustomers
            // 
            this.btnShowAllCustomers.Location = new System.Drawing.Point(307, 115);
            this.btnShowAllCustomers.Name = "btnShowAllCustomers";
            this.btnShowAllCustomers.Size = new System.Drawing.Size(272, 38);
            this.btnShowAllCustomers.TabIndex = 6;
            this.btnShowAllCustomers.Text = "Visa alla kunder";
            this.btnShowAllCustomers.UseVisualStyleBackColor = true;
            this.btnShowAllCustomers.Click += new System.EventHandler(this.btnShowAllCustomers_Click);
            // 
            // btnShowMonthlyCommission
            // 
            this.btnShowMonthlyCommission.Location = new System.Drawing.Point(307, 194);
            this.btnShowMonthlyCommission.Name = "btnShowMonthlyCommission";
            this.btnShowMonthlyCommission.Size = new System.Drawing.Size(272, 38);
            this.btnShowMonthlyCommission.TabIndex = 7;
            this.btnShowMonthlyCommission.Text = "Visa provision per månad";
            this.btnShowMonthlyCommission.UseVisualStyleBackColor = true;
            this.btnShowMonthlyCommission.Click += new System.EventHandler(this.btnShowMonthlyCommission_Click);
            // 
            // FrmAuctionNetStartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 419);
            this.Controls.Add(this.btnShowMonthlyCommission);
            this.Controls.Add(this.btnShowAllCustomers);
            this.Controls.Add(this.btnAddBid);
            this.Controls.Add(this.btnViewCurrentAuctions);
            this.Controls.Add(this.btnAddAuction);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAddSupplier);
            this.Controls.Add(this.btnAddProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAuctionNetStartPage";
            this.Text = "AuctionNet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnAddAuction;
        private System.Windows.Forms.Button btnViewCurrentAuctions;
        private System.Windows.Forms.Button btnAddBid;
        private System.Windows.Forms.Button btnShowAllCustomers;
        private System.Windows.Forms.Button btnShowMonthlyCommission;
    }
}

