namespace StockPredictor
{
    partial class Input_Form
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
            this.load_button = new System.Windows.Forms.Button();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(328, 12);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(176, 40);
            this.load_button.TabIndex = 0;
            this.load_button.Text = "Load Stock(s)";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(412, 58);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(392, 31);
            this.endTimePicker.TabIndex = 1;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(12, 58);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(394, 31);
            this.startTimePicker.TabIndex = 2;
            this.startTimePicker.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            this.startTimePicker.ValueChanged += new System.EventHandler(this.starttimepicker_ValueChanged);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Location = new System.Drawing.Point(12, 12);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(110, 25);
            this.startLabel.TabIndex = 3;
            this.startLabel.Text = "Start Time";
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Location = new System.Drawing.Point(700, 12);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(103, 25);
            this.endLabel.TabIndex = 4;
            this.endLabel.Text = "End Time";
            // 
            // Input_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.load_button);
            this.Name = "Input_Form";
            this.Text = "Load Stock";
            this.Load += new System.EventHandler(this.Input_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button load_button;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
    }
}

