using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    public class PLConversionStrategy : ICurrencyConversionStrategy
    {
        private decimal exchangeRate = 0.789m;

        public decimal ConvertToEUR(decimal amount)
        {
            return amount * exchangeRate;
        }
    }
}
