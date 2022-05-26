using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersoanaNS;

namespace GrupNS
{
    public class Grup
    {
        private const char SEPARATOR_FISIER = ' ';
        private const int ID = 0;
        private const int DENUMIRE = 1;
        private const int DATACREARE= 2;

        public int Id { get; set; }
        public string Denumire { get; set; }
        public DateTime DataCreare { get; set; }
 

        public Grup(int id, string denumire)
        {
            Id = id;
            Denumire = denumire;
            DataCreare = DateTime.Now;
        
        }

        public string ConversieLaSir_PentruFisier
        {
            get
            {
                string obiectGrupPentruFisier = string.Format("{1}{0}{2}{0}{3}",
                                SEPARATOR_FISIER,
                               Id,
                               Denumire,
                               DataCreare.ToString("dd/MM/yyyy"));

                return obiectGrupPentruFisier;
            }
        }

        public Grup(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);
            Id = Convert.ToInt32(dateFisier[ID]);
            Denumire = dateFisier[DENUMIRE];
            DateTime.TryParse(dateFisier[DATACREARE], out DateTime result);
            DataCreare = result;
        }

         

    }
}
