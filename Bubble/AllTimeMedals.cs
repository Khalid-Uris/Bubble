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
    public partial class AllTimeMedals : Form
    {
        public AllTimeMedals()
        {
            InitializeComponent();
        }

        private void AllTimeMedals_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'p2_DataDataSet5.AllTimeMedals' table. You can move, or remove it, as needed.
            this.allTimeMedalsTableAdapter.Fill(this.p2_DataDataSet5.AllTimeMedals);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Country";
            chart1.Series[0].YValueMembers = "Country";

            chart1.Series[1].XValueMember = "Golds";
            chart1.Series[1].YValueMembers = "Golds";


            chart1.Series[2].XValueMember = "Silvers";
            chart1.Series[2].YValueMembers = "Silvers";


            chart1.Series[3].XValueMember = "Bronzes";
            chart1.Series[3].YValueMembers = "Bronzes";


            chart1.Series[4].XValueMember = "TotalMedals";
            chart1.Series[4].YValueMembers = "TotalMedals";

            chart1.DataSource = p2_DataDataSet5.AllTimeMedals;
            chart1.DataBind();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            WelcomeFome obj = new WelcomeFome ();
            obj.Show();
            this.Hide();
        }
    }
}
