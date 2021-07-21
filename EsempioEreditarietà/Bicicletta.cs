using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsempioEreditarietà
{
    public class Bicicletta : Veicolo
    {
        public bool Elettrica { get; set; }
        public Bicicletta(String Modello, String Brand, int Codice, bool Elettrica)
            : base(Modello, Brand, Codice)
        {
            this.Elettrica = Elettrica;
        }

        public Bicicletta()
        {

        }
   
    }


    }