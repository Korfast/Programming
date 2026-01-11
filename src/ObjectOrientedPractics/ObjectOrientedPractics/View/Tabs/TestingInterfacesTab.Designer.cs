namespace ObjectOrientedPractics.View.Tabs
{
    partial class TestingInterfacesTab
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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.equalsButton = new System.Windows.Forms.Button();
            this.cloneButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.secondAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.firstAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(13, 191);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(215, 134);
            this.itemsListBox.TabIndex = 0;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(13, 329);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(103, 26);
            this.sortButton.TabIndex = 1;
            this.sortButton.Text = "Sort Items";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // equalsButton
            // 
            this.equalsButton.Location = new System.Drawing.Point(104, 146);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(86, 26);
            this.equalsButton.TabIndex = 2;
            this.equalsButton.Text = "Equals Address";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // cloneButton
            // 
            this.cloneButton.Location = new System.Drawing.Point(13, 146);
            this.cloneButton.Name = "cloneButton";
            this.cloneButton.Size = new System.Drawing.Size(86, 26);
            this.cloneButton.TabIndex = 3;
            this.cloneButton.Text = "Clone Address";
            this.cloneButton.UseVisualStyleBackColor = true;
            this.cloneButton.Click += new System.EventHandler(this.CloneButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.resultLabel.Location = new System.Drawing.Point(195, 153);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(57, 20);
            this.resultLabel.TabIndex = 4;
            this.resultLabel.Text = "Result:";
            // 
            // secondAddressControl
            // 
            this.secondAddressControl.Location = new System.Drawing.Point(306, 3);
            this.secondAddressControl.Name = "secondAddressControl";
            this.secondAddressControl.ReadOnly = false;
            this.secondAddressControl.Size = new System.Drawing.Size(298, 116);
            this.secondAddressControl.TabIndex = 6;
            // 
            // firstAddressControl
            // 
            this.firstAddressControl.Location = new System.Drawing.Point(3, 3);
            this.firstAddressControl.Name = "firstAddressControl";
            this.firstAddressControl.ReadOnly = false;
            this.firstAddressControl.Size = new System.Drawing.Size(297, 116);
            this.firstAddressControl.TabIndex = 5;
            // 
            // TestingInterfacesTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.secondAddressControl);
            this.Controls.Add(this.firstAddressControl);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.cloneButton);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.itemsListBox);
            this.Name = "TestingInterfacesTab";
            this.Size = new System.Drawing.Size(673, 390);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Объявления полей
        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.Button cloneButton;
        private System.Windows.Forms.Label resultLabel;
        private ObjectOrientedPractics.View.Controls.AddressControl firstAddressControl;
        private ObjectOrientedPractics.View.Controls.AddressControl secondAddressControl;
    }
}