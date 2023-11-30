using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    public class LiabilityConversionStrategy : ICurrencyConversionStrategy
    {
        private decimal exchangeRate = 0.321m;

        public decimal ConvertToEUR(decimal amount)
        {
            return amount * exchangeRate;
        }
    }
}
