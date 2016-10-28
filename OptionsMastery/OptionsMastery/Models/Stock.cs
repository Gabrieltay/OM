using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsMastery.Models
{
    public class Stock
    {
        public Stock(String aSymbol, String aName, String aMarket)
        {
            this.Symbol = aSymbol;
            this.Name = aName;
            this.Market = aMarket;
        }

        public String Symbol
        {
            get;set;
        }

        public String Market
        {
            get;set;
        }

        public String Name
        {
            get;set;
        }
    }
}
