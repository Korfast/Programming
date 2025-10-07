namespace ObjectOrientedPractics
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.CustomersTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab1 = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.tabControl1.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.itemsTabPage);
            this.tabControl1.Controls.Add(this.CustomersTabPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(622, 433);
            this.tabControl1.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsTab1);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 25);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(614, 404);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTabPage
            // 
            this.CustomersTabPage.Location = new System.Drawing.Point(4, 25);
            this.CustomersTabPage.Name = "CustomersTabPage";
            this.CustomersTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CustomersTabPage.Size = new System.Drawing.Size(792, 421);
            this.CustomersTabPage.TabIndex = 1;
            this.CustomersTabPage.Text = "Customers";
            this.CustomersTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            this.itemsTab1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab1.Location = new System.Drawing.Point(3, 3);
            this.itemsTab1.Name = "itemsTab1";
            this.itemsTab1.Size = new System.Drawing.Size(608, 398);
            this.itemsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(400, 380);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.itemsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.TabPage CustomersTabPage;
        private View.Tabs.ItemsTab itemsTab1;
    }
}

