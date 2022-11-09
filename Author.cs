using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Author
    {
        private string name;
        private string surname;

        public Author(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public int CompareTo(Author other)
        {
            if (string.Equals(other.name, name, StringComparison.OrdinalIgnoreCase)) return surname.CompareTo(other.surname);
            return name.CompareTo(other.name);
        }
    }
}
