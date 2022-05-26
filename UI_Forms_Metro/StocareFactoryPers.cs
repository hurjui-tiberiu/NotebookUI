using System.Configuration;
using System.IO;using AdminPers_FisierNS;

namespace UI_Forms_Metro
{
    static class StocareFactoryPers
    {
        private const string NUME_FISIER = "NumeFisier";
        public static IStocareDate GetAdminStocare()
        {                                                                                                                 
            string numeFisier = ConfigurationManager.AppSettings[NUME_FISIER];
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string caleCompletaFisier = locatieFisierSolutie + "\\" + numeFisier;

            return new AdminPers_Fisier(caleCompletaFisier);
        }
    }
}
