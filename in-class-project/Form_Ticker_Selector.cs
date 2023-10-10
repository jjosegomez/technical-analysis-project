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
        public class StockData
        {
            private string ticker;
            private string period;
            private DateTime date;
            private decimal open;
            private decimal close;
            private decimal high;
            private decimal low;
            private int volume;

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

            public DateTime Date
            {
                get { return date; }
                set { date = value; }
            }

            public decimal Open
            {
                get { return open; }
                set { open = value; }
            }

            public decimal Close
            {
                get { return close; }
                set { close = value; }
            }

            public decimal High
            {
                get { return high; }
                set { high = value; }
            }

            public decimal Low
            {
                get { return low; }
                set { low = value; }
            }

            public int Volume
            {
                get { return volume; }
                set { volume = value; }
            }

            public StockData(string ticker, string period, DateTime date, decimal open, decimal close, decimal high, decimal low, int volume)
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

        // Rest of your code...


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
                BindingList<StockData> stockDataList;  //this is an array of candlesticks
                using (StreamReader reader = new StreamReader(selectedFilePath))
                {
                    stockDataList = new BindingList<StockData>();
                    dataGridView1.DataSource = stockDataList;
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
                            string s = $"{fields[2]}{fields[3]}".Trim('"');
                            DateTime date = DateTime.Parse("2023-10-03 15:45:30");
                            decimal open = decimal.Parse(fields[4]);
                            decimal close = decimal.Parse(fields[5]);
                            decimal high = decimal.Parse(fields[6]);
                            decimal low = decimal.Parse(fields[7]);
                            int volume = int.Parse(fields[8]);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
