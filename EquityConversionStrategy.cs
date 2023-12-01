using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    //Třída pro přepočet u položky Equity
    public class EquityConversionStrategy : ICurrencyConversionStrategy
    {
        private decimal exchangeRate = 0.04116920543m; //kurz aktualni dle ČNB ke 30.11. 2023

        public decimal ConvertToEUR(decimal amount)
        {
            return amount * exchangeRate;
        }
    }
}
