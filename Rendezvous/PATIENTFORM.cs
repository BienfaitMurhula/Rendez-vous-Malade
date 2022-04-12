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
    public partial class PATIENTFORM : Form
    {
        public PATIENTFORM()
        {
            InitializeComponent();
        }

        Traitements m = new Traitements();

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            m.comboboxNOM(comboBox1);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            crystalReportViewer1.SelectionFormula = "{parpatient.NOM} = '" + comboBox1.Text + " ' ";
            crystalReportViewer1.Refresh();
            crystalReportViewer1.RefreshReport();
        }
    }
}
