using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceptuPrograma
{
    class Category
    {
        public string Title { get; set; }
        public int Count { get; set; }
        public Category(string title, int count)
        {
            Title = title;
            Count = count;
        }
    }
}
