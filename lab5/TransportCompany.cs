using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company;

namespace Company
{
    public class TransportCompany
    {
        private static TransportCompany _instance;
        public string CompName;
        Double CompTariph = 0;
        List<Tariph> TariphList = new List<Tariph>();

        public TransportCompany(string compName, double compTariph)
        {
            this.CompName = compName;
            this.CompTariph = compTariph;
            this.TariphList = new List<Tariph>();
        }

        /*public static TransportCompany getInstance(string compName, double compTariph)
        {
            if (_instance == null)
            {
                lock (typeof(TransportCompany))
                {
                    if (null == _instance)
                        _instance = new TransportCompany(compName, compTariph);
                }
            }
            return _instance;
        }*/

        
        public void AddTariph(Tariph tariph)
        {
            TariphList.Add(tariph);
        }

        public void AddTariph(Double weight)
        {
            Tariph tariph = new Tariph(weight, this.CompTariph, this.CompName);
            TariphList.Add(tariph);
        }
        public void AddTariph(Double weight ,Double CompTariph)
        {
            Tariph tariph = new Tariph(weight, CompTariph, this.CompName);
            TariphList.Add(tariph);
        }

        public double GetCompTarief()
        {
            return this.CompTariph;
        }

        public Double GetTotalIncome()
        {
            Double totalIncome = 0;
            foreach(Tariph tar in TariphList)
            {
                totalIncome += tar.GetTotalPrice();
            }
        return totalIncome;
        }
        

    }
}
