using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPredictor
{
    public static class CandlestickLoader
    {
        public static List<Candlestick> LoadFromCSV(string filePath)
        {
            var candlesticks = new List<Candlestick>();

            using (var reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    var values = line.Split(',');
                    values[0] = values[0].Trim('"');
                    Console.WriteLine("CSV Line: " + line);

                    if (DateTime.TryParse(values[0], out DateTime dateTime) &&
                        decimal.TryParse(values[1], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal open) &&
                        decimal.TryParse(values[4], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal close) &&
                        decimal.TryParse(values[2], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal high) &&
                        decimal.TryParse(values[3], NumberStyles.Any, CultureInfo.InvariantCulture, out decimal low) &&
                        long.TryParse(values[5], out long volume))
                    {
                        candlesticks.Add(new Candlestick(dateTime, open, close, high, low, volume));
                    }
                    else
                    {
                        // Debug: Print if any parse fails
                        Console.WriteLine("Failed to parse line: " + line);
                    }
                }
                if (candlesticks[0].Date > candlesticks[1].Date)
                {
                    candlesticks.Reverse();
                }


            }
            Console.WriteLine("Total candlesticks loaded: " + candlesticks.Count);
            return candlesticks;
        }
    }
}
