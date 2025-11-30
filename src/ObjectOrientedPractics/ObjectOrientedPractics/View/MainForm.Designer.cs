namespace ObjectOrientedPractics.View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.customersTabPage = new System.Windows.Forms.TabPage();
            this.customersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.cartsTabPage = new System.Windows.Forms.TabPage();
            this.cartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.mainTabControl.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.customersTabPage.SuspendLayout();
            this.cartsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Controls.Add(this.customersTabPage);
            this.mainTabControl.Controls.Add(this.cartsTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(466, 352);
            this.mainTabControl.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsTab);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.itemsTabPage.Size = new System.Drawing.Size(458, 326);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsTab
            // 
            this.itemsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTab.Location = new System.Drawing.Point(2, 2);
            this.itemsTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemsTab.Name = "itemsTab";
            this.itemsTab.Size = new System.Drawing.Size(454, 322);
            this.itemsTab.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.customersTab);
            this.customersTabPage.Location = new System.Drawing.Point(4, 22);
            this.customersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.customersTabPage.Size = new System.Drawing.Size(458, 326);
            this.customersTabPage.TabIndex = 1;
            this.customersTabPage.Text = "Customers";
            this.customersTabPage.UseVisualStyleBackColor = true;
            // 
            // customersTab
            // 
            this.customersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTab.Location = new System.Drawing.Point(2, 2);
            this.customersTab.Margin = new System.Windows.Forms.Padding(2);
            this.customersTab.Name = "customersTab";
            this.customersTab.Size = new System.Drawing.Size(454, 322);
            this.customersTab.TabIndex = 0;
            // 
            // cartsTabPage
            // 
            this.cartsTabPage.Controls.Add(this.cartsTab);
            this.cartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartsTabPage.Name = "cartsTabPage";
            this.cartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartsTabPage.Size = new System.Drawing.Size(458, 326);
            this.cartsTabPage.TabIndex = 2;
            this.cartsTabPage.Text = "Carts";
            this.cartsTabPage.UseVisualStyleBackColor = true;
            // 
            // cartsTab
            // 
            this.cartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTab.Location = new System.Drawing.Point(3, 3);
            this.cartsTab.Margin = new System.Windows.Forms.Padding(2);
            this.cartsTab.Name = "cartsTab";
            this.cartsTab.Size = new System.Drawing.Size(452, 320);
            this.cartsTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 352);
            this.Controls.Add(this.mainTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(304, 316);
            this.Name = "MainForm";
            this.Text = "ObjectOrientedPractics";
            this.mainTabControl.ResumeLayout(false);
            this.itemsTabPage.ResumeLayout(false);
            this.customersTabPage.ResumeLayout(false);
            this.cartsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage itemsTabPage;
        private View.Tabs.ItemsTab itemsTab;
        private System.Windows.Forms.TabPage customersTabPage;
        private View.Tabs.CustomersTab customersTab;
        private System.Windows.Forms.TabPage cartsTabPage;
        private View.Tabs.CartsTab cartsTab;
    }
}

