using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioEreditarietà
{
    public class Automobile : Veicolo
    {
       
        public String Targa { get; set; }
        public String Carburante { get; set; }

        public Automobile(String Modello, String Brand, int Codice, String Targa, String Carburante)
           : base(Modello, Brand, Codice)
        {
            this.Targa = Targa;
            this.Carburante = Carburante;
        }

        public Automobile()
        {

        }

      }
    }


    }



