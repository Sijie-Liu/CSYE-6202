namespace AirlineReservationSystem
{
    partial class BookTickets
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_seatType = new System.Windows.Forms.ComboBox();
            this.txt_customerName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_flight = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seat Type";
            // 
            // combo_seatType
            // 
            this.combo_seatType.FormattingEnabled = true;
            this.combo_seatType.Items.AddRange(new object[] {
            "E",
            "EP",
            "B"});
            this.combo_seatType.Location = new System.Drawing.Point(204, 185);
            this.combo_seatType.Name = "combo_seatType";
            this.combo_seatType.Size = new System.Drawing.Size(121, 21);
            this.combo_seatType.TabIndex = 2;
            // 
            // txt_customerName
            // 
            this.txt_customerName.Location = new System.Drawing.Point(204, 121);
            this.txt_customerName.Name = "txt_customerName";
            this.txt_customerName.Size = new System.Drawing.Size(100, 20);
            this.txt_customerName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buy The Ticket";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Flight";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "User";
            // 
            // txt_flight
            // 
            this.txt_flight.AutoSize = true;
            this.txt_flight.Location = new System.Drawing.Point(161, 48);
            this.txt_flight.Name = "txt_flight";
            this.txt_flight.Size = new System.Drawing.Size(46, 13);
            this.txt_flight.TabIndex = 7;
            this.txt_flight.Text = "txt_flight";
            // 
            // txt_user
            // 
            this.txt_user.AutoSize = true;
            this.txt_user.Location = new System.Drawing.Point(162, 81);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(35, 13);
            this.txt_user.TabIndex = 8;
            this.txt_user.Text = "label6";
            // 
            // BookTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 302);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.txt_flight);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_customerName);
            this.Controls.Add(this.combo_seatType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "BookTickets";
            this.Text = "BookTickets";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_seatType;
        private System.Windows.Forms.TextBox txt_customerName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txt_flight;
        private System.Windows.Forms.Label txt_user;
    }
}