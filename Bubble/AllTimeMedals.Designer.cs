namespace Bubble
{
    partial class AllTimeMedals
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.p2_DataDataSet5 = new Bubble.P2_DataDataSet5();
            this.allTimeMedalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.allTimeMedalsTableAdapter = new Bubble.P2_DataDataSet5TableAdapters.AllTimeMedalsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bronzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMedalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTimeMedalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.goldsDataGridViewTextBoxColumn,
            this.silversDataGridViewTextBoxColumn,
            this.bronzesDataGridViewTextBoxColumn,
            this.totalMedalsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.allTimeMedalsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // p2_DataDataSet5
            // 
            this.p2_DataDataSet5.DataSetName = "P2_DataDataSet5";
            this.p2_DataDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // allTimeMedalsBindingSource
            // 
            this.allTimeMedalsBindingSource.DataMember = "AllTimeMedals";
            this.allTimeMedalsBindingSource.DataSource = this.p2_DataDataSet5;
            // 
            // allTimeMedalsTableAdapter
            // 
            this.allTimeMedalsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // goldsDataGridViewTextBoxColumn
            // 
            this.goldsDataGridViewTextBoxColumn.DataPropertyName = "Golds";
            this.goldsDataGridViewTextBoxColumn.HeaderText = "Golds";
            this.goldsDataGridViewTextBoxColumn.Name = "goldsDataGridViewTextBoxColumn";
            // 
            // silversDataGridViewTextBoxColumn
            // 
            this.silversDataGridViewTextBoxColumn.DataPropertyName = "Silvers";
            this.silversDataGridViewTextBoxColumn.HeaderText = "Silvers";
            this.silversDataGridViewTextBoxColumn.Name = "silversDataGridViewTextBoxColumn";
            // 
            // bronzesDataGridViewTextBoxColumn
            // 
            this.bronzesDataGridViewTextBoxColumn.DataPropertyName = "Bronzes";
            this.bronzesDataGridViewTextBoxColumn.HeaderText = "Bronzes";
            this.bronzesDataGridViewTextBoxColumn.Name = "bronzesDataGridViewTextBoxColumn";
            // 
            // totalMedalsDataGridViewTextBoxColumn
            // 
            this.totalMedalsDataGridViewTextBoxColumn.DataPropertyName = "TotalMedals";
            this.totalMedalsDataGridViewTextBoxColumn.HeaderText = "TotalMedals";
            this.totalMedalsDataGridViewTextBoxColumn.Name = "totalMedalsDataGridViewTextBoxColumn";
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(246, 0);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Country";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Golds";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Silvers";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Bronzes";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "TotalMedals";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(909, 390);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(482, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(708, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AllTimeMedals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AllTimeMedals";
            this.Text = "AllTimeMedals";
            this.Load += new System.EventHandler(this.AllTimeMedals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allTimeMedalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private P2_DataDataSet5 p2_DataDataSet5;
        private System.Windows.Forms.BindingSource allTimeMedalsBindingSource;
        private P2_DataDataSet5TableAdapters.AllTimeMedalsTableAdapter allTimeMedalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goldsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silversDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bronzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMedalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}