using System;
using System.Collections.Generic;
using System.Text;
using PersoanaNS;
using System.IO;


namespace AdminPers_FisierNS
{
    public class AdminPers_Fisier:IStocareDate
    {
        private string numeFisier;

        public AdminPers_Fisier(string numefisier)
        {
            numeFisier = numefisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddPers(Persoana Pers)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(Pers.ConversieLaSir_PentruFisier);
            }
        }

        public List<Persoana> GetPersoane()
        {
            List < Persoana > persoane = new List<Persoana>();
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    persoane.Add(new Persoana(linieFisier));
                }
            }

            return persoane;
        }

        public List<Persoana> CautarePersoane(string nume, string prenume)
        {
            List<Persoana> Persoane = new List<Persoana>();
            Persoana pers;
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    pers = new Persoana(linieFisier);
                    if (pers.Nume == nume &pers.Prenume==prenume)
                        Persoane.Add(pers);
                }
            }

            return Persoane;
        }

        public bool UpdatePersoana(Persoana persoanaDeActualizat)
        {
            List<Persoana> persoane = GetPersoane();
            bool actualizareCuSucces = false;

            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, false))
            {
                foreach (Persoana persoana in persoane)
                {
                    Persoana persoanaPentruScrisInFisier = persoana;
         
                    if (persoana.Id == persoanaDeActualizat.Id)
                    {
                        persoanaPentruScrisInFisier = persoanaDeActualizat;
                    }
                    streamWriterFisierText.WriteLine(persoanaPentruScrisInFisier.ConversieLaSir_PentruFisier);
                }
                actualizareCuSucces = true;
            }

            return actualizareCuSucces;
        }

    }
}
