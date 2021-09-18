using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatModelPlanets.Forms
{
    public partial class AddPlanet : Form
    {
        MouseEventArgs mouseEventArgs;
        PictureBox picture;
        public AddPlanet(MouseEventArgs e, PictureBox pic)
        {
            InitializeComponent();
            picture = pic;
            mouseEventArgs = e;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e1)
        {
            double.TryParse(tBMass.Text, out double mass);
            double.TryParse(tBvelositiX.Text, out double velX);
            double.TryParse(tBvelositiY.Text, out double velY);

            if (mass != 0)
            {
                Planet planet = new Planet(mouseEventArgs.X, mouseEventArgs.Y, velX, velY, mass);
                Planet.planets.Add(planet);
            }
            else
            {
                MessageBox.Show("Введите массу!");
            }
            picture.Refresh();
            this.Close();
        }
    }
}
