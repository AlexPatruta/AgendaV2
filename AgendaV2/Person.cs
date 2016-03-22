using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaV2
{
    class Person
    {   /// <summary>
    /// number represents the entry identification number
    /// </summary>
        public static int identificationNumber = 0;
        public int ID { get; set; }
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Person(string name, string telephone, string email)
        {
            this.ID = identificationNumber++;
            this.Name = name;
            this.Telephone = telephone;
            this.Email = email;
        }
        public Person(string name, string telephone)
        {
            this.ID = identificationNumber++; ;
            this.Name = name;
            this.Telephone = telephone;
            this.Email = null;
        }
        public Person(string name)
        {
            this.ID = identificationNumber++; ;
            this.Name = name;
            this.Telephone = null;
            this.Email = null;
        }
    }
}
