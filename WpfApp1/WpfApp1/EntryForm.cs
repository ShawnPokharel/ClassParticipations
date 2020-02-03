using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class EntryForm
    {
        public string Name { get; set; }
        //public string LastName { get; set; }
        public string Address { get; set; }
        public int ZipCode { get; set; }

        /// <summary>
        /// Default/Empty constructor for the Entryform class
        /// </summary>
        public EntryForm()
        {
            Name = string.Empty;
           // LastName = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }

        /// <summary>
        /// Overloaded constructor taking 3 parameters
        /// </summary>
        /// <param name="name"></param>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        public EntryForm(string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;
        }
        /// <summary>
        /// Overloaded constructor taking 2 parameters
        /// </summary>
        /// <param name="address"></param>
        /// <param name="zipCode"></param>
        public EntryForm(string address, int zipCode)
        {
            Name = string.Empty;
            Address = address;
            ZipCode = zipCode;
        }
        public override string ToString()
        {
            return $"{Name} lives at {Address} at the zipcode {ZipCode}";
        }
    }
}
