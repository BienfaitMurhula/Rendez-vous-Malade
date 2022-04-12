using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendezvous
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Malade k = new Malade();
            panel2.Controls.Add(k);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Medcin k = new Medcin();
            panel2.Controls.Add(k);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            Rendezvous k = new Rendezvous();
            panel2.Controls.Add(k);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            consultation k = new consultation();
            panel2.Controls.Add(k);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Formrendezvous n = new Formrendezvous();
            n.Show();
        }
        Traitements n = new Traitements();
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            PATIENTFORM n = new PATIENTFORM();
            n.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
