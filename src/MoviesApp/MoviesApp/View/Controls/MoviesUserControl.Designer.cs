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
            this.AddMovieButton = new System.Windows.Forms.Button();
            this.EditMovieButton = new System.Windows.Forms.Button();
            this.DeleteMovieButton = new System.Windows.Forms.Button();
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
            this.MoviesTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoviesTableLayoutPanel.Name = "MoviesTableLayoutPanel";
            this.MoviesTableLayoutPanel.RowCount = 3;
            this.MoviesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 193F));
            this.MoviesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MoviesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.MoviesTableLayoutPanel.Size = new System.Drawing.Size(867, 591);
            this.MoviesTableLayoutPanel.TabIndex = 0;
            // 
            // SelectedMovieGroupBox
            // 
            this.SelectedMovieGroupBox.Controls.Add(this.SelectedMovieTableLayoutPanel);
            this.SelectedMovieGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SelectedMovieGroupBox.Location = new System.Drawing.Point(350, 4);
            this.SelectedMovieGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedMovieGroupBox.Name = "SelectedMovieGroupBox";
            this.SelectedMovieGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedMovieGroupBox.Size = new System.Drawing.Size(513, 185);
            this.SelectedMovieGroupBox.TabIndex = 0;
            this.SelectedMovieGroupBox.TabStop = false;
            this.SelectedMovieGroupBox.Text = "Selected Movie";
            // 
            // SelectedMovieTableLayoutPanel
            // 
            this.SelectedMovieTableLayoutPanel.ColumnCount = 2;
            this.SelectedMovieTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
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
            this.SelectedMovieTableLayoutPanel.Location = new System.Drawing.Point(4, 19);
            this.SelectedMovieTableLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectedMovieTableLayoutPanel.Name = "SelectedMovieTableLayoutPanel";
            this.SelectedMovieTableLayoutPanel.RowCount = 5;
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SelectedMovieTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.SelectedMovieTableLayoutPanel.Size = new System.Drawing.Size(505, 162);
            this.SelectedMovieTableLayoutPanel.TabIndex = 3;
            // 
            // DurationInMinutesTextBox
            // 
            this.DurationInMinutesTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.DurationInMinutesTextBox.Enabled = false;
            this.DurationInMinutesTextBox.Location = new System.Drawing.Point(79, 133);
            this.DurationInMinutesTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DurationInMinutesTextBox.MaxLength = 3;
            this.DurationInMinutesTextBox.Name = "DurationInMinutesTextBox";
            this.DurationInMinutesTextBox.Size = new System.Drawing.Size(39, 22);
            this.DurationInMinutesTextBox.TabIndex = 12;
            this.DurationInMinutesTextBox.TextChanged += new System.EventHandler(this.DurationInMinutesTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.RatingTextBox.Enabled = false;
            this.RatingTextBox.Location = new System.Drawing.Point(79, 101);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RatingTextBox.MaxLength = 2;
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(39, 22);
            this.RatingTextBox.TabIndex = 11;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.ReleaseYearTextBox.Enabled = false;
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(79, 36);
            this.ReleaseYearTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ReleaseYearTextBox.MaxLength = 4;
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(39, 22);
            this.ReleaseYearTextBox.TabIndex = 9;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // DurationInMinutesLabel
            // 
            this.DurationInMinutesLabel.AutoSize = true;
            this.DurationInMinutesLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.DurationInMinutesLabel.Location = new System.Drawing.Point(11, 135);
            this.DurationInMinutesLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.DurationInMinutesLabel.Name = "DurationInMinutesLabel";
            this.DurationInMinutesLabel.Size = new System.Drawing.Size(60, 27);
            this.DurationInMinutesLabel.TabIndex = 8;
            this.DurationInMinutesLabel.Text = "Duration:";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RatingLabel.Location = new System.Drawing.Point(22, 103);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(49, 26);
            this.RatingLabel.TabIndex = 6;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GenreLabel.Location = new System.Drawing.Point(24, 70);
            this.GenreLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(47, 27);
            this.GenreLabel.TabIndex = 4;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ReleaseYearLabel.Location = new System.Drawing.Point(9, 38);
            this.ReleaseYearLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(62, 26);
            this.ReleaseYearLabel.TabIndex = 2;
            this.ReleaseYearLabel.Text = "Release:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TitleTextBox.Enabled = false;
            this.TitleTextBox.Location = new System.Drawing.Point(79, 4);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TitleTextBox.MaximumSize = new System.Drawing.Size(809, 20);
            this.TitleTextBox.MaxLength = 100;
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(422, 20);
            this.TitleTextBox.TabIndex = 1;
            this.TitleTextBox.TextChanged += new System.EventHandler(this.TitleTextBox_TextChanged);
            // 
            // TaitleLabel
            // 
            this.TaitleLabel.AutoSize = true;
            this.TaitleLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.TaitleLabel.Location = new System.Drawing.Point(35, 6);
            this.TaitleLabel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 0);
            this.TaitleLabel.Name = "TaitleLabel";
            this.TaitleLabel.Size = new System.Drawing.Size(36, 26);
            this.TaitleLabel.TabIndex = 0;
            this.TaitleLabel.Text = "Title:";
            // 
            // GenreComboBox
            // 
            this.GenreComboBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.GenreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenreComboBox.Enabled = false;
            this.GenreComboBox.FormattingEnabled = true;
            this.GenreComboBox.Location = new System.Drawing.Point(79, 68);
            this.GenreComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GenreComboBox.Name = "GenreComboBox";
            this.GenreComboBox.Size = new System.Drawing.Size(160, 24);
            this.GenreComboBox.TabIndex = 13;
            this.GenreComboBox.SelectedIndexChanged += new System.EventHandler(this.GenreComboBox_SelectedIndexChanged);
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.HorizontalScrollbar = true;
            this.MoviesListBox.ItemHeight = 16;
            this.MoviesListBox.Location = new System.Drawing.Point(4, 4);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesTableLayoutPanel.SetRowSpan(this.MoviesListBox, 2);
            this.MoviesListBox.Size = new System.Drawing.Size(338, 540);
            this.MoviesListBox.TabIndex = 1;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // ButtonsFlowLayoutPanel
            // 
            this.ButtonsFlowLayoutPanel.Controls.Add(this.AddMovieButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.EditMovieButton);
            this.ButtonsFlowLayoutPanel.Controls.Add(this.DeleteMovieButton);
            this.ButtonsFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonsFlowLayoutPanel.Location = new System.Drawing.Point(4, 552);
            this.ButtonsFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ButtonsFlowLayoutPanel.Name = "ButtonsFlowLayoutPanel";
            this.ButtonsFlowLayoutPanel.Size = new System.Drawing.Size(224, 35);
            this.ButtonsFlowLayoutPanel.TabIndex = 2;
            // 
            // AddMovieButton
            // 
            this.AddMovieButton.Location = new System.Drawing.Point(4, 4);
            this.AddMovieButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddMovieButton.Name = "AddMovieButton";
            this.AddMovieButton.Size = new System.Drawing.Size(67, 28);
            this.AddMovieButton.TabIndex = 0;
            this.AddMovieButton.Text = "Add";
            this.AddMovieButton.UseVisualStyleBackColor = true;
            this.AddMovieButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditMovieButton
            // 
            this.EditMovieButton.Location = new System.Drawing.Point(79, 4);
            this.EditMovieButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EditMovieButton.Name = "EditMovieButton";
            this.EditMovieButton.Size = new System.Drawing.Size(67, 28);
            this.EditMovieButton.TabIndex = 2;
            this.EditMovieButton.Text = "Edit";
            this.EditMovieButton.UseVisualStyleBackColor = true;
            this.EditMovieButton.Click += new System.EventHandler(this.EditMovieButton_Click);
            // 
            // DeleteMovieButton
            // 
            this.DeleteMovieButton.Location = new System.Drawing.Point(4, 40);
            this.DeleteMovieButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeleteMovieButton.Name = "DeleteMovieButton";
            this.DeleteMovieButton.Size = new System.Drawing.Size(67, 28);
            this.DeleteMovieButton.TabIndex = 1;
            this.DeleteMovieButton.Text = "Delete";
            this.DeleteMovieButton.UseVisualStyleBackColor = true;
            this.DeleteMovieButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MoviesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MoviesTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MoviesUserControl";
            this.Size = new System.Drawing.Size(867, 591);
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
        private System.Windows.Forms.Button AddMovieButton;
        private System.Windows.Forms.Button DeleteMovieButton;
        private System.Windows.Forms.Button EditMovieButton;
    }
}
