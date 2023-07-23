using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockFromInternet
{
    public class StockExchange
    {
        public delegate void PriceChange (int price);
        public PriceChange PriceChangeHandler { get; set; }

        public void Start()
        {
            while (true) 
            {
            int SberbankPrice  = (new Random()).Next(50,100);
                PriceChangeHandler(SberbankPrice);
                Thread.Sleep(2000);


            }

        }

    }
}
