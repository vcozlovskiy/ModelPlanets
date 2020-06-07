using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatModelPlanets
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double impulse;
        List<Planet> planets = new List<Planet>();
        double dt = 0.1;
        double a = 8;
        Pen pen = new Pen(Color.Red, 5);
        Pen Pen2 = new Pen(Color.White,1);
        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int j = 0; j < planets.Count; j++)
            {
                graphics.DrawEllipse(pen, (float)planets[j].x, (float)planets[j].y, 5, 5);
                graphics.DrawLine(Pen2,(float)planets[j].x, (float)planets[j].y, (float)(planets[j].x + planets[j].FX/20), (float)(planets[j].y +planets[j].FY/20));
            }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Planet planet1 = new Planet(pictureBox1.Width, pictureBox1.Height);
            planets.Add(planet1);
            pictureBox1.Refresh();
        }
        double distans;
        double ForsMod;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < planets.Count ; j++) 
            {
                for (int i = 0; i < planets.Count; i++)
                {
                    distans = Math.Sqrt(Math.Abs((planets[i].x - planets[j].x) * (planets[i].x - planets[j].x)) + Math.Abs((planets[i].y - planets[j].y) * (planets[i].y - planets[j].y)));
                    if (distans < 20)
                    {
                        distans = 20;
                    }
                    ForsMod = a * planets[i].mass * planets[j].mass / distans;
                    planets[i].FX += 1 * -1 * ForsMod * (planets[i].x - planets[j].x) / distans;
                    planets[i].FY += 1 * -1 * ForsMod * (planets[i].y - planets[j].y) / distans;
                }
                planets[j].VelX += planets[j].FX / planets[j].mass * dt * dt / 2;
                planets[j].VelY += planets[j].FY / planets[j].mass * dt * dt / 2;
                planets[j].FX = 0;
                planets[j].FY = 0;
            }
            for(int i = 0;i < planets.Count; i++)
            {
                planets[i].x += planets[i].VelX * dt;
                planets[i].y += planets[i].VelY * dt;
            }
            pictureBox1.Refresh();
        }


        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
                double.TryParse(tBMass.Text, out double mass);
                double.TryParse(tBvelositiX.Text, out double velX);
                double.TryParse(tBvelositiY.Text, out double velY);
            if (mass != 0)
            { 
                Planet planeta = new Planet(e.X, e.Y, velX, velY, mass);
                planets.Add(planeta);
                pictureBox1.Refresh();
            }
            else
            {
                MessageBox.Show("Введите массу!");
            }
            
        }
        public class Planet
        {
            public double x;
            public double y;
            public double VelX;
            public double VelY;
            public double mass;
            public double FX;
            public double FY;
            public Color Color;
            public Random Cor = new Random();
            public Planet(int sizeX, int sizeY)
            {
                mass = Cor.Next(0, 1000) * Cor.NextDouble();
                x = Cor.Next(0, (int)sizeX);
                y = Cor.Next(0, (int)sizeY);
                VelX = Cor.Next(-10,10);
                VelY = Cor.Next(-10,10);
            }
            public Planet(int CordX, int CordY, double velx, double vely, double massa)
            {
                x = CordX;
                y = CordY;
                VelX = velx;
                VelY = vely;
                mass = massa;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            planets.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dt-=0.025;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dt+=0.025;
        }
    }
}
