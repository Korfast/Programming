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
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.isPriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.buttonsTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.customersLabel = new System.Windows.Forms.Label();
            this.customersListBox = new System.Windows.Forms.ListBox();
            this.selectedCustomerLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.discountsLabel = new System.Windows.Forms.Label();
            this.discountsListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.customersTableLayoutPanel.SuspendLayout();
            this.selectedCustomerTableLayoutPanel.SuspendLayout();
            this.buttonsTableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // customersTableLayoutPanel
            // 
            this.customersTableLayoutPanel.ColumnCount = 2;
            this.customersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251F));
            this.customersTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customersTableLayoutPanel.Controls.Add(this.selectedCustomerTableLayoutPanel, 1, 1);
            this.customersTableLayoutPanel.Controls.Add(this.buttonsTableLayoutPanel, 0, 3);
            this.customersTableLayoutPanel.Controls.Add(this.customersLabel, 0, 0);
            this.customersTableLayoutPanel.Controls.Add(this.customersListBox, 0, 1);
            this.customersTableLayoutPanel.Controls.Add(this.selectedCustomerLabel, 1, 0);
            this.customersTableLayoutPanel.Controls.Add(this.tableLayoutPanel1, 1, 2);
            this.customersTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.customersTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersTableLayoutPanel.Name = "customersTableLayoutPanel";
            this.customersTableLayoutPanel.RowCount = 4;
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 235F));
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.customersTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.customersTableLayoutPanel.Size = new System.Drawing.Size(640, 480);
            this.customersTableLayoutPanel.TabIndex = 1;
            // 
            // selectedCustomerTableLayoutPanel
            // 
            this.selectedCustomerTableLayoutPanel.ColumnCount = 2;
            this.selectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.selectedCustomerTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.addressControl, 0, 3);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.fullNameTextBox, 1, 1);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.fullNameLabel, 0, 1);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.idTextBox, 1, 0);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.idLabel, 0, 0);
            this.selectedCustomerTableLayoutPanel.Controls.Add(this.isPriorityCheckBox, 1, 2);
            this.selectedCustomerTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectedCustomerTableLayoutPanel.Location = new System.Drawing.Point(254, 22);
            this.selectedCustomerTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selectedCustomerTableLayoutPanel.Name = "selectedCustomerTableLayoutPanel";
            this.selectedCustomerTableLayoutPanel.RowCount = 4;
            this.selectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.selectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.selectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.selectedCustomerTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.selectedCustomerTableLayoutPanel.Size = new System.Drawing.Size(383, 231);
            this.selectedCustomerTableLayoutPanel.TabIndex = 8;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.fullNameTextBox.Location = new System.Drawing.Point(96, 30);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullNameTextBox.MaximumSize = new System.Drawing.Size(120, 22);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(120, 22);
            this.fullNameTextBox.TabIndex = 4;
            this.fullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.fullNameLabel.Location = new System.Drawing.Point(3, 28);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(71, 28);
            this.fullNameLabel.TabIndex = 3;
            this.fullNameLabel.Text = "Full Name:";
            this.fullNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // idTextBox
            // 
            this.idTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.idTextBox.Location = new System.Drawing.Point(96, 2);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(120, 22);
            this.idTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.idLabel.Location = new System.Drawing.Point(3, 0);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(23, 28);
            this.idLabel.TabIndex = 1;
            this.idLabel.Text = "ID:";
            this.idLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // isPriorityCheckBox
            // 
            this.isPriorityCheckBox.AutoSize = true;
            this.isPriorityCheckBox.Location = new System.Drawing.Point(96, 58);
            this.isPriorityCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.isPriorityCheckBox.Name = "isPriorityCheckBox";
            this.isPriorityCheckBox.Size = new System.Drawing.Size(83, 20);
            this.isPriorityCheckBox.TabIndex = 7;
            this.isPriorityCheckBox.Text = "Is Priority";
            this.isPriorityCheckBox.UseVisualStyleBackColor = true;
            this.isPriorityCheckBox.CheckedChanged += new System.EventHandler(this.IsPriorityCheckBox_CheckedChanged);
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
            this.buttonsTableLayoutPanel.Location = new System.Drawing.Point(3, 432);
            this.buttonsTableLayoutPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonsTableLayoutPanel.Name = "buttonsTableLayoutPanel";
            this.buttonsTableLayoutPanel.RowCount = 1;
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonsTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.buttonsTableLayoutPanel.Size = new System.Drawing.Size(245, 46);
            this.buttonsTableLayoutPanel.TabIndex = 7;
            // 
            // addButton
            // 
            this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addButton.Location = new System.Drawing.Point(3, 2);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(74, 42);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeButton.Location = new System.Drawing.Point(83, 2);
            this.removeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(74, 42);
            this.removeButton.TabIndex = 1;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // customersLabel
            // 
            this.customersLabel.AutoSize = true;
            this.customersLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.customersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customersLabel.Location = new System.Drawing.Point(3, 0);
            this.customersLabel.Name = "customersLabel";
            this.customersLabel.Size = new System.Drawing.Size(80, 20);
            this.customersLabel.TabIndex = 0;
            this.customersLabel.Text = "Customers";
            // 
            // customersListBox
            // 
            this.customersListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersListBox.FormattingEnabled = true;
            this.customersListBox.ItemHeight = 16;
            this.customersListBox.Location = new System.Drawing.Point(3, 22);
            this.customersListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.customersListBox.Name = "customersListBox";
            this.customersTableLayoutPanel.SetRowSpan(this.customersListBox, 2);
            this.customersListBox.Size = new System.Drawing.Size(245, 406);
            this.customersListBox.TabIndex = 1;
            this.customersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // selectedCustomerLabel
            // 
            this.selectedCustomerLabel.AutoSize = true;
            this.selectedCustomerLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.selectedCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectedCustomerLabel.Location = new System.Drawing.Point(254, 0);
            this.selectedCustomerLabel.Name = "selectedCustomerLabel";
            this.selectedCustomerLabel.Size = new System.Drawing.Size(138, 20);
            this.selectedCustomerLabel.TabIndex = 3;
            this.selectedCustomerLabel.Text = "Selected Customer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.discountsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.discountsListBox, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(254, 258);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(383, 169);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // discountsLabel
            // 
            this.discountsLabel.AutoSize = true;
            this.discountsLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.discountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.discountsLabel.Location = new System.Drawing.Point(3, 0);
            this.discountsLabel.Name = "discountsLabel";
            this.discountsLabel.Size = new System.Drawing.Size(75, 20);
            this.discountsLabel.TabIndex = 4;
            this.discountsLabel.Text = "Discounts";
            // 
            // discountsListBox
            // 
            this.discountsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.discountsListBox.FormattingEnabled = true;
            this.discountsListBox.ItemHeight = 16;
            this.discountsListBox.Location = new System.Drawing.Point(3, 23);
            this.discountsListBox.Name = "discountsListBox";
            this.discountsListBox.Size = new System.Drawing.Size(223, 143);
            this.discountsListBox.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.button3, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(232, 22);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(148, 145);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 2);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 42);
            this.button3.TabIndex = 0;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addressControl
            // 
            this.selectedCustomerTableLayoutPanel.SetColumnSpan(this.addressControl, 2);
            this.addressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addressControl.Location = new System.Drawing.Point(5, 89);
            this.addressControl.Margin = new System.Windows.Forms.Padding(5);
            this.addressControl.Name = "addressControl";
            this.addressControl.ReadOnly = false;
            this.addressControl.Size = new System.Drawing.Size(373, 137);
            this.addressControl.TabIndex = 6;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customersTableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(640, 480);
            this.customersTableLayoutPanel.ResumeLayout(false);
            this.customersTableLayoutPanel.PerformLayout();
            this.selectedCustomerTableLayoutPanel.ResumeLayout(false);
            this.selectedCustomerTableLayoutPanel.PerformLayout();
            this.buttonsTableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel customersTableLayoutPanel;
        private System.Windows.Forms.Label customersLabel;
        private System.Windows.Forms.ListBox customersListBox;
        private System.Windows.Forms.Label selectedCustomerLabel;
        private System.Windows.Forms.TableLayoutPanel selectedCustomerTableLayoutPanel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TableLayoutPanel buttonsTableLayoutPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private Controls.AddressControl addressControl;
        private System.Windows.Forms.CheckBox isPriorityCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label discountsLabel;
        private System.Windows.Forms.ListBox discountsListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}