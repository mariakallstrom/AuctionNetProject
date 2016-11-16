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
            this.listViewAuctions = new System.Windows.Forms.ListView();
            this.listViewBidHistory = new System.Windows.Forms.ListView();
            this.lblBidHistory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CalendarFromDate = new System.Windows.Forms.MonthCalendar();
            this.CalendarToDate = new System.Windows.Forms.MonthCalendar();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewAuctions
            // 
            this.listViewAuctions.Location = new System.Drawing.Point(0, -1);
            this.listViewAuctions.Name = "listViewAuctions";
            this.listViewAuctions.Size = new System.Drawing.Size(467, 377);
            this.listViewAuctions.TabIndex = 0;
            this.listViewAuctions.UseCompatibleStateImageBehavior = false;
            // 
            // listViewBidHistory
            // 
            this.listViewBidHistory.Location = new System.Drawing.Point(510, 68);
            this.listViewBidHistory.Name = "listViewBidHistory";
            this.listViewBidHistory.Size = new System.Drawing.Size(259, 308);
            this.listViewBidHistory.TabIndex = 1;
            this.listViewBidHistory.UseCompatibleStateImageBehavior = false;
            // 
            // lblBidHistory
            // 
            this.lblBidHistory.AutoSize = true;
            this.lblBidHistory.Location = new System.Drawing.Point(507, 38);
            this.lblBidHistory.Name = "lblBidHistory";
            this.lblBidHistory.Size = new System.Drawing.Size(78, 17);
            this.lblBidHistory.TabIndex = 2;
            this.lblBidHistory.Text = "Budhistorik";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 414);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Visa auktioner som avslutas inom intervallet";
            // 
            // CalendarFromDate
            // 
            this.CalendarFromDate.Location = new System.Drawing.Point(18, 468);
            this.CalendarFromDate.Name = "CalendarFromDate";
            this.CalendarFromDate.TabIndex = 4;
            // 
            // CalendarToDate
            // 
            this.CalendarToDate.Location = new System.Drawing.Point(314, 468);
            this.CalendarToDate.Name = "CalendarToDate";
            this.CalendarToDate.TabIndex = 5;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(15, 442);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(37, 17);
            this.lblFromDate.TabIndex = 6;
            this.lblFromDate.Text = "Från";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(311, 442);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(26, 17);
            this.lblToDate.TabIndex = 7;
            this.lblToDate.Text = "Till";
            // 
            // FrmShowAuctions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 707);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.CalendarToDate);
            this.Controls.Add(this.CalendarFromDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBidHistory);
            this.Controls.Add(this.listViewBidHistory);
            this.Controls.Add(this.listViewAuctions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmShowAuctions";
            this.Text = "Pågående Auktioner";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewAuctions;
        private System.Windows.Forms.ListView listViewBidHistory;
        private System.Windows.Forms.Label lblBidHistory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar CalendarFromDate;
        private System.Windows.Forms.MonthCalendar CalendarToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
    }
}