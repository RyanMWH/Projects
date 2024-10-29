namespace StockPredictor
{
    partial class Display_Input_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart_stock = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataGridView_stock = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Chart_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart_stock
            // 
            chartArea2.Name = "ChartArea1";
            this.Chart_stock.ChartAreas.Add(chartArea2);
            this.Chart_stock.IsSoftShadows = false;
            legend2.Name = "Legend1";
            this.Chart_stock.Legends.Add(legend2);
            this.Chart_stock.Location = new System.Drawing.Point(131, 26);
            this.Chart_stock.Name = "Chart_stock";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.Chart_stock.Series.Add(series2);
            this.Chart_stock.Size = new System.Drawing.Size(1036, 385);
            this.Chart_stock.TabIndex = 0;
            this.Chart_stock.Text = "chart1";
            // 
            // DataGridView_stock
            // 
            this.DataGridView_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView_stock.Location = new System.Drawing.Point(131, 537);
            this.DataGridView_stock.Name = "DataGridView_stock";
            this.DataGridView_stock.RowHeadersWidth = 82;
            this.DataGridView_stock.RowTemplate.Height = 33;
            this.DataGridView_stock.Size = new System.Drawing.Size(1036, 300);
            this.DataGridView_stock.TabIndex = 1;
            // 
            // Display_Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 849);
            this.Controls.Add(this.DataGridView_stock);
            this.Controls.Add(this.Chart_stock);
            this.Name = "Display_Input_Form";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataVisualization.Charting.Chart Chart_stock;
        public System.Windows.Forms.DataGridView DataGridView_stock;
    }
}