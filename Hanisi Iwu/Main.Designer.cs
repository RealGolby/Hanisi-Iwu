namespace Hanisi_Iwu
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.ShowMoviesBtn = new System.Windows.Forms.Button();
            this.AddMovieBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Golbyho uzasny tier list ani...eh teda filmů";
            // 
            // ShowMoviesBtn
            // 
            this.ShowMoviesBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ShowMoviesBtn.Location = new System.Drawing.Point(517, 244);
            this.ShowMoviesBtn.Name = "ShowMoviesBtn";
            this.ShowMoviesBtn.Size = new System.Drawing.Size(204, 117);
            this.ShowMoviesBtn.TabIndex = 1;
            this.ShowMoviesBtn.Text = "Ukaz filmy";
            this.ShowMoviesBtn.UseVisualStyleBackColor = true;
            this.ShowMoviesBtn.Click += new System.EventHandler(this.ShowMoviesBtn_Click);
            // 
            // AddMovieBtn
            // 
            this.AddMovieBtn.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.AddMovieBtn.Location = new System.Drawing.Point(65, 244);
            this.AddMovieBtn.Name = "AddMovieBtn";
            this.AddMovieBtn.Size = new System.Drawing.Size(204, 117);
            this.AddMovieBtn.TabIndex = 2;
            this.AddMovieBtn.Text = "Zandej filmy";
            this.AddMovieBtn.UseVisualStyleBackColor = true;
            this.AddMovieBtn.Click += new System.EventHandler(this.AddMovieBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddMovieBtn);
            this.Controls.Add(this.ShowMoviesBtn);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button ShowMoviesBtn;
        private Button AddMovieBtn;
    }
}