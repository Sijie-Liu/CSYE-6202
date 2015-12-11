namespace AirlineReservationSystem
{
    partial class Update
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_carrier = new System.Windows.Forms.TextBox();
            this.txt_arrTime = new System.Windows.Forms.TextBox();
            this.txt_depTime = new System.Windows.Forms.TextBox();
            this.txt_arr = new System.Windows.Forms.TextBox();
            this.txt_dep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_flight = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(427, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 25;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_carrier
            // 
            this.txt_carrier.Location = new System.Drawing.Point(237, 319);
            this.txt_carrier.Name = "txt_carrier";
            this.txt_carrier.Size = new System.Drawing.Size(100, 20);
            this.txt_carrier.TabIndex = 24;
            // 
            // txt_arrTime
            // 
            this.txt_arrTime.Location = new System.Drawing.Point(240, 282);
            this.txt_arrTime.Name = "txt_arrTime";
            this.txt_arrTime.Size = new System.Drawing.Size(100, 20);
            this.txt_arrTime.TabIndex = 23;
            // 
            // txt_depTime
            // 
            this.txt_depTime.Location = new System.Drawing.Point(244, 239);
            this.txt_depTime.Name = "txt_depTime";
            this.txt_depTime.Size = new System.Drawing.Size(100, 20);
            this.txt_depTime.TabIndex = 22;
            // 
            // txt_arr
            // 
            this.txt_arr.Location = new System.Drawing.Point(238, 200);
            this.txt_arr.Name = "txt_arr";
            this.txt_arr.Size = new System.Drawing.Size(100, 20);
            this.txt_arr.TabIndex = 21;
            // 
            // txt_dep
            // 
            this.txt_dep.Location = new System.Drawing.Point(232, 159);
            this.txt_dep.Name = "txt_dep";
            this.txt_dep.Size = new System.Drawing.Size(100, 20);
            this.txt_dep.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Carrier";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Arrival Time";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(125, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Departure Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Arrival";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Departure";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Flight Name";
            // 
            // txt_flight
            // 
            this.txt_flight.AutoSize = true;
            this.txt_flight.Location = new System.Drawing.Point(242, 112);
            this.txt_flight.Name = "txt_flight";
            this.txt_flight.Size = new System.Drawing.Size(35, 13);
            this.txt_flight.TabIndex = 26;
            this.txt_flight.Text = "label7";
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 445);
            this.Controls.Add(this.txt_flight);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_carrier);
            this.Controls.Add(this.txt_arrTime);
            this.Controls.Add(this.txt_depTime);
            this.Controls.Add(this.txt_arr);
            this.Controls.Add(this.txt_dep);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Update";
            this.Text = "Update";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_carrier;
        private System.Windows.Forms.TextBox txt_arrTime;
        private System.Windows.Forms.TextBox txt_depTime;
        private System.Windows.Forms.TextBox txt_arr;
        private System.Windows.Forms.TextBox txt_dep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_flight;
    }
}