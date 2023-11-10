namespace in_class_project
{
    partial class Form_Ticker_Selector
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
            this.openFileDialog_LoadTicker = new System.Windows.Forms.OpenFileDialog();
            this.label_directions = new System.Windows.Forms.Label();
            this.label_start_date = new System.Windows.Forms.Label();
            this.label_end_date = new System.Windows.Forms.Label();
            this.dateTimePicker_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_StartDate = new System.Windows.Forms.DateTimePicker();
            this.label_title = new System.Windows.Forms.Label();
            this.button_load_stock_data = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog_LoadTicker
            // 
            this.openFileDialog_LoadTicker.Multiselect = true;
            // 
            // label_directions
            // 
            this.label_directions.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_directions.AutoSize = true;
            this.label_directions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_directions.Location = new System.Drawing.Point(85, 201);
            this.label_directions.Name = "label_directions";
            this.label_directions.Size = new System.Drawing.Size(205, 32);
            this.label_directions.TabIndex = 21;
            this.label_directions.Text = "To start choose a date range and\r\nthen select one or more files";
            this.label_directions.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_start_date
            // 
            this.label_start_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_start_date.AutoSize = true;
            this.label_start_date.Location = new System.Drawing.Point(163, 260);
            this.label_start_date.Name = "label_start_date";
            this.label_start_date.Size = new System.Drawing.Size(56, 13);
            this.label_start_date.TabIndex = 20;
            this.label_start_date.Text = "Start date:";
            // 
            // label_end_date
            // 
            this.label_end_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_end_date.AutoSize = true;
            this.label_end_date.Location = new System.Drawing.Point(163, 315);
            this.label_end_date.Name = "label_end_date";
            this.label_end_date.Size = new System.Drawing.Size(53, 13);
            this.label_end_date.TabIndex = 19;
            this.label_end_date.Text = "End date:";
            // 
            // dateTimePicker_EndDate
            // 
            this.dateTimePicker_EndDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_EndDate.Location = new System.Drawing.Point(90, 331);
            this.dateTimePicker_EndDate.Name = "dateTimePicker_EndDate";
            this.dateTimePicker_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_EndDate.TabIndex = 18;
            // 
            // dateTimePicker_StartDate
            // 
            this.dateTimePicker_StartDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker_StartDate.Location = new System.Drawing.Point(90, 277);
            this.dateTimePicker_StartDate.Name = "dateTimePicker_StartDate";
            this.dateTimePicker_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_StartDate.TabIndex = 17;
            // 
            // label_title
            // 
            this.label_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_title.AutoSize = true;
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_title.Location = new System.Drawing.Point(88, 42);
            this.label_title.Margin = new System.Windows.Forms.Padding(3);
            this.label_title.MaximumSize = new System.Drawing.Size(200, 400);
            this.label_title.Name = "label_title";
            this.label_title.Padding = new System.Windows.Forms.Padding(10);
            this.label_title.Size = new System.Drawing.Size(199, 126);
            this.label_title.TabIndex = 16;
            this.label_title.Text = "Welcome to my Technical Analysis Project";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_load_stock_data
            // 
            this.button_load_stock_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_load_stock_data.Location = new System.Drawing.Point(163, 368);
            this.button_load_stock_data.Name = "button_load_stock_data";
            this.button_load_stock_data.Size = new System.Drawing.Size(53, 23);
            this.button_load_stock_data.TabIndex = 15;
            this.button_load_stock_data.Text = "Load";
            this.button_load_stock_data.UseVisualStyleBackColor = true;
            this.button_load_stock_data.Click += new System.EventHandler(this.button_load_stock_data_Click);
            // 
            // Form_Ticker_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 433);
            this.Controls.Add(this.label_directions);
            this.Controls.Add(this.label_start_date);
            this.Controls.Add(this.label_end_date);
            this.Controls.Add(this.dateTimePicker_EndDate);
            this.Controls.Add(this.dateTimePicker_StartDate);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_load_stock_data);
            this.Name = "Form_Ticker_Selector";
            this.Text = "Select your tickers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadTicker;
        private System.Windows.Forms.Label label_directions;
        private System.Windows.Forms.Label label_start_date;
        private System.Windows.Forms.Label label_end_date;
        private System.Windows.Forms.DateTimePicker dateTimePicker_EndDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker_StartDate;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_load_stock_data;
    }
}