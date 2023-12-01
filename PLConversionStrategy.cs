using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    //Třída pro přepočet u položky PL
    public class PLConversionStrategy : ICurrencyConversionStrategy
    {
        //Kurz jsem odhadnul dle hodnot kurzu EURa mezi 1.11. 2023 a 30.11. 2023 - Měl by zde být použit zajištěný (hedged) kurz - Strategie sloužící k ochraně před rizikem pohybu měnových kurzů. Stanovuje se na základě výsledku smlouvy mezi dvěma stranami, nicméně pro toto řešení je zmíněný ohhad dle mého názoru dostačující.
        private decimal exchangeRate = 0.04084133142m; 

        public decimal ConvertToEUR(decimal amount)
        {
            return amount * exchangeRate;
        }
    }
}
