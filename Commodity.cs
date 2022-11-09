using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Commodity
    {
        private readonly double price;
        private readonly string countryOfOrigin;
        private readonly string name;
        private readonly string packingDate;
        private readonly string descriotion;

        public Commodity(double price, string countryOfOrigin, string name, string packingDate, string descriotion)
        {
            this.price = price;
            this.countryOfOrigin = countryOfOrigin;
            this.name = name;
            this.packingDate = packingDate;
            this.descriotion = descriotion;
        }

        public double Price { get { return price; } }
        public string CountryOfOrigin { get { return countryOfOrigin; } }
        public string Name { get { return name; } }
        public string PackingDate { get { return packingDate; } }
        public string Descriotion { get { return descriotion; } }

    }
}
