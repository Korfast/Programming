namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.cartsTabTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.customerCartTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.customerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customersComboBox = new System.Windows.Forms.ComboBox();
            this.cartsListBox = new System.Windows.Forms.ListBox();
            this.amountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.addToCartButton = new System.Windows.Forms.Button();
            this.cartsTabTableLayoutPanel.SuspendLayout();
            this.customerCartTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.customerTableLayoutPanel.SuspendLayout();
            this.amountFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartsTabTableLayoutPanel
            // 
            this.cartsTabTableLayoutPanel.ColumnCount = 2;
            this.cartsTabTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.cartsTabTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cartsTabTableLayoutPanel.Controls.Add(this.itemsListBox, 0, 1);
            this.cartsTabTableLayoutPanel.Controls.Add(this.itemsLabel, 0, 0);
            this.cartsTabTableLayoutPanel.Controls.Add(this.customerCartTableLayoutPanel, 1, 1);
            this.cartsTabTableLayoutPanel.Controls.Add(this.addToCartButton, 0, 3);
            this.cartsTabTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTabTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.cartsTabTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartsTabTableLayoutPanel.Name = "cartsTabTableLayoutPanel";
            this.cartsTabTableLayoutPanel.RowCount = 4;
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cartsTabTableLayoutPanel.Size = new System.Drawing.Size(640, 480);
            this.cartsTabTableLayoutPanel.TabIndex = 0;
            // 
            // itemsListBox
            // 
            this.itemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 16;
            this.itemsListBox.Location = new System.Drawing.Point(3, 22);
            this.itemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.itemsListBox.Name = "itemsListBox";
            this.cartsTabTableLayoutPanel.SetRowSpan(this.itemsListBox, 2);
            this.itemsListBox.Size = new System.Drawing.Size(245, 418);
            this.itemsListBox.TabIndex = 0;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(3, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(44, 16);
            this.itemsLabel.TabIndex = 1;
            this.itemsLabel.Text = "Items";
            // 
            // customerCartTableLayoutPanel
            // 
            this.customerCartTableLayoutPanel.ColumnCount = 1;
            this.customerCartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerCartTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 4);
            this.customerCartTableLayoutPanel.Controls.Add(this.cartLabel, 0, 1);
            this.customerCartTableLayoutPanel.Controls.Add(this.customerTableLayoutPanel, 0, 0);
            this.customerCartTableLayoutPanel.Controls.Add(this.cartsListBox, 0, 2);
            this.customerCartTableLayoutPanel.Controls.Add(this.amountFlowLayoutPanel, 0, 3);
            this.customerCartTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerCartTableLayoutPanel.Location = new System.Drawing.Point(254, 22);
            this.customerCartTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerCartTableLayoutPanel.Name = "customerCartTableLayoutPanel";
            this.customerCartTableLayoutPanel.RowCount = 6;
            this.cartsTabTableLayoutPanel.SetRowSpan(this.customerCartTableLayoutPanel, 2);
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerCartTableLayoutPanel.Size = new System.Drawing.Size(383, 418);
            this.customerCartTableLayoutPanel.TabIndex = 2;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonsTableLayoutPanel.Controls.Add(this.removeItemButton, 1, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.clearCartButton, 2, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.createOrderButton, 0, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 237);
            this.buttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(377, 41);
            this.buttonsTableLayoutPanel.TabIndex = 4;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(154, 2);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(107, 36);
            this.removeItemButton.TabIndex = 1;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(267, 2);
            this.clearCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(107, 36);
            this.clearCartButton.TabIndex = 2;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            this.clearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(3, 2);
            this.createOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(107, 36);
            this.createOrderButton.TabIndex = 0;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(3, 39);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(34, 16);
            this.cartLabel.TabIndex = 0;
            this.cartLabel.Text = "Cart:";
            // 
            // customerTableLayoutPanel
            // 
            this.customerTableLayoutPanel.ColumnCount = 2;
            this.customerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.customerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerTableLayoutPanel.Controls.Add(this.customerLabel, 0, 0);
            this.customerTableLayoutPanel.Controls.Add(this.customersComboBox, 1, 0);
            this.customerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTableLayoutPanel.Location = new System.Drawing.Point(3, 2);
            this.customerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customerTableLayoutPanel.Name = "customerTableLayoutPanel";
            this.customerTableLayoutPanel.RowCount = 1;
            this.customerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerTableLayoutPanel.Size = new System.Drawing.Size(377, 35);
            this.customerTableLayoutPanel.TabIndex = 1;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(3, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(76, 16);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Customer:";
            // 
            // customersComboBox
            // 
            this.customersComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customersComboBox.FormattingEnabled = true;
            this.customersComboBox.Location = new System.Drawing.Point(85, 2);
            this.customersComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersComboBox.Name = "customersComboBox";
            this.customersComboBox.Size = new System.Drawing.Size(289, 24);
            this.customersComboBox.TabIndex = 3;
            this.customersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // cartsListBox
            // 
            this.cartsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsListBox.FormattingEnabled = true;
            this.cartsListBox.ItemHeight = 16;
            this.cartsListBox.Location = new System.Drawing.Point(3, 57);
            this.cartsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cartsListBox.Name = "cartsListBox";
            this.cartsListBox.Size = new System.Drawing.Size(377, 131);
            this.cartsListBox.TabIndex = 5;
            // 
            // amountFlowLayoutPanel
            // 
            this.amountFlowLayoutPanel.AutoSize = true;
            this.amountFlowLayoutPanel.Controls.Add(this.amountLabel);
            this.amountFlowLayoutPanel.Controls.Add(this.costLabel);
            this.amountFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.amountFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.amountFlowLayoutPanel.Location = new System.Drawing.Point(312, 192);
            this.amountFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountFlowLayoutPanel.Name = "amountFlowLayoutPanel";
            this.amountFlowLayoutPanel.Size = new System.Drawing.Size(68, 41);
            this.amountFlowLayoutPanel.TabIndex = 6;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(3, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(62, 16);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(3, 16);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 25);
            this.costLabel.TabIndex = 1;
            // 
            // addToCartButton
            // 
            this.addToCartButton.Location = new System.Drawing.Point(3, 444);
            this.addToCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addToCartButton.Name = "addToCartButton";
            this.addToCartButton.Size = new System.Drawing.Size(100, 34);
            this.addToCartButton.TabIndex = 3;
            this.addToCartButton.Text = "Add To Cart";
            this.addToCartButton.UseVisualStyleBackColor = true;
            this.addToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartsTabTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(640, 480);
            this.cartsTabTableLayoutPanel.ResumeLayout(false);
            this.cartsTabTableLayoutPanel.PerformLayout();
            this.customerCartTableLayoutPanel.ResumeLayout(false);
            this.customerCartTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.customerTableLayoutPanel.ResumeLayout(false);
            this.customerTableLayoutPanel.PerformLayout();
            this.amountFlowLayoutPanel.ResumeLayout(false);
            this.amountFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel cartsTabTableLayoutPanel;
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.TableLayoutPanel customerCartTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.TableLayoutPanel customerTableLayoutPanel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customersComboBox;
        private System.Windows.Forms.ListBox cartsListBox;
        private System.Windows.Forms.FlowLayoutPanel amountFlowLayoutPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button addToCartButton;
    }
}