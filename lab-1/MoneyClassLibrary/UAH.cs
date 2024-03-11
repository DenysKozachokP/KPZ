using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyClassLibrary
{
    public class UAH : Currency
    {
        public UAH(int euros, int cents) : base(euros, cents) { }

        public override string GetCurrencySymbol()
        {
            return "₴";
        }
    }

}
