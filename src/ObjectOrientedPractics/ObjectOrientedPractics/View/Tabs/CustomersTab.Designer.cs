namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            this.customersTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.selectedCustomerTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.selectedCustomerPanel = new System.Windows.Forms.Panel();
            this.customersTableLayoutPanel.SuspendLayout();
            this.selectedCustomerTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersTableLayoutPanel
            // 
            this.customersTableLayoutPanel.ColumnCount = 2;
            this.customersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 188F));
            this.customersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customersTableLayoutPanel.Controls.Add(this.selectedCustomerTableLayoutPanel, 1, 1);
            this.customersTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 3);
            this.customersTableLayoutPanel.Controls.Add(this.customersLabel, 0, 0);
            this.customersTableLayoutPanel.Controls.Add(this.customersListBox, 0, 1);
            this.customersTableLayoutPanel.Controls.Add(this.selectedCustomerLabel, 1, 0);
            this.customersTableLayoutPanel.Controls.Add(this.selectedCustomerPanel, 1, 2);
            this.customersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.customersTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customersTableLayoutPanel.Name = "customersTableLayoutPanel";
            this.customersTableLayoutPanel.RowCount = 4;
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.customersTableLayoutPanel.Size = new System.Drawing.Size(480, 390);
            this.customersTableLayoutPanel.TabIndex = 1;
            // 
            // selectedCustomerTableLayoutPanel
            // 
            this.selectedCustomerTableLayoutPanel.ColumnCount = 2;
            this.selectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.selectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.addressTextBox, 1, 2);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.addressLabel, 0, 2);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.fullNameTextBox, 1, 1);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.fullNameLabel, 0, 1);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.idTextBox, 1, 0);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.idLabel, 0, 0);
            this.selectedCustomerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCustomerTableLayoutPanel.Location = new System.Drawing.Point(190, 18);
            this.selectedCustomerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedCustomerTableLayoutPanel.Name = "selectedCustomerTableLayoutPanel";
            this.selectedCustomerTableLayoutPanel.RowCount = 3;
            this.selectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.selectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.selectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedCustomerTableLayoutPanel.Size = new System.Drawing.Size(288, 94);
            this.selectedCustomerTableLayoutPanel.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressTextBox.Location = new System.Drawing.Point(62, 48);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(224, 44);
            this.addressTextBox.TabIndex = 6;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.addressLabel.Location = new System.Drawing.Point(2, 46);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(56, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address:";
            this.addressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.fullNameTextBox.Location = new System.Drawing.Point(62, 25);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fullNameTextBox.MaximumSize = new System.Drawing.Size(91, 22);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(91, 20);
            this.fullNameTextBox.TabIndex = 4;
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fullNameLabel.Location = new System.Drawing.Point(2, 23);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(38, 23);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "Full Name:";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idTextBox
            // 
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.idTextBox.Location = new System.Drawing.Point(62, 2);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(91, 20);
            this.idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Location = new System.Drawing.Point(2, 0);
            this.idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 23);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonsTableLayoutPanel
            // 
            this.buttonsTableLayoutPanel.ColumnCount = 3;
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.buttonsTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.buttonsTableLayoutPanel.Controls.Add(this.addButton, 0, 0);
            this.buttonsTableLayoutPanel.Controls.Add(this.removeButton, 1, 0);
            this.buttonsTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(2, 351);
            this.buttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(184, 37);
            this.buttonsTableLayoutPanel.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(2, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(56, 33);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(62, 2);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(56, 33);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersLabel.Location = new System.Drawing.Point(2, 0);
            this.customersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(65, 16);
            this.customersLabel.TabIndex = 0;
            this.customersLabel.Text = "Customers";
            // 
            // customersListBox
            // 
            this.customersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.Location = new System.Drawing.Point(2, 18);
            this.customersListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.customersListBox.Name = "customersListBox";
            this.customersTableLayoutPanel.SetRowSpan(this.customersListBox, 2);
            this.customersListBox.Size = new System.Drawing.Size(184, 329);
            this.customersListBox.TabIndex = 1;
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(190, 0);
            this.selectedCustomerLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(113, 16);
            this.selectedCustomerLabel.TabIndex = 3;
            this.selectedCustomerLabel.Text = "Selected Customer";
            // 
            // selectedCustomerPanel
            // 
            this.selectedCustomerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCustomerPanel.Location = new System.Drawing.Point(190, 116);
            this.selectedCustomerPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectedCustomerPanel.Name = "selectedCustomerPanel";
            this.customersTableLayoutPanel.SetRowSpan(this.selectedCustomerPanel, 2);
            this.selectedCustomerPanel.Size = new System.Drawing.Size(288, 272);
            this.selectedCustomerPanel.TabIndex = 9;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customersTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(480, 390);
            this.customersTableLayoutPanel.ResumeLayout(false);
            this.customersTableLayoutPanel.PerformLayout();
            this.selectedCustomerTableLayoutPanel.ResumeLayout(false);
            this.selectedCustomerTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customersTableLayoutPanel;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.TableLayoutPanel selectedCustomerTableLayoutPanel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Panel selectedCustomerPanel;
    }
}
