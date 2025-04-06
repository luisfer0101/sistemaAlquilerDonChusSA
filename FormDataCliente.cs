using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace sistemaAlquilerDonChusSA
{
    public partial class FormDataCliente : Form
    {
        private const string ArchivoClientes = "clientes.json";
        private List<Cliente> listaClientes = new List<Cliente>();
        public FormDataCliente()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (listaClientes.Any(c => c.Nit == textBoxNIT.Text))
            {
                MessageBox.Show("El NIT ya existe.");
                return;
            }

            Cliente cliente = new Cliente
            {
                Nit = textBoxNIT.Text,
                Nombre = textBoxNombre.Text,
                Direccion = textBoxDireccion.Text
            };

            listaClientes.Add(cliente);
            GuardarClientes();
            textBoxNIT.Clear();
            textBoxNombre.Clear();
            textBoxDireccion.Clear();
        }

        //metodos 
        private void GuardarClientes()
        {
            string json = JsonConvert.SerializeObject(listaClientes, Formatting.Indented);
            File.WriteAllText(ArchivoClientes, json);
        }


    }
}
