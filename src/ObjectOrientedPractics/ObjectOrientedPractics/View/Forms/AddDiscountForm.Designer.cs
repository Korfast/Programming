namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.percentDiscountLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // percentDiscountLabel
            // 
            this.percentDiscountLabel.AutoSize = true;
            this.percentDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.percentDiscountLabel.Location = new System.Drawing.Point(12, 9);
            this.percentDiscountLabel.Name = "percentDiscountLabel";
            this.percentDiscountLabel.Size = new System.Drawing.Size(128, 16);
            this.percentDiscountLabel.TabIndex = 0;
            this.percentDiscountLabel.Text = "Percent Discount:";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(12, 39);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(58, 15);
            this.categoryLabel.TabIndex = 1;
            this.categoryLabel.Text = "Category:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(62, 85);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(92, 40);
            this.OkButton.TabIndex = 3;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 85);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(92, 40);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(77, 39);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(175, 21);
            this.categoryComboBox.TabIndex = 5;
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 137);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.percentDiscountLabel);
            this.Name = "AddDiscountForm";
            this.Text = "Add Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label percentDiscountLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox categoryComboBox;
    }
}