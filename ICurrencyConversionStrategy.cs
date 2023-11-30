using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    public interface ICurrencyConversionStrategy
    {
        decimal ConvertToEUR(decimal amount);
    }
}
