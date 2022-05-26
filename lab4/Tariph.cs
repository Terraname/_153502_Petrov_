using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Tariph
    {
        double price;
        double weight;
        string compName;
        public Tariph(double price, double weight, string compName)
        {
            this.price = price;
            this.weight = weight;
            this.compName = compName;

        }

        public double GetTotalPrice()
        {
            return price * weight;
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }
    }
}
