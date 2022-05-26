using System;
using System.Collections.Generic;
using System.Text;
using static PersoanaNS.Enumerari;
using System.Globalization;
namespace PersoanaNS
{
    public class Persoana
    {
        private const char SEPARATOR_FISIER = ' ';

        private const int ID = 0;
        private const int NUME = 1;
        private const int PRENUME = 2;
        private const int DATAN = 3;
        private const int EMAIL = 4;
        private const int NRTEL = 5;
        private const int SEX = 6;
        private const int PASIUNI = 7;

        public int Id { set; get; }
        public string Nume { set; get; }
        public string Prenume { set; get; }
        public DateTime DataN { set; get; }
        public string Email { set; get; }
        public string NrTel { set; get; }
        public Sex SexPers { set; get; }
        public Pasiuni PasiuniPers { set; get; }

        public Persoana()
        {
            Id = 0;
            Nume = "anonim";
            Prenume = "anonim";
            DataN = new DateTime(1, 1, 1);
            Email = "anonim@mail.com";
            NrTel = "0000000000";
        }

        public Persoana(int id, string nume, string prenume, DateTime datan, string email, string nrtel)
        {
            Id = id;
            Nume = nume;
            Prenume = prenume;
            DataN = datan;
            Email = email;
            NrTel = nrtel;
        }

        public Persoana(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_FISIER);
            Id = Convert.ToInt32(dateFisier[ID]);
            Nume = dateFisier[NUME];
            Prenume = dateFisier[PRENUME];
            DataN = DateTime.Parse(dateFisier[DATAN]);
            Email = dateFisier[EMAIL];
            NrTel = dateFisier[NRTEL];
            SexPers = (Sex)Enum.Parse(typeof(Sex), dateFisier[SEX]);
            PasiuniPers = (Pasiuni)Enum.Parse(typeof(Pasiuni), dateFisier[PASIUNI]);
        }

        public string ConversieLaSir_PentruFisier
        {
            get
            {
                string obiectStudentPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}{5}{0}{6}{0}{7}{0}{8}",
                    SEPARATOR_FISIER,
                   Id,
                   Nume,
                   Prenume,
                   DataN.ToString("dd/MM/yyyy"),
                   Email,
                   NrTel,
                   SexPers,
                   Int32.Parse(PasiuniPers.ToString("X"), System.Globalization.NumberStyles.HexNumber)).ToString();
                return obiectStudentPentruFisier;
            }
        }
    }
}
