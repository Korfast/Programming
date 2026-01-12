namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.selectedItemLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.itemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.selectedItemTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.idCostTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.costTextBox = new System.Windows.Forms.TextBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.findAndItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.organizingProductsComboBox = new System.Windows.Forms.ComboBox();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.findTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.findLabel = new System.Windows.Forms.Label();
            this.findTextBox = new System.Windows.Forms.TextBox();
            this.itemsTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.selectedItemTableLayoutPanel.SuspendLayout();
            this.idCostTableLayoutPanel.SuspendLayout();
            this.findAndItemsTableLayoutPanel.SuspendLayout();
            this.orderTableLayoutPanel.SuspendLayout();
            this.findTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedItemLabel
            // 
            this.selectedItemLabel.AutoSize = true;
            this.selectedItemLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedItemLabel.Location = new System.Drawing.Point(192, 0);
            this.selectedItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedItemLabel.Name = "selectedItemLabel";
            this.selectedItemLabel.Size = new System.Drawing.Size(102, 16);
            this.selectedItemLabel.TabIndex = 3;
            this.selectedItemLabel.Text = "Selected Item";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(2, 0);
            this.itemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(44, 16);
            this.itemsLabel.TabIndex = 0;
            this.itemsLabel.Text = "Items";
            // 
            // itemsTableLayoutPanel
            // 
            this.itemsTableLayoutPanel.ColumnCount = 2;
            this.itemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190F));
            this.itemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemsTableLayoutPanel.Controls.Add(this.itemsLabel, 0, 0);
            this.itemsTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 2);
            this.itemsTableLayoutPanel.Controls.Add(this.selectedItemLabel, 1, 0);
            this.itemsTableLayoutPanel.Controls.Add(this.selectedItemTableLayoutPanel, 1, 1);
            this.itemsTableLayoutPanel.Controls.Add(this.findAndItemsTableLayoutPanel, 0, 1);
            this.itemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.itemsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.itemsTableLayoutPanel.Name = "itemsTableLayoutPanel";
            this.itemsTableLayoutPanel.RowCount = 3;
            this.itemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.itemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.itemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.itemsTableLayoutPanel.Size = new System.Drawing.Size(480, 390);
            this.itemsTableLayoutPanel.TabIndex = 0;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonsTableLayoutPanel.Controls.Add(this.addButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.removeButton, 1, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(2, 347);
            this.buttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(186, 41);
            this.buttonsTableLayoutPanel.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(2, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(61, 37);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(67, 2);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(61, 37);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // selectedItemTableLayoutPanel
            // 
            this.selectedItemTableLayoutPanel.ColumnCount = 1;
            this.selectedItemTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedItemTableLayoutPanel.Controls.Add(this.nameLabel, 0, 1);
            this.selectedItemTableLayoutPanel.Controls.Add(this.descriptionLabel, 0, 3);
            this.selectedItemTableLayoutPanel.Controls.Add(this.idCostTableLayoutPanel, 0, 0);
            this.selectedItemTableLayoutPanel.Controls.Add(this.nameTextBox, 0, 2);
            this.selectedItemTableLayoutPanel.Controls.Add(this.descriptionTextBox, 0, 4);
            this.selectedItemTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedItemTableLayoutPanel.Location = new System.Drawing.Point(192, 18);
            this.selectedItemTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.selectedItemTableLayoutPanel.Name = "selectedItemTableLayoutPanel";
            this.selectedItemTableLayoutPanel.RowCount = 6;
            this.selectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.selectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.selectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.selectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.selectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedItemTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.selectedItemTableLayoutPanel.Size = new System.Drawing.Size(286, 325);
            this.selectedItemTableLayoutPanel.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameLabel.Location = new System.Drawing.Point(2, 73);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(44, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.descriptionLabel.Location = new System.Drawing.Point(2, 137);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(72, 16);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Description:";
            // 
            // idCostTableLayoutPanel
            // 
            this.idCostTableLayoutPanel.ColumnCount = 2;
            this.idCostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.idCostTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.idCostTableLayoutPanel.Controls.Add(this.costTextBox, 1, 1);
            this.idCostTableLayoutPanel.Controls.Add(this.costLabel, 0, 1);
            this.idCostTableLayoutPanel.Controls.Add(this.idTextBox, 1, 0);
            this.idCostTableLayoutPanel.Controls.Add(this.idLabel, 0, 0);
            this.idCostTableLayoutPanel.Controls.Add(this.categoryComboBox, 1, 2);
            this.idCostTableLayoutPanel.Controls.Add(this.categoryLabel, 0, 2);
            this.idCostTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idCostTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.idCostTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2);
            this.idCostTableLayoutPanel.Name = "idCostTableLayoutPanel";
            this.idCostTableLayoutPanel.RowCount = 3;
            this.idCostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.idCostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.idCostTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.idCostTableLayoutPanel.Size = new System.Drawing.Size(282, 69);
            this.idCostTableLayoutPanel.TabIndex = 2;
            // 
            // costTextBox
            // 
            this.costTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costTextBox.Location = new System.Drawing.Point(58, 25);
            this.costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.costTextBox.MaximumSize = new System.Drawing.Size(114, 22);
            this.costTextBox.MinimumSize = new System.Drawing.Size(38, 4);
            this.costTextBox.Name = "costTextBox";
            this.costTextBox.Size = new System.Drawing.Size(114, 20);
            this.costTextBox.TabIndex = 4;
            this.costTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.costLabel.Location = new System.Drawing.Point(2, 23);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(34, 23);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "Cost:";
            this.costLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idTextBox
            // 
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idTextBox.Location = new System.Drawing.Point(58, 2);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.MaximumSize = new System.Drawing.Size(114, 22);
            this.idTextBox.MinimumSize = new System.Drawing.Size(38, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(114, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Location = new System.Drawing.Point(2, 2);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(22, 21);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(58, 48);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.MaximumSize = new System.Drawing.Size(114, 0);
            this.categoryComboBox.MinimumSize = new System.Drawing.Size(38, 0);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(114, 21);
            this.categoryComboBox.TabIndex = 6;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.categoryLabel.Location = new System.Drawing.Point(2, 48);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(50, 21);
            this.categoryLabel.TabIndex = 7;
            this.categoryLabel.Text = "Category:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(2, 90);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(282, 45);
            this.nameTextBox.TabIndex = 4;
            this.nameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionTextBox.Location = new System.Drawing.Point(2, 155);
            this.descriptionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(282, 152);
            this.descriptionTextBox.TabIndex = 5;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // findAndItemsTableLayoutPanel
            // 
            this.findAndItemsTableLayoutPanel.ColumnCount = 1;
            this.findAndItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.findAndItemsTableLayoutPanel.Controls.Add(this.orderTableLayoutPanel, 0, 2);
            this.findAndItemsTableLayoutPanel.Controls.Add(this.itemsListBox, 0, 1);
            this.findAndItemsTableLayoutPanel.Controls.Add(this.findTableLayoutPanel, 0, 0);
            this.findAndItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findAndItemsTableLayoutPanel.Location = new System.Drawing.Point(0, 16);
            this.findAndItemsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.findAndItemsTableLayoutPanel.Name = "findAndItemsTableLayoutPanel";
            this.findAndItemsTableLayoutPanel.RowCount = 3;
            this.findAndItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.findAndItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.findAndItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.findAndItemsTableLayoutPanel.Size = new System.Drawing.Size(190, 329);
            this.findAndItemsTableLayoutPanel.TabIndex = 5;
            // 
            // orderTableLayoutPanel
            // 
            this.orderTableLayoutPanel.ColumnCount = 2;
            this.orderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.orderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderTableLayoutPanel.Controls.Add(this.OrderByLabel, 0, 0);
            this.orderTableLayoutPanel.Controls.Add(this.organizingProductsComboBox, 1, 0);
            this.orderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTableLayoutPanel.Location = new System.Drawing.Point(0, 304);
            this.orderTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.orderTableLayoutPanel.Name = "orderTableLayoutPanel";
            this.orderTableLayoutPanel.RowCount = 1;
            this.orderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderTableLayoutPanel.Size = new System.Drawing.Size(190, 25);
            this.orderTableLayoutPanel.TabIndex = 4;
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrderByLabel.Location = new System.Drawing.Point(3, 3);
            this.OrderByLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(56, 22);
            this.OrderByLabel.TabIndex = 0;
            this.OrderByLabel.Text = "Order by:";
            // 
            // organizingProductsComboBox
            // 
            this.organizingProductsComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organizingProductsComboBox.FormattingEnabled = true;
            this.organizingProductsComboBox.Location = new System.Drawing.Point(65, 3);
            this.organizingProductsComboBox.Name = "organizingProductsComboBox";
            this.organizingProductsComboBox.Size = new System.Drawing.Size(122, 21);
            this.organizingProductsComboBox.TabIndex = 1;
            this.organizingProductsComboBox.SelectedIndexChanged += new System.EventHandler(this.OrganizingProductsComboBox_SelectedIndexChanged);
            // 
            // itemsListBox
            // 
            this.itemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(2, 29);
            this.itemsListBox.Margin = new System.Windows.Forms.Padding(2);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(186, 273);
            this.itemsListBox.TabIndex = 2;
            this.itemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // findTableLayoutPanel
            // 
            this.findTableLayoutPanel.ColumnCount = 2;
            this.findTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.findTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.findTableLayoutPanel.Controls.Add(this.findLabel, 0, 0);
            this.findTableLayoutPanel.Controls.Add(this.findTextBox, 1, 0);
            this.findTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.findTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.findTableLayoutPanel.Name = "findTableLayoutPanel";
            this.findTableLayoutPanel.RowCount = 1;
            this.findTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.findTableLayoutPanel.Size = new System.Drawing.Size(190, 27);
            this.findTableLayoutPanel.TabIndex = 3;
            // 
            // findLabel
            // 
            this.findLabel.AutoSize = true;
            this.findLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findLabel.Location = new System.Drawing.Point(3, 3);
            this.findLabel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.findLabel.Name = "findLabel";
            this.findLabel.Size = new System.Drawing.Size(34, 24);
            this.findLabel.TabIndex = 0;
            this.findLabel.Text = "Find:";
            // 
            // findTextBox
            // 
            this.findTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.findTextBox.Location = new System.Drawing.Point(43, 3);
            this.findTextBox.Name = "findTextBox";
            this.findTextBox.Size = new System.Drawing.Size(144, 20);
            this.findTextBox.TabIndex = 1;
            this.findTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.itemsTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(480, 390);
            this.itemsTableLayoutPanel.ResumeLayout(false);
            this.itemsTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.selectedItemTableLayoutPanel.ResumeLayout(false);
            this.selectedItemTableLayoutPanel.PerformLayout();
            this.idCostTableLayoutPanel.ResumeLayout(false);
            this.idCostTableLayoutPanel.PerformLayout();
            this.findAndItemsTableLayoutPanel.ResumeLayout(false);
            this.orderTableLayoutPanel.ResumeLayout(false);
            this.orderTableLayoutPanel.PerformLayout();
            this.findTableLayoutPanel.ResumeLayout(false);
            this.findTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label selectedItemLabel;
        private System.Windows.Forms.TableLayoutPanel itemsTableLayoutPanel;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.TableLayoutPanel selectedItemTableLayoutPanel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TableLayoutPanel idCostTableLayoutPanel;
        private System.Windows.Forms.TextBox costTextBox;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TableLayoutPanel findAndItemsTableLayoutPanel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TableLayoutPanel findTableLayoutPanel;
        private System.Windows.Forms.Label findLabel;
        private System.Windows.Forms.TextBox findTextBox;
        private System.Windows.Forms.TableLayoutPanel orderTableLayoutPanel;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.ComboBox organizingProductsComboBox;
    }
}