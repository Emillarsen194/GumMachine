using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GumMachine
{
    class Gum
    {
        private String typeOfGum;
        

        public String TypeOfGum
        {
            get
            {
                return typeOfGum;
            }

            set
            {
                typeOfGum = value;
            }
        }



        public Gum()
        {

        }

        public Gum(String tgum)
        {
            this.typeOfGum = tgum;

        }
    }
}
