using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class GetStockData
    {
        #region Fields
        List<string> csvFile;
        

        #endregion

        #region Methods

        public List<string> ReadFromCSV()
        {

            csvFile = new List<string>();

            string csvData;

            WebClient web = new WebClient()
            {
                csvData = web.DownloadString("http://finance.yahoo.com/d/quotes.csv?s=AAPL+GOOG+MSFT&f=snbaopl1");
            }
            
            csvFile.Add(csvData);

            return csvFile;
        }

        #endregion


    }
}
