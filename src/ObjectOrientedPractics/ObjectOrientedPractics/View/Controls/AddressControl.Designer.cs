namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.deliveryAddressTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.buildingApartmentTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.apartmentTextBox = new System.Windows.Forms.TextBox();
            this.apartmentLabel = new System.Windows.Forms.Label();
            this.buildingTextBox = new System.Windows.Forms.TextBox();
            this.countryTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postIndexLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.streetLabel = new System.Windows.Forms.Label();
            this.buildingLabel = new System.Windows.Forms.Label();
            this.deliveryAddressLabel = new System.Windows.Forms.Label();
            this.postIndexTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.deliveryAddressTableLayoutPanel.SuspendLayout();
            this.buildingApartmentTableLayoutPanel.SuspendLayout();
            this.countryTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // deliveryAddressTableLayoutPanel
            // 
            this.deliveryAddressTableLayoutPanel.ColumnCount = 2;
            this.deliveryAddressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.deliveryAddressTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.buildingApartmentTableLayoutPanel, 1, 4);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.countryTableLayoutPanel, 1, 2);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.countryLabel, 0, 2);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.streetLabel, 0, 3);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.buildingLabel, 0, 4);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.deliveryAddressLabel, 0, 0);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.postIndexTextBox, 1, 1);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.streetTextBox, 1, 3);
            this.deliveryAddressTableLayoutPanel.Controls.Add(this.postIndexLabel, 0, 1);
            this.deliveryAddressTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deliveryAddressTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.deliveryAddressTableLayoutPanel.Name = "deliveryAddressTableLayoutPanel";
            this.deliveryAddressTableLayoutPanel.RowCount = 5;
            this.deliveryAddressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.deliveryAddressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.deliveryAddressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.deliveryAddressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.deliveryAddressTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.deliveryAddressTableLayoutPanel.Size = new System.Drawing.Size(404, 108);
            this.deliveryAddressTableLayoutPanel.TabIndex = 0;
            // 
            // buildingApartmentTableLayoutPanel
            // 
            this.buildingApartmentTableLayoutPanel.ColumnCount = 3;
            this.buildingApartmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buildingApartmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.buildingApartmentTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.buildingApartmentTableLayoutPanel.Controls.Add(this.apartmentTextBox, 2, 0);
            this.buildingApartmentTableLayoutPanel.Controls.Add(this.apartmentLabel, 1, 0);
            this.buildingApartmentTableLayoutPanel.Controls.Add(this.buildingTextBox, 0, 0);
            this.buildingApartmentTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buildingApartmentTableLayoutPanel.Location = new System.Drawing.Point(73, 85);
            this.buildingApartmentTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.buildingApartmentTableLayoutPanel.Name = "buildingApartmentTableLayoutPanel";
            this.buildingApartmentTableLayoutPanel.RowCount = 1;
            this.buildingApartmentTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buildingApartmentTableLayoutPanel.Size = new System.Drawing.Size(331, 23);
            this.buildingApartmentTableLayoutPanel.TabIndex = 12;
            // 
            // apartmentTextBox
            // 
            this.apartmentTextBox.Location = new System.Drawing.Point(151, 3);
            this.apartmentTextBox.MaximumSize = new System.Drawing.Size(70, 20);
            this.apartmentTextBox.MaxLength = 10;
            this.apartmentTextBox.Name = "apartmentTextBox";
            this.apartmentTextBox.Size = new System.Drawing.Size(70, 20);
            this.apartmentTextBox.TabIndex = 3;
            this.apartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // apartmentLabel
            // 
            this.apartmentLabel.AutoSize = true;
            this.apartmentLabel.Location = new System.Drawing.Point(79, 0);
            this.apartmentLabel.Name = "apartmentLabel";
            this.apartmentLabel.Size = new System.Drawing.Size(66, 15);
            this.apartmentLabel.TabIndex = 2;
            this.apartmentLabel.Text = "Apartment:";
            this.apartmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buildingTextBox
            // 
            this.buildingTextBox.Location = new System.Drawing.Point(3, 3);
            this.buildingTextBox.MaxLength = 10;
            this.buildingTextBox.MinimumSize = new System.Drawing.Size(70, 20);
            this.buildingTextBox.Name = "buildingTextBox";
            this.buildingTextBox.Size = new System.Drawing.Size(70, 20);
            this.buildingTextBox.TabIndex = 1;
            this.buildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // countryTableLayoutPanel
            // 
            this.countryTableLayoutPanel.ColumnCount = 3;
            this.countryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.countryTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.countryTableLayoutPanel.Controls.Add(this.cityTextBox, 2, 0);
            this.countryTableLayoutPanel.Controls.Add(this.cityLabel, 1, 0);
            this.countryTableLayoutPanel.Controls.Add(this.countryTextBox, 0, 0);
            this.countryTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countryTableLayoutPanel.Location = new System.Drawing.Point(73, 39);
            this.countryTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.countryTableLayoutPanel.Name = "countryTableLayoutPanel";
            this.countryTableLayoutPanel.RowCount = 1;
            this.countryTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countryTableLayoutPanel.Size = new System.Drawing.Size(331, 23);
            this.countryTableLayoutPanel.TabIndex = 10;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cityTextBox.Location = new System.Drawing.Point(188, 3);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.MinimumSize = new System.Drawing.Size(50, 20);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(140, 20);
            this.cityTextBox.TabIndex = 2;
            this.cityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(148, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(29, 15);
            this.cityLabel.TabIndex = 1;
            this.cityLabel.Text = "City:";
            this.cityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countryTextBox
            // 
            this.countryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countryTextBox.Location = new System.Drawing.Point(3, 3);
            this.countryTextBox.MaxLength = 50;
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(139, 20);
            this.countryTextBox.TabIndex = 0;
            this.countryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // postIndexLabel
            // 
            this.postIndexLabel.AutoSize = true;
            this.postIndexLabel.Location = new System.Drawing.Point(3, 16);
            this.postIndexLabel.Name = "postIndexLabel";
            this.postIndexLabel.Size = new System.Drawing.Size(67, 15);
            this.postIndexLabel.TabIndex = 1;
            this.postIndexLabel.Text = "Post Index:";
            this.postIndexLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Location = new System.Drawing.Point(3, 39);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(51, 15);
            this.countryLabel.TabIndex = 2;
            this.countryLabel.Text = "Country:";
            this.countryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(3, 62);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(42, 15);
            this.streetLabel.TabIndex = 3;
            this.streetLabel.Text = "Street:";
            this.streetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buildingLabel
            // 
            this.buildingLabel.AutoSize = true;
            this.buildingLabel.Location = new System.Drawing.Point(3, 85);
            this.buildingLabel.Name = "buildingLabel";
            this.buildingLabel.Size = new System.Drawing.Size(55, 15);
            this.buildingLabel.TabIndex = 4;
            this.buildingLabel.Text = "Building:";
            this.buildingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // deliveryAddressLabel
            // 
            this.deliveryAddressLabel.AutoSize = true;
            this.deliveryAddressTableLayoutPanel.SetColumnSpan(this.deliveryAddressLabel, 2);
            this.deliveryAddressLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.deliveryAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deliveryAddressLabel.Location = new System.Drawing.Point(3, 0);
            this.deliveryAddressLabel.Name = "deliveryAddressLabel";
            this.deliveryAddressLabel.Size = new System.Drawing.Size(131, 16);
            this.deliveryAddressLabel.TabIndex = 0;
            this.deliveryAddressLabel.Text = "Delivery Address";
            // 
            // postIndexTextBox
            // 
            this.postIndexTextBox.Location = new System.Drawing.Point(76, 19);
            this.postIndexTextBox.MaximumSize = new System.Drawing.Size(45, 20);
            this.postIndexTextBox.MaxLength = 6;
            this.postIndexTextBox.Name = "postIndexTextBox";
            this.postIndexTextBox.Size = new System.Drawing.Size(45, 20);
            this.postIndexTextBox.TabIndex = 5;
            this.postIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // streetTextBox
            // 
            this.streetTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.streetTextBox.Location = new System.Drawing.Point(76, 65);
            this.streetTextBox.MaxLength = 100;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(325, 20);
            this.streetTextBox.TabIndex = 9;
            this.streetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deliveryAddressTableLayoutPanel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(404, 108);
            this.deliveryAddressTableLayoutPanel.ResumeLayout(false);
            this.deliveryAddressTableLayoutPanel.PerformLayout();
            this.buildingApartmentTableLayoutPanel.ResumeLayout(false);
            this.buildingApartmentTableLayoutPanel.PerformLayout();
            this.countryTableLayoutPanel.ResumeLayout(false);
            this.countryTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion



        private System.Windows.Forms.TableLayoutPanel deliveryAddressTableLayoutPanel;
        private System.Windows.Forms.Label deliveryAddressLabel;
        private System.Windows.Forms.Label postIndexLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.Label buildingLabel;
        private System.Windows.Forms.TextBox postIndexTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.TableLayoutPanel countryTableLayoutPanel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TableLayoutPanel buildingApartmentTableLayoutPanel;
        private System.Windows.Forms.TextBox apartmentTextBox;
        private System.Windows.Forms.Label apartmentLabel;
        private System.Windows.Forms.TextBox buildingTextBox;
    }
}