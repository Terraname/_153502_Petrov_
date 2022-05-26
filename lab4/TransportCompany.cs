using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company;

namespace Company
{
    class TransportCompany
    {
        private static TransportCompany _instance;
        public string CompName;
        Double CompTariph = 0;
        List<Tariph> TariphList = new List<Tariph>();

        protected TransportCompany(string compName, double compTariph)
        {
            this.CompName = compName;
            this.CompTariph = compTariph;
            this.TariphList = new List<Tariph>();
        }

        public static TransportCompany getInstance(string compName, double compTariph)
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
        }

        
        static public void AddTariph(Tariph tariph)
        {
            _instance.TariphList.Add(tariph);
        }

        static public void AddTariph(Double weight)
        {
            Tariph tariph = new Tariph(weight, _instance.CompTariph, _instance.CompName);
            _instance.TariphList.Add(tariph);
        }
        static public void AddTariph(Double weight ,Double CompTariph)
        {
            Tariph tariph = new Tariph(weight, CompTariph, _instance.CompName);
            _instance.TariphList.Add(tariph);
        }

        static public void SetCompTariph(double CompTariph)
        {
            _instance.CompTariph = CompTariph;
        }
        static public Double GetTotalIncome()
        {
            Double totalIncome = 0;
            foreach(Tariph tar in _instance.TariphList)
            {
                totalIncome += tar.GetTotalPrice();
            }
        return totalIncome;
        }
        

    }
}
