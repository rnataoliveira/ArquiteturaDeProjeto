using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    class Contato
    {
        public String Name { get; set; }
        public String Phone { get; set; }

        public Contato(String _name, String _phone)
        {
            this.Name = _name;
            this.Phone = _phone;
        }

    }
}
