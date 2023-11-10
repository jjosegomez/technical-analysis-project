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
        public BindingSource FilterByDateRange(DateTime startDate, DateTime endDate, BindingList<SmartCandleStick> stockData)
        {
            BindingSource filteredData = new BindingSource();
            stockData.Reverse();
            foreach (var cd in stockData)
            {
                if (cd.date >= startDate && cd.date <= endDate)
                {
                    filteredData.Add(cd);
                }
            }

            return filteredData;
        }
        public void SetData(BindingList<SmartCandleStick> stockData, string Ticker, DateTime intial_start_date, DateTime initial_end_date)
        {
            // Set the data source for your chart control
            // For example, if you have a chart control named 'chart1':
            Label_StockName.Text = Ticker;
            bindingSource_stockData.Clear();
            bindingSource_stockData =  FilterByDateRange(intial_start_date, initial_end_date, stockData);

            foreach (SmartCandleStick stock in bindingSource_stockData)
            {
                Console.WriteLine($"{Ticker} {stock.open}, {stock.high}, {stock.low}, {stock.close}");
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
        private void buttonFindPattern_Click(object sender, EventArgs e)
        {
            string Pattern = comboBox_Pattern.Text;
        }
    }

}
