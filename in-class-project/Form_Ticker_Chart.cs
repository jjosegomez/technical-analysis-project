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
        // takes input from a combo box and checks all the data points that correspond to that pattern.
        // for example if pattern = Bullish then it looks for all the SmartCandleSticks where isBullish return true and make an annotation.
        private void buttonFindPattern_Click(object sender, EventArgs e)
        {
            string pattern = $"Is{comboBox_Pattern.Text}"; // Ensure the pattern name starts with "Is"

            // Get the method info for the pattern method
            var methodInfo = typeof(SmartCandleStick).GetMethod(pattern);

            // Check if the method exists
            if (methodInfo != null)
            {
                TickerChart.Annotations.Clear();
                Console.WriteLine(pattern);

                // Get the list of SmartCandleSticks from the binding source
                List<SmartCandleStick> smartCandleSticks = bindingSource_stockData.OfType<SmartCandleStick>().ToList();

                // Find data points that match the pattern
                foreach (var cd in smartCandleSticks)
                {
                    bool isPattern = (bool)methodInfo.Invoke(cd, null);

                    if (isPattern)
                    {
                        // Add annotation for the matching data point
                        Console.WriteLine($"Match found for {comboBox_Pattern.Text} at {cd.date}");
                        AddAnnotation(cd);
                    }
                }

                // Redraw the chart
                TickerChart.Invalidate();
            }
            else
            {
                Console.WriteLine("Pattern method not found.");
            }
        }


        private void AddAnnotation(SmartCandleStick cd)
        {
            TextAnnotation annotation = new TextAnnotation();

            // Customize the annotation based on the data point
            annotation.Text = $"{comboBox_Pattern.Text}";
            annotation.X = cd.date.ToOADate();
            annotation.Y = (double)cd.high; // You can customize this based on your data
            annotation.ForeColor = Color.Red;
            annotation.Font = new Font("Arial", 10);

            // Add the annotation to the chart's annotations collection
            TickerChart.Annotations.Add(annotation);
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


        private void button_refresh_Click(object sender, EventArgs e)
        {
            ChangeDateRangeAndRefresh(RefreshDateTimePicker_Start.Value,RefreshDateTimePicker_End.Value);
        }
    }

}
