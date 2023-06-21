using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleStore
{
    public class Electronics : IProduct
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; } = 0;
        public string Company { get; set; } = string.Empty;


        public void DisplayProduct()
        {
            Console.WriteLine("Name: \t{0}\nCompany: {1}\nPrice: {2:c}\n",
                this.Name, this.Company, this.Price);
        }
    }
}
