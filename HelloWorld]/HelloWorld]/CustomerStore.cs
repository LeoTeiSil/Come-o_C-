using HelloWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld_
{
    internal class CustomerStore : Customer
    {
        public CustomerStore(string name, string address, DateTime birthday)
        {
            Name = name;
            Address = address;
            Birthday = birthday;
        }
    }
}
