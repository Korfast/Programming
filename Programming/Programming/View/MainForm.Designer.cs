namespace Programming.View
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
            this.ClassesTabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.moviesInformationUserControl1 = new Programming.View.Controls.MoviesInformationUserControl();
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.rectanglesInfarmationUserControl1 = new Programming.View.Controls.RectanglesInfarmationUserControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.seasonHandleUserControl1 = new Programming.View.Controls.SeasonHandleUserControl();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingUserControl = new Programming.View.Controls.WeekdayParsingUserControl();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationsControl = new Programming.View.Controls.EnumerationsControl();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.ClassesTabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClassesTabPage
            // 
            this.ClassesTabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassesTabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassesTabPage.Location = new System.Drawing.Point(4, 22);
            this.ClassesTabPage.Name = "ClassesTabPage";
            this.ClassesTabPage.Size = new System.Drawing.Size(616, 415);
            this.ClassesTabPage.TabIndex = 1;
            this.ClassesTabPage.Text = "Classes";
            this.ClassesTabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.moviesInformationUserControl1);
            this.MoviesGroupBox.Location = new System.Drawing.Point(310, 6);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(298, 359);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // moviesInformationUserControl1
            // 
            this.moviesInformationUserControl1.Location = new System.Drawing.Point(6, 14);
            this.moviesInformationUserControl1.Name = "moviesInformationUserControl1";
            this.moviesInformationUserControl1.Size = new System.Drawing.Size(285, 270);
            this.moviesInformationUserControl1.TabIndex = 0;
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.rectanglesInfarmationUserControl1);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(4, 6);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(300, 359);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // rectanglesInfarmationUserControl1
            // 
            this.rectanglesInfarmationUserControl1.Location = new System.Drawing.Point(4, 14);
            this.rectanglesInfarmationUserControl1.Name = "rectanglesInfarmationUserControl1";
            this.rectanglesInfarmationUserControl1.Size = new System.Drawing.Size(286, 270);
            this.rectanglesInfarmationUserControl1.TabIndex = 0;
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
            this.SeasonHandleGroupBox.Controls.Add(this.seasonHandleUserControl1);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(312, 284);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(300, 123);
            this.SeasonHandleGroupBox.TabIndex = 3;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // seasonHandleUserControl1
            // 
            this.seasonHandleUserControl1.Location = new System.Drawing.Point(8, 21);
            this.seasonHandleUserControl1.Name = "seasonHandleUserControl1";
            this.seasonHandleUserControl1.Size = new System.Drawing.Size(286, 39);
            this.seasonHandleUserControl1.TabIndex = 1;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingUserControl);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(4, 284);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(300, 123);
            this.WeekdayParsingGroupBox.TabIndex = 2;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayParsingUserControl
            // 
            this.WeekdayParsingUserControl.Location = new System.Drawing.Point(6, 21);
            this.WeekdayParsingUserControl.Name = "WeekdayParsingUserControl";
            this.WeekdayParsingUserControl.Size = new System.Drawing.Size(285, 59);
            this.WeekdayParsingUserControl.TabIndex = 0;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.EnumerationsControl);
            this.EnumsGroupBox.Location = new System.Drawing.Point(4, 6);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(606, 271);
            this.EnumsGroupBox.TabIndex = 1;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // EnumerationsControl
            // 
            this.EnumerationsControl.Location = new System.Drawing.Point(6, 16);
            this.EnumerationsControl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.EnumerationsControl.Name = "EnumerationsControl";
            this.EnumerationsControl.Size = new System.Drawing.Size(489, 223);
            this.EnumerationsControl.TabIndex = 0;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumsTabPage);
            this.MainTabControl.Controls.Add(this.ClassesTabPage);
            this.MainTabControl.Controls.Add(this.RectanglesTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(624, 441);
            this.MainTabControl.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 22);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.RectanglesTabPage.Size = new System.Drawing.Size(616, 415);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(2, 2);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(612, 411);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgrammingDemo";
            this.ClassesTabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage ClassesTabPage;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private View.Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Controls.EnumerationsControl EnumerationsControl;
        private View.Controls.WeekdayParsingUserControl WeekdayParsingUserControl;
        private View.Controls.SeasonHandleUserControl seasonHandleUserControl1;
        private View.Controls.RectanglesInfarmationUserControl rectanglesInfarmationUserControl1;
        private View.Controls.MoviesInformationUserControl moviesInformationUserControl1;
    }
}

