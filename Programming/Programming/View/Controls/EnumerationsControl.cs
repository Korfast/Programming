using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
            InitializeEnumsList();
        }

        private void InitializeEnumsList()
        {
            var enumTypes = Assembly.GetExecutingAssembly().GetTypes().Where
                (type => type.IsEnum && type.Namespace == "Programming.Model").ToList();

            EnumsListBox.DataSource = enumTypes;
            EnumsListBox.DisplayMember = "Name";

            if (EnumsListBox.Items.Count > 0)
            {
                EnumsListBox.SelectedIndex = 0;
                UpdateValuesListBox();
            }
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateValuesListBox();
        }

        private void UpdateValuesListBox()
        {

            if (EnumsListBox.SelectedItem != null)
            {
                Type selectedType = ((Type)EnumsListBox.SelectedItem);
                Array values = Enum.GetValues(selectedType);
                ValuesListBox.DataSource = values;
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ValuesListBox.SelectedItem is Enum selectedValue)
            {
                ValueTextBox.Text = Convert.ToInt32(selectedValue).ToString();
            }
        }
    }
}
