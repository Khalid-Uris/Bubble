namespace Bubble
{
    partial class ColunmnsChart
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
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bronzeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.top10CountrysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2_DataDataSet1 = new Bubble.P2_DataDataSet1();
            this.top20CountrysBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.p2_DataDataSet = new Bubble.P2_DataDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.top20CountrysTableAdapter = new Bubble.P2_DataDataSetTableAdapters.Top20CountrysTableAdapter();
            this.top10CountrysTableAdapter = new Bubble.P2_DataDataSet1TableAdapters.Top10CountrysTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10CountrysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.top20CountrysBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.AxisX.Interval = 1D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(351, 0);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Country";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Bronze";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Gold";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Silver";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Total Medal";
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Size = new System.Drawing.Size(782, 428);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title2.Name = "Top 20 Country";
            this.chart1.Titles.Add(title2);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.bronzeDataGridViewTextBoxColumn,
            this.goldDataGridViewTextBoxColumn,
            this.silverDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.top10CountrysBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(345, 490);
            this.dataGridView1.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // countryDataGridViewTextBoxColumn
            // 
            this.countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            this.countryDataGridViewTextBoxColumn.HeaderText = "Country";
            this.countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            // 
            // bronzeDataGridViewTextBoxColumn
            // 
            this.bronzeDataGridViewTextBoxColumn.DataPropertyName = "Bronze";
            this.bronzeDataGridViewTextBoxColumn.HeaderText = "Bronze";
            this.bronzeDataGridViewTextBoxColumn.Name = "bronzeDataGridViewTextBoxColumn";
            // 
            // goldDataGridViewTextBoxColumn
            // 
            this.goldDataGridViewTextBoxColumn.DataPropertyName = "Gold";
            this.goldDataGridViewTextBoxColumn.HeaderText = "Gold";
            this.goldDataGridViewTextBoxColumn.Name = "goldDataGridViewTextBoxColumn";
            // 
            // silverDataGridViewTextBoxColumn
            // 
            this.silverDataGridViewTextBoxColumn.DataPropertyName = "Silver";
            this.silverDataGridViewTextBoxColumn.HeaderText = "Silver";
            this.silverDataGridViewTextBoxColumn.Name = "silverDataGridViewTextBoxColumn";
            // 
            // top10CountrysBindingSource
            // 
            this.top10CountrysBindingSource.DataMember = "Top10Countrys";
            this.top10CountrysBindingSource.DataSource = this.p2_DataDataSet1;
            // 
            // p2_DataDataSet1
            // 
            this.p2_DataDataSet1.DataSetName = "P2_DataDataSet1";
            this.p2_DataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // top20CountrysBindingSource
            // 
            this.top20CountrysBindingSource.DataMember = "Top20Countrys";
            this.top20CountrysBindingSource.DataSource = this.p2_DataDataSet;
            // 
            // p2_DataDataSet
            // 
            this.p2_DataDataSet.DataSetName = "P2_DataDataSet";
            this.p2_DataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(634, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // top20CountrysTableAdapter
            // 
            this.top20CountrysTableAdapter.ClearBeforeFill = true;
            // 
            // top10CountrysTableAdapter
            // 
            this.top10CountrysTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(806, 435);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ColunmnsChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 490);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Name = "ColunmnsChart";
            this.Text = "ColunmnsChart";
            this.Load += new System.EventHandler(this.ColunmnsChart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top10CountrysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.top20CountrysBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private P2_DataDataSet p2_DataDataSet;
        private System.Windows.Forms.BindingSource top20CountrysBindingSource;
        private P2_DataDataSetTableAdapters.Top20CountrysTableAdapter top20CountrysTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bronzeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goldDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silverDataGridViewTextBoxColumn;
        private P2_DataDataSet1 p2_DataDataSet1;
        private System.Windows.Forms.BindingSource top10CountrysBindingSource;
        private P2_DataDataSet1TableAdapters.Top10CountrysTableAdapter top10CountrysTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}