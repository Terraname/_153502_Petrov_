using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public interface IPrice
    {
        public double GetTotalPrice(Tariph tariph);
    }
    public class Tariph
    {
        public double price;
        public double weight;
        public double discount = 0;
        public double absolut_discount = 0;
        public string compName;
        public IPrice pr;
        public Tariph(double price, double weight, string compName)
        {
            this.price = price;
            this.weight = weight;
            this.compName = compName;

        }

        //public IPrice GetPrice {private get; set; }
        public double GetTotalPrice()
        {
            //return price * weight;
            return pr.GetTotalPrice(this);
        }

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void SetDiscount(double discount)
        {
            if(discount>= 0 && discount <= 100)
            this.discount = discount;
        }
        public void SetAbsolutDiscount(double ablolut_discount)
        {
            this.absolut_discount = ablolut_discount;
        }
    }

    

    public class PriceWithOutDiscount : IPrice
    {
        public double GetTotalPrice(Tariph tariph)
        {
            return tariph.price * tariph.weight;
        }
    }

    public class PriceWithDiscount : IPrice
    {
        public double GetTotalPrice(Tariph tariph)
        {
            return (tariph.price * tariph.weight) * (100 - tariph.discount) / 100;
        }
    }

    public class PriceWithTotalDiscount : IPrice
    {
        public double GetTotalPrice(Tariph tariph)
        {
            if (tariph.absolut_discount <= tariph.price * tariph.weight)
                return (tariph.price * tariph.weight) - tariph.absolut_discount;
            return 0;
        }
    }

}

