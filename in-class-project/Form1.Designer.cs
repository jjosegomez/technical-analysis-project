namespace in_class_project
{
    partial class Form1
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.comboBoxStockTicker = new System.Windows.Forms.ComboBox();
            this.labelStockTicker = new System.Windows.Forms.Label();
            this.labelPeriod = new System.Windows.Forms.Label();
            this.comboBoxPeriod = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(464, 90);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxStockTicker
            // 
            this.comboBoxStockTicker.AccessibleName = "";
            this.comboBoxStockTicker.FormattingEnabled = true;
            this.comboBoxStockTicker.Items.AddRange(new object[] {
            "STOCK1",
            "STOCK2",
            "STOCK3",
            "STOCK4",
            "STOCK5",
            "STOCK6",
            "STOCK7"});
            this.comboBoxStockTicker.Location = new System.Drawing.Point(101, 90);
            this.comboBoxStockTicker.Name = "comboBoxStockTicker";
            this.comboBoxStockTicker.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStockTicker.TabIndex = 5;
            // 
            // labelStockTicker
            // 
            this.labelStockTicker.AutoSize = true;
            this.labelStockTicker.Location = new System.Drawing.Point(26, 95);
            this.labelStockTicker.Name = "labelStockTicker";
            this.labelStockTicker.Size = new System.Drawing.Size(69, 13);
            this.labelStockTicker.TabIndex = 6;
            this.labelStockTicker.Text = "Stock TIcker";
            // 
            // labelPeriod
            // 
            this.labelPeriod.AutoSize = true;
            this.labelPeriod.Location = new System.Drawing.Point(260, 95);
            this.labelPeriod.Name = "labelPeriod";
            this.labelPeriod.Size = new System.Drawing.Size(37, 13);
            this.labelPeriod.TabIndex = 7;
            this.labelPeriod.Text = "Period";
            // 
            // comboBoxPeriod
            // 
            this.comboBoxPeriod.FormattingEnabled = true;
            this.comboBoxPeriod.Location = new System.Drawing.Point(303, 90);
            this.comboBoxPeriod.Name = "comboBoxPeriod";
            this.comboBoxPeriod.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPeriod.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 292);
            this.Controls.Add(this.comboBoxPeriod);
            this.Controls.Add(this.labelPeriod);
            this.Controls.Add(this.labelStockTicker);
            this.Controls.Add(this.comboBoxStockTicker);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ComboBox comboBoxStockTicker;
        private System.Windows.Forms.Label labelStockTicker;
        private System.Windows.Forms.Label labelPeriod;
        private System.Windows.Forms.ComboBox comboBoxPeriod;
    }
}

