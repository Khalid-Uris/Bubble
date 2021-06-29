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
    public partial class Form1 : Form
    {
        // Background Year
        int year;

        int x = 1, cnt = 0;
        float y = 1f;
        // Label move to diagnonally Bottom to up
        int x1 = 1, cnt1 = 0;
        float y1 = 400f;

        private float redBallWidth = 25;
        private float redBallHeight = 25;
        private int redBallPosX = 50;
        private int redBallPosY = 40;
        private int redMoveStepX = 20;
        private int redMoveStepY = 20;
        private float redIncreament = 0.0f;//increment red variable

        // Pink ball Variable
        private int pinkWidth = 25;
        private int pinkHeight = 25;
        private int pinkBallPosX = 50;
        private int pinkBallPosY = 80;
        private int pinkMoveStepX = 15;
        private int pinkMoveStepY = 15;
        private int pinkIncreament = 0;//increment variable


        // Blue ball Variable
        private int blueWidth = 25;
        private int blueHeight = 25;
        private int blueBallPosX = 50;
        private int blueBallPosY = 120;
        private int blueMoveStepX = 13;
        private int blueMoveStepY = 13;

        //BDconnection obj = new BDconnection();
        // Brown Ball variable
        private int brownWidth = 25;
        private int brownHeight = 25;
        private int brownBallPosX = 50;
        private int brownBallPosY = 160;
        private int brownMoveStepX = 12;
        private int brownMoveStepY = 12;

        // Yellow ball Variable
        private int yellowWidth = 25;
        private int yellowHeight = 25;
        private int yellowBallPosX = 50;
        private int yellowBallPosY = 200;
        private int yellowMoveStepX = 11;
        private int yellowMoveStepY = 11;


        // Green Ball Variable
        private int greenWidth = 25;
        private int greenHeight = 25;
        private int greenBallPosX = 50;
        private int greenBallPosY = 240;
        private int greenMoveStepX = 9;
        private int greenMoveStepY = 9;

        // Orange Ball Variable
        private int orangeWidth = 25;
        private int orangeHeight = 25;
        private int orangeBallPosX = 50;
        private int orangeBallPosY = 280;
        private int orangeMoveStepX = 8;
        private int orangeMoveStepY = 8;

        // Indigo Ball Variable
        private int indigoWidth = 25;
        private int indigoHeight = 25;
        private int indigoBallPosX = 50;
        private int indigoBallPosY = 320;
        private int indigoMoveStepX = 7;
        private int indigoMoveStepY = 7;

        // Maroon Ball Variable
        private int maroonWidth = 25;
        private int maroonHeight = 25;
        private int maroonBallPosX = 50;
        private int maroonBallPosY = 360;
        private int maroonMoveStepX = 6;
        private int maroonMoveStepY = 6;

        // Skyblue Ball Variable
        private int skyblueWidth = 25;
        private int skyblueHeight = 25;
        private int skyblueBallPosX = 50;
        private int skyblueBallPosY = 400;
        private int skyblueMoveStepX = 5;
        private int skyblueMoveStepY = 5;

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint ,
                true
                );
            this.UpdateStyles();

            //year
            year = 1896;
        }

        private void PaintCircle(object sender, PaintEventArgs e)
        {

            e.Graphics.SmoothingMode = 
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            //e.Graphics.Clear(this.BackColor);

            // Green Ball Object
            e.Graphics.FillEllipse(Brushes.Green,
              greenBallPosX, greenBallPosY,
              greenWidth, greenHeight
              );

            e.Graphics.DrawEllipse(Pens.Black,
                greenBallPosX, greenBallPosY,
                greenWidth, greenHeight);

            // Pink ball object
            e.Graphics.FillEllipse(Brushes.Pink,
               pinkBallPosX, pinkBallPosY,
               pinkWidth, pinkHeight);

            e.Graphics.DrawEllipse(Pens.Black,
                   pinkBallPosX, pinkBallPosY,
                   pinkWidth, pinkHeight);

            // Blue ball Object
            e.Graphics.FillEllipse(Brushes.Blue,
                blueBallPosX, blueBallPosY,
                blueWidth, blueHeight
                );

            e.Graphics.DrawEllipse(Pens.Black,
                blueBallPosX, blueBallPosY,
                blueWidth, blueHeight);

            // Yellow ball Object
            e.Graphics.FillEllipse(Brushes.Yellow,
                yellowBallPosX, yellowBallPosY,
                yellowWidth, yellowHeight
                );

            e.Graphics.DrawEllipse(Pens.Black,
                yellowBallPosX, yellowBallPosY,
                yellowWidth, yellowHeight);


            // Red ball object
            e.Graphics.FillEllipse(Brushes.Red,
                redBallPosX, redBallPosY,
                redBallWidth, redBallHeight);

            e.Graphics.DrawEllipse(Pens.Black,
                redBallPosX, redBallPosY,
                redBallWidth, redBallHeight);

            // Brown ball Object
            e.Graphics.FillEllipse(Brushes.Brown,
                brownBallPosX, brownBallPosY,
                brownWidth, brownHeight
                );

            e.Graphics.DrawEllipse(Pens.Black,
                brownBallPosX, brownBallPosY,
                brownWidth, brownHeight);


            // Green Ball Object
            e.Graphics.FillEllipse(Brushes.Orange,
              orangeBallPosX, orangeBallPosY,
              orangeWidth, orangeHeight
              );

            e.Graphics.DrawEllipse(Pens.Black,
                orangeBallPosX, orangeBallPosY,
                orangeWidth, orangeHeight);


            // Indigo Ball Object
            e.Graphics.FillEllipse(Brushes.Indigo,
              indigoBallPosX, indigoBallPosY,
              indigoWidth, indigoHeight
              );

            e.Graphics.DrawEllipse(Pens.Black,
                indigoBallPosX, indigoBallPosY,
                indigoWidth, indigoHeight);

            // Maroon Ball Object
            e.Graphics.FillEllipse(Brushes.Maroon,
              maroonBallPosX, maroonBallPosY,
              maroonWidth, maroonHeight
              );

            e.Graphics.DrawEllipse(Pens.Black,
                maroonBallPosX, maroonBallPosY,
                maroonWidth, maroonHeight);


            // Skyblue Ball Object
            e.Graphics.FillEllipse(Brushes.SkyBlue,
              skyblueBallPosX, skyblueBallPosY,
              skyblueWidth, skyblueHeight
              );

            e.Graphics.DrawEllipse(Pens.Black,
                skyblueBallPosX, skyblueBallPosY,
                skyblueWidth, skyblueHeight);

            //Draw A Lines
            Graphics g = e.Graphics;
            //int w = this.ClientSize.Width;
            //int h = this.ClientSize.Height;
            // pen=rantangle, Brush=paints,Font=text
            //g.DrawRectangle(Pens.Red,w/2,h/2, 100, 80);
            //Pen p = new Pen(Color.Black);
            //g.DrawLine(p, 0, 0, h, w);

            Brush black = new SolidBrush(Color.Black);
            Pen blackPen = new Pen(black, 3);

            //Point[] points = new Point[2];
            
            g.DrawLine(blackPen,50,0,50,450); //This is height 
            g.DrawLine(blackPen, 50, 450, 760,450); //This is Width
            //g.DrawLine(blackPen,)

            // This is years text in X-axis 
            Font f = new Font("Arial", 12, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Years", f, black, 336, 460);

            Font f1 = new Font("Arial", 10,FontStyle.Bold);
            g.DrawString("1896", f1, black, 100, 450);
            g.DrawString("1900", f1, black, 200, 450);
            g.DrawString("1904", f1, black, 300, 450);
            g.DrawString("1908", f1, black, 400, 450);
            g.DrawString("1912", f1, black, 500, 450);
            g.DrawString("1916", f1, black, 600, 450);


            // This is Medals text in Y-axis
           /* Font medals = new Font("Arial", 10, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Medals", medals, black, 0, 200);

            Font m = new Font("Arial", 10, FontStyle.Bold);
            g.DrawString("350", m, black, 22, 50);
            g.DrawString("300", m, black, 22, 100);
            g.DrawString("250", m, black, 22, 150);
            g.DrawString("200", m, black, 22, 190);
            g.DrawString("150", m, black, 22, 250);
            g.DrawString("100", m, black, 22, 300);
            g.DrawString("50", m, black, 22, 350);*/
            //g.DrawString("", m, black,  22, 375);
            //g.DrawString("150", m, black, 600, 407);

        }
        // Red ball Movement
        /*private void MoveBall(object sender, EventArgs e)
        {
            // update coordinates
            redBallPosX += redMoveStepX;
        


           if(
                redBallPosX<0 ||
                redBallPosX+redBallWidth>this.ClientSize.Width                  
                )
            {
                redMoveStepX = -redMoveStepX;
            }

            redBallPosY += redMoveStepY;
            if (
               redBallPosY < 0 ||
               redBallPosY + redBallHeight > this.ClientSize.Height
               )
            {
                redMoveStepY = -redMoveStepY;
            }

           


            // update painting
            this.Refresh();

            
        }*/

        // pink ball coordinates
        /*   private void pinkBallMove(object sender, EventArgs e)
           {
               // update coordinate
               pinkBallPosX += pinkMoveStepX;
               pinkHeight += pinkIncreament;
               pinkWidth += pinkIncreament;

               if (pinkBallPosX+pinkWidth>this.ClientSize.Width)
               {
                   pinkMoveStepX = -pinkMoveStepX;
                   if (pinkIncreament == 0)
                       pinkIncreament += 1;
                   else
                       pinkIncreament += 2;
               }

               if (pinkBallPosX < 0)
               {
                   pinkMoveStepX = -pinkMoveStepX;
                   pinkIncreament -= 2;
               }

               // update coordinates
               this.Refresh();


           }*/
        // Blue ball Move
        /*   private void blueBallMove(object sender, EventArgs e)
           {
               blueBallPosX += blueMoveStepX;
               if(blueBallPosX+blueWidth>this.ClientSize.Width || blueBallPosX<0)
               {
                   blueBallPosX = blueBallPosX-blueMoveStepX;
               }
               blueBallPosY -= blueMoveStepY;
               if(blueBallPosY<0 || blueBallPosY>this.ClientSize.Height)
               {
                   blueBallPosY = blueBallPosY+blueMoveStepY;
               }


               //update coodinate
               this.Refresh();
           }*/
        // Yellow ball Movement
        /* private void yellowBallMove(object sender, EventArgs e)
         {
             //update Coordinate
             yellowBallPosX -= yellowMoveStepX;
             if(yellowBallPosX<0 || yellowBallPosX+yellowWidth>ClientSize.Width)
             {
                 yellowMoveStepX = -yellowMoveStepX;
             }

             yellowBallPosY -= yellowMoveStepY;
             if(yellowBallPosY<0 || yellowBallPosY+yellowHeight>ClientSize.Height)
             {
                 yellowMoveStepY = -yellowMoveStepY;
             }

             //update Color
             this.Refresh();
         }*/

        /*     private void greenBallMove(object sender, EventArgs e)
             {
                 greenBallPosY += greenMoveStepY;
                 if (greenBallPosY > this.ClientSize.Height) 
                 {
                     greenBallPosY = -greenBallPosY;
                 }
                 //if (pinkBallPosY < 0)
                 //{
                   //  greenMoveStepY = -greenMoveStepY;
                // }
                     //update Color
                     this.Refresh();
             }*/
        // this is label timer
        private void timer6_Tick(object sender, EventArgs e)
        {
            //int[] arr = obj.PrintSql_Array();
            //brown Ball Coordinate
           /* brownBallPosX += brownMoveStepX;
            if (brownBallPosX + brownWidth > this.ClientSize.Width || brownBallPosX < 0)
            {
                brownBallPosX = brownBallPosX - brownMoveStepX;
            }

            brownBallPosY += brownMoveStepY;
            if (brownBallPosY + brownWidth > this.ClientSize.Height || brownBallPosY < 0)
            {
                brownBallPosY = brownBallPosY - brownMoveStepY;
            }*/
             /*foreach(int i in arr)
             {
                 brownBallPosY += i;
                 if (i < 0 || i > this.ClientSize.Height)
                 {
                     i = i + i;
                 }
             }*/
            //update painting 
            this.Refresh();

            /*label1.SetBounds(x1, (int)y1, 1, 1);

            // Forward Steps
            if (cnt1 == 0)
            {
                x1++;
                y1 = y1 - 0.60f;
            }
            if (x1 == 500)
            {
                cnt1 = 1;
            }
            // Backforward Steps
            if (cnt1 == 1)
            {
                x1--;
                y1 = y1 + 0.60f;
            }
            if (x1 == 1)
            {
                cnt1 = 0;
            }*/

            /*label2.SetBounds(x, (int)y, 1, 1);
            if(cnt==0)
            {
                x++;
                y = y + 0.60f;

            }
            if(cnt==1)
            {
                x--;
                y = y + 0.6f;
            }
            if(x==700)
            {
                cnt = 1;
            }
            if(x==1)
            {
                cnt = 0;
            }*/

        }
        // this is take object in center
        /*private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }*/

        // This year timer
        private void timer7_Tick(object sender, EventArgs e)
        {
             year=year+4;

            if(year>=2020)
            {
                timer7.Stop();
            }
            lblyears.Text = year.ToString();

            //this is custom control progressBar 
            myProgressBar1.Minimum = 1896;
            myProgressBar1.Maximum = 2020;

            if(myProgressBar1.Value<myProgressBar1.Maximum)
            {
                myProgressBar1.Value = myProgressBar1.Value + 4;
            }

            // this is progressBar
            progressBar1.Minimum = 1896;
            progressBar1.Maximum = 2020;

            if(progressBar1.Value<progressBar1.Maximum)
            {
                progressBar1.Value = progressBar1.Value + 4;
            }

            // This Red coordinates
            // update coordinates 
            redBallPosX += redMoveStepX;

            if (redBallPosX + redBallWidth > this.ClientSize.Width)
            {
                redMoveStepX = -redMoveStepX;
            }

            //redBallPosY -= redMoveStepY;
            if (redBallPosX < 0)
            {
                redMoveStepX = -redMoveStepX;
            }

            // pink ball coordinates
            // update coordinate
            pinkBallPosX += pinkMoveStepX;
            pinkHeight += pinkIncreament;
            pinkWidth += pinkIncreament;

            if (pinkBallPosX + pinkWidth > this.ClientSize.Width)
            {
                pinkMoveStepX = -pinkMoveStepX;
                if (pinkIncreament == 0)
                    pinkIncreament += 1;
                else
                    pinkIncreament += 2;
            }
            if (pinkBallPosX < 0)
            {
                pinkMoveStepX = -pinkMoveStepX;
                pinkIncreament -= 2;
            }

            //Blue Ball Coordinate
            blueBallPosX += blueMoveStepX;
            if (blueBallPosX + blueWidth > this.ClientSize.Width)
            {
                blueMoveStepX = -blueMoveStepX;
            }
            //blueBallPosY -= blueMoveStepY;
            if (blueBallPosX < 0)
            {
                blueMoveStepX = -blueMoveStepX;
            }

            //Yellow Ball Coordinates
            //update Coordinate
            yellowBallPosX += yellowMoveStepX;
            if (yellowBallPosX + yellowWidth > this.ClientSize.Width)
            {
                yellowMoveStepX = -yellowMoveStepX;
            }

            //yellowBallPosY -= yellowMoveStepY;
            if (yellowBallPosX < 0)
            {
                yellowMoveStepX = -yellowMoveStepX;
            }

            //Green Ball Coordinate
            greenBallPosX += greenMoveStepX;
            if (greenBallPosX + greenWidth > this.ClientSize.Width)
            {
                greenMoveStepX = -greenMoveStepX;
            }
            if (greenBallPosX < 0)
            {
                greenMoveStepX = -greenMoveStepX;
            }

            //Brown Ball Coordinate
            brownBallPosX += brownMoveStepX;
            if (brownBallPosX + brownWidth > this.ClientSize.Width)
            {
                brownMoveStepX = -brownMoveStepX;
            }
            if (brownBallPosX < 0)
            {
                brownMoveStepX = -brownMoveStepX;
            }

            //Orange Ball Coordinate
            orangeBallPosX += orangeMoveStepX;
            if (orangeBallPosX + orangeWidth > this.ClientSize.Width)
            {
                orangeMoveStepX = -orangeMoveStepX;
            }
            if (orangeBallPosX < 0)
            {
                orangeMoveStepX = -orangeMoveStepX;
            }

            //Indigo Ball Coordinate
            indigoBallPosX += indigoMoveStepX;
            if (indigoBallPosX + indigoWidth > this.ClientSize.Width)
            {
                indigoMoveStepX = -indigoMoveStepX;
            }
            if (indigoBallPosX < 0)
            {
                indigoMoveStepX = -indigoMoveStepX;
            }

            //Maroon Ball Coordinate
            maroonBallPosX += maroonMoveStepX;
            if (maroonBallPosX + maroonWidth > this.ClientSize.Width)
            {
                maroonMoveStepX = -maroonMoveStepX;
            }
            if (maroonBallPosX < 0)
            {
                maroonMoveStepX = -maroonMoveStepX;
            }

            //SkyBlue Ball Coordinate
            skyblueBallPosX += skyblueMoveStepX;
            if (skyblueBallPosX + skyblueWidth > this.ClientSize.Width)
            {
                skyblueMoveStepX = -skyblueMoveStepX;
            }
            if (skyblueBallPosX < 0)
            {
                skyblueMoveStepX = -skyblueMoveStepX;
            }

            /*blueBallPosX += blueMoveStepX;
            if (blueBallPosX + blueWidth > this.ClientSize.Width)
            {
                blueBallPosX = blueBallPosX - blueMoveStepX;
            }
            //blueBallPosY -= blueMoveStepY;
            if (blueBallPosX < 0)
            {
                blueBallPosX = -blueBallPosX;
            }*/


            // update painting
            this.Refresh();
        }

        //year start button
        //This is Start Button
        private void button1_Click(object sender, EventArgs e)
        {
            timer7.Start();
            if(year==2020)
            {
                year = 1896;
                lblyears.Text = year.ToString();//this is label of timer

                timer7.Start();

                myProgressBar1.Value = 1896;
                progressBar1.Value = 1896;

                redBallPosX = 50;
                redBallPosY = 40;

                pinkBallPosX = 50;
                pinkBallPosY = 80;

                blueBallPosX = 50;
                blueBallPosY = 120;

                brownBallPosX = 50;
                brownBallPosY = 160;

                yellowBallPosX = 50;
                yellowBallPosY = 200;

                greenBallPosX = 50;
                greenBallPosY = 240;

                orangeBallPosX = 50;
                orangeBallPosY = 280;

                indigoBallPosX = 50;
                indigoBallPosY = 320;

                maroonBallPosX = 50;
                maroonBallPosY = 360;

                skyblueBallPosX = 50;
                skyblueBallPosY = 400;
    }
        }
        //This is Stop Button
        /*private void button3_Click(object sender, EventArgs e)
        {
            timer7.Stop();
            year = 1896;
            lblyears.Text = year.ToString();

            redBallPosX = 0;
            redBallPosY = 0;

            //myProgressBar1.Value = 1896;
            //progressBar1.Value = 1896;
        }*/
        //This is Pause Button
        private void button2_Click(object sender, EventArgs e)
        {
            timer7.Stop();
           
        }
        //This is database MenuItem
        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Database obj = new Database();
            obj.Show();
            this.Hide();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WelcomeFome obj = new WelcomeFome();
            obj.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*BDconnection obj = new BDconnection();
            int[] arr = obj.PrintSql_Array();
            foreach(int i in arr)
            {
                MessageBox.Show(i.ToString(),"1896 year value ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }*/
            
            timer6.Interval = 100;
            timer6.Start();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}

// this.Client.Width is bigger then the windows size