using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptuPrograma
{
    public partial class AboutPage : UserControl
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private void AboutPage_Load(object sender, EventArgs e)
        {
            AboutLabel.Text = "Pragrama parašyta naudojant Windows Forms \nAutorius: Paulius Ložys \n2020 metai";
        }

        private void AboutLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
