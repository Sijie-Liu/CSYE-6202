namespace AirlineReservationSystem
{
    partial class AddFlight
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_flight = new System.Windows.Forms.TextBox();
            this.txt_dep = new System.Windows.Forms.TextBox();
            this.txt_arr = new System.Windows.Forms.TextBox();
            this.txt_depTime = new System.Windows.Forms.TextBox();
            this.txt_arrTime = new System.Windows.Forms.TextBox();
            this.txt_carrier = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Departure Time";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Arrival Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(99, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Carrier";
            // 
            // txt_flight
            // 
            this.txt_flight.Location = new System.Drawing.Point(200, 104);
            this.txt_flight.Name = "txt_flight";
            this.txt_flight.Size = new System.Drawing.Size(100, 20);
            this.txt_flight.TabIndex = 6;
            // 
            // txt_dep
            // 
            this.txt_dep.Location = new System.Drawing.Point(198, 157);
            this.txt_dep.Name = "txt_dep";
            this.txt_dep.Size = new System.Drawing.Size(100, 20);
            this.txt_dep.TabIndex = 7;
            // 
            // txt_arr
            // 
            this.txt_arr.Location = new System.Drawing.Point(204, 198);
            this.txt_arr.Name = "txt_arr";
            this.txt_arr.Size = new System.Drawing.Size(100, 20);
            this.txt_arr.TabIndex = 8;
            // 
            // txt_depTime
            // 
            this.txt_depTime.Location = new System.Drawing.Point(210, 237);
            this.txt_depTime.Name = "txt_depTime";
            this.txt_depTime.Size = new System.Drawing.Size(100, 20);
            this.txt_depTime.TabIndex = 9;
            // 
            // txt_arrTime
            // 
            this.txt_arrTime.Location = new System.Drawing.Point(206, 280);
            this.txt_arrTime.Name = "txt_arrTime";
            this.txt_arrTime.Size = new System.Drawing.Size(100, 20);
            this.txt_arrTime.TabIndex = 10;
            // 
            // txt_carrier
            // 
            this.txt_carrier.Location = new System.Drawing.Point(203, 317);
            this.txt_carrier.Name = "txt_carrier";
            this.txt_carrier.Size = new System.Drawing.Size(100, 20);
            this.txt_carrier.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 403);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_carrier);
            this.Controls.Add(this.txt_arrTime);
            this.Controls.Add(this.txt_depTime);
            this.Controls.Add(this.txt_arr);
            this.Controls.Add(this.txt_dep);
            this.Controls.Add(this.txt_flight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddFlight";
            this.Text = "AddFlight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_flight;
        private System.Windows.Forms.TextBox txt_dep;
        private System.Windows.Forms.TextBox txt_arr;
        private System.Windows.Forms.TextBox txt_depTime;
        private System.Windows.Forms.TextBox txt_arrTime;
        private System.Windows.Forms.TextBox txt_carrier;
        private System.Windows.Forms.Button button1;
    }
}