using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Client
    {
        private string name;
        private string password;
        private List<Tariph> TariphList = new List<Tariph>();
        public Client(string name, string password) 
        { 
            this.name = name;
            this.password = password;
        }
        public void MakeOrder(Tariph order)
        {
            TariphList.Add(order);
        }
        public void CreatOrder(TransportCompany Company, double price, double weight)
        {
            Tariph tariph = new Tariph(price, weight, Company.CompName);
            TariphList.Add(tariph);
            Company.AddTariph(tariph);
        }
        public double GetTotalExpances()
        {
            double totalExp = 0;
            foreach (Tariph order in TariphList)
            {
                totalExp += order.GetTotalPrice();
            }
            return totalExp;
        }
    }
}
