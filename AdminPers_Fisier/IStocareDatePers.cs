using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersoanaNS;

namespace AdminPers_FisierNS
{
    public interface IStocareDate
    {
        void AddPers(Persoana Pers);
        List<Persoana> GetPersoane();
        List<Persoana> CautarePersoane(string nume, string prenume);
        bool UpdatePersoana(Persoana persoanaDeActualizat);
    }
}
