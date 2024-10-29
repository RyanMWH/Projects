using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPredictor
{
    public class Candlestick
    {
        // Properties of the Candlestick
        public DateTime Date { get; set; }  
        public decimal Open { get; set; }       
        public decimal Close { get; set; }    
        public decimal High { get; set; }       
        public decimal Low { get; set; }       
        public long Volume { get; set; }        

        //Constructor
        public Candlestick(DateTime date, decimal open, decimal close, decimal high, decimal low, long volume)
        {
            Date = date;
            Open = open;
            Close = close;
            High = high;
            Low = low;
            Volume = volume;
        }

        // Method to determine if the candlestick is bullish
        public bool IsBullish()
        {
            return Close > Open;
        }

        // Method to determine if the candlestick is bearish
        public bool IsBearish()
        {
            return Close < Open;
        }

        // Method to calculate the range of the candlestick
        public decimal Range()
        {
            return High - Low;
        }

        // Override ToString method for easy debugging
        public override string ToString()
        {
            return $"{Date}: Open={Open}, Close={Close}, High={High}, Low={Low}, Volume={Volume}, Bullish={IsBullish()}";
        }
    }
}

