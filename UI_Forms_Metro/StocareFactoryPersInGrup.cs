using AdminPersInGrup_FisierNS;
using PersInGrupNS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Forms_Metro
{
    public class StocareFactoryPersInGrup
    {
        private const string NUME_FISIER = "NumeFisierPersInGrup";
        public static IStocareDatePersInGrup GetAdminStocare()
        {
            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            return new AdminPersInGrup(caleCompletaFisier);
        }
    }
}
