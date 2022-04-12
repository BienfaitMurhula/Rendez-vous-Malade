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
    public partial class consultation : UserControl
    {
        public consultation()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        Traitements n = new Traitements();
        private void consultation_Load(object sender, EventArgs e)
        {
            n.afficher(dataGridView1, "select * from consultation");
            n.comboboxidmalade(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n.insertconsultation(label12, textBox1, dateTimePicker1, comboBox1);
            n.afficher(dataGridView1, "select * from consultation");
        }
    }
}
