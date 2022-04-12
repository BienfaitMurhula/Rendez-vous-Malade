using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rendezvous
{
    public partial class Medcin : UserControl
    {
        public Medcin()
        {
            InitializeComponent();
        }
        Traitements m = new Traitements();
        private void button1_Click(object sender, EventArgs e)
        {
            m.insertmixtemedcin(label12,textBox1,textBox2,textBox3,textBox4,comboBox1,textBox6,textBox9);
            m.afficher(dataGridView1, "select * from MEDCIN");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Medcin_Load(object sender, EventArgs e)
        {
            m.afficher(dataGridView1, "select * from MEDCIN");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.insertmixtemedcin(label12, textBox1, textBox2, textBox3, textBox4, comboBox1, textBox6, textBox9);
            m.afficher(dataGridView1, "select * from MEDCIN");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.deletemedcin(label12);
            m.afficher(dataGridView1, "select * from MEDCIN");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            m.selectionmedcin(dataGridView1, label12, textBox1, textBox2, textBox3, textBox4, comboBox1, textBox6, textBox9);
        }
    }
}
