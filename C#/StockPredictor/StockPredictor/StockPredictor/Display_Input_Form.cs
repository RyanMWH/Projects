using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace StockPredictor
{
    public partial class Display_Input_Form : Form
    {
        private List<Candlestick> candlesticks;
        private string filename;

        public Display_Input_Form(List<Candlestick> candlesticks, string filename)
        {
            InitializeComponent();
            this.candlesticks = candlesticks;
            this.filename = filename;

            // Debug: Print the number of candlesticks loaded
            Console.WriteLine("Candlesticks Count: " + candlesticks.Count);
            foreach (var candle in candlesticks)
            {
                Console.WriteLine(candle.ToString());
            }

            LoadCandleStickData();
        }

        private void LoadCandleStickData()
        {
            SetupChart();
            SetupDataGridView();
        }

        private void SetupChart()
        {
            Chart_stock.Series.Clear();
            Series series = new Series(filename)
            {
                ChartType = SeriesChartType.Candlestick,
                XValueType = ChartValueType.DateTime
            };
            
            foreach (var candle in candlesticks)
            {
                var dataPoint = new DataPoint(candle.Date.ToOADate(), new double[] { (double)candle.High, (double)candle.Low, (double)candle.Open, (double)candle.Close });
                if (candle.IsBullish())
                {
                    dataPoint.Color = System.Drawing.Color.Lime; // Green for bullish
                }
                else
                {
                    dataPoint.Color = System.Drawing.Color.Red; // Red for bearish
                    dataPoint.BackSecondaryColor = System.Drawing.Color.Red;
                }
                series.Points.Add(dataPoint);
            }

            Chart_stock.Series.Clear();
            Chart_stock.Series.Add(series);
            Chart_stock.DataBind();

            if (Chart_stock.Legends.Count > 0)
            {
                Chart_stock.Legends[0].Enabled = false;
            }

            // Debug: Print if chart is added
            Console.WriteLine("Chart updated with series points count: " + series.Points.Count);
        }

        private void SetupDataGridView()
        {
            DataGridView_stock.DataSource = new BindingList<Candlestick>(candlesticks);

            // Debug: Print if DataGridView is updated
            Console.WriteLine("DataGridView updated with rows count: " + DataGridView_stock.Rows.Count);
        }
    }
}
