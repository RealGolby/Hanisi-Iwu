namespace Hanisi_Iwu
{
    partial class AddMovie
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
            this.SpecialAwards = new System.Windows.Forms.Label();
            this.Notes = new System.Windows.Forms.Label();
            this.PersonalRating = new System.Windows.Forms.Label();
            this.Director = new System.Windows.Forms.Label();
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.Lenght = new System.Windows.Forms.Label();
            this.Genres = new System.Windows.Forms.Label();
            this.Rating = new System.Windows.Forms.Label();
            this.MovieName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoadMovie = new System.Windows.Forms.Button();
            this.SaveMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SpecialAwards
            // 
            this.SpecialAwards.AutoSize = true;
            this.SpecialAwards.Location = new System.Drawing.Point(152, 526);
            this.SpecialAwards.Name = "SpecialAwards";
            this.SpecialAwards.Size = new System.Drawing.Size(84, 15);
            this.SpecialAwards.TabIndex = 21;
            this.SpecialAwards.Text = "Special awards";
            // 
            // Notes
            // 
            this.Notes.AutoSize = true;
            this.Notes.Location = new System.Drawing.Point(152, 433);
            this.Notes.Name = "Notes";
            this.Notes.Size = new System.Drawing.Size(38, 15);
            this.Notes.TabIndex = 20;
            this.Notes.Text = "Notes";
            // 
            // PersonalRating
            // 
            this.PersonalRating.AutoSize = true;
            this.PersonalRating.Location = new System.Drawing.Point(152, 399);
            this.PersonalRating.Name = "PersonalRating";
            this.PersonalRating.Size = new System.Drawing.Size(86, 15);
            this.PersonalRating.TabIndex = 19;
            this.PersonalRating.Text = "Personal rating";
            // 
            // Director
            // 
            this.Director.AutoSize = true;
            this.Director.Location = new System.Drawing.Point(152, 286);
            this.Director.Name = "Director";
            this.Director.Size = new System.Drawing.Size(49, 15);
            this.Director.TabIndex = 18;
            this.Director.Text = "Director";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Location = new System.Drawing.Point(152, 256);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(70, 15);
            this.ReleaseDate.TabIndex = 17;
            this.ReleaseDate.Text = "ReleaseDate";
            // 
            // Lenght
            // 
            this.Lenght.AutoSize = true;
            this.Lenght.Location = new System.Drawing.Point(152, 222);
            this.Lenght.Name = "Lenght";
            this.Lenght.Size = new System.Drawing.Size(44, 15);
            this.Lenght.TabIndex = 16;
            this.Lenght.Text = "Lenght";
            // 
            // Genres
            // 
            this.Genres.AutoSize = true;
            this.Genres.Location = new System.Drawing.Point(152, 189);
            this.Genres.Name = "Genres";
            this.Genres.Size = new System.Drawing.Size(43, 15);
            this.Genres.TabIndex = 15;
            this.Genres.Text = "Genres";
            // 
            // Rating
            // 
            this.Rating.AutoSize = true;
            this.Rating.Location = new System.Drawing.Point(152, 153);
            this.Rating.Name = "Rating";
            this.Rating.Size = new System.Drawing.Size(41, 15);
            this.Rating.TabIndex = 14;
            this.Rating.Text = "Rating";
            // 
            // MovieName
            // 
            this.MovieName.AutoSize = true;
            this.MovieName.Location = new System.Drawing.Point(152, 119);
            this.MovieName.Name = "MovieName";
            this.MovieName.Size = new System.Drawing.Size(72, 15);
            this.MovieName.TabIndex = 13;
            this.MovieName.Text = "MovieName";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 33);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 23);
            this.textBox1.TabIndex = 12;
            // 
            // LoadMovie
            // 
            this.LoadMovie.Location = new System.Drawing.Point(101, 62);
            this.LoadMovie.Name = "LoadMovie";
            this.LoadMovie.Size = new System.Drawing.Size(164, 37);
            this.LoadMovie.TabIndex = 22;
            this.LoadMovie.Text = "Add Movie";
            this.LoadMovie.UseVisualStyleBackColor = true;
            this.LoadMovie.Click += new System.EventHandler(this.LoadMovie_Click);
            // 
            // SaveMovie
            // 
            this.SaveMovie.Location = new System.Drawing.Point(101, 624);
            this.SaveMovie.Name = "SaveMovie";
            this.SaveMovie.Size = new System.Drawing.Size(164, 37);
            this.SaveMovie.TabIndex = 23;
            this.SaveMovie.Text = "Add Movie";
            this.SaveMovie.UseVisualStyleBackColor = true;
            this.SaveMovie.Click += new System.EventHandler(this.SaveMovie_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 673);
            this.Controls.Add(this.SaveMovie);
            this.Controls.Add(this.LoadMovie);
            this.Controls.Add(this.SpecialAwards);
            this.Controls.Add(this.Notes);
            this.Controls.Add(this.PersonalRating);
            this.Controls.Add(this.Director);
            this.Controls.Add(this.ReleaseDate);
            this.Controls.Add(this.Lenght);
            this.Controls.Add(this.Genres);
            this.Controls.Add(this.Rating);
            this.Controls.Add(this.MovieName);
            this.Controls.Add(this.textBox1);
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label SpecialAwards;
        private Label Notes;
        private Label PersonalRating;
        private Label Director;
        private Label ReleaseDate;
        private Label Lenght;
        private Label Genres;
        private Label Rating;
        private Label MovieName;
        private TextBox textBox1;
        private Button LoadMovie;
        private Button SaveMovie;
    }
}