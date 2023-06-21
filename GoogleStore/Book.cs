using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleStore
{
    public class Book : IProduct
    {
        public string Author { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;

        public void DisplayProduct()
        {
            Console.WriteLine("Title: \t{0}\nAuthor: {1}\nPrice: {2:c}\n",
                this.Name, this.Author, this. Price);
        }
    }
}
