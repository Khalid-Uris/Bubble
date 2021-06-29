namespace Bubble
{
    partial class AthleteMedals
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.p2_DataDataSet4 = new Bubble.P2_DataDataSet4();
            this.athlete2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athlete2TableAdapter = new Bubble.P2_DataDataSet4TableAdapters.Athlete2TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.athleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goldsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.silversDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bronzesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalMedalsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athlete2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.athleteDataGridViewTextBoxColumn,
            this.countryDataGridViewTextBoxColumn,
            this.goldsDataGridViewTextBoxColumn,
            this.silversDataGridViewTextBoxColumn,
            this.bronzesDataGridViewTextBoxColumn,
            this.totalMedalsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.athlete2BindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(287, 12);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series1.Legend = "Legend1";
            series1.Name = "Athlete";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series2.Legend = "Legend1";
            series2.Name = "Golds";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Silvers";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Legend = "Legend1";
            series4.Name = "Bronzes";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series5.Legend = "Legend1";
            series5.Name = "TotalMedals";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(973, 368);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(459, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 31);
            this.button1.TabIndex = 2;
            this.button1.Text = "&Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // p2_DataDataSet4
            // 
            this.p2_DataDataSet4.DataSetName = "P2_DataDataSet4";
            this.p2_DataDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // athlete2BindingSource
            // 
            this.athlete2BindingSource.DataMember = "Athlete2";
            this.athlete2BindingSource.DataSource = this.p2_DataDataSet4;
            // 
            // athlete2TableAdapter
            // 
            this.athlete2TableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // athleteDataGridViewTextBoxColumn
            // 
            this.athleteDataGridViewTextBoxColumn.DataPropertyName = "Athlete";
            this.athleteDataGridViewTextBoxColumn.HeaderText = "Athlete";
            this.athleteDataGridViewTextBoxColumn.Name = "athleteDataGridViewTextBoxColumn";
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(704, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 31);
            this.button2.TabIndex = 3;
            this.button2.Text = "&Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AthleteMedals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AthleteMedals";
            this.Text = "AthleteMedals";
            this.Load += new System.EventHandler(this.AthleteMedals_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p2_DataDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athlete2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button button1;
        private P2_DataDataSet4 p2_DataDataSet4;
        private System.Windows.Forms.BindingSource athlete2BindingSource;
        private P2_DataDataSet4TableAdapters.Athlete2TableAdapter athlete2TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn athleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goldsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn silversDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bronzesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalMedalsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button2;
    }
}