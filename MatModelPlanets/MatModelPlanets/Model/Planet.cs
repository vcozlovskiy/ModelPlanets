using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MatModelPlanets
{
    public class Planet
    {
        private double Mass;
        private Vector radVec;
        private Vector velVec;
        private Vector forsVec;
        private Color colorPlanet;
        private double radPlanet = 10;

        static double ForsMod, distans, dt = 0.1;
        SolidBrush pen;

        public static List<Planet> planets = new List<Planet>();
        private static Random corRand = new Random();

        public Planet(int CordX, int CordY, double velx, double vely, double mass)
        {
            Mass = mass;
            radVec = new Vector(CordX,CordY);
            velVec = new Vector(velx,vely);
            forsVec = new Vector(0,0);
            colorPlanet = Color.FromArgb(corRand.Next(0, 255), corRand.Next(0,255), corRand.Next(0,255));
            pen = new SolidBrush(colorPlanet);

            planets.Add(this);
        }

        private static void unitPlanets(Planet plnt1, Planet plnt2)
        {
            plnt1.Mass += plnt2.Mass;
            plnt1.radPlanet = Math.Sqrt(Math.Pow(plnt1.radPlanet,2) + Math.Pow(plnt2.radPlanet,2));
            plnt1.velVec.X = (plnt2.Mass * plnt2.velVec.X + plnt1.Mass * plnt1.velVec.X) / (plnt1.Mass + plnt2.Mass); 
            plnt1.velVec.Y = (plnt2.Mass * plnt2.velVec.Y + plnt1.Mass * plnt1.velVec.Y) / (plnt1.Mass + plnt2.Mass);
            planets.Remove(plnt2);
        }

        public static void GetNewParametrs()
        {
            for (int i = 0; i < planets.Count; i++)
            {
                planets[i].velVec.X += planets[i].forsVec.X / planets[i].Mass * dt;
                planets[i].velVec.Y += planets[i].forsVec.Y / planets[i].Mass * dt;
                planets[i].radVec.X += planets[i].velVec.X * dt;
                planets[i].radVec.Y += planets[i].velVec.Y * dt;
                planets[i].forsVec.X = 0;
                planets[i].forsVec.Y = 0;
            }

            for (int j = 0; j < planets.Count; j++)
            {
                for (int i = 0; i < planets.Count; i++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    distans = Math.Pow(planets[i].radVec.X - planets[j].radVec.X, 2) + Math.Pow(planets[i].radVec.Y - planets[j].radVec.Y,2); ;
                    if (distans < planets[i].radPlanet)
                    {
                        unitPlanets(planets[i], planets[j]);
                        distans = 20;
                        j = planets.Count - 1;
                        continue;
                    }

                    ForsMod = planets[i].Mass * planets[j].Mass / distans * 10;
                    Vector temp = new Vector(planets[i].radVec.X - planets[j].radVec.X, planets[i].radVec.Y - planets[j].radVec.Y);
                    planets[i].forsVec.X += ForsMod * -1 * temp.Cos() / planets[i].Mass;
                    planets[i].forsVec.Y += ForsMod * -1 * temp.Sin() / planets[i].Mass;
                }
            }
        }

        public static void PlanetsRefresh(ref object sender,ref PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            FontFamily family = new FontFamily("Times New Roman");
            Font font = new Font(family, 10.0f, FontStyle.Bold | FontStyle.Underline);
            SolidBrush brush = new SolidBrush(Color.White);
            Pen p = new Pen(Color.Green, 5);

            for (int j = 0; j < planets.Count; j++)
            {
                graphics.FillEllipse(planets[j].pen, (float)planets[j].radVec.X, (float)planets[j].radVec.Y, (float)planets[j].radPlanet, (float)planets[j].radPlanet);
                graphics.DrawString($"X :{string.Format("{0:E2}", planets[j].forsVec.X)}, Y: {string.Format("{0:E2}", planets[j].forsVec.Y)}",font, brush, (float)planets[j].radVec.X, (float)planets[j].radVec.Y);
            }
        }

        public static void Clear()
        {
            planets.Clear();
        }
    }
}
