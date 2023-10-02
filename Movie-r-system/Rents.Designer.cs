namespace Movie_r_system
{
    partial class Rents
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
            this.movie = new System.Windows.Forms.ComboBox();
            this.user = new System.Windows.Forms.ComboBox();
            this.price = new System.Windows.Forms.NumericUpDown();
            this.returndate = new System.Windows.Forms.DateTimePicker();
            this.rentdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ffff.SuspendLayout();
            this.avaliable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(613, 335);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "Close";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(385, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(538, 313);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "All Rents";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(526, 288);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            
            // 
            // ffff
            // 
            this.ffff.Controls.Add(this.button3);
            this.ffff.Controls.Add(this.button2);
            this.ffff.Controls.Add(this.button1);
            this.ffff.Location = new System.Drawing.Point(21, 181);
            this.ffff.Name = "ffff";
            this.ffff.Size = new System.Drawing.Size(358, 177);
            this.ffff.TabIndex = 17;
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
            this.avaliable.Controls.Add(this.movie);
            this.avaliable.Controls.Add(this.user);
            this.avaliable.Controls.Add(this.price);
            this.avaliable.Controls.Add(this.returndate);
            this.avaliable.Controls.Add(this.rentdate);
            this.avaliable.Controls.Add(this.label1);
            this.avaliable.Controls.Add(this.label6);
            this.avaliable.Controls.Add(this.label5);
            this.avaliable.Controls.Add(this.label4);
            this.avaliable.Controls.Add(this.label8);
            this.avaliable.Location = new System.Drawing.Point(21, 12);
            this.avaliable.Name = "avaliable";
            this.avaliable.Size = new System.Drawing.Size(358, 163);
            this.avaliable.TabIndex = 16;
            this.avaliable.TabStop = false;
            this.avaliable.Text = "Rent Information";
            // 
            // movie
            // 
            this.movie.FormattingEnabled = true;
            this.movie.Location = new System.Drawing.Point(110, 125);
            this.movie.Name = "movie";
            this.movie.Size = new System.Drawing.Size(135, 21);
            this.movie.TabIndex = 31;
            // 
            // user
            // 
            this.user.FormattingEnabled = true;
            this.user.Location = new System.Drawing.Point(110, 98);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(135, 21);
            this.user.TabIndex = 30;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(110, 72);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(135, 20);
            this.price.TabIndex = 29;
            // 
            // returndate
            // 
            this.returndate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.returndate.Location = new System.Drawing.Point(110, 45);
            this.returndate.Name = "returndate";
            this.returndate.Size = new System.Drawing.Size(135, 20);
            this.returndate.TabIndex = 28;
            // 
            // rentdate
            // 
            this.rentdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.rentdate.Location = new System.Drawing.Point(110, 19);
            this.rentdate.Name = "rentdate";
            this.rentdate.Size = new System.Drawing.Size(135, 20);
            this.rentdate.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 26;
            this.label1.Text = "Return Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 18;
            this.label6.Text = "Price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Movie Title:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rent Date:";
            // 
            // Rents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 383);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ffff);
            this.Controls.Add(this.avaliable);
            this.Name = "Rents";
            this.Text = "Rents";
            this.Load += new System.EventHandler(this.Rents_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ffff.ResumeLayout(false);
            this.avaliable.ResumeLayout(false);
            this.avaliable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.price)).EndInit();
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
        private System.Windows.Forms.DateTimePicker rentdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox movie;
        private System.Windows.Forms.ComboBox user;
        private System.Windows.Forms.NumericUpDown price;
        private System.Windows.Forms.DateTimePicker returndate;
    }
}