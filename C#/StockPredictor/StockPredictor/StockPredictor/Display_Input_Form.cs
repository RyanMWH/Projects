﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockPredictor
{
    public partial class Display_Input_Form : Form
    {
        public Display_Input_Form(List<Candlestick> candlesticks)
        {
            InitializeComponent();
            LoadCandleStickData(candlesticks);
        }
        private void LoadCandleStickData(List<Candlestick> candlesticks)
    }
}
