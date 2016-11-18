namespace AuctionNet.Forms
{
    partial class FrmShowAuctions
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
            this.listViewBidHistory = new System.Windows.Forms.ListView();
            this.lblBidHistory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarView = new System.Windows.Forms.MonthCalendar();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.dgvAllAuction = new System.Windows.Forms.DataGridView();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAuction)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewBidHistory
            // 
            this.listViewBidHistory.Location = new System.Drawing.Point(567, 351);
            this.listViewBidHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewBidHistory.Name = "listViewBidHistory";
            this.listViewBidHistory.Size = new System.Drawing.Size(291, 223);
            this.listViewBidHistory.TabIndex = 1;
            this.listViewBidHistory.UseCompatibleStateImageBehavior = false;
            // 
            // lblBidHistory
            // 
            this.lblBidHistory.AutoSize = true;
            this.lblBidHistory.Location = new System.Drawing.Point(563, 303);
            this.lblBidHistory.Name = "lblBidHistory";
            this.lblBidHistory.Size = new System.Drawing.Size(88, 20);
            this.lblBidHistory.TabIndex = 2;
            this.lblBidHistory.Text = "Budhistorik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visa auktioner som avslutas inom intervallet";
            // 
            // CalendarView
            // 
            this.CalendarView.Location = new System.Drawing.Point(36, 322);
            this.CalendarView.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.CalendarView.MaxSelectionCount = 40;
            this.CalendarView.Name = "CalendarView";
            this.CalendarView.TabIndex = 4;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(33, 289);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(164, 20);
            this.lblFromDate.TabIndex = 6;
            this.lblFromDate.Text = "Välj datum från och till";
            // 
            // dgvAllAuction
            // 
            this.dgvAllAuction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAuction.Location = new System.Drawing.Point(34, 24);
            this.dgvAllAuction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllAuction.Name = "dgvAllAuction";
            this.dgvAllAuction.RowTemplate.Height = 24;
            this.dgvAllAuction.Size = new System.Drawing.Size(929, 204);
            this.dgvAllAuction.TabIndex = 8;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(375, 524);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(122, 50);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Tillbaka";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(370, 322);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(127, 49);
            this.btnGet.TabIndex = 10;
            this.btnGet.Text = "Hämta";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(682, 235);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(281, 40);
            this.btnShowAll.TabIndex = 11;
            this.btnShowAll.Text = "Hämta alla auktioner";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // FrmShowAuctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 656);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvAllAuction);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.CalendarView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBidHistory);
            this.Controls.Add(this.listViewBidHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmShowAuctions";
            this.Text = "Pågående Auktioner";
            this.Load += new System.EventHandler(this.FrmShowAuctions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAuction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewBidHistory;
        private System.Windows.Forms.Label lblBidHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar CalendarView;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.DataGridView dgvAllAuction;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.Button btnShowAll;
    }
}