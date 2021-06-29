using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble
{
    public partial class ColunmnsChart : Form
    {
        public ColunmnsChart()
        {
            InitializeComponent();
        }

        private void ColunmnsChart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p2_DataDataSet1.Top10Countrys' table. You can move, or remove it, as needed.
            this.top10CountrysTableAdapter.Fill(this.p2_DataDataSet1.Top10Countrys);
            // TODO: This line of code loads data into the 'p2_DataDataSet.Top20Countrys' table. You can move, or remove it, as needed.
            this.top20CountrysTableAdapter.Fill(this.p2_DataDataSet.Top20Countrys);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Country";
            chart1.Series[0].YValueMembers = "Country";

            chart1.Series[1].XValueMember = "Bronze";
            chart1.Series[1].YValueMembers = "Bronze";


             chart1.Series[2].XValueMember = "Gold";
             chart1.Series[2].YValueMembers = "Gold";


             chart1.Series[3].XValueMember = "Silver";
             chart1.Series[3].YValueMembers = "Silver";


             chart1.Series[4].XValueMember = "Total_Medal";
             chart1.Series[4].YValueMembers = "Total_Medal"; 

            chart1.DataSource = p2_DataDataSet1.Top10Countrys;
            chart1.DataBind();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            WelcomeFome obj = new WelcomeFome();
            obj.Show();
            this.Hide();
        }
    }
}
