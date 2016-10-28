using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsMastery.Models
{
    public class LinearRegressionStrategy
    {
        List<Option> mTransactions = null;
            
        public LinearRegressionStrategy(Stock aStock)
        {
            this.Stock = aStock;
            mTransactions = new List<Option>();
        } 

        public LinearRegressionStrategy(Stock aStock, List<Option> aTransactions)
        {
            this.Stock = aStock;
            mTransactions = aTransactions;
        }

        public void Add(Option aTransaction)
        {
            this.mTransactions.Add( aTransaction );
        }

        public void Remove(Option aTransaction)
        {
            this.mTransactions.Remove( aTransaction );
        }

        public Double ProfitLoss()
        {
            Double nResult = 0.0;

            foreach(Option aTransaction in this.mTransactions)
            {
                if ( aTransaction.Contract == Option.ContractType.PUT )
                {
                    if ( aTransaction.Action == Option.ActionType.SELL )
                    {
                        nResult += ( aTransaction.Quantity * aTransaction.Premium * 100 );
                    }
                    else
                    {
                        nResult -= ( aTransaction.Quantity * aTransaction.Premium * 100 );
                    }
                }
            }

            return nResult;
        }

        public Stock Stock
        {
            get; set; 
        }
    }
}
