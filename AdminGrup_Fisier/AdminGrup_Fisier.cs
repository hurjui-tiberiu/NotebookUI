using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrupNS;


namespace AdminGrup_FisierNS
{
    public class AdminGrup_Fisier: IStocareDateGrup
    {
        private string numeFisier;

        public AdminGrup_Fisier(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream stream=File.Open(this.numeFisier, FileMode.OpenOrCreate);
            stream.Close();
        }

        public void AddGrup(Grup grup)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(grup.ConversieLaSir_PentruFisier);
            }

        }

        public List<Grup> GetGrupuri()
        {
            List<Grup> grup = new List<Grup>();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    grup.Add(new Grup(linieFisier));
                }
            }

            return grup;
        }

        public Grup GetGrup(int idGrup)
        {
            // instructiunea 'using' va apela streamReader.Close()
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                // citeste cate o linie si creaza un obiect de tip Student
                // pe baza datelor din linia citita
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Grup grup = new Grup(linieFisier);
                    if (grup.Id == idGrup)
                        return grup;
                }
            }

            return null;
        }
    }
}
