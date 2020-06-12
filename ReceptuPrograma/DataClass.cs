using ReceptuPrograma.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptuPrograma
{
    static class DataClass
    {
        public static System.Windows.Forms.Control lastUsedControl = null;
        public static List<Category> categories = new List<Category>() { new Category("Nepriskirta",0)}; // Contains all categories
        public static List<Recipe> recipes = new List<Recipe>(); // Contains all recipes
    }
}
