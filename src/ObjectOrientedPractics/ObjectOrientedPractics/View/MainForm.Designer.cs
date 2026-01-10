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
            this.orderTabPage = new System.Windows.Forms.TabPage();
            this.ordersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.priorityOrdersTabPage = new System.Windows.Forms.TabPage();
            this.priorityOrdersTab = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.testingInterfacesTabPage = new System.Windows.Forms.TabPage();
            this.testingInterfacesTab = new ObjectOrientedPractics.View.Tabs.TestingInterfacesTab();
            this.mainTabControl.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.customersTabPage.SuspendLayout();
            this.cartsTabPage.SuspendLayout();
            this.orderTabPage.SuspendLayout();
            this.priorityOrdersTabPage.SuspendLayout();
            this.testingInterfacesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.itemsTabPage);
            this.mainTabControl.Controls.Add(this.customersTabPage);
            this.mainTabControl.Controls.Add(this.cartsTabPage);
            this.mainTabControl.Controls.Add(this.orderTabPage);
            this.mainTabControl.Controls.Add(this.priorityOrdersTabPage);
            this.mainTabControl.Controls.Add(this.testingInterfacesTabPage);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(706, 547);
            this.mainTabControl.TabIndex = 0;
            this.mainTabControl.SelectedIndexChanged += new System.EventHandler(this.MainTabControl_SelectedIndexChanged);
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsTab);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.itemsTabPage.Size = new System.Drawing.Size(698, 521);
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
            this.itemsTab.Size = new System.Drawing.Size(694, 517);
            this.itemsTab.TabIndex = 0;
            // 
            // customersTabPage
            // 
            this.customersTabPage.Controls.Add(this.customersTab);
            this.customersTabPage.Location = new System.Drawing.Point(4, 22);
            this.customersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.customersTabPage.Name = "customersTabPage";
            this.customersTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.customersTabPage.Size = new System.Drawing.Size(698, 521);
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
            this.customersTab.Size = new System.Drawing.Size(694, 517);
            this.customersTab.TabIndex = 0;
            // 
            // cartsTabPage
            // 
            this.cartsTabPage.Controls.Add(this.cartsTab);
            this.cartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.cartsTabPage.Name = "cartsTabPage";
            this.cartsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.cartsTabPage.Size = new System.Drawing.Size(698, 521);
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
            this.cartsTab.Size = new System.Drawing.Size(692, 515);
            this.cartsTab.TabIndex = 0;
            // 
            // orderTabPage
            // 
            this.orderTabPage.Controls.Add(this.ordersTab);
            this.orderTabPage.Location = new System.Drawing.Point(4, 22);
            this.orderTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.orderTabPage.Name = "orderTabPage";
            this.orderTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.orderTabPage.Size = new System.Drawing.Size(698, 521);
            this.orderTabPage.TabIndex = 3;
            this.orderTabPage.Text = "Orders";
            this.orderTabPage.UseVisualStyleBackColor = true;
            // 
            // ordersTab
            // 
            this.ordersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTab.Location = new System.Drawing.Point(2, 2);
            this.ordersTab.Margin = new System.Windows.Forms.Padding(2);
            this.ordersTab.Name = "ordersTab";
            this.ordersTab.Size = new System.Drawing.Size(694, 517);
            this.ordersTab.TabIndex = 0;
            // 
            // priorityOrdersTabPage
            // 
            this.priorityOrdersTabPage.Controls.Add(this.priorityOrdersTab);
            this.priorityOrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.priorityOrdersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.priorityOrdersTabPage.Name = "priorityOrdersTabPage";
            this.priorityOrdersTabPage.Padding = new System.Windows.Forms.Padding(2);
            this.priorityOrdersTabPage.Size = new System.Drawing.Size(698, 521);
            this.priorityOrdersTabPage.TabIndex = 4;
            this.priorityOrdersTabPage.Text = "Priority Orders";
            this.priorityOrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab
            // 
            this.priorityOrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priorityOrdersTab.Location = new System.Drawing.Point(2, 2);
            this.priorityOrdersTab.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.priorityOrdersTab.Name = "priorityOrdersTab";
            this.priorityOrdersTab.Size = new System.Drawing.Size(694, 517);
            this.priorityOrdersTab.TabIndex = 0;
            // 
            // testingInterfacesTabPage
            // 
            this.testingInterfacesTabPage.Controls.Add(this.testingInterfacesTab);
            this.testingInterfacesTabPage.Location = new System.Drawing.Point(4, 22);
            this.testingInterfacesTabPage.Name = "testingInterfacesTabPage";
            this.testingInterfacesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.testingInterfacesTabPage.Size = new System.Drawing.Size(698, 521);
            this.testingInterfacesTabPage.TabIndex = 5;
            this.testingInterfacesTabPage.Text = "TestingInterfacesTabPage";
            this.testingInterfacesTabPage.UseVisualStyleBackColor = true;
            // 
            // testingInterfacesTab
            // 
            this.testingInterfacesTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testingInterfacesTab.Location = new System.Drawing.Point(3, 3);
            this.testingInterfacesTab.Name = "testingInterfacesTab";
            this.testingInterfacesTab.Size = new System.Drawing.Size(692, 515);
            this.testingInterfacesTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 547);
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
            this.orderTabPage.ResumeLayout(false);
            this.priorityOrdersTabPage.ResumeLayout(false);
            this.testingInterfacesTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage orderTabPage;
        private Tabs.OrdersTab ordersTab;
        private System.Windows.Forms.TabPage priorityOrdersTabPage;
        private Tabs.PriorityOrdersTab priorityOrdersTab;
        private System.Windows.Forms.TabPage testingInterfacesTabPage;
        private Tabs.TestingInterfacesTab testingInterfacesTab;
    }
}

