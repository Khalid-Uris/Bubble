using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble
{
    public partial class WelcomeFome : Form
    {
        public WelcomeFome()
        {
            InitializeComponent();
        }

        private void WelcomeFome_Load(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }*/

        private void WelcomeFome_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ColunmnsChart obj = new ColunmnsChart();
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AthleteMedals obj = new AthleteMedals();
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            AllTimeMedals obj = new AllTimeMedals();
            obj.Show();
            this.Hide();
        }
    }
}
