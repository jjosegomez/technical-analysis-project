﻿namespace in_class_project
{
    partial class Form_Ticker_Chart
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ChartDateTimePicker_Start = new System.Windows.Forms.DateTimePicker();
            this.ChartDateTimePicker_End = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FilteredStockDataList = new System.Windows.Forms.BindingSource(this.components);
            this.button_refresh = new System.Windows.Forms.Button();
            this.TickerChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Label_StockName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FilteredStockDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickerChart)).BeginInit();
            this.SuspendLayout();
            // 
            // ChartDateTimePicker_Start
            // 
            this.ChartDateTimePicker_Start.Location = new System.Drawing.Point(94, 84);
            this.ChartDateTimePicker_Start.Name = "ChartDateTimePicker_Start";
            this.ChartDateTimePicker_Start.Size = new System.Drawing.Size(200, 20);
            this.ChartDateTimePicker_Start.TabIndex = 0;
            // 
            // ChartDateTimePicker_End
            // 
            this.ChartDateTimePicker_End.Location = new System.Drawing.Point(337, 84);
            this.ChartDateTimePicker_End.Name = "ChartDateTimePicker_End";
            this.ChartDateTimePicker_End.Size = new System.Drawing.Size(200, 20);
            this.ChartDateTimePicker_End.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "FROM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "TO";
            // 
            // button_refresh
            // 
            this.button_refresh.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_refresh.Location = new System.Drawing.Point(549, 76);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(34, 35);
            this.button_refresh.TabIndex = 0;
            this.button_refresh.Text = "↻";
            this.button_refresh.UseVisualStyleBackColor = false;
            // 
            // TickerChart
            // 
            chartArea1.Name = "ChartArea_CandleSticks";
            chartArea2.Name = "ChartArea_Volume";
            this.TickerChart.ChartAreas.Add(chartArea1);
            this.TickerChart.ChartAreas.Add(chartArea2);
            this.TickerChart.DataSource = this.FilteredStockDataList;
            legend1.Name = "Legend1";
            this.TickerChart.Legends.Add(legend1);
            this.TickerChart.Location = new System.Drawing.Point(16, 124);
            this.TickerChart.Name = "TickerChart";
            series1.ChartArea = "ChartArea_CandleSticks";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.CustomProperties = "PriceDownColor=Red, PriceUpColor=Lime, LabelValueType=High";
            series1.Legend = "Legend1";
            series1.Name = "Price";
            series1.YValuesPerPoint = 4;
            series2.ChartArea = "ChartArea_Volume";
            series2.Legend = "Legend1";
            series2.Name = "Volume";
            this.TickerChart.Series.Add(series1);
            this.TickerChart.Series.Add(series2);
            this.TickerChart.Size = new System.Drawing.Size(588, 347);
            this.TickerChart.TabIndex = 4;
            this.TickerChart.Text = "chart1";
            // 
            // Label_StockName
            // 
            this.Label_StockName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_StockName.AutoSize = true;
            this.Label_StockName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_StockName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Label_StockName.Location = new System.Drawing.Point(229, 31);
            this.Label_StockName.Name = "Label_StockName";
            this.Label_StockName.Size = new System.Drawing.Size(164, 31);
            this.Label_StockName.TabIndex = 5;
            this.Label_StockName.Text = "StockName";
            this.Label_StockName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_Ticker_Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 499);
            this.Controls.Add(this.Label_StockName);
            this.Controls.Add(this.TickerChart);
            this.Controls.Add(this.button_refresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ChartDateTimePicker_End);
            this.Controls.Add(this.ChartDateTimePicker_Start);
            this.Name = "Form_Ticker_Chart";
            ((System.ComponentModel.ISupportInitialize)(this.FilteredStockDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TickerChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource FilteredStockDataList;
        private System.Windows.Forms.DateTimePicker ChartDateTimePicker_Start;
        private System.Windows.Forms.DateTimePicker ChartDateTimePicker_End;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.DataVisualization.Charting.Chart TickerChart;
        private System.Windows.Forms.Label Label_StockName;
    }
}