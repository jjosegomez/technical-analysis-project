using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq; // language integrated query - extract data using C#.
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace in_class_project
{
    

    public partial class Form_Ticker_Selector : Form
    {
        public class StockData
        {
            public DateTime date;
            public decimal open;
            public decimal close;
            public decimal high;
            public decimal low;
            public decimal volume;

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

            public decimal Volume
            {
                get { return volume; }
                set { volume = value; }
            }

            public StockData(DateTime date, decimal open, decimal close, decimal high, decimal low, int volume)
            {
                this.date = date;
                this.open = open;
                this.close = close;
                this.high = high;
                this.low = low;
                this.volume = volume;
            }

        }

        public class DateConverter
        {
            public static string ConvertToCustomFormat(string inputDate)
            {
                DateTime parsedDate;

                if (DateTime.TryParseExact(inputDate, "MMMM d yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate))
                {
                    return parsedDate.ToString("yyyy-MM-dd HH:mm:ss");
                }
                else
                {
                    return "Invalid Date Format";
                }
            }
        }

        public Form_Ticker_Selector()
        {
            InitializeComponent();

                // Subscribe to the ValueChanged events of date pickers
        }

        BindingList<StockData> stockDataList;  //this is an array of candlesticks
        BindingSource bindingSource = new BindingSource();

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // to refresh the chart
            openFileDialog.Title = "Open Ticker CSV file";
            openFileDialog.Filter = "All Files|*.csv|Daily Stock|*-Day.csv|Weekly Stock|*-Week.csv|Monthly Stock|*-Month.csv";

            chart1.DataSource = bindingSource;
            chart1.DataBind();

            // file was selected
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DateTime startDate = dateTimePicker_StartDate.Value;
                DateTime endDate = dateTimePicker_EndDate.Value;
                string selectedFilePath = openFileDialog.FileName;
                string selectedFileName = Path.GetFileName(selectedFilePath); // Extract only the filename
                label_Filename.Text = "File:\t" + selectedFileName; // Display the filename in a TextBox
                List<StockData> rawData;
                using (StreamReader reader = new StreamReader(selectedFilePath))
                {
                    rawData = new List<StockData>();
                    stockDataList = new BindingList<StockData>();
                    string line;
                    int lineCounter = 0;
                    string stockTicker = "";
                    string stockPeriod = "";
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

                            stockTicker = fields[0].Trim('"');
                            stockPeriod = fields[1].Trim('"');
                            string s = $"{fields[2]}{fields[3]}".Trim('"');
                            DateTime date = DateTime.Parse(s);
                            decimal open = decimal.Parse(fields[4]);
                            decimal close = decimal.Parse(fields[5]);
                            decimal high = decimal.Parse(fields[6]);
                            decimal low = decimal.Parse(fields[7]);
                            int volume = int.Parse(fields[8]);
                            // Process the line (e.g., print it to the console

                            StockData stockData = new StockData(date, open, close, high, low, volume);
                            rawData.Add(stockData);

                            lineCounter++;
                        }

                        rawData.Reverse();
                        //filter the data from rawData using the date ranges.
                        foreach (var stockData in rawData)
                        {
                            if (stockData.date >= startDate && stockData.date <= endDate)
                            {
                                stockDataList.Add(stockData);
                            }

                            if (stockData.date > endDate)
                            {
                                break;
                            }
                        }

                        foreach (var stockData in stockDataList)
                        {
                            Console.WriteLine($"Ticker: {stockTicker}, Period: {stockPeriod}, Date: {stockData.Date}, Open: {stockData.Open}, Close: {stockData.Close}, High: {stockData.High}, Low: {stockData.Low}, Volume: {stockData.Volume}");
                        }

                        // stockData should be only the data in the date range
                        dataGridView1.DataSource = stockDataList;

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

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog_LoadTicker_FileOk(object sender, CancelEventArgs e)
        {

        }

    }
}
