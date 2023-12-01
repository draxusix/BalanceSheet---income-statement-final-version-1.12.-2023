using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracovniZadaniV2
{
    //Třída definující objekt BalanceSheet, jakožto celkovou rozvahu obsahující seznam (list) položek (itemů)
    internal class BalanceSheet
    {
        public List<BalanceSheetItem> Items { get; set; }

        public BalanceSheet(List<BalanceSheetItem> items)
        {
            Items = items;
        }
    }
}
