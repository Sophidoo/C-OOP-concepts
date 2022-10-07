using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absclass
{
    /*Aggregation*/
    public class Address
    {
        private string street;
        private string city;

        public void setStreet(string street)
        {
            this.street = street;
        }
        public string getStreet()
        {
            return street;
        }

        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return city;
        }

        public void displayDetails()
        {
            Console.WriteLine("Street: {0}", getStreet());
            Console.WriteLine("City: {0}", getCity());
        }
    }
}
