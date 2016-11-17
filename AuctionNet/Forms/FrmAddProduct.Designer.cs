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
            this.AddPicture = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(37, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(104, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Produktnamn";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(40, 72);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(220, 26);
            this.txtProductName.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(40, 180);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(220, 136);
            this.txtDescription.TabIndex = 3;
            // 
            // llDescription
            // 
            this.llDescription.AutoSize = true;
            this.llDescription.Location = new System.Drawing.Point(37, 136);
            this.llDescription.Name = "llDescription";
            this.llDescription.Size = new System.Drawing.Size(90, 20);
            this.llDescription.TabIndex = 2;
            this.llDescription.Text = "Beskrivning";
            // 
            // txtStartPrice
            // 
            this.txtStartPrice.Location = new System.Drawing.Point(331, 72);
            this.txtStartPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStartPrice.Name = "txtStartPrice";
            this.txtStartPrice.Size = new System.Drawing.Size(220, 26);
            this.txtStartPrice.TabIndex = 5;
            // 
            // lblStartPrice
            // 
            this.lblStartPrice.AutoSize = true;
            this.lblStartPrice.Location = new System.Drawing.Point(327, 29);
            this.lblStartPrice.Name = "lblStartPrice";
            this.lblStartPrice.Size = new System.Drawing.Size(82, 20);
            this.lblStartPrice.TabIndex = 4;
            this.lblStartPrice.Text = "Utropspris";
            // 
            // txtCommission
            // 
            this.txtCommission.Location = new System.Drawing.Point(331, 180);
            this.txtCommission.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(220, 26);
            this.txtCommission.TabIndex = 7;
            // 
            // lblCommission
            // 
            this.lblCommission.AutoSize = true;
            this.lblCommission.Location = new System.Drawing.Point(327, 136);
            this.lblCommission.Name = "lblCommission";
            this.lblCommission.Size = new System.Drawing.Size(72, 20);
            this.lblCommission.TabIndex = 6;
            this.lblCommission.Text = "Provision";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(331, 290);
            this.txtSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.Size = new System.Drawing.Size(220, 26);
            this.txtSupplier.TabIndex = 9;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(327, 246);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(85, 20);
            this.lblSupplier.TabIndex = 8;
            this.lblSupplier.Text = "Leverantör";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(40, 360);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(137, 60);
            this.btnAddProduct.TabIndex = 10;
            this.btnAddProduct.Text = "Spara produkt";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // AddPicture
            // 
            this.AddPicture.Location = new System.Drawing.Point(331, 349);
            this.AddPicture.Name = "AddPicture";
            this.AddPicture.Size = new System.Drawing.Size(220, 71);
            this.AddPicture.TabIndex = 11;
            this.AddPicture.Text = "Lägg till bild";
            this.AddPicture.UseVisualStyleBackColor = true;
            this.AddPicture.Click += new System.EventHandler(this.AddPicture_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 60);
            this.button1.TabIndex = 12;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
         
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 458);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AddPicture);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmAddProduct";
            this.Text = "Lägg till Produkt";
            this.Load += new System.EventHandler(this.FrmAddProduct_Load);
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
        private System.Windows.Forms.Button AddPicture;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}