using System;
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
    public partial class Input_Form : Form
    {
        private OpenFileDialog openFileDialog_load;
        public Input_Form()
        {
            InitializeComponent();
            openFileDialog_load = new OpenFileDialog();
            openFileDialog_load.FileOk += OpenFileDialog_load_FileOk;
        }

        private void OpenFileDialog_load_FileOk(object sender, CancelEventArgs e)
        {
            Text = openFileDialog_load.FileName;

            Display_Input_Form display_Input_Form = new Display_Input_Form();
            display_Input_Form.ShowDialog();
            display_Input_Form.Text = Text;
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
    }
}
