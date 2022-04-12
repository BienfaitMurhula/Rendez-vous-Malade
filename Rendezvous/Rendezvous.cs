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
    public partial class Rendezvous : UserControl
    {
        public Rendezvous()
        {
            InitializeComponent();
        }

        Traitements n = new Traitements();
        private void Rendezvous_Load(object sender, EventArgs e)
        {
            n.affichetexte(label5);
            n.comboboxidmalade(comboBox2);
            n.comboboxidmedcin2(comboBox1);
            n.afficher(dataGridView1, "SELECT DISTINCT MALADAE.NOM,MALADAE.POSTNOM,MALADAE.PRENOM,MALADAE.Adresse_,MALADAE.SEXE,MALADAE.TELEPHONE,RENDEZVOUS.Motif,RENDEZVOUS.Date_rendezvous,RENDEZVOUS.Heure, MEDCIN.NOM,MEDCIN.POSTNOM,MEDCIN.SPECIALITE FROM RENDEZVOUS INNER JOIN MEDCIN ON RENDEZVOUS.CODEMEDCIN=MEDCIN.CODEMEDCIN INNER JOIN MALADAE ON MALADAE.IDMALADE=RENDEZVOUS.IDMALADE");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            n.insertrendezvous(label12, textBox1, dateTimePicker1, label5, comboBox1, comboBox2);
            n.afficher(dataGridView1, "SELECT DISTINCT MALADAE.NOM,MALADAE.POSTNOM,MALADAE.PRENOM,MALADAE.Adresse_,MALADAE.SEXE,MALADAE.TELEPHONE,RENDEZVOUS.Motif,RENDEZVOUS.Date_rendezvous,RENDEZVOUS.Heure, MEDCIN.NOM,MEDCIN.POSTNOM,MEDCIN.SPECIALITE FROM RENDEZVOUS INNER JOIN MEDCIN ON RENDEZVOUS.CODEMEDCIN=MEDCIN.CODEMEDCIN INNER JOIN MALADAE ON MALADAE.IDMALADE=RENDEZVOUS.IDMALADE");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            n.sendMessage(richTextBox1, textBox2);
            richTextBox1.Text = "";
            textBox2.Text = "";
        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            label8.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
           
        }
    }
}
