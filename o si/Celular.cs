using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_si
{
    class Celular : Dispositivos
    {
        protected string sistema_operativo;

         public string SistemaOperativo
        {
            get
            {
                return sistema_operativo;
            }
            set
            {
                sistema_operativo = value;
            }
        }

        public Celular() : base()
        {
            sistema_operativo = "";
        }

        public override string ToString()
        {
            return sistema_operativo + "" + base.ToString();
        }

    }
}
