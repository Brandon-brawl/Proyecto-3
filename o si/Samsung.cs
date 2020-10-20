using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o_si
{
    class Samsung : Celular
    {
        protected  string marca;

        public  string Marca 
        {
            get 
            {
                return marca;
            }
            set
            {
                marca = value;
            }
        }

        public Samsung() : base()
        {
            marca = "";
        }

        public override string ToString()
        {
            return marca + "" + base.ToString();
        }
    }
}