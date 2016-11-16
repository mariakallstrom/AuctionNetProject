namespace AuctionNet.Forms
{
    partial class FrmAddProduct
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.llDescription = new System.Windows.Forms.Label();
            this.txtStartPrice = new System.Windows.Forms.TextBox();
            this.lblStartPrice = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.TextBox();
            this.lblCommission = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(33, 23);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(92, 17);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Produktnamn";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(36, 58);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(196, 22);
            this.txtProductName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(36, 144);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(196, 110);
            this.txtDescription.TabIndex = 3;
            // 
            // llDescription
            // 
            this.llDescription.AutoSize = true;
            this.llDescription.Location = new System.Drawing.Point(33, 109);
            this.llDescription.Name = "llDescription";
            this.llDescription.Size = new System.Drawing.Size(81, 17);
            this.llDescription.TabIndex = 2;
            this.llDescription.Text = "Beskrivning";
            // 
            // txtStartPrice
            // 
            this.txtStartPrice.Location = new System.Drawing.Point(294, 58);
            this.txtStartPrice.Name = "txtStartPrice";
            this.txtStartPrice.Size = new System.Drawing.Size(196, 22);
            this.txtStartPrice.TabIndex = 5;
            // 
            // lblStartPrice
            // 
            this.lblStartPrice.AutoSize = true;
            this.lblStartPrice.Location = new System.Drawing.Point(291, 23);
            this.lblStartPrice.Name = "lblStartPrice";
            this.lblStartPrice.Size = new System.Drawing.Size(73, 17);
            this.lblStartPrice.TabIndex = 4;
            this.lblStartPrice.Text = "Utropspris";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(294, 144);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(196, 22);
            this.txtCommission.TabIndex = 7;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(291, 109);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(66, 17);
            this.lblCommission.TabIndex = 6;
            this.lblCommission.Text = "Provision";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(294, 232);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(196, 22);
            this.txtSupplier.TabIndex = 9;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(291, 197);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(77, 17);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Leverantör";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(36, 288);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(122, 48);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Spara produkt";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 366);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtSupplier);
            this.Controls.Add(this.lblSupplier);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.lblCommission);
            this.Controls.Add(this.txtStartPrice);
            this.Controls.Add(this.lblStartPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.llDescription);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmAddProduct";
            this.Text = "Lägg till Produkt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label llDescription;
        private System.Windows.Forms.TextBox txtStartPrice;
        private System.Windows.Forms.Label lblStartPrice;
        private System.Windows.Forms.TextBox txtCommission;
        private System.Windows.Forms.Label lblCommission;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.Button btnAddProduct;
    }
}