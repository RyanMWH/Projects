using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPredictor
{
    public partial class Input_Form : Form
    {
        public Input_Form()
        {
            InitializeComponent();
            openFileDialog_load = new OpenFileDialog();
            openFileDialog_load.FileOk += OpenFileDialog_load_FileOk;

            openFileDialog_load.Filter = "CSV Files (*.csv)|*.csv";
            openFileDialog_load.Title = "File Selection";
            openFileDialog_load.InitialDirectory = "C:\\";
            openFileDialog_load.RestoreDirectory = false;
            openFileDialog_load.ShowHelp = false;
        }

        private void OpenFileDialog_load_FileOk(object sender, CancelEventArgs e)
        {
            var filepath = openFileDialog_load.FileName;
            var fileName = Path.GetFileNameWithoutExtension(filepath);
            List<Candlestick> allCandleSticks = CandlestickLoader.LoadFromCSV(filepath);
            

            //Properties
            

            DateTime startDate = DateTimePicker_start.Value;
            DateTime endDate = DateTimePicker_end.Value;

            List<Candlestick> filteredCandlesticks = FilteredCandlesticks(allCandleSticks, startDate, endDate);
            Console.WriteLine($"Loaded {filteredCandlesticks.Count} filtered candlesticks.");
            BindingList<Candlestick> boundList = new BindingList<Candlestick>(filteredCandlesticks);
            Display_Input_Form display_Input_Form = new Display_Input_Form(filteredCandlesticks, fileName);
            display_Input_Form.Text = fileName;
            display_Input_Form.DataGridView_stock.DataSource = boundList;
            display_Input_Form.Chart_stock.DataSource = boundList;
            display_Input_Form.Show();

        }

        private void Input_Form_Load(object sender, EventArgs e)
        {

        }

        private void starttimepicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void endTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void load_button_Click(object sender, EventArgs e)
        {
            openFileDialog_load.ShowDialog();
        }

        public static List<Candlestick> FilteredCandlesticks(List<Candlestick> candlesticks, DateTime startDate, DateTime endDate)
        {
            var filteredCandlesticks = new List<Candlestick>();

            foreach (var candlestick in candlesticks)
            {
                if (candlestick.Date >= startDate && candlestick.Date <= endDate)
                {
                    filteredCandlesticks.Add(candlestick);
                }
                if (candlestick.Date >= endDate)
                {
                    break;
                }
            }
            return filteredCandlesticks;
        }
    }
}
