using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_si
{
    class Modelo : Samsung
    {
        protected string modelo;

        public string Nmodelo
        {
            get 
            {
                return modelo;
            }
            set 
            {
                modelo = value;
            }
        }

        public Modelo() : base ()
        {
            modelo = "";
        }

        public override string ToString()
        {
            return modelo + "" + base.ToString();
        }

    }
}
