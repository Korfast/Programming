namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.ValuesLabel = new System.Windows.Forms.Label();
            this.EnumsLabel = new System.Windows.Forms.Label();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LenghTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.ClassesTabPage.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumsGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(616, 415);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.ChooseSeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(312, 284);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(300, 123);
            this.SeasonHandleGroupBox.TabIndex = 3;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(217, 35);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(10, 37);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(200, 21);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(7, 21);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(82, 13);
            this.ChooseSeasonLabel.TabIndex = 0;
            this.ChooseSeasonLabel.Text = "Choose Season";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.TypeLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(4, 284);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(300, 123);
            this.WeekdayParsingGroupBox.TabIndex = 2;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekdayLabel.Location = new System.Drawing.Point(13, 64);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(0, 15);
            this.WeekdayLabel.TabIndex = 3;
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(219, 35);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(75, 23);
            this.ParseButton.TabIndex = 2;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(13, 37);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(200, 20);
            this.WeekdayTextBox.TabIndex = 1;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(10, 21);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type value for parsing:";
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.NumberLabel);
            this.EnumsGroupBox.Controls.Add(this.ValuesLabel);
            this.EnumsGroupBox.Controls.Add(this.EnumsLabel);
            this.EnumsGroupBox.Controls.Add(this.ValueTextBox);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Location = new System.Drawing.Point(4, 6);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(606, 271);
            this.EnumsGroupBox.TabIndex = 1;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(340, 16);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(48, 13);
            this.NumberLabel.TabIndex = 5;
            this.NumberLabel.Text = "ht value:";
            // 
            // ValuesLabel
            // 
            this.ValuesLabel.AutoSize = true;
            this.ValuesLabel.Location = new System.Drawing.Point(173, 16);
            this.ValuesLabel.Name = "ValuesLabel";
            this.ValuesLabel.Size = new System.Drawing.Size(72, 13);
            this.ValuesLabel.TabIndex = 4;
            this.ValuesLabel.Text = "Choose value";
            // 
            // EnumsLabel
            // 
            this.EnumsLabel.AutoSize = true;
            this.EnumsLabel.Location = new System.Drawing.Point(6, 16);
            this.EnumsLabel.Name = "EnumsLabel";
            this.EnumsLabel.Size = new System.Drawing.Size(109, 13);
            this.EnumsLabel.TabIndex = 3;
            this.EnumsLabel.Text = "Choose enumerations";
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.Location = new System.Drawing.Point(343, 35);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(150, 20);
            this.ValueTextBox.TabIndex = 2;
            this.ValueTextBox.Text = "0";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(176, 35);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(150, 199);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 35);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(150, 199);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumsTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(624, 441);
            this.MainTabControl.TabIndex = 0;
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(616, 415);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.FindButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LenghTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label3);
            this.RectanglesGroupBox.Controls.Add(this.label2);
            this.RectanglesGroupBox.Controls.Add(this.label1);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(4, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(335, 230);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(187, 196);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(100, 23);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(187, 115);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(187, 76);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 5;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LenghTextBox
            // 
            this.LenghTextBox.Location = new System.Drawing.Point(187, 37);
            this.LenghTextBox.Name = "LenghTextBox";
            this.LenghTextBox.Size = new System.Drawing.Size(100, 20);
            this.LenghTextBox.TabIndex = 4;
            this.LenghTextBox.TextChanged += new System.EventHandler(this.LenghTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(184, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Color:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lenght:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Location = new System.Drawing.Point(7, 20);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(174, 199);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgrammingDemo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ClassesTabPage.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label EnumsLabel;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.Label ValuesLabel;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.TextBox LenghTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Button FindButton;
    }
}

