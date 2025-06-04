namespace MoviesApp.View.Controls
{
    partial class MoviesUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SelectedMovieGroupBox = new System.Windows.Forms.GroupBox();
            this.SelectedMovieTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.DurationInMinutesTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.DurationInMinutesLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.TaitleLabel = new System.Windows.Forms.Label();
            this.GenreComboBox = new System.Windows.Forms.ComboBox();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.ButtonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MoviesTableLayoutPanel.SuspendLayout();
            this.SelectedMovieGroupBox.SuspendLayout();
            this.SelectedMovieTableLayoutPanel.SuspendLayout();
            this.ButtonsFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoviesTableLayoutPanel
            // 
            this.MoviesTableLayoutPanel.ColumnCount = 2;
            this.MoviesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MoviesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MoviesTableLayoutPanel.Controls.Add(this.SelectedMovieGroupBox, 1, 0);
            this.MoviesTableLayoutPanel.Controls.Add(this.MoviesListBox, 0, 0);
            this.MoviesTableLayoutPanel.Controls.Add(this.ButtonsFlowLayoutPanel, 0, 2);
            this.MoviesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MoviesTableLayoutPanel.Name = "MoviesTableLayoutPanel";
            this.MoviesTableLayoutPanel.RowCount = 3;
            this.MoviesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.MoviesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MoviesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.MoviesTableLayoutPanel.Size = new System.Drawing.Size(640, 480);
            this.MoviesTableLayoutPanel.TabIndex = 0;
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.Controls.Add(this.SelectedMovieTableLayoutPanel);
            this.SelectedMovieGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(259, 3);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(378, 151);
            this.SelectedMovieGroupBox.TabIndex = 0;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Selected Movie";
            // 
            // SelectedMovieTableLayoutPanel
            // 
            this.SelectedMovieTableLayoutPanel.ColumnCount = 2;
            this.SelectedMovieTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.SelectedMovieTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.DurationInMinutesTextBox, 1, 4);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.RatingTextBox, 1, 3);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.ReleaseYearTextBox, 1, 1);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.DurationInMinutesLabel, 0, 4);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.RatingLabel, 0, 3);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.GenreLabel, 0, 2);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.ReleaseYearLabel, 0, 1);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.TitleTextBox, 1, 0);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.TaitleLabel, 0, 0);
            this.SelectedMovieTableLayoutPanel.Controls.Add(this.GenreComboBox, 1, 2);
            this.SelectedMovieTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedMovieTableLayoutPanel.Location = new System.Drawing.Point(3, 16);
            this.SelectedMovieTableLayoutPanel.Name = "SelectedMovieTableLayoutPanel";
            this.SelectedMovieTableLayoutPanel.RowCount = 5;
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.SelectedMovieTableLayoutPanel.Size = new System.Drawing.Size(372, 132);
            this.SelectedMovieTableLayoutPanel.TabIndex = 3;
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(59, 108);
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(121, 20);
            this.DurationInMinutesTextBox.TabIndex = 12;
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RatingTextBox.Location = new System.Drawing.Point(59, 82);
            this.RatingTextBox.MaxLength = 2;
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(20, 20);
            this.RatingTextBox.TabIndex = 11;
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(59, 29);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(121, 20);
            this.ReleaseYearTextBox.TabIndex = 9;
            // 
            // DurationInMinutesLabel
            // 
            this.DurationInMinutesLabel.AutoSize = true;
            this.DurationInMinutesLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(3, 110);
            this.DurationInMinutesLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.DurationInMinutesLabel.Name = "DurationInMinutesLabel";
            this.DurationInMinutesLabel.Size = new System.Drawing.Size(50, 22);
            this.DurationInMinutesLabel.TabIndex = 8;
            this.DurationInMinutesLabel.Text = "Duration:";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RatingLabel.Location = new System.Drawing.Point(12, 84);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 21);
            this.RatingLabel.TabIndex = 6;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GenreLabel.Location = new System.Drawing.Point(14, 57);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 22);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(4, 31);
            this.ReleaseYearLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(49, 21);
            this.ReleaseYearLabel.TabIndex = 2;
            this.ReleaseYearLabel.Text = "Release:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.Location = new System.Drawing.Point(59, 3);
            this.TitleTextBox.MaximumSize = new System.Drawing.Size(400, 20);
            this.TitleTextBox.MaxLength = 300;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(310, 20);
            this.TitleTextBox.TabIndex = 1;
            // 
            // TaitleLabel
            // 
            this.TaitleLabel.AutoSize = true;
            this.TaitleLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TaitleLabel.Location = new System.Drawing.Point(23, 5);
            this.TaitleLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.TaitleLabel.Name = "TaitleLabel";
            this.TaitleLabel.Size = new System.Drawing.Size(30, 21);
            this.TaitleLabel.TabIndex = 0;
            this.TaitleLabel.Text = "Title:";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(59, 55);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(121, 21);
            this.GenreComboBox.TabIndex = 13;
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.Location = new System.Drawing.Point(3, 3);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesTableLayoutPanel.SetRowSpan(this.MoviesListBox, 2);
            this.MoviesListBox.Size = new System.Drawing.Size(250, 439);
            this.MoviesListBox.TabIndex = 1;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // ButtonsFlowLayoutPanel
            // 
            this.ButtonsFlowLayoutPanel.Controls.Add(this.AddButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.DeleteButton);
            this.ButtonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonsFlowLayoutPanel.Location = new System.Drawing.Point(3, 448);
            this.ButtonsFlowLayoutPanel.Name = "ButtonsFlowLayoutPanel";
            this.ButtonsFlowLayoutPanel.Size = new System.Drawing.Size(112, 29);
            this.ButtonsFlowLayoutPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(50, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(59, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(50, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoviesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesTableLayoutPanel);
            this.Name = "MoviesUserControl";
            this.Size = new System.Drawing.Size(640, 480);
            this.MoviesTableLayoutPanel.ResumeLayout(false);
            this.SelectedMovieGroupBox.ResumeLayout(false);
            this.SelectedMovieTableLayoutPanel.ResumeLayout(false);
            this.SelectedMovieTableLayoutPanel.PerformLayout();
            this.ButtonsFlowLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel MoviesTableLayoutPanel;
        private System.Windows.Forms.GroupBox SelectedMovieGroupBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label TaitleLabel;
        private System.Windows.Forms.TableLayoutPanel SelectedMovieTableLayoutPanel;
        private System.Windows.Forms.Label DurationInMinutesLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.TextBox DurationInMinutesTextBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.ComboBox GenreComboBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.FlowLayoutPanel ButtonsFlowLayoutPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}
