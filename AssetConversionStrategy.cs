using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    public class AssetConversionStrategy : ICurrencyConversionStrategy
    {
        private decimal exchangeRate = 0.123m; //kurz neni aktualni, doplnit

        public decimal ConvertToEUR(decimal amount)
        {
            return amount * exchangeRate;
        }
    }
}
