namespace Movie_r_system
{
    partial class Users
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
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ffff = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.avaliable = new System.Windows.Forms.GroupBox();
            this.zip = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ffff.SuspendLayout();
            this.avaliable.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(612, 350);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 15;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(384, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 313);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(526, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // ffff
            // 
            this.ffff.Controls.Add(this.button3);
            this.ffff.Controls.Add(this.button2);
            this.ffff.Controls.Add(this.button1);
            this.ffff.Location = new System.Drawing.Point(20, 196);
            this.ffff.Name = "ffff";
            this.ffff.Size = new System.Drawing.Size(358, 177);
            this.ffff.TabIndex = 13;
            this.ffff.TabStop = false;
            this.ffff.Text = "Actions";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button3.Location = new System.Drawing.Point(30, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(296, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.YellowGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.Location = new System.Drawing.Point(30, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(296, 42);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Location = new System.Drawing.Point(30, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // avaliable
            // 
            this.avaliable.Controls.Add(this.label6);
            this.avaliable.Controls.Add(this.label5);
            this.avaliable.Controls.Add(this.label4);
            this.avaliable.Controls.Add(this.zip);
            this.avaliable.Controls.Add(this.label8);
            this.avaliable.Controls.Add(this.email);
            this.avaliable.Controls.Add(this.name);
            this.avaliable.Controls.Add(this.label7);
            this.avaliable.Controls.Add(this.address);
            this.avaliable.Controls.Add(this.phone);
            this.avaliable.Location = new System.Drawing.Point(20, 27);
            this.avaliable.Name = "avaliable";
            this.avaliable.Size = new System.Drawing.Size(358, 163);
            this.avaliable.TabIndex = 12;
            this.avaliable.TabStop = false;
            this.avaliable.Text = "User Information";
            // 
            // zip
            // 
            this.zip.Location = new System.Drawing.Point(110, 128);
            this.zip.Name = "zip";
            this.zip.Size = new System.Drawing.Size(135, 20);
            this.zip.TabIndex = 25;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(110, 102);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(135, 20);
            this.email.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "ZIP Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Email:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(110, 76);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(135, 20);
            this.phone.TabIndex = 21;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(110, 50);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(135, 20);
            this.address.TabIndex = 20;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(110, 24);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 20);
            this.name.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Phone:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Full Name:";
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ffff);
            this.Controls.Add(this.avaliable);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ffff.ResumeLayout(false);
            this.avaliable.ResumeLayout(false);
            this.avaliable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox ffff;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox avaliable;
        private System.Windows.Forms.TextBox zip;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}