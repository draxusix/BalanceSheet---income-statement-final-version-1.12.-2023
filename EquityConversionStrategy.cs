using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    public class EquityConversionStrategy : ICurrencyConversionStrategy
    {
        private decimal exchangeRate = 0.456m;

        public decimal ConvertToEUR(decimal amount)
        {
            return amount * exchangeRate;
        }
    }
}
