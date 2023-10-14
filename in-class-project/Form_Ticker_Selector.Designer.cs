using System.Drawing;

namespace in_class_project
{
    partial class Form_Ticker_Selector : System.Windows.Forms.Form
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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.openFileDialog_LoadTicker = new System.Windows.Forms.OpenFileDialog();
            this.label_Filename = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label_table_title = new System.Windows.Forms.Label();
            this.label_chart_title = new System.Windows.Forms.Label();
            this.label_end_date = new System.Windows.Forms.Label();
            this.label_start_date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.Location = new System.Drawing.Point(538, 123);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 27);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Load File";
            this.buttonSearch.UseCompatibleTextRendering = true;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_title.AutoSize = true;
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_title.Location = new System.Drawing.Point(194, 17);
            this.label_title.Margin = new System.Windows.Forms.Padding(3);
            this.label_title.MaximumSize = new System.Drawing.Size(200, 400);
            this.label_title.Name = "label_title";
            this.label_title.Padding = new System.Windows.Forms.Padding(10);
            this.label_title.Size = new System.Drawing.Size(199, 126);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Welcome to my Technical Analysis Project";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog_LoadTicker
            // 
            this.openFileDialog_LoadTicker.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_LoadTicker_FileOk);
            // 
            // label_Filename
            // 
            this.label_Filename.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Filename.AutoSize = true;
            this.label_Filename.Location = new System.Drawing.Point(413, 130);
            this.label_Filename.MaximumSize = new System.Drawing.Size(150, 100);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Size = new System.Drawing.Size(101, 13);
            this.label_Filename.TabIndex = 2;
            this.label_Filename.Text = "Select a Ticker File:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(82, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(654, 123);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(413, 34);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_StartDate.TabIndex = 0;
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(413, 88);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_EndDate.TabIndex = 4;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.Name = "ChartAreaPrice";
            chartArea2.AlignWithChartArea = "ChartAreaPrice";
            chartArea2.Name = "ChartAreaVolume";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.DataSource = this.bindingSource1;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(48, 340);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartAreaPrice";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series1.Legend = "Legend1";
            series1.Name = "SeriesPrice";
            series1.XValueMember = "0";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series1.YValueMembers = "0";
            series1.YValuesPerPoint = 4;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartAreaVolume";
            series2.LabelForeColor = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.Name = "SeriesVolume";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(721, 376);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            title1.Name = "Price";
            title2.Name = "Volume";
            this.chart1.Titles.Add(title1);
            this.chart1.Titles.Add(title2);
            this.chart1.Click += new System.EventHandler(this.chart1_Click_1);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // label_table_title
            // 
            this.label_table_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_table_title.AutoSize = true;
            this.label_table_title.Location = new System.Drawing.Point(79, 168);
            this.label_table_title.Name = "label_table_title";
            this.label_table_title.Size = new System.Drawing.Size(91, 13);
            this.label_table_title.TabIndex = 6;
            this.label_table_title.Text = "Stock Data Table";
            // 
            // label_chart_title
            // 
            this.label_chart_title.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_chart_title.AutoSize = true;
            this.label_chart_title.Location = new System.Drawing.Point(48, 314);
            this.label_chart_title.Name = "label_chart_title";
            this.label_chart_title.Size = new System.Drawing.Size(152, 13);
            this.label_chart_title.TabIndex = 7;
            this.label_chart_title.Text = "Chart For Stock Data Selected";
            // 
            // label_end_date
            // 
            this.label_end_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_end_date.AutoSize = true;
            this.label_end_date.Location = new System.Drawing.Point(413, 69);
            this.label_end_date.Name = "label_end_date";
            this.label_end_date.Size = new System.Drawing.Size(53, 13);
            this.label_end_date.TabIndex = 8;
            this.label_end_date.Text = "End date:";
            // 
            // label_start_date
            // 
            this.label_start_date.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_start_date.AutoSize = true;
            this.label_start_date.Location = new System.Drawing.Point(413, 15);
            this.label_start_date.Name = "label_start_date";
            this.label_start_date.Size = new System.Drawing.Size(56, 13);
            this.label_start_date.TabIndex = 9;
            this.label_start_date.Text = "Start date:";
            // 
            // Form_Ticker_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 782);
            this.Controls.Add(this.label_start_date);
            this.Controls.Add(this.label_end_date);
            this.Controls.Add(this.label_chart_title);
            this.Controls.Add(this.label_table_title);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Filename);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Form_Ticker_Selector";
            this.Text = "t";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadTicker;
        private System.Windows.Forms.Label label_Filename;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_table_title;
        private System.Windows.Forms.Label label_chart_title;
        private System.Windows.Forms.Label label_end_date;
        private System.Windows.Forms.Label label_start_date;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}

