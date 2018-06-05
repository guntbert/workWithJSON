using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace workWithJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer bill = new Customer
            {
                Id = 1,
                Name = "Bill Gates",
                phoneNumbers = new List<PhoneNumber>
            {
                new PhoneNumber
                {
                    AreaCode="CAL",
                    number="122356"
                },
                new PhoneNumber
                {
                    AreaCode="Wash",
                    number="563498"
                }
            }
            };

            // Serializing Class->JSON
            string jsonBill = JsonConvert.SerializeObject(bill);
            Console.WriteLine(jsonBill);

            Customer newCust = JsonConvert.DeserializeObject<Customer>(jsonBill);
            Console.WriteLine($"Name:{newCust.Name}, Id:{newCust.Id}");
            foreach (PhoneNumber pn in newCust.phoneNumbers)
            {
                Console.WriteLine(pn.AreaCode + pn.number);
            }

            List<Customer> allCustomers = new List<Customer>();
            Customer anotherCust = new Customer
            {
                Id = 2,
                Name = "George Washington",
                phoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber
                    {
                    AreaCode="WAS",
                    number="01010101"
                    }
                }
            };

            allCustomers.Add(anotherCust);
            anotherCust = new Customer
            {
                Id = 3,
                Name = "Mariah Carey",
                phoneNumbers = new List<PhoneNumber>
                {
                    new PhoneNumber
                    {
                    AreaCode="HOL",
                    number="56566565"
                    }
                }
            };
            allCustomers.Add(anotherCust);

            string jsonAll = JsonConvert.SerializeObject(allCustomers);
            Console.WriteLine(jsonAll);
            List<Customer> newCustList = JsonConvert.DeserializeObject<List<Customer>>(jsonAll);

        }


    }
}

