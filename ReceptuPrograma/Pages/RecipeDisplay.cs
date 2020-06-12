using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceptuPrograma.Pages
{
    public partial class RecipeDisplay : UserControl
    {
        public RecipeDisplay()
        {
            InitializeComponent();
            RecipeList.DoubleClick += RecipeList_DoubleClick;
        }

        private void DoWork()
        {
            MessageBox.Show($"This is a recipe control :) for index {RecipeList.SelectedIndex}");
        }

        private void RecipeList_DoubleClick(object sender, EventArgs e)
        {
            if (RecipeList.SelectedIndex != -1)
                DoWork();

            RecipeList.SelectedIndex = -1;
        }
        public ListBox List
        {
            get { return RecipeList; }
            set { RecipeList = value; }
        }
    }
}
