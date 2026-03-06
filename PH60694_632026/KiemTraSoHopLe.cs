using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PH60694_632026
{
    public class KiemTraSoHopLe
    {
        public bool KiemTra(int n)
        {
            if(n < 1 || n > 50) return false;
            if(n % 8 == 0) return false;
            return true;
        }
    }
}
