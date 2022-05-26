using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersoanaNS
{
    public class Enumerari
    {
        public enum Sex
        {
           F=0, //Feminin
           M=1 //Masculin
        }

        [Flags]
        public enum Pasiuni
        {
            Sport=1,
            Muzica=2,
            Gaming=4,
            Arta=8
        }
    }
}
