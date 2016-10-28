using OptionsMastery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionsMastery.Test
{

    public class SampleData
    {



        public static List<LinearRegressionStrategy> GetLrosSampleData()
        {
            List<LinearRegressionStrategy> nLROSList = new List<LinearRegressionStrategy>();

            Stock nRsxStock = new Stock( "RSX", "VanEck Vectors Russia ETF", "NYSE" );

            Option nRsxOption1 = new Option( nRsxStock, Option.ContractType.PUT, Option.ActionType.SELL, 
                new DateTime( 2016, 11, 18 ), 1, 19.00, 0.80, new DateTime( 2016, 10, 21 ) );

            Option nRsxOption2 = new Option( nRsxStock, Option.ContractType.PUT, Option.ActionType.SELL,
                new DateTime( 2016, 12, 17 ), 1, 19.00, 0.74, new DateTime( 2016, 11, 18 ) );

            Option nRsxOption3 = new Option( nRsxStock, Option.ContractType.PUT, Option.ActionType.BUY,
                new DateTime( 2016, 12, 17 ), 1, 19.00, 0.54, new DateTime( 2016, 12, 15 ) );

            LinearRegressionStrategy nLROS_RSX = new LinearRegressionStrategy( nRsxStock );
            nLROS_RSX.Add( nRsxOption1 );
            nLROS_RSX.Add( nRsxOption2 );
            nLROS_RSX.Add( nRsxOption3 );

            nLROSList.Add( nLROS_RSX );

            return nLROSList;
        }
    }
}
