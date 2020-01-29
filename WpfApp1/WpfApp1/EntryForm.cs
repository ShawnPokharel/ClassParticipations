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

        public EntryForm()
        {
            Name = string.Empty;
           // LastName = string.Empty;
            Address = string.Empty;
            ZipCode = 0;
        }
        public EntryForm(string name, string address, int zipCode)
        {
            Name = name;
            
            Address = address;
            ZipCode = zipCode;


        }
        public override string ToString()
        {
            return $"{Name} lives at {Address} at the zipcode {ZipCode}";
        }
    }
}
