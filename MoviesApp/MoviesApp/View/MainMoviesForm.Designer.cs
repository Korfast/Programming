namespace MoviesApp.View
{
    partial class MainMoviesForm
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
            this.moviesUserControl1 = new MoviesApp.View.Controls.MoviesUserControl();
            this.SuspendLayout();
            // 
            // moviesUserControl1
            // 
            this.moviesUserControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.moviesUserControl1.Location = new System.Drawing.Point(0, 0);
            this.moviesUserControl1.Name = "moviesUserControl1";
            this.moviesUserControl1.Size = new System.Drawing.Size(624, 441);
            this.moviesUserControl1.TabIndex = 0;
            // 
            // MainMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.moviesUserControl1);
            this.Name = "MainMoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMoviesForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MoviesUserControl moviesUserControl1;
    }
}