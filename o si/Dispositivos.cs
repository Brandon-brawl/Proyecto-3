using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_si
{
    class Dispositivos
    {
        protected int generacion;

        public int Generacion
        {
            get
            {
                return generacion;
            }
            set
            {
                generacion = value;
            }
        }


        public Dispositivos()
        {
            generacion = 0;
        }

        public override string ToString()
        {
            return generacion + "";
            
        }

    }
}
