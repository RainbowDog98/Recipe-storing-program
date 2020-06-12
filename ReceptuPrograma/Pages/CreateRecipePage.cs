using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ReceptuPrograma.Pages
{
    public partial class CreateRecipePage : UserControl
    {
        public CreateRecipePage()
        {
            InitializeComponent();

            foreach (var item in DataClass.categories)
            {
                CategoryComboBox.Items.Add(item.Title);
            }

        }
        public delegate void CancelButtonPressed();
        public CancelButtonPressed CancelEvent;

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if(TitleBox.Text == "")
            {
                MessageBox.Show("Būtina įvesti pavadinimą!");
                return;
            }
            if(CategoryComboBox.SelectedIndex == -1 && CustomCategoryBox.Text == "")
            {
                MessageBox.Show("Būtina pasirinkti kategorija!");
                return;
            }


            string path = Directory.GetCurrentDirectory() + "\\Receptai";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            using (var file = new StreamWriter(path + $"\\{TitleBox.Text}.csv"))
            {
                file.Write(string.Format("{0};{1};{2};{3};{4}"
                    ,TitleBox.Text
                    ,CustomCategoryBox.Text == ""? DataClass.categories[CategoryComboBox.SelectedIndex].Title : CustomCategoryBox.Text
                    ,LinkBox.Text
                    ,TagBox.Text
                    ,DescriptionBox.Text));
            }

            CancelEvent?.Invoke();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke();
        }
    }
}
