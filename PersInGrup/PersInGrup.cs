using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersInGrupNS
{
    public class PersInGrup
    {
        private const char SEPARATOR_FISIER= ' ';
        private const char SEPARATOR_SECUNDAR_FISIER = ',';
        private const int IDPERS = 0;
        private const int IDGRUP = 1;
        public int idPers { get; set; }
        public List<int> idGrupuri { set; get; }

        public PersInGrup(int idP)
        {
            idPers = idP;
        }

        public string ConversieLaSir_PentruFisier
        {
            get
            {
                string ids = string.Join(SEPARATOR_SECUNDAR_FISIER.ToString(), idGrupuri);
                string obiectGrupPentruFisier = string.Format("{1}{0}{2}",
                                SEPARATOR_FISIER,
                               idPers,
                               ids);

                return obiectGrupPentruFisier;
            }
        }

        public PersInGrup(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);
            idPers = Convert.ToInt32(dateFisier[IDPERS]);
            SetGrupIds(dateFisier[IDGRUP], ',');
        
        }

        public void SetGrupIds(string sirIds, char delimitator = ',')
        {
            idGrupuri = new List<int>();
            string[] vectorIdsDupaSplit = sirIds.Split(delimitator);

            foreach (string id in vectorIdsDupaSplit)
            {
                Int32.TryParse(id, out int IDGrup);
                idGrupuri.Add(IDGrup);

            }
        }
    }
}
