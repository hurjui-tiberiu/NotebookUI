using AdminGrup_FisierNS;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Forms_Metro
{
    class StocareFactoryGrup
    {
        private const string NUME_FISIER = "NumeFisierGrup";
        public static IStocareDateGrup GetAdminStocare()
        {
            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            return new AdminGrup_Fisier(caleCompletaFisier);
        }
    }
}
