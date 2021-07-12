using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Info
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Hobby { get; set; }

        public Info(string name, string address, string hobby)
        {
            Name = name;
            Address = address;
            Hobby = hobby;

        }

        public string Details
        {
            get
            {
                return
                  String.Format("{0}'s address is {1} and hobby is {2}.", this.Name, this.Address,this.Hobby);
            }
        }

    }


}
