using System;
using PersoanaNS;
using System.Configuration;
using AdminPers_FisierNS;
using System.IO;
using GrupNS;
using AdminGrup_FisierNS;
using System.Collections.Generic;

namespace ProgramNS
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeFisier = ConfigurationManager.AppSettings["NumeFisier"];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;
            AdminPers_Fisier adminPers = new AdminPers_Fisier(caleCompletaFisier);
            Persoana persoanaNoua = new Persoana();

           // AdminGrup_Fisier adminGrup = new AdminGrup_FisierNS(locatieFisierSolutie + "\\Grup.bin");

           // int nrPers = adminPers.GetNrPers();

            string optiune;
            do
            {
                Console.WriteLine("F. Afisare persoane din fisier");
                Console.WriteLine("S. Salvare persoane in fisier");
                Console.WriteLine("C. Citire de la tastatura");
                Console.WriteLine("L. Cautare dupa nume si prenume");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("G. Adaugare Grup");
                Console.WriteLine("Alegeti o optiune");

                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "F":
                       // Persoana[] pers = adminPers.GetPersoane(out nrPers);
                       // AfisarePersoane(pers, nrPers);
                        break;
                    case "S":
                       // int idPersoana = nrPers + 1;
                       // persoanaNoua.Id = idPersoana;
                       // adminPers.AddPers(persoanaNoua);
                       // nrPers++;
                        break;
                    case "C":
                        persoanaNoua = CitireDeLaTastatura();
                        break;
                    case "L":
                        CautareDupaNumeSiPrenume(adminPers);
                        break;
                    case "X":
                        return;
                    case "G":
                      //  List < Grup > grups= adminGrup.GetGrup();
                        ////foreach (Grup g in grups)
                           // Console.WriteLine(g.Denumire);
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();
        }

        public static void AfisarePersoane(Persoana[] pers, int nrPersoane)
        {
            Console.WriteLine("Persoanele sunt:");
            for (int contor = 0; contor < nrPersoane; contor++)
            {
                string infoStudent = string.Format("Persoana cu id-ul #{0}: {1} {2} {3} {4} {5}",
                   pers[contor].Id,
                  pers[contor].Nume,
                   pers[contor].Prenume,
                   pers[contor].DataN.ToString("d"),
                   pers[contor].Email,
                   pers[contor].NrTel);

                Console.WriteLine(infoStudent);
            }
        }

        public static Persoana CitireDeLaTastatura()
        {
            Console.Write("Nume: ");
            string nume = Console.ReadLine();

            Console.Write("Prenume: ");
            string prenume = Console.ReadLine();

            Console.Write("Data nastere: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Numar telefon: ");
            string nrtel = Console.ReadLine();

            Persoana persoana = new Persoana(0, nume, prenume, date, email, nrtel);
            return persoana;
        }

        public static void CautareDupaNumeSiPrenume(AdminPers_Fisier adminPers)
        {
            Console.Write("Introduceti numele: ");
            string nume = Console.ReadLine();
            Console.Write("Introduceti prenumele: ");
            
            string prenume = Console.ReadLine();
            //Persoana pers = adminPers.VerifPers(nume, prenume);

           // if (pers != null)
            //    Console.WriteLine(pers.ConversieLaSir_PentruFisier);
           // else Console.WriteLine("Persoana inexistenta!");
        }

    }
}
