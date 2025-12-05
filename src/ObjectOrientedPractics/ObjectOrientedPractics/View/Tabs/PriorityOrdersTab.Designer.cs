namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            this.ordersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.priorityOptionsLabel = new System.Windows.Forms.Label();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.clearCartButton = new System.Windows.Forms.Button();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.selectedOrderLabel = new System.Windows.Forms.Label();
            this.selectedOrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.orderItemsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.orderItems = new System.Windows.Forms.Label();
            this.ordeItemsistBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deliveryTimeLabel = new System.Windows.Forms.Label();
            this.deliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.costLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.amountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.ordersTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.selectedOrderTableLayoutPanel.SuspendLayout();
            this.orderItemsTableLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.amountFlowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ordersTableLayoutPanel
            // 
            this.ordersTableLayoutPanel.ColumnCount = 2;
            this.ordersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.ordersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ordersTableLayoutPanel.Controls.Add(this.priorityOptionsLabel, 1, 0);
            this.ordersTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 4);
            this.ordersTableLayoutPanel.Controls.Add(this.selectedOrderLabel, 0, 0);
            this.ordersTableLayoutPanel.Controls.Add(this.selectedOrderTableLayoutPanel, 0, 1);
            this.ordersTableLayoutPanel.Controls.Add(this.addressControl, 0, 2);
            this.ordersTableLayoutPanel.Controls.Add(this.orderItemsTableLayoutPanel, 0, 3);
            this.ordersTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 1);
            this.ordersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ordersTableLayoutPanel.Name = "ordersTableLayoutPanel";
            this.ordersTableLayoutPanel.RowCount = 5;
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.ordersTableLayoutPanel.Size = new System.Drawing.Size(640, 480);
            this.ordersTableLayoutPanel.TabIndex = 1;
            // 
            // priorityOptionsLabel
            // 
            this.priorityOptionsLabel.AutoSize = true;
            this.priorityOptionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priorityOptionsLabel.Location = new System.Drawing.Point(263, 0);
            this.priorityOptionsLabel.Name = "priorityOptionsLabel";
            this.priorityOptionsLabel.Size = new System.Drawing.Size(113, 16);
            this.priorityOptionsLabel.TabIndex = 9;
            this.priorityOptionsLabel.Text = "Priority Options";
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.ordersTableLayoutPanel.SetColumnSpan(this.buttonsTableLayoutPanel, 2);
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buttonsTableLayoutPanel.Controls.Add(this.removeItemButton, 1, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.clearCartButton, 2, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.createOrderButton, 0, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 438);
            this.buttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(634, 40);
            this.buttonsTableLayoutPanel.TabIndex = 7;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(411, 2);
            this.removeItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(107, 36);
            this.removeItemButton.TabIndex = 1;
            this.removeItemButton.Text = "Remove Item";
            this.removeItemButton.UseVisualStyleBackColor = true;
            // 
            // clearCartButton
            // 
            this.clearCartButton.Location = new System.Drawing.Point(524, 2);
            this.clearCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearCartButton.Name = "clearCartButton";
            this.clearCartButton.Size = new System.Drawing.Size(107, 36);
            this.clearCartButton.TabIndex = 2;
            this.clearCartButton.Text = "Clear Cart";
            this.clearCartButton.UseVisualStyleBackColor = true;
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
            // 
            // selectedOrderLabel
            // 
            this.selectedOrderLabel.AutoSize = true;
            this.selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedOrderLabel.Location = new System.Drawing.Point(3, 0);
            this.selectedOrderLabel.Name = "selectedOrderLabel";
            this.selectedOrderLabel.Size = new System.Drawing.Size(112, 16);
            this.selectedOrderLabel.TabIndex = 1;
            this.selectedOrderLabel.Text = "Selected Order";
            // 
            // selectedOrderTableLayoutPanel
            // 
            this.selectedOrderTableLayoutPanel.ColumnCount = 2;
            this.selectedOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.selectedOrderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedOrderTableLayoutPanel.Controls.Add(this.statusComboBox, 1, 2);
            this.selectedOrderTableLayoutPanel.Controls.Add(this.statusLabel, 0, 2);
            this.selectedOrderTableLayoutPanel.Controls.Add(this.createdTextBox, 1, 1);
            this.selectedOrderTableLayoutPanel.Controls.Add(this.createdLabel, 0, 1);
            this.selectedOrderTableLayoutPanel.Controls.Add(this.idTextBox, 1, 0);
            this.selectedOrderTableLayoutPanel.Controls.Add(this.idLabel, 0, 0);
            this.selectedOrderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedOrderTableLayoutPanel.Location = new System.Drawing.Point(3, 23);
            this.selectedOrderTableLayoutPanel.Name = "selectedOrderTableLayoutPanel";
            this.selectedOrderTableLayoutPanel.RowCount = 3;
            this.selectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.selectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.selectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.selectedOrderTableLayoutPanel.Size = new System.Drawing.Size(254, 94);
            this.selectedOrderTableLayoutPanel.TabIndex = 2;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(92, 54);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.MaximumSize = new System.Drawing.Size(151, 0);
            this.statusComboBox.MinimumSize = new System.Drawing.Size(49, 0);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(151, 24);
            this.statusComboBox.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.statusLabel.Location = new System.Drawing.Point(3, 57);
            this.statusLabel.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(47, 16);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Status:";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // createdTextBox
            // 
            this.createdTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createdTextBox.Location = new System.Drawing.Point(92, 28);
            this.createdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createdTextBox.MaximumSize = new System.Drawing.Size(151, 22);
            this.createdTextBox.MinimumSize = new System.Drawing.Size(49, 4);
            this.createdTextBox.Name = "createdTextBox";
            this.createdTextBox.Size = new System.Drawing.Size(151, 22);
            this.createdTextBox.TabIndex = 5;
            // 
            // createdLabel
            // 
            this.createdLabel.AutoSize = true;
            this.createdLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.createdLabel.Location = new System.Drawing.Point(3, 26);
            this.createdLabel.Name = "createdLabel";
            this.createdLabel.Size = new System.Drawing.Size(58, 26);
            this.createdLabel.TabIndex = 4;
            this.createdLabel.Text = "Created:";
            this.createdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idTextBox
            // 
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idTextBox.Location = new System.Drawing.Point(92, 2);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.MaximumSize = new System.Drawing.Size(151, 22);
            this.idTextBox.MinimumSize = new System.Drawing.Size(49, 22);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(151, 22);
            this.idTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Location = new System.Drawing.Point(3, 2);
            this.idLabel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 24);
            this.idLabel.TabIndex = 2;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // addressControl
            // 
            this.ordersTableLayoutPanel.SetColumnSpan(this.addressControl, 2);
            this.addressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl.Location = new System.Drawing.Point(4, 124);
            this.addressControl.Margin = new System.Windows.Forms.Padding(4);
            this.addressControl.Name = "addressControl";
            this.addressControl.ReadOnly = false;
            this.addressControl.Size = new System.Drawing.Size(632, 133);
            this.addressControl.TabIndex = 3;
            // 
            // orderItemsTableLayoutPanel
            // 
            this.orderItemsTableLayoutPanel.ColumnCount = 2;
            this.ordersTableLayoutPanel.SetColumnSpan(this.orderItemsTableLayoutPanel, 2);
            this.orderItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderItemsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.orderItemsTableLayoutPanel.Controls.Add(this.amountFlowLayoutPanel, 1, 2);
            this.orderItemsTableLayoutPanel.Controls.Add(this.orderItems, 0, 0);
            this.orderItemsTableLayoutPanel.Controls.Add(this.ordeItemsistBox, 0, 1);
            this.orderItemsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderItemsTableLayoutPanel.Location = new System.Drawing.Point(3, 264);
            this.orderItemsTableLayoutPanel.Name = "orderItemsTableLayoutPanel";
            this.orderItemsTableLayoutPanel.RowCount = 3;
            this.orderItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.orderItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderItemsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.orderItemsTableLayoutPanel.Size = new System.Drawing.Size(634, 169);
            this.orderItemsTableLayoutPanel.TabIndex = 4;
            // 
            // orderItems
            // 
            this.orderItems.AutoSize = true;
            this.orderItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderItems.Location = new System.Drawing.Point(3, 0);
            this.orderItems.Name = "orderItems";
            this.orderItems.Size = new System.Drawing.Size(87, 16);
            this.orderItems.TabIndex = 1;
            this.orderItems.Text = "Order Items";
            // 
            // ordeItemsistBox
            // 
            this.orderItemsTableLayoutPanel.SetColumnSpan(this.ordeItemsistBox, 2);
            this.ordeItemsistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordeItemsistBox.FormattingEnabled = true;
            this.ordeItemsistBox.ItemHeight = 16;
            this.ordeItemsistBox.Location = new System.Drawing.Point(3, 23);
            this.ordeItemsistBox.Name = "ordeItemsistBox";
            this.ordeItemsistBox.Size = new System.Drawing.Size(628, 98);
            this.ordeItemsistBox.TabIndex = 13;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.deliveryTimeLabel);
            this.flowLayoutPanel1.Controls.Add(this.deliveryTimeComboBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(263, 23);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 94);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // deliveryTimeLabel
            // 
            this.deliveryTimeLabel.AutoSize = true;
            this.deliveryTimeLabel.Location = new System.Drawing.Point(3, 0);
            this.deliveryTimeLabel.Name = "deliveryTimeLabel";
            this.deliveryTimeLabel.Size = new System.Drawing.Size(94, 16);
            this.deliveryTimeLabel.TabIndex = 0;
            this.deliveryTimeLabel.Text = "Delivery Time:";
            // 
            // deliveryTimeComboBox
            // 
            this.deliveryTimeComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryTimeComboBox.FormattingEnabled = true;
            this.deliveryTimeComboBox.Location = new System.Drawing.Point(103, 2);
            this.deliveryTimeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deliveryTimeComboBox.MaximumSize = new System.Drawing.Size(151, 0);
            this.deliveryTimeComboBox.MinimumSize = new System.Drawing.Size(49, 0);
            this.deliveryTimeComboBox.Name = "deliveryTimeComboBox";
            this.deliveryTimeComboBox.Size = new System.Drawing.Size(151, 24);
            this.deliveryTimeComboBox.TabIndex = 8;
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
            // amountFlowLayoutPanel
            // 
            this.amountFlowLayoutPanel.AutoSize = true;
            this.amountFlowLayoutPanel.Controls.Add(this.amountLabel);
            this.amountFlowLayoutPanel.Controls.Add(this.costLabel);
            this.amountFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.amountFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.amountFlowLayoutPanel.Location = new System.Drawing.Point(563, 126);
            this.amountFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountFlowLayoutPanel.Name = "amountFlowLayoutPanel";
            this.amountFlowLayoutPanel.Size = new System.Drawing.Size(68, 41);
            this.amountFlowLayoutPanel.TabIndex = 12;
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ordersTableLayoutPanel);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(640, 480);
            this.ordersTableLayoutPanel.ResumeLayout(false);
            this.ordersTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.selectedOrderTableLayoutPanel.ResumeLayout(false);
            this.selectedOrderTableLayoutPanel.PerformLayout();
            this.orderItemsTableLayoutPanel.ResumeLayout(false);
            this.orderItemsTableLayoutPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.amountFlowLayoutPanel.ResumeLayout(false);
            this.amountFlowLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ordersTableLayoutPanel;
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.TableLayoutPanel selectedOrderTableLayoutPanel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private ObjectOrientedPractics.View.Controls.AddressControl addressControl;
        private System.Windows.Forms.TableLayoutPanel orderItemsTableLayoutPanel;
        private System.Windows.Forms.Label orderItems;
        private System.Windows.Forms.ListBox ordeItemsistBox;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button clearCartButton;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label priorityOptionsLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label deliveryTimeLabel;
        private System.Windows.Forms.ComboBox deliveryTimeComboBox;
        private System.Windows.Forms.FlowLayoutPanel amountFlowLayoutPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label costLabel;
    }
}
