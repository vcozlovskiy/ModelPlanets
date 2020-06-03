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
        List<Planet> planets = new List<Planet>();
        double dt = 1;
        double a = 0.01;
        Pen pen = new Pen(Color.Red, 5);
        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            for (int j = 0; j < planets.Count; j++)
            {
                graphics.DrawEllipse(pen, (float)planets[j].x, (float)planets[j].y, 5, 5);
            }
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            Planet planet1 = new Planet(pictureBox1.Width, pictureBox1.Height);
            planets.Add(planet1);
            pictureBox1.Refresh();
        }
        double distans;
        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int j = 0; j < planets.Count; j++) 
            {
                try
                {
                    distans = Math.Sqrt(Math.Abs((planets[j].x - planets[j + 1].x) * (planets[j].x - planets[j + 1].x)) + Math.Abs((planets[j].y - planets[j + 1].y) * (planets[j].y - planets[j + 1].y)));
                    planets[j].FX += a * -1 * (planets[j].x - planets[j + 1].x) / Math.Abs(planets[j].x - planets[j + 1].x) * planets[j].mass * planets[j + 1].mass / distans;
                    planets[j].FY += a * -1 * (planets[j].y - planets[j + 1].y) / Math.Abs(planets[j].y - planets[j + 1].y) * planets[j].mass * planets[j + 1].mass / distans;

                    planets[j + 1].FX = a * -1 * (planets[j+1].x - planets[j].x) / Math.Abs(planets[j + 1].x - planets[j].x) * planets[j + 1].mass * planets[j].mass / distans;
                    planets[j + 1].FY = a * -1 * (planets[j+1].y - planets[j].y) / Math.Abs(planets[j + 1].y - planets[j].y) * planets[j + 1].mass * planets[j].mass / distans;

                    planets[j].VelX += planets[j].FX / planets[j].mass * dt;
                    planets[j + 1].VelX += planets[j + 1].FX / planets[j + 1].mass * dt;

                    planets[j].VelY += planets[j].FY / planets[j].mass * dt;
                    planets[j + 1].VelY += planets[j + 1].FY / planets[j + 1].mass * dt;

                    planets[j + 1].x += planets[j + 1].VelX * dt;
                    planets[j].x += planets[j].VelX * dt;

                    planets[j + 1].y += planets[j + 1].VelY * dt;
                    planets[j].y += planets[j].VelY * dt;
                }
                catch 
                {
                    distans = Math.Sqrt(Math.Abs((planets[j].x - planets[0].x) * (planets[j].x - planets[0].x)) + Math.Abs((planets[j].y - planets[0].y) * (planets[j].y - planets[0].y)));
                    planets[j].FX = a * -1 * (planets[j].x - planets[0].x) / Math.Abs(planets[j].x - planets[0].x) * planets[j].mass * planets[0].mass / distans;
                    planets[j].FY = a * -1 * (planets[j].y - planets[0].y) / Math.Abs(planets[j].y - planets[0].y) * planets[j].mass * planets[0].mass / distans;

                    planets[0].FX = a * -1 * (planets[0].x - planets[j].x) / Math.Abs(planets[0].x - planets[j].x) * planets[0].mass * planets[j].mass / distans;
                    planets[0].FY = a * -1 * (planets[0].y - planets[j].y) / Math.Abs(planets[0].y - planets[j].y) * planets[0].mass * planets[j].mass / distans;

                    planets[j].VelX += planets[j].FX / planets[j].mass * dt;
                    planets[0].VelX += planets[0].FX / planets[0].mass * dt;

                    planets[j].VelY += planets[j].FY / planets[j].mass * dt;
                    planets[0].VelY += planets[0].FY / planets[0].mass * dt;

                    planets[0].x += planets[0].VelX * dt;
                    planets[j].x += planets[j].VelX * dt;

                    planets[0].y += planets[0].VelY * dt;
                    planets[j].y += planets[j].VelY * dt;
                }
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
                mass = Cor.Next(0, 100) * Cor.NextDouble();
                x = Cor.Next(0, (int)sizeX);
                y = Cor.Next(0, (int)sizeY);
                VelX = Cor.Next(0, 0);
                VelY = Cor.Next(0, 0);
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
    }
}
