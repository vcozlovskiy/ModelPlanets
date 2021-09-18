using System;
using System.Drawing;
using MatModelPlanets.Forms;
using System.Windows.Forms;

namespace MatModelPlanets
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Planet.PlanetsRefresh(ref sender, ref e);
        }
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Refresh();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Planet.GetNewParametrs();
            pictureBox1.Refresh();
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form add = new AddPlanet(e, pictureBox1);
            add.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Planet.Clear();
            pictureBox1.Refresh();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
