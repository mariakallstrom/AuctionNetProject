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
            this.CalendarFromDate = new System.Windows.Forms.MonthCalendar();
            this.CalendarToDate = new System.Windows.Forms.MonthCalendar();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.dgvAllAuction = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllAuction)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewBidHistory
            // 
            this.listViewBidHistory.Location = new System.Drawing.Point(574, 85);
            this.listViewBidHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listViewBidHistory.Name = "listViewBidHistory";
            this.listViewBidHistory.Size = new System.Drawing.Size(291, 384);
            this.listViewBidHistory.TabIndex = 1;
            this.listViewBidHistory.UseCompatibleStateImageBehavior = false;
            // 
            // lblBidHistory
            // 
            this.lblBidHistory.AutoSize = true;
            this.lblBidHistory.Location = new System.Drawing.Point(570, 48);
            this.lblBidHistory.Name = "lblBidHistory";
            this.lblBidHistory.Size = new System.Drawing.Size(88, 20);
            this.lblBidHistory.TabIndex = 2;
            this.lblBidHistory.Text = "Budhistorik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visa auktioner som avslutas inom intervallet";
            // 
            // CalendarFromDate
            // 
            this.CalendarFromDate.Location = new System.Drawing.Point(20, 585);
            this.CalendarFromDate.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.CalendarFromDate.Name = "CalendarFromDate";
            this.CalendarFromDate.TabIndex = 4;
            // 
            // CalendarToDate
            // 
            this.CalendarToDate.Location = new System.Drawing.Point(353, 585);
            this.CalendarToDate.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.CalendarToDate.Name = "CalendarToDate";
            this.CalendarToDate.TabIndex = 5;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(17, 552);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(42, 20);
            this.lblFromDate.TabIndex = 6;
            this.lblFromDate.Text = "Från";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(350, 552);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(27, 20);
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "Till";
            // 
            // dgvAllAuction
            // 
            this.dgvAllAuction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllAuction.Location = new System.Drawing.Point(20, 85);
            this.dgvAllAuction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvAllAuction.Name = "dgvAllAuction";
            this.dgvAllAuction.RowTemplate.Height = 24;
            this.dgvAllAuction.Size = new System.Drawing.Size(511, 385);
            this.dgvAllAuction.TabIndex = 8;
            // 
            // FrmShowAuctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 884);
            this.Controls.Add(this.dgvAllAuction);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.CalendarToDate);
            this.Controls.Add(this.CalendarFromDate);
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
        private System.Windows.Forms.MonthCalendar CalendarFromDate;
        private System.Windows.Forms.MonthCalendar CalendarToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.DataGridView dgvAllAuction;
    }
}