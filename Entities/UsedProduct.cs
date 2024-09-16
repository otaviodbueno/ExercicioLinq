using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufacutereDate) : base(name, price)
        {
            ManufactureDate = manufacutereDate;
        }

        public override string PriceTag()
        {
            return Name + "(used) $" +
             Price + "(Manufacture date: )" + ManufactureDate;
        }
    }
}
