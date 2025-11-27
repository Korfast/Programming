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
            this.buttomsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.cartLabel = new System.Windows.Forms.Label();
            this.customerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerComboBox = new System.Windows.Forms.ComboBox();
            this.cartListBox = new System.Windows.Forms.ListBox();
            this.amountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cartsTabTableLayoutPanel.SuspendLayout();
            this.customerCartTableLayoutPanel.SuspendLayout();
            this.buttomsTableLayoutPanel.SuspendLayout();
            this.customerTableLayoutPanel.SuspendLayout();
            this.amountFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // cartsTabTableLayoutPanel
            // 
            this.cartsTabTableLayoutPanel.ColumnCount = 2;
            this.cartsTabTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.cartsTabTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cartsTabTableLayoutPanel.Controls.Add(this.itemsListBox, 0, 1);
            this.cartsTabTableLayoutPanel.Controls.Add(this.itemsLabel, 0, 0);
            this.cartsTabTableLayoutPanel.Controls.Add(this.customerCartTableLayoutPanel, 1, 1);
            this.cartsTabTableLayoutPanel.Controls.Add(this.button1, 0, 3);
            this.cartsTabTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartsTabTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.cartsTabTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartsTabTableLayoutPanel.Name = "cartsTabTableLayoutPanel";
            this.cartsTabTableLayoutPanel.RowCount = 4;
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cartsTabTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.cartsTabTableLayoutPanel.Size = new System.Drawing.Size(480, 390);
            this.cartsTabTableLayoutPanel.TabIndex = 0;
            // 
            // itemsListBox
            // 
            this.itemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(2, 18);
            this.itemsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.itemsListBox.Name = "itemsListBox";
            this.cartsTabTableLayoutPanel.SetRowSpan(this.itemsListBox, 2);
            this.itemsListBox.Size = new System.Drawing.Size(184, 338);
            this.itemsListBox.TabIndex = 0;
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.itemsLabel.Location = new System.Drawing.Point(2, 0);
            this.itemsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(37, 13);
            this.itemsLabel.TabIndex = 1;
            this.itemsLabel.Text = "Items";
            // 
            // customerCartTableLayoutPanel
            // 
            this.customerCartTableLayoutPanel.ColumnCount = 1;
            this.customerCartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerCartTableLayoutPanel.Controls.Add(this.buttomsTableLayoutPanel, 0, 4);
            this.customerCartTableLayoutPanel.Controls.Add(this.cartLabel, 0, 1);
            this.customerCartTableLayoutPanel.Controls.Add(this.customerTableLayoutPanel, 0, 0);
            this.customerCartTableLayoutPanel.Controls.Add(this.cartListBox, 0, 2);
            this.customerCartTableLayoutPanel.Controls.Add(this.amountFlowLayoutPanel, 0, 3);
            this.customerCartTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerCartTableLayoutPanel.Location = new System.Drawing.Point(190, 18);
            this.customerCartTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerCartTableLayoutPanel.Name = "customerCartTableLayoutPanel";
            this.customerCartTableLayoutPanel.RowCount = 6;
            this.cartsTabTableLayoutPanel.SetRowSpan(this.customerCartTableLayoutPanel, 2);
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerCartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerCartTableLayoutPanel.Size = new System.Drawing.Size(288, 338);
            this.customerCartTableLayoutPanel.TabIndex = 2;
            // 
            // buttomsTableLayoutPanel
            // 
            this.buttomsTableLayoutPanel.ColumnCount = 3;
            this.buttomsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttomsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttomsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttomsTableLayoutPanel.Controls.Add(this.removeItemButton, 1, 0);
            this.buttomsTableLayoutPanel.Controls.Add(this.clearCartButton, 2, 0);
            this.buttomsTableLayoutPanel.Controls.Add(this.createOrderButton, 0, 0);
            this.buttomsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttomsTableLayoutPanel.Location = new System.Drawing.Point(2, 194);
            this.buttomsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttomsTableLayoutPanel.Name = "buttomsTableLayoutPanel";
            this.buttomsTableLayoutPanel.RowCount = 1;
            this.buttomsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttomsTableLayoutPanel.Size = new System.Drawing.Size(284, 33);
            this.buttomsTableLayoutPanel.TabIndex = 4;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(128, 2);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(75, 28);
            this.removeItemButton.TabIndex = 1;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(207, 2);
            this.clearCartButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(75, 28);
            this.clearCartButton.TabIndex = 2;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
            // 
            // createOrderButton
            // 
            this.createOrderButton.Location = new System.Drawing.Point(2, 2);
            this.createOrderButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(75, 28);
            this.createOrderButton.TabIndex = 0;
            this.createOrderButton.Text = "Create Order";
            this.createOrderButton.UseVisualStyleBackColor = true;
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Location = new System.Drawing.Point(2, 32);
            this.cartLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(29, 13);
            this.cartLabel.TabIndex = 0;
            this.cartLabel.Text = "Cart:";
            // 
            // customerTableLayoutPanel
            // 
            this.customerTableLayoutPanel.ColumnCount = 2;
            this.customerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.customerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customerTableLayoutPanel.Controls.Add(this.customerLabel, 0, 0);
            this.customerTableLayoutPanel.Controls.Add(this.customerComboBox, 1, 0);
            this.customerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerTableLayoutPanel.Location = new System.Drawing.Point(2, 2);
            this.customerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerTableLayoutPanel.Name = "customerTableLayoutPanel";
            this.customerTableLayoutPanel.RowCount = 1;
            this.customerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.customerTableLayoutPanel.Size = new System.Drawing.Size(284, 28);
            this.customerTableLayoutPanel.TabIndex = 1;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customerLabel.Location = new System.Drawing.Point(2, 0);
            this.customerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(63, 13);
            this.customerLabel.TabIndex = 2;
            this.customerLabel.Text = "Customer:";
            // 
            // customerComboBox
            // 
            this.customerComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerComboBox.FormattingEnabled = true;
            this.customerComboBox.Location = new System.Drawing.Point(69, 2);
            this.customerComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customerComboBox.Name = "customerComboBox";
            this.customerComboBox.Size = new System.Drawing.Size(213, 21);
            this.customerComboBox.TabIndex = 3;
            // 
            // cartListBox
            // 
            this.cartListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartListBox.FormattingEnabled = true;
            this.cartListBox.Location = new System.Drawing.Point(2, 47);
            this.cartListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cartListBox.Name = "cartListBox";
            this.cartListBox.Size = new System.Drawing.Size(284, 106);
            this.cartListBox.TabIndex = 5;
            // 
            // amountFlowLayoutPanel
            // 
            this.amountFlowLayoutPanel.AutoSize = true;
            this.amountFlowLayoutPanel.Controls.Add(this.amountLabel);
            this.amountFlowLayoutPanel.Controls.Add(this.costLabel);
            this.amountFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.amountFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.amountFlowLayoutPanel.Location = new System.Drawing.Point(229, 157);
            this.amountFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.amountFlowLayoutPanel.Name = "amountFlowLayoutPanel";
            this.amountFlowLayoutPanel.Size = new System.Drawing.Size(57, 33);
            this.amountFlowLayoutPanel.TabIndex = 6;
            // 
            // amountLabel
            // 
            this.amountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.amountLabel.Location = new System.Drawing.Point(2, 0);
            this.amountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(53, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Amount:";
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.costLabel.Location = new System.Drawing.Point(2, 13);
            this.costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(0, 20);
            this.costLabel.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(2, 360);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add To Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cartsTabTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(480, 390);
            this.cartsTabTableLayoutPanel.ResumeLayout(false);
            this.cartsTabTableLayoutPanel.PerformLayout();
            this.customerCartTableLayoutPanel.ResumeLayout(false);
            this.customerCartTableLayoutPanel.PerformLayout();
            this.buttomsTableLayoutPanel.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel buttomsTableLayoutPanel;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.TableLayoutPanel customerTableLayoutPanel;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerComboBox;
        private System.Windows.Forms.ListBox cartListBox;
        private System.Windows.Forms.FlowLayoutPanel amountFlowLayoutPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Button button1;
    }
}