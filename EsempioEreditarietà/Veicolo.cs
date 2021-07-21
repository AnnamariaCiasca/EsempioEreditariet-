using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioEreditarietà
{
    public class Veicolo
    {

        public String Brand { get; set; }
        public String Modello { get; set; }
        public int Codice { get; set; }



        public Veicolo()
        {

        }

        public Veicolo(String brand, String modello, int codice)
        {
            this.Brand = brand;
            this.Modello = modello;
            this.Codice = codice;
        }
    }
}