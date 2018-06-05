﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workWithJSON
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PhoneNumber> phoneNumbers;

    }
    class PhoneNumber
    {
        public string AreaCode { get; set; }
        public string number { get; set; }
    }

 

}
