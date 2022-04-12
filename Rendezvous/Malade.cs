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
    public partial class Malade : UserControl
    {
        public Malade()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Traitements m = new Traitements();
            m.insertmixtemalade(label12, textBox1, textBox2, textBox3, comboBox1, dateTimePicker1, textBox4, comboBox2, maskedTextBox1, textBox9, textBox8, Adresse1);
            m.afficher(dataGridView1, "select * from MALADAE");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            Traitements m = new Traitements();
            m.afficher(dataGridView1, "select * from MALADAE");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Traitements m = new Traitements();
            m.insertmixtemalade(label12, textBox1, textBox2, textBox3, comboBox1, dateTimePicker1, textBox4, comboBox2, maskedTextBox1, textBox9, textBox8, Adresse1);
            m.afficher(dataGridView1, "select * from MALADAE");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Traitements m = new Traitements();
            m.deletemalade(label12);
            m.afficher(dataGridView1, "select * from MALADAE");
        }

        private void Malade_Load(object sender, EventArgs e)
        {
            Traitements m = new Traitements();
            m.afficher(dataGridView1, "select * from MALADAE");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Traitements m = new Traitements();
            m.selection(dataGridView1, label12, textBox1, textBox2, textBox3, comboBox1, dateTimePicker1, textBox4, comboBox2, maskedTextBox1, textBox9, textBox8, Adresse1);
        }
    }
}
