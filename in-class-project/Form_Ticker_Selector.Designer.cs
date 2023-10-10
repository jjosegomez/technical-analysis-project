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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.openFileDialog_LoadTicker = new System.Windows.Forms.OpenFileDialog();
            this.label_Filename = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(614, 100);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Load File";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label_title.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_title.Location = new System.Drawing.Point(372, 29);
            this.label_title.Margin = new System.Windows.Forms.Padding(3);
            this.label_title.MaximumSize = new System.Drawing.Size(200, 400);
            this.label_title.Name = "label_title";
            this.label_title.Padding = new System.Windows.Forms.Padding(10);
            this.label_title.Size = new System.Drawing.Size(199, 126);
            this.label_title.TabIndex = 1;
            this.label_title.Text = "Welcome to my Technical Analysis Project";
            this.label_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Filename
            // 
            this.label_Filename.AutoSize = true;
            this.label_Filename.Location = new System.Drawing.Point(601, 68);
            this.label_Filename.MaximumSize = new System.Drawing.Size(150, 100);
            this.label_Filename.Name = "label_Filename";
            this.label_Filename.Size = new System.Drawing.Size(98, 13);
            this.label_Filename.TabIndex = 2;
            this.label_Filename.Text = "Select a Ticker File";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1011, 340);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_Ticker_Selector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label_Filename);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.buttonSearch);
            this.Name = "Form_Ticker_Selector";
            this.Text = "Ticker Selection";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadTicker;
        private System.Windows.Forms.Label label_Filename;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

