using PersInGrupNS;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersInGrup_FisierNS
{
    public class AdminPersInGrup:IStocareDatePersInGrup
    {
        private string numeFisier;

        public AdminPersInGrup(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream stream = File.Open(this.numeFisier, FileMode.OpenOrCreate);
            stream.Close();
        }

        public void AddPersInGrup(PersInGrup persingrup)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(persingrup.ConversieLaSir_PentruFisier);
            }

        }

        public List<PersInGrup> GetPersInGrup()
        {
            List<PersInGrup> grup = new List<PersInGrup>();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    grup.Add(new PersInGrup(linieFisier));
                }
            }

            return grup;
        }

        public bool UpdatePIG(PersInGrup PIGdeActualizat)
        {
            List<PersInGrup> persoane = GetPersInGrup();
            bool actualizareCuSucces = false;

            //instructiunea 'using' va apela la final swFisierText.Close();
            //al doilea parametru setat la 'false' al constructorului StreamWriter indica modul 'overwrite' de deschidere al fisierului
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (PersInGrup persoana in persoane)
                {
                    PersInGrup persoanaPentruScrisInFisier = persoana;
                    //informatiile despre studentul actualizat vor fi preluate din parametrul "studentActualizat"
                    if (persoana.idPers== PIGdeActualizat.idPers)
                    {
                        persoanaPentruScrisInFisier = PIGdeActualizat;
                    }
                    streamWriterFisierText.WriteLine(persoanaPentruScrisInFisier.ConversieLaSir_PentruFisier);
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }
    }
}
