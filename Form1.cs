using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemaAlquilerDonChusSA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            FormDataCliente form = new FormDataCliente();
            form.ShowDialog();
        }

        private void buttonAlquiler_Click(object sender, EventArgs e)
        {
            FormAuto form = new FormAuto();
            form.ShowDialog();
        }

        private void buttonAuto_Click(object sender, EventArgs e)
        {
            FormAlquiler form = new FormAlquiler();
            form.ShowDialog();
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            FormReporte form = new FormReporte();
            form.ShowDialog();
        }
    }
}
