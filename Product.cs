using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Product : Commodity
    {
        private readonly int quantity;
        private readonly int expirationTime;
        private readonly string measureUnit;

        public Product(double price, string countryOfOrigin, string name, string packingDate, string descriotion, int quantity, int expirationTime, string measureUnit) : base(price, countryOfOrigin, name, packingDate, descriotion)
        {
            this.quantity = quantity;
            this.expirationTime = expirationTime;
            this.measureUnit = measureUnit;
        }
        public int Quantity { get { return quantity; } }
        public int ExpirationDate { get { return expirationTime; } }
        public string MeasureUnit { get { return measureUnit; } }
    }
}
