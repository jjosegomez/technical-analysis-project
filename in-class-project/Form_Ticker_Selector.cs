using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq; // language integrated query - extract data using C#.
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace in_class_project
{


    public partial class Form_Ticker_Selector : Form
    {
        public class StockData  //candle stick classes
        {
            private string ticker;
            private string period;
            private string date;
            private string open;
            private string close;
            private string high;
            private string low;
            private string volume;

            // Properties to access the fields
            public string Ticker
            {
                get { return ticker; }
                set { ticker = value; }
            }

            public string Period
            {
                get { return period; }
                set { period = value; }
            }

            public string Date
            {
                get { return date; }
                set { date = value; }
            }

            public string Open
            {
                get { return open; }
                set { open = value; }
            }

            public string Close
            {
                get { return close; }
                set { close = value; }
            }

            public string High
            {
                get { return high; }
                set { high = value; }
            }

            public string Low
            {
                get { return low; }
                set { low = value; }
            }

            public string Volume
            {
                get { return volume; }
                set { volume = value; }
            }

            // Constructor
            public StockData(string ticker, string period, string date, string open, string close, string high, string low, string volume)
            {
                this.ticker = ticker;
                this.period = period;
                this.date = date;
                this.open = open;
                this.close = close;
                this.high = high;
                this.low = low;
                this.volume = volume;
            }
        }
        public Form_Ticker_Selector()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.Title = "Open Ticker CSV file";
            openFileDialog.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";

            // file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string selectedFileName = Path.GetFileName(selectedFilePath); // Extract only the filename
                label_Filename.Text = "File:\t" + selectedFileName; // Display the filename in a TextBox
                List<StockData> stockDataList = new List<StockData>();  //this is an array of stockData
                // Open the file for reading
                using (StreamReader reader = new StreamReader(selectedFilePath))
                {
                    string line;
                    int lineCounter = 0;


                    try
                    {
                        while ((line = reader.ReadLine()) != null)
                        {
                            // Skip the first line (lineCounter == 0)
                            if (lineCounter == 0)
                            {
                                lineCounter++;
                                continue;
                            }
                            string[] fields = line.Split(',');
                            string ticker = fields[0].Trim('"');
                            string period = fields[1].Trim('"');
                            string date = fields[2].Trim('"');
                            string open = fields[3].Trim('"');
                            string close = fields[4].Trim('"');
                            string high = fields[5].Trim('"');
                            string low = fields[6].Trim('"');
                            string volume = fields[7].Trim('"');
                            // Process the line (e.g., print it to the console

                            StockData stockData = new StockData(ticker, period, date, open, close, high, low, volume);
                                stockDataList.Add(stockData);
                     

                            lineCounter++;
                        }
                        foreach (var stockData in stockDataList)
                        {
                            Console.WriteLine($"Ticker: {stockData.Ticker}, Period: {stockData.Period}, Date: {stockData.Date}, Open: {stockData.Open}, Close: {stockData.Close}, High: {stockData.High}, Low: {stockData.Low}, Volume: {stockData.Volume}");
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle and log the exception
                        Console.WriteLine($"An error occurred: {ex.Message}");
                    }

                }
            }
        }

    }
}
