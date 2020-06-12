using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptuPrograma
{
    class Recipe
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public string Hyperlink { get; set; }
        public List<string> Tags { get; set; }
        public string Description { get; set; }

        public string SaveFormat()
        {
            StringBuilder strb = new StringBuilder();
            if (Tags.Count > 0)
            {
                Tags.ForEach((x) => strb.Append($"{x},"));                
            }
            return string.Format("{0};{1};{2};{3};{4}",Title,Category,Hyperlink,strb.ToString(),Description);
        }
        public override string ToString()
        {
            return Title;
        }
    }
}
