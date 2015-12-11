namespace AirlineReservationSystem
{
    partial class ViewTrip
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
            this.tripTable = new System.Windows.Forms.DataGridView();
            this.tripID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tripTable
            // 
            this.tripTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tripTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tripID,
            this.flight,
            this.customer});
            this.tripTable.Location = new System.Drawing.Point(12, 12);
            this.tripTable.Name = "tripTable";
            this.tripTable.Size = new System.Drawing.Size(344, 363);
            this.tripTable.TabIndex = 0;
            // 
            // tripID
            // 
            this.tripID.HeaderText = "Seat ID";
            this.tripID.Name = "tripID";
            // 
            // flight
            // 
            this.flight.HeaderText = "Flight Number";
            this.flight.Name = "flight";
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer Name";
            this.customer.Name = "customer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "Unbook";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewTrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tripTable);
            this.Name = "ViewTrip";
            this.Text = "ViewTrip";
            ((System.ComponentModel.ISupportInitialize)(this.tripTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tripTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn tripID;
        private System.Windows.Forms.DataGridViewTextBoxColumn flight;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.Button button1;
    }
}