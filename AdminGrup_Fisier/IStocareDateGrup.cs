using GrupNS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminGrup_FisierNS
{
    public interface IStocareDateGrup
    {
        void AddGrup(Grup grup);
        List<Grup> GetGrupuri();
        Grup GetGrup(int idGrup);
    }
}
