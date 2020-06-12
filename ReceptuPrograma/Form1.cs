using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReceptuPrograma.Pages;

namespace ReceptuPrograma
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        private RecipeDisplay allRecipeDisplay; // Displays all avaliable recipies
        private RecipeDisplay categoryDisplay; // Display recipies from a category
        private AboutPage about;
  

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileReader f = new FileReader();
            allRecipeDisplay = new RecipeDisplay();
            categoryDisplay = new RecipeDisplay();
            about = new AboutPage();

            allRecipeDisplay.List.Click += AllRecipeList_Click;

           
            Task loadItems = new Task(() =>
            {
                f.ReadFiles();

                foreach (var item in DataClass.recipes)
                {
                    allRecipeDisplay.List.Items.Add(item.ToString());
                }
                foreach (var item in DataClass.categories)
                {
                    categoryDisplay.List.Items.Add(string.Format("[{1}] {0}", item.Title, item.Count));
                }

            });
            loadItems.Start();

            BackBtn.Enabled = false;
            ForwardsBtn.Enabled = false;
            HomeBtn.Enabled = false;

            AddBtn.Enabled = false;
            RemoveBtn.Enabled = false;
            EditBtn.Enabled = false;

        }

       

        #region Side panel buttons
        private void AllRecepiesBtn_Click(object sender, EventArgs e)
        {
            DisableControl(Control.All);
            MainPanel.Controls.Clear();
            allRecipeDisplay.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(allRecipeDisplay);

            AllRecepiesBtn.Enabled = false;
            CategoryBtn.Enabled = true;
            AboutBtn.Enabled = true;
            EnableControl(Control.Add);
            EnableControl(Control.SearchBar);
        }
        private void CategoryBtn_Click(object sender, EventArgs e)
        {
            DisableControl(Control.All);
            MainPanel.Controls.Clear();
            categoryDisplay.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(categoryDisplay);

            AllRecepiesBtn.Enabled = true;
            CategoryBtn.Enabled = false;
            AboutBtn.Enabled = true;

            EnableControl(Control.SearchBar);
        }
        private void AboutBtn_Click(object sender, EventArgs e)
        {
            DisableControl(Control.All);
            MainPanel.Controls.Clear();
            about.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(about);

            AllRecepiesBtn.Enabled = true;
            CategoryBtn.Enabled = true;
            AboutBtn.Enabled = false;
        }
        #endregion


        #region Control panel buttons
        private void BackBtn_Click(object sender, EventArgs e)
        {

        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {

        }
        private void ForwardsBtn_Click(object sender, EventArgs e)
        {

        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            DisableControl(Control.All);
            if(AboutBtn.Enabled && CategoryBtn.Enabled) // AllRecipes tab
            {
                DataClass.lastUsedControl = MainPanel.Controls[0];
                MainPanel.Controls.Clear();

                CreateRecipePage createPage = new CreateRecipePage();
                createPage.Dock = DockStyle.Fill;
                createPage.CancelEvent += CancelEvent;
                MainPanel.Controls.Add(createPage);
            }
/*            else if (AboutBtn.Enabled && AllRecepiesBtn.Enabled) // AllRecipes tab
            {

            }*/
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Control buttons

        enum Control
        {
            All,
            EditButtons,
            NavigationButtons,
            Back,
            Forwards,
            Home,
            SearchBar,
            Add,
            Remove,
            Edit
        }
        private void AllRecipeList_Click(object sender, EventArgs e)
        {
            if (allRecipeDisplay.List.SelectedIndex != -1)
            {
                EnableControl(Control.EditButtons);
            }
            else
            {
                DisableControl(Control.Remove);
                DisableControl(Control.Edit);
            }
        }
        private void DisableControl(Control control)
        {
            switch (control)
            {
                case Control.All:
                    BackBtn.Enabled = false;
                    HomeBtn.Enabled = false;
                    ForwardsBtn.Enabled = false;
                    SearchBox.Enabled = false;
                    AddBtn.Enabled = false;
                    RemoveBtn.Enabled = false;
                    EditBtn.Enabled = false;
                    break;
                case Control.Back:
                    BackBtn.Enabled = false;
                    break;
                case Control.Forwards:
                    ForwardsBtn.Enabled = false;
                    break;
                case Control.Home:
                    HomeBtn.Enabled = false;
                    break;
                case Control.SearchBar:
                    SearchBox.Enabled = false;
                    break;
                case Control.Add:
                    AddBtn.Enabled = false;
                    break;
                case Control.Remove:
                    RemoveBtn.Enabled = false;
                    break;
                case Control.Edit:
                    EditBtn.Enabled = false;
                    break;
                case Control.EditButtons:
                    AddBtn.Enabled = false;
                    RemoveBtn.Enabled = false;
                    EditBtn.Enabled = false;
                    break;
                case Control.NavigationButtons:
                    BackBtn.Enabled = false;
                    HomeBtn.Enabled = false;
                    ForwardsBtn.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        private void EnableControl(Control control)
        {
            switch (control)
            {
                case Control.All:
                    BackBtn.Enabled = true;
                    HomeBtn.Enabled = true;
                    ForwardsBtn.Enabled = true;
                    SearchBox.Enabled = true;
                    AddBtn.Enabled = true;
                    RemoveBtn.Enabled = true;
                    EditBtn.Enabled = true;
                    break;
                case Control.Back:
                    BackBtn.Enabled = true;
                    break;
                case Control.Forwards:
                    ForwardsBtn.Enabled = true;
                    break;
                case Control.Home:
                    HomeBtn.Enabled = true;
                    break;
                case Control.SearchBar:
                    SearchBox.Enabled = true;
                    break;
                case Control.Add:
                    AddBtn.Enabled = true;
                    break;
                case Control.Remove:
                    RemoveBtn.Enabled = true;
                    break;
                case Control.Edit:
                    EditBtn.Enabled = true;
                    break;
                case Control.EditButtons:
                    AddBtn.Enabled = true;
                    RemoveBtn.Enabled = true;
                    EditBtn.Enabled = true;
                    break;
                case Control.NavigationButtons:
                    BackBtn.Enabled = true;
                    HomeBtn.Enabled = true;
                    ForwardsBtn.Enabled = true;
                    break;
                default:
                    break;
            }
        }
        private void CancelEvent()
        {
            MainPanel.Controls.Clear();
            MainPanel.Controls.Add(DataClass.lastUsedControl);
        }
        #endregion
    }
}
