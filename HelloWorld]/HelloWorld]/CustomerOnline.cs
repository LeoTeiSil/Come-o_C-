using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HelloWorld_
{
    internal class CustomerOnline : Customer
    {
        public CustomerOnline(string name, string address, DateTime birthday)
        {
            Name = name;
            Address = address;
            Birthday = birthday;
        }
    }
}
