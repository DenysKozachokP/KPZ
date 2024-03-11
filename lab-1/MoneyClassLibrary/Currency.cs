using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClassLibrary
{
    public abstract class Currency
    {
        public int Major { get; protected set; }
        public int Minor { get; protected set; }

        protected Currency(int majorUnit, int minorUnit)
        {
            SetAmount(majorUnit, minorUnit);
        }
        public abstract string GetCurrencySymbol();
        public void SetAmount(int majorUnit, int minorUnit)
        {
            Major = majorUnit;
            Minor = minorUnit;
        }
        public override string ToString()
        {
            return $"{GetCurrencySymbol()}{Major}.{Minor:D2}";
        }
    }
}
