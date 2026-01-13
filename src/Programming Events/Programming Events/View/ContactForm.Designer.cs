namespace Programming_Events.View
{
    partial class ContactForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneLabel = new System.Windows.Forms.Label();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.Location = new System.Drawing.Point(15, 15);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(100, 23);
            this.FullNameLabel.TabIndex = 0;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(12, 41);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(285, 20);
            this.FullNameTextBox.TabIndex = 1;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // PhoneLabel
            // 
            this.PhoneLabel.Location = new System.Drawing.Point(15, 64);
            this.PhoneLabel.Name = "PhoneLabel";
            this.PhoneLabel.Size = new System.Drawing.Size(79, 23);
            this.PhoneLabel.TabIndex = 2;
            this.PhoneLabel.Text = "Phone:";
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.Location = new System.Drawing.Point(12, 90);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(285, 20);
            this.PhoneTextBox.TabIndex = 3;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // AddressLabel
            // 
            this.AddressLabel.Location = new System.Drawing.Point(15, 119);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(100, 23);
            this.AddressLabel.TabIndex = 4;
            this.AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(12, 145);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(285, 20);
            this.AddressTextBox.TabIndex = 5;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(215, 183);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(80, 30);
            this.CloseButton.TabIndex = 6;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ContactForm
            // 
            this.ClientSize = new System.Drawing.Size(312, 223);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.FullNameLabel);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.PhoneLabel);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AddressTextBox);
            this.Name = "ContactForm";
            this.Text = "Main Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected System.Windows.Forms.Label FullNameLabel;
        protected System.Windows.Forms.TextBox FullNameTextBox;
        protected System.Windows.Forms.Label PhoneLabel;
        protected System.Windows.Forms.TextBox PhoneTextBox;
        protected System.Windows.Forms.Label AddressLabel;
        protected System.Windows.Forms.TextBox AddressTextBox;
        protected System.Windows.Forms.Button CloseButton;
    }
}

