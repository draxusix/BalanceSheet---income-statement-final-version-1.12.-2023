using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    //Rozhraní, které jsem použil k definování jednotlivých přepočtů hodnoty položek z CZK do EUR
    public interface ICurrencyConversionStrategy
    {
        decimal ConvertToEUR(decimal amount);
    }
}
