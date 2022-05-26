using PersInGrupNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminPersInGrup_FisierNS
{
    public interface IStocareDatePersInGrup
    {
        void AddPersInGrup(PersInGrup persingrup);
        List<PersInGrup> GetPersInGrup();
        bool UpdatePIG(PersInGrup PIGdeActualizat);
    }
}
