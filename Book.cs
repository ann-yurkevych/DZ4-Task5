using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Book : Commodity
    {
        private readonly int pages;

        private readonly string publisher;

        private readonly List<Author> authors = new List<Author>();

        public Book(double price, string countryOfOrigin, string name, string packingDate, string descriotion, int pages, string publisher, List<Author> authors) : base(price, countryOfOrigin, name, packingDate, descriotion)
        {
            this.pages = pages;
            this.publisher = publisher;
            this.authors = authors;
        }
        public int Pages { get { return pages; } }
        public string Publisher { get { return publisher; } }
        public List<Author> Authors { get { return authors; } } 
    }
}
