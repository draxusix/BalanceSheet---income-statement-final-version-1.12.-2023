using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    internal class BalanceSheet
    {
        public List<BalanceSheetItem> Items { get; set; }

        public BalanceSheet(List<BalanceSheetItem> items)
        {
            Items = items;
        }
    }
}
