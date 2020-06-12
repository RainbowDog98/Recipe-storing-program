using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ReceptuPrograma
{
    class FileReader
    {
        private bool HasCategory(string text)
        {
            foreach (var item in DataClass.categories)
            {
                if(item.Title.ToLower() == text.ToLower())
                {
                    item.Count++;
                    return true;
                }
            }
            return false;
        }
        public void ReadFiles()
        {
            string path = Directory.GetCurrentDirectory() + "\\Receptai";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
                MessageBox.Show("Nerastas \"Receptai\" aplankalas");
            }

            string[] files = Directory.GetFiles(path, "*.csv");

            foreach (var file in files)
            {
                var f = File.ReadAllText(file);
                var splitted = f.Split(';');

                if (splitted.Length != 5)
                {
                    MessageBox.Show($"Klaidingas formatas faile: {file}");
                }
                else
                {

                    /// TODO 
                    /// Change the format

                    // splitted[1] = category

                    if (!HasCategory(splitted[1])){
                        DataClass.categories.Add(new Category(splitted[1], 1));
                    }

                    Recipe temp = new Recipe();
                    temp.Title = splitted[0];
                    temp.Category = splitted[1];
                    temp.Hyperlink = splitted[2];
                    temp.Tags = splitted[3].Split(new char[]{','},StringSplitOptions.RemoveEmptyEntries).ToList();
                    temp.Description = splitted[4];

                    DataClass.recipes.Add(temp);
                }
            }
            DataClass.recipes.Sort((x,y) => x.Title.CompareTo(y.Title));
            DataClass.categories.Sort((x, y) => x.Title.CompareTo(y.Title));
        }     
    }
}
