using MoviesApp.View.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesApp.View
{
    public partial class MainMoviesForm : Form
    {
        public MainMoviesForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // сохраняем перед закрытием формы
            MainMoviesUserControl.SaveData(); 
        }
    }
}
