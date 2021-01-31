using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantSystem.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
       
        public Customer() { }
        public Customer(string aPhoneNumber ,string aName, string aLastName, string anAddress, string aZipCode )
        {
            PhoneNumber = aPhoneNumber;
            Name = aName;
            LastName = aLastName;
            Address = anAddress;
            ZipCode = aZipCode;
        }
    }
}
