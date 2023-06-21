using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleStore
{
    public class PetSupplies : IProduct
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; } = 0.0;
        public int Quantity { get; set; } = 0;


        public void DisplayProduct()
        {
            Console.WriteLine("Name: \t{0}\nQuantity: {1}\nPrice: {2:c}\n",
                this.Name, this.Quantity, this.Price);
        }
    }
}
