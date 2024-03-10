using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public partial class drobi
    {
        #region sravnenie
        public static bool operator ==(drobi x, drobi y) { 
            if (x.Numerator == y.Numerator && x.Denominator == y.Denominator) return true; 
            return false;
        }

        public static bool operator !=(drobi x, drobi y)
        {
            if (x.Numerator == y.Numerator && x.Denominator == y.Denominator) return false;
            return true;
        }

        public static bool operator <(drobi x, drobi y)
        {
            if (x.Numerator / x.Denominator < y.Numerator/y.Denominator) return true;
            return false;
        }

        public static bool operator >(drobi x, drobi y)
        {
            if (x.Numerator / x.Denominator > y.Numerator / y.Denominator) return true;
            return false;
        }

        public static bool operator <=(drobi x, drobi y)
        {
            if (((float)x.Numerator / x.Denominator) <= ((float)y.Numerator / y.Denominator)) return true;
            return false;
        }

        public static bool operator >=(drobi x, drobi y)
        {
            if (((float)x.Numerator / x.Denominator) >= ((float)y.Numerator / y.Denominator)) return true;
            return false;
        }
        #endregion
    }
}
