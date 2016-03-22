using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaV2
{
    class Person
    {
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Person(string name, string telephone, string email)
        {
            this.Name = name;
            this.Telephone = telephone;
            this.Email = email;
        }
    }
}
