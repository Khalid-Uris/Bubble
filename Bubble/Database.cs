using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bubble
{
    public partial class Database : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-153RETS;Initial Catalog=P2_Data;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        public Database()
        {
            InitializeComponent();
            displayData();
        }
        public void displayData()
        {
            con.Open();
            adpt = new SqlDataAdapter("select * from Summer_Olympic_Games_Data", con);
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
    }
}
