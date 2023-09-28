namespace Movie_r_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchByToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.moviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.titleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAvailableMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allRentedMoviesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchByToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.reportsToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchByToolStripMenuItem
            // 
            this.searchByToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moviesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.rentsToolStripMenuItem});
            this.searchByToolStripMenuItem.Name = "searchByToolStripMenuItem";
            this.searchByToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.searchByToolStripMenuItem.Text = "Maintenance";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.titleToolStripMenuItem,
            this.directorToolStripMenuItem,
            this.genreToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.reportsToolStripMenuItem.Text = "Search by";
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfUsersToolStripMenuItem,
            this.listOfMoviesToolStripMenuItem,
            this.allAvailableMoviesToolStripMenuItem,
            this.allRentedMoviesToolStripMenuItem});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem1.Text = "Reports";
            // 
            // moviesToolStripMenuItem
            // 
            this.moviesToolStripMenuItem.Name = "moviesToolStripMenuItem";
            this.moviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.moviesToolStripMenuItem.Text = "Movies";
            this.moviesToolStripMenuItem.Click += new System.EventHandler(this.moviesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // rentsToolStripMenuItem
            // 
            this.rentsToolStripMenuItem.Name = "rentsToolStripMenuItem";
            this.rentsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rentsToolStripMenuItem.Text = "Rents";
            // 
            // titleToolStripMenuItem
            // 
            this.titleToolStripMenuItem.Name = "titleToolStripMenuItem";
            this.titleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.titleToolStripMenuItem.Text = "Title";
            // 
            // directorToolStripMenuItem
            // 
            this.directorToolStripMenuItem.Name = "directorToolStripMenuItem";
            this.directorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.directorToolStripMenuItem.Text = "Director";
            // 
            // genreToolStripMenuItem
            // 
            this.genreToolStripMenuItem.Name = "genreToolStripMenuItem";
            this.genreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.genreToolStripMenuItem.Text = "Genre";
            // 
            // listOfUsersToolStripMenuItem
            // 
            this.listOfUsersToolStripMenuItem.Name = "listOfUsersToolStripMenuItem";
            this.listOfUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfUsersToolStripMenuItem.Text = "List of Users";
            // 
            // listOfMoviesToolStripMenuItem
            // 
            this.listOfMoviesToolStripMenuItem.Name = "listOfMoviesToolStripMenuItem";
            this.listOfMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listOfMoviesToolStripMenuItem.Text = "List of Movies";
            // 
            // allAvailableMoviesToolStripMenuItem
            // 
            this.allAvailableMoviesToolStripMenuItem.Name = "allAvailableMoviesToolStripMenuItem";
            this.allAvailableMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allAvailableMoviesToolStripMenuItem.Text = "All Available Movies";
            // 
            // allRentedMoviesToolStripMenuItem
            // 
            this.allRentedMoviesToolStripMenuItem.Name = "allRentedMoviesToolStripMenuItem";
            this.allRentedMoviesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.allRentedMoviesToolStripMenuItem.Text = "All Rented Movies";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Movie Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchByToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem titleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem directorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listOfUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAvailableMoviesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allRentedMoviesToolStripMenuItem;
    }
}

