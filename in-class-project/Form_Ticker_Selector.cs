using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace in_class_project
{
    public partial class Form_Ticker_Selector : Form
    {
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
        }


        public BindingList<SmartCandleStick> loadCandleStickData(string selectedFilePath)
        {
            BindingList<SmartCandleStick> stockDataList = new BindingList<SmartCandleStick>();
            using (StreamReader reader = new StreamReader(selectedFilePath))
            {
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
                        decimal high = decimal.Parse(fields[5]);
                        decimal low = decimal.Parse(fields[6]);
                        decimal close = decimal.Parse(fields[7]);
                        int volume = int.Parse(fields[8]);
                        // Process the line (e.g., print it to the console

                        SmartCandleStick stockData = new SmartCandleStick(date, open, high, low, close, volume);
                        stockDataList.Add(stockData);
                        lineCounter++;
                    }

                    // stockData should be only the data in the date 


                }
                catch (Exception ex)
                {
                    // Handle and log the exception
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }

            }
            return stockDataList;
        }

        List<BindingList<SmartCandleStick>> AllFilesList;
        // this function load all the data of all the files an returns a list of list of CandleSticks
        private void button_load_stock_data_Click(object sender, EventArgs e)
        {
            AllFilesList = new List<BindingList<SmartCandleStick>>();
            openFileDialog_LoadTicker.Title = "Open Ticker CSV file";
            openFileDialog_LoadTicker.Filter = "All Files|*.csv|Daily Stock|*-Day.csv|Weekly Stock|*-Week.csv|Monthly Stock|*-Month.csv";

            // file was selected
            if (openFileDialog_LoadTicker.ShowDialog() == DialogResult.OK)
            {

                string[] selectedFiles = openFileDialog_LoadTicker.FileNames;

                foreach (var file in selectedFiles)
                {
                    OpenNewFormWithData(loadCandleStickData(file), Path.GetFileName(file));
                }
            }
        }
        // for each file I need to load a form with all the data
        public void OpenNewFormWithData(BindingList<SmartCandleStick> stockData, string Ticker)
        {
            Form_Ticker_Chart newForm = new Form_Ticker_Chart();
            newForm.Show();
            newForm.SetData(stockData, Ticker, dateTimePicker_StartDate.Value, dateTimePicker_EndDate.Value); // Pass the stock data to the new form
        }

        //function to make annotations for candlesticks patterns
    }
}