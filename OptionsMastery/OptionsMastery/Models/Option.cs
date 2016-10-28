using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsMastery.Models
{
    public class Option
    {
        public Option(Stock aStock, ContractType aContract, ActionType aAction, 
                    DateTime aExpiryDate, int aQuantity, double aStrikePrice, 
                    double aPremium, DateTime aExecuteDate )
        {
            this.Stock = aStock;
            this.Contract = aContract;
            this.Action = aAction;
            this.ExpiryDate = aExpiryDate;
            this.Quantity = aQuantity;
            this.StrikePrice = aStrikePrice;
            this.Premium = aPremium;
            this.ExecutedDate = aExecuteDate;
        }

        public enum ContractType
        {
            PUT,
            CALL
        }
        public enum ActionType
        {
            BUY,
            SELL
        }

        public Stock Stock
        {
            get; set;
        }

        public DateTime ExecutedDate
        {
            get; set;
        }

        public DateTime ExpiryDate
        {
            get; set;
        }

        public Double StrikePrice
        {
            get; set;
        }

        public Double Premium
        {
            get; set;
        }

        public int Quantity
        {
            get; set;
        }

        public ContractType Contract
        {
            get; set;
        }

        public ActionType Action
        {
            get; set;
        }
    }

}
