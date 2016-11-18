namespace AuctionNet.Forms
{
    partial class FrmAddAuction
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
            this.components = new System.ComponentModel.Container();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.txtStartTime = new System.Windows.Forms.TextBox();
            this.txtEndtime = new System.Windows.Forms.TextBox();
            this.lblEndTime = new System.Windows.Forms.Label();
            this.txtAcceptPrice = new System.Windows.Forms.TextBox();
            this.lblAcceptPrice = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblProductId = new System.Windows.Forms.Label();
            this.btnAddAuction = new System.Windows.Forms.Button();
            this.auctionNetDataSet1 = new AuctionNet.AuctionNetDataSet1();
            this.auctionNetDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter = new AuctionNet.AuctionNetDataSet1TableAdapters.ProductsTableAdapter();
            this.auctionNetDataSet = new AuctionNet.AuctionNetDataSet();
            this.productsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productsTableAdapter1 = new AuctionNet.AuctionNetDataSetTableAdapters.ProductsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.auctionNetDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionNetDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Location = new System.Drawing.Point(26, 32);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(61, 20);
            this.lblStartTime.TabIndex = 0;
            this.lblStartTime.Text = "Starttid";
            // 
            // txtStartTime
            // 
            this.txtStartTime.Location = new System.Drawing.Point(29, 75);
            this.txtStartTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStartTime.Name = "txtStartTime";
            this.txtStartTime.Size = new System.Drawing.Size(181, 26);
            this.txtStartTime.TabIndex = 1;
            // 
            // txtEndtime
            // 
            this.txtEndtime.Location = new System.Drawing.Point(29, 178);
            this.txtEndtime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEndtime.Name = "txtEndtime";
            this.txtEndtime.Size = new System.Drawing.Size(181, 26);
            this.txtEndtime.TabIndex = 3;
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Location = new System.Drawing.Point(26, 135);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(54, 20);
            this.lblEndTime.TabIndex = 2;
            this.lblEndTime.Text = "Sluttid";
            // 
            // txtAcceptPrice
            // 
            this.txtAcceptPrice.Location = new System.Drawing.Point(277, 75);
            this.txtAcceptPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAcceptPrice.Name = "txtAcceptPrice";
            this.txtAcceptPrice.Size = new System.Drawing.Size(122, 26);
            this.txtAcceptPrice.TabIndex = 5;
            // 
            // lblAcceptPrice
            // 
            this.lblAcceptPrice.AutoSize = true;
            this.lblAcceptPrice.Location = new System.Drawing.Point(273, 32);
            this.lblAcceptPrice.Name = "lblAcceptPrice";
            this.lblAcceptPrice.Size = new System.Drawing.Size(84, 20);
            this.lblAcceptPrice.TabIndex = 4;
            this.lblAcceptPrice.Text = "Acceptpris";
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(277, 178);
            this.txtProductId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(122, 26);
            this.txtProductId.TabIndex = 7;
            // 
            // lblProductId
            // 
            this.lblProductId.AutoSize = true;
            this.lblProductId.Location = new System.Drawing.Point(273, 135);
            this.lblProductId.Name = "lblProductId";
            this.lblProductId.Size = new System.Drawing.Size(78, 20);
            this.lblProductId.TabIndex = 6;
            this.lblProductId.Text = "ProduktId";
            // 
            // btnAddAuction
            // 
            this.btnAddAuction.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnAddAuction.Location = new System.Drawing.Point(29, 259);
            this.btnAddAuction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddAuction.Name = "btnAddAuction";
            this.btnAddAuction.Size = new System.Drawing.Size(148, 56);
            this.btnAddAuction.TabIndex = 8;
            this.btnAddAuction.Text = "Spara Auktion";
            this.btnAddAuction.UseVisualStyleBackColor = true;
            this.btnAddAuction.Click += new System.EventHandler(this.btnAddAuction_Click);
            // 
            // auctionNetDataSet1
            // 
            this.auctionNetDataSet1.DataSetName = "AuctionNetDataSet1";
            this.auctionNetDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auctionNetDataSet1BindingSource
            // 
            this.auctionNetDataSet1BindingSource.DataSource = this.auctionNetDataSet1;
            this.auctionNetDataSet1BindingSource.Position = 0;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "Products";
            this.productsBindingSource.DataSource = this.auctionNetDataSet1;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // auctionNetDataSet
            // 
            this.auctionNetDataSet.DataSetName = "AuctionNetDataSet";
            this.auctionNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsBindingSource1
            // 
            this.productsBindingSource1.DataMember = "Products";
            this.productsBindingSource1.DataSource = this.auctionNetDataSet;
            // 
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // FrmAddAuction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 401);
            this.Controls.Add(this.btnAddAuction);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.lblProductId);
            this.Controls.Add(this.txtAcceptPrice);
            this.Controls.Add(this.lblAcceptPrice);
            this.Controls.Add(this.txtEndtime);
            this.Controls.Add(this.lblEndTime);
            this.Controls.Add(this.txtStartTime);
            this.Controls.Add(this.lblStartTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAddAuction";
            this.Text = "Lägg till Auktion";
            this.Load += new System.EventHandler(this.FrmAddAuction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.auctionNetDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionNetDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auctionNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStartTime;
        private System.Windows.Forms.Label lblEndTime;
        private System.Windows.Forms.Label lblAcceptPrice;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Button btnAddAuction;
        public System.Windows.Forms.TextBox txtStartTime;
        public System.Windows.Forms.TextBox txtEndtime;
        public System.Windows.Forms.TextBox txtAcceptPrice;
        public System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.BindingSource auctionNetDataSet1BindingSource;
        private AuctionNetDataSet1 auctionNetDataSet1;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private AuctionNetDataSet1TableAdapters.ProductsTableAdapter productsTableAdapter;
        private AuctionNetDataSet auctionNetDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource1;
        private AuctionNetDataSetTableAdapters.ProductsTableAdapter productsTableAdapter1;
    }
}