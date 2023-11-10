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
        public void FilterByDateRange(DateTime startDate, DateTime endDate, BindingList<CandleStick> stockData)
        {
            foreach (var cd in stockData)
            {
                if (cd.date >= startDate && cd.date <= endDate)
                {
                    FilteredStockDataList.Add(cd);
                }

                if (cd.date > endDate)
                {
                    break;
                }
            }
        }
        public void SetData(BindingList<CandleStick> stockData, string Ticker, DateTime intial_start_date, DateTime initial_end_date)
        {
            // Set the data source for your chart control
            // For example, if you have a chart control named 'chart1':
            Label_StockName.Text = Ticker;

            FilterByDateRange(intial_start_date, initial_end_date, stockData);

            foreach(CandleStick stock in FilteredStockDataList)
            {
                Console.WriteLine($"{Ticker} {stock.open}, {stock.high}, {stock.low}, {stock.close}");
            }

            TickerChart.DataSource = FilteredStockDataList;
            // Update the chart control to reflect the new data
            TickerChart.DataBind();
        }
    }
    
}
