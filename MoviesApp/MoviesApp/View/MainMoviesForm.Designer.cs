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
            this.MainMoviesUserControl = new MoviesApp.View.Controls.MoviesUserControl();
            this.SuspendLayout();
            // 
            // MainMoviesUserControl
            // 
            this.MainMoviesUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMoviesUserControl.Location = new System.Drawing.Point(0, 0);
            this.MainMoviesUserControl.MinimumSize = new System.Drawing.Size(0, 160);
            this.MainMoviesUserControl.Name = "MainMoviesUserControl";
            this.MainMoviesUserControl.Size = new System.Drawing.Size(624, 441);
            this.MainMoviesUserControl.TabIndex = 0;
            // 
            // MainMoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.MainMoviesUserControl);
            this.MinimumSize = new System.Drawing.Size(455, 200);
            this.Name = "MainMoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMoviesForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.MoviesUserControl MainMoviesUserControl;
    }
}