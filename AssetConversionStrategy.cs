using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    //Třída pro přepočet u položky Asset
    public class AssetConversionStrategy : ICurrencyConversionStrategy
    {
        private decimal exchangeRate = 0.0407664085m; //kurz dle ČNB z 10.11. 2023

        public decimal ConvertToEUR(decimal amount)
        {
            return amount * exchangeRate;
        }
    }
}
