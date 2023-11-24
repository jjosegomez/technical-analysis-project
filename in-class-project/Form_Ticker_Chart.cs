using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static in_class_project.Form_Ticker_Selector;
using System.Windows.Forms.DataVisualization.Charting;

namespace in_class_project
{
    public partial class Form_Ticker_Chart : Form
    {
        public Form_Ticker_Chart()
        {
            InitializeComponent();
        }
        BindingList<SmartCandleStick> stockDataList = new BindingList<SmartCandleStick>();
        public BindingSource FilterByDateRange(DateTime startDate, DateTime endDate, BindingList<SmartCandleStick> stockData)
        {
            BindingSource filteredData = new BindingSource();
            
            foreach (var cd in stockData)
            {
                if (cd.date >= startDate && cd.date <= endDate)
                {
                    filteredData.Add(cd);
                }
            }
            stockDataList = stockData;
            return filteredData;
        }
        public void SetData(BindingList<SmartCandleStick> stockData, string Ticker, DateTime intial_start_date, DateTime initial_end_date)
        {
            // Set the data source for your chart 
            stockData = new BindingList<SmartCandleStick>(stockData.OrderBy(cd => cd.date).ToList());

            Label_StockName.Text = Ticker;
            bindingSource_stockData.Clear();
            bindingSource_stockData =  FilterByDateRange(intial_start_date, initial_end_date, stockData);

            foreach (SmartCandleStick stock in bindingSource_stockData)
            {
                Console.WriteLine($"{Ticker}, {stock.date} {stock.open}, {stock.high}, {stock.low}, {stock.close}");
            }

            TickerChart.DataSource = bindingSource_stockData;

            // Configure the chart series
            TickerChart.Series[0].XValueMember = "Date";
            TickerChart.Series[0].YValueMembers = "Open,High,Low,Close";
            TickerChart.Series[0].ChartType = SeriesChartType.Candlestick;
            
            if (bindingSource_stockData.Count > 0)
            { 
                double minY = (double)bindingSource_stockData.OfType<SmartCandleStick>().Min(cd => cd.low);
                double maxY = (double)bindingSource_stockData.OfType<SmartCandleStick>().Max(cd => cd.high);
                // Set Y-axis range
                TickerChart.ChartAreas[0].AxisY.Minimum = minY;
                TickerChart.ChartAreas[0].AxisY.Maximum = maxY;
            }


            // Format Y-axis labels to display two decimal places
            TickerChart.ChartAreas[0].AxisY.LabelStyle.Format = "F2";

            // Update the chart
            TickerChart.DataBind();

            // Create series for Price and Volume chart areas
            Series priceSeries = TickerChart.Series[0];
            priceSeries.ChartType = SeriesChartType.Candlestick;
            priceSeries.XValueType = ChartValueType.Date;

            Series volumeSeries = TickerChart.Series[1];
            volumeSeries.ChartType = SeriesChartType.Column;
            volumeSeries.XValueType = ChartValueType.Date;

            TickerChart.Series[0].Points.Clear();
            TickerChart.Series[1].Points.Clear();

            // Add data points to the Candlestick and Column series
            foreach (SmartCandleStick cd in bindingSource_stockData)
            {
                // Add data points to Candlestick series
                DataPoint priceDataPoint = new DataPoint();
                priceDataPoint.XValue = cd.date.ToOADate();
                priceDataPoint.YValues = new double[] { (double)cd.high, (double)cd.low, (double)cd.open, (double)cd.close };
                //priceDataPoint.SetValueXY(stockData.Date, (double)stockData.High, (double)stockData.Low, (double)stockData.Close, (double)stockData.Open);
                

                priceSeries.Points.Add(priceDataPoint);

                // Add data points to Volume series
                DataPoint volumeDataPoint = new DataPoint();
                volumeDataPoint.XValue = cd.date.ToOADate();
                volumeDataPoint.SetValueY((double)cd.volume);
                volumeSeries.Points.Add(volumeDataPoint);
            }
        }

        private void ChangeDateRangeAndRefresh(DateTime startDate, DateTime endDate)
        {
            // Filter the data based on the new date range
            bindingSource_stockData = FilterByDateRange(startDate, endDate, stockDataList);

            // Update the chart series with the filtered data
            UpdateChartSeries(bindingSource_stockData);
        }

        private void UpdateChartSeries(BindingSource dataSource)
        {
            // Clear existing annotations
            TickerChart.Annotations.Clear();

            // Set the data source for the chart
            TickerChart.DataSource = dataSource;

            // Configure the chart series
            TickerChart.Series[0].XValueMember = "Date";
            TickerChart.Series[0].YValueMembers = "Open,High,Low,Close";
            TickerChart.Series[0].ChartType = SeriesChartType.Candlestick;

            // Clear existing points in the series
            TickerChart.Series[0].Points.Clear();
            TickerChart.Series[1].Points.Clear();

            // Update the chart
            TickerChart.DataBind();

            // Create series for Price and Volume chart areas
            Series priceSeries = TickerChart.Series[0];
            priceSeries.ChartType = SeriesChartType.Candlestick;
            priceSeries.XValueType = ChartValueType.Date;

            Series volumeSeries = TickerChart.Series[1];
            volumeSeries.ChartType = SeriesChartType.Column;
            volumeSeries.XValueType = ChartValueType.Date;

            // Add data points to the Candlestick and Column series
            foreach (SmartCandleStick cd in dataSource)
            {
                // Add data points to Candlestick series
                DataPoint priceDataPoint = new DataPoint();
                priceDataPoint.XValue = cd.date.ToOADate();
                priceDataPoint.YValues = new double[] { (double)cd.high, (double)cd.low, (double)cd.open, (double)cd.close };

                priceSeries.Points.Add(priceDataPoint);

                // Add data points to Volume series
                DataPoint volumeDataPoint = new DataPoint();
                volumeDataPoint.XValue = cd.date.ToOADate();
                volumeDataPoint.SetValueY((double)cd.volume);
                volumeSeries.Points.Add(volumeDataPoint);
            }


            // Redraw the chart
            TickerChart.Invalidate();
        }


        // creating the recognizerList and adding the recognizers created.
        private void button_refresh_Click(object sender, EventArgs e)
        {
            ChangeDateRangeAndRefresh(RefreshDateTimePicker_Start.Value,RefreshDateTimePicker_End.Value);
        }

        // change function so it takes the index of the combobox selected. make a comboBox on change event to update the variable holding the recognizer
        // return a list of integers (index) that correspond to the pattern found.
        // make a list of recognizer so we can loop use the index of the recognizerList to call the recognizer both recognizer list and the combobox should have the same options in the same orde for it to work.
        List<Recognizer> recognizersList = new List<Recognizer>();
        
        //populate the array of recognizers this have to be in the same oreder than in the combo box so the index corresponds to the recgonzier
        public void populateRecognizerList() { 
            recognizersList.Clear(); // to save space clear every time the combobox is hit
            //Bullish
            recognizersList.Add(new BullishRecognizer());
            //Bearish
            recognizersList.Add(new BearishRecognizer());
            //Neutral
            recognizersList.Add(new NeutralRecognizer());
            //Marubozu
            recognizersList.Add(new MarubozuRecognizer());
            //Doji
            recognizersList.Add(new DojiRecognizer());
            //DragonflyDoji
            recognizersList.Add(new DragonflyDojiRecognizer());
            //GravestoneDoji
            recognizersList.Add(new GravestoneDojiRecognizer());
            //Hammer
            recognizersList.Add(new HammerRecognizer());
            //InvertedHammer
            recognizersList.Add(new InvertedHammerRecognizer());
            //Peak
            recognizersList.Add(new PeakRecognizer());
            //Valley
            recognizersList.Add(new ValleyRecognizer());
        }
        private void buttonFindPattern_Click(object sender, EventArgs e)
        {

            TickerChart.Annotations.Clear();
            List<int> indexes = new List<int>();
            populateRecognizerList();
            if (comboBox_Pattern.Text == "")
            {
                return;
            }
            bool isPattern = new bool();
            List<SmartCandleStick> tempList = new List<SmartCandleStick>();
            int i = new int();
            for (i = 0; i < bindingSource_stockData.Count - 2; i++)
            {
                tempList.Clear();

                // Accumulate the next three candlesticks in the tempList
                tempList.Add((SmartCandleStick)bindingSource_stockData[i]);
                tempList.Add((SmartCandleStick)bindingSource_stockData[i + 1]);
                tempList.Add((SmartCandleStick)bindingSource_stockData[i + 2]);

                // Recognize patterns for the sequence of candlesticks
                isPattern = recognizersList[recognizerSelected].RecognizePattern(tempList);

                if (isPattern) { AddAnnotation(i); }
            }

            if (comboBox_Pattern.Text == "Valley" || comboBox_Pattern.Text == "Peak") { return;  }
            
            //handling last 2 of the list
            int secondTolastIdx = i;
            int lastIdx = i + 1;
            SmartCandleStick secondTolast = (SmartCandleStick)bindingSource_stockData[secondTolastIdx];
            SmartCandleStick last = (SmartCandleStick)bindingSource_stockData[lastIdx];
            tempList.Clear();
            tempList.Add(secondTolast);
            isPattern = recognizersList[recognizerSelected].RecognizePattern(tempList);
            if (isPattern) { AddAnnotation(secondTolastIdx); }
            tempList.Clear();
            tempList.Add(last);
            isPattern = recognizersList[recognizerSelected].RecognizePattern(tempList);
            if (isPattern) { AddAnnotation(lastIdx); }

        }

        private void AddAnnotation(int index)
        {
            // fix annotations when peak or valley
            if (comboBox_Pattern.Text == "Valley" || comboBox_Pattern.Text == "Peak")
            {
                index = index + 1;
            }

            TextAnnotation annotation = new TextAnnotation();

            // Customize the annotation based on the data point
            annotation.Text = $"{comboBox_Pattern.Text}";
            annotation.AnchorDataPoint = TickerChart.Series[0].Points[index];
            annotation.ForeColor = Color.Aqua;
            annotation.BackColor = Color.Black;
            annotation.Font = new Font("Arial", 10);

            // Add the annotation to the chart's annotations collection
            TickerChart.Annotations.Add(annotation);
        }

        int recognizerSelected = new int();
        private void comboBox_Pattern_SelectedIndexChanged(object sender, EventArgs e)
        {
            recognizerSelected = comboBox_Pattern.SelectedIndex;
        }
    }

}
