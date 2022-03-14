using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAPOTE_JAYVEE_IT105L_C11
{
    public class Product
    {
        public string Description { get; set; }
        public double Cost { get; set; }
        public int NumberOrdered { get; set; }

        public Product(string description, double cost)
        {
            Description = description;
            Cost = cost;  
        }
    }
}
