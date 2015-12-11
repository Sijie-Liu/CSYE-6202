namespace AirlineReservationSystem
{
    partial class ViewSeat
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
            this.seatTable = new System.Windows.Forms.DataGridView();
            this.seatType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.seatTable)).BeginInit();
            this.SuspendLayout();
            // 
            // seatTable
            // 
            this.seatTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seatTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.seatType,
            this.price});
            this.seatTable.Location = new System.Drawing.Point(88, 120);
            this.seatTable.Name = "seatTable";
            this.seatTable.Size = new System.Drawing.Size(260, 203);
            this.seatTable.TabIndex = 0;
            this.seatTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.seatTable_CellContentClick);
            // 
            // seatType
            // 
            this.seatType.HeaderText = "Seat Type";
            this.seatType.Name = "seatType";
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // ViewSeat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 432);
            this.Controls.Add(this.seatTable);
            this.Name = "ViewSeat";
            this.Text = "ViewSeat";
            ((System.ComponentModel.ISupportInitialize)(this.seatTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView seatTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn seatType;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
    }
}