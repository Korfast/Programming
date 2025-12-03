namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.selectedOrderLabel = new System.Windows.Forms.Label();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.selectedOrderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.createdTextBox = new System.Windows.Forms.TextBox();
            this.createdLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.orderTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.amountFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.amountLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.orderItems = new System.Windows.Forms.Label();
            this.ordeItemsistBox = new System.Windows.Forms.ListBox();
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.ordersTableLayoutPanel.SuspendLayout();
            this.selectedOrderTableLayoutPanel.SuspendLayout();
            this.orderTableLayoutPanel.SuspendLayout();
            this.amountFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersTableLayoutPanel
            // 
            this.ordersTableLayoutPanel.ColumnCount = 2;
            this.ordersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ordersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ordersTableLayoutPanel.Controls.Add(this.selectedOrderLabel, 1, 0);
            this.ordersTableLayoutPanel.Controls.Add(this.ordersLabel, 0, 0);
            this.ordersTableLayoutPanel.Controls.Add(this.selectedOrderTableLayoutPanel, 1, 1);
            this.ordersTableLayoutPanel.Controls.Add(this.addressControl, 1, 2);
            this.ordersTableLayoutPanel.Controls.Add(this.orderTableLayoutPanel, 1, 3);
            this.ordersTableLayoutPanel.Controls.Add(this.ordersDataGridView, 0, 1);
            this.ordersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ordersTableLayoutPanel.Name = "ordersTableLayoutPanel";
            this.ordersTableLayoutPanel.RowCount = 4;
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.ordersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ordersTableLayoutPanel.Size = new System.Drawing.Size(640, 480);
            this.ordersTableLayoutPanel.TabIndex = 0;
            // 
            // selectedOrderLabel
            // 
            this.selectedOrderLabel.AutoSize = true;
            this.selectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedOrderLabel.Location = new System.Drawing.Point(323, 0);
            this.selectedOrderLabel.Name = "selectedOrderLabel";
            this.selectedOrderLabel.Size = new System.Drawing.Size(112, 16);
            this.selectedOrderLabel.TabIndex = 1;
            this.selectedOrderLabel.Text = "Selected Order";
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersLabel.Location = new System.Drawing.Point(3, 0);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(54, 16);
            this.ordersLabel.TabIndex = 0;
            this.ordersLabel.Text = "Orders";
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
            this.selectedOrderTableLayoutPanel.Location = new System.Drawing.Point(323, 23);
            this.selectedOrderTableLayoutPanel.Name = "selectedOrderTableLayoutPanel";
            this.selectedOrderTableLayoutPanel.RowCount = 3;
            this.selectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.selectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.selectedOrderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.selectedOrderTableLayoutPanel.Size = new System.Drawing.Size(314, 94);
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
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
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
            // orderTableLayoutPanel
            // 
            this.orderTableLayoutPanel.ColumnCount = 2;
            this.orderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.orderTableLayoutPanel.Controls.Add(this.amountFlowLayoutPanel, 1, 2);
            this.orderTableLayoutPanel.Controls.Add(this.orderItems, 0, 0);
            this.orderTableLayoutPanel.Controls.Add(this.ordeItemsistBox, 0, 1);
            this.orderTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderTableLayoutPanel.Location = new System.Drawing.Point(323, 264);
            this.orderTableLayoutPanel.Name = "orderTableLayoutPanel";
            this.orderTableLayoutPanel.RowCount = 4;
            this.orderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.orderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.orderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.orderTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.orderTableLayoutPanel.Size = new System.Drawing.Size(314, 213);
            this.orderTableLayoutPanel.TabIndex = 4;
            // 
            // amountFlowLayoutPanel
            // 
            this.amountFlowLayoutPanel.AutoSize = true;
            this.amountFlowLayoutPanel.Controls.Add(this.amountLabel);
            this.amountFlowLayoutPanel.Controls.Add(this.costLabel);
            this.amountFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.amountFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.amountFlowLayoutPanel.Location = new System.Drawing.Point(243, 182);
            this.amountFlowLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.amountFlowLayoutPanel.Name = "amountFlowLayoutPanel";
            this.amountFlowLayoutPanel.Size = new System.Drawing.Size(68, 41);
            this.amountFlowLayoutPanel.TabIndex = 12;
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
            this.orderTableLayoutPanel.SetColumnSpan(this.ordeItemsistBox, 2);
            this.ordeItemsistBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordeItemsistBox.FormattingEnabled = true;
            this.ordeItemsistBox.ItemHeight = 16;
            this.ordeItemsistBox.Location = new System.Drawing.Point(3, 23);
            this.ordeItemsistBox.Name = "ordeItemsistBox";
            this.ordeItemsistBox.Size = new System.Drawing.Size(308, 154);
            this.ordeItemsistBox.TabIndex = 13;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersDataGridView.Location = new System.Drawing.Point(3, 23);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersTableLayoutPanel.SetRowSpan(this.ordersDataGridView, 3);
            this.ordersDataGridView.RowTemplate.Height = 24;
            this.ordersDataGridView.Size = new System.Drawing.Size(314, 454);
            this.ordersDataGridView.TabIndex = 5;
            this.ordersDataGridView.SelectionChanged += new System.EventHandler(this.ordersDataGridView_SelectionChanged);
            // 
            // addressControl
            // 
            this.addressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl.Location = new System.Drawing.Point(324, 124);
            this.addressControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressControl.Name = "addressControl";
            this.addressControl.Size = new System.Drawing.Size(312, 133);
            this.addressControl.TabIndex = 3;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ordersTableLayoutPanel);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(640, 480);
            this.ordersTableLayoutPanel.ResumeLayout(false);
            this.ordersTableLayoutPanel.PerformLayout();
            this.selectedOrderTableLayoutPanel.ResumeLayout(false);
            this.selectedOrderTableLayoutPanel.PerformLayout();
            this.orderTableLayoutPanel.ResumeLayout(false);
            this.orderTableLayoutPanel.PerformLayout();
            this.amountFlowLayoutPanel.ResumeLayout(false);
            this.amountFlowLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel ordersTableLayoutPanel;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.Label selectedOrderLabel;
        private System.Windows.Forms.TableLayoutPanel selectedOrderTableLayoutPanel;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label createdLabel;
        private System.Windows.Forms.TextBox createdTextBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ComboBox statusComboBox;
        private ObjectOrientedPractics.View.Controls.AddressControl addressControl;
        private System.Windows.Forms.TableLayoutPanel orderTableLayoutPanel;
        private System.Windows.Forms.Label orderItems;
        private System.Windows.Forms.FlowLayoutPanel amountFlowLayoutPanel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.ListBox ordeItemsistBox;
        private System.Windows.Forms.DataGridView ordersDataGridView;
    }
}
