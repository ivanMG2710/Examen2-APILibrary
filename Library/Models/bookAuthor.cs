using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    public class bookAuthor
    {
        public string titleBook { get; set; } = null;
        public string authorBook { get; set; } = null;
        public int chaptersBook { get; set; }
        public int pagesBook { get; set; }
        public double priceBook { get; set; }
    }
}
