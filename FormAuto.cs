using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace sistemaAlquilerDonChusSA
{
    public partial class FormAuto : Form
    {
        private const string ArchivoAutos = "autos.json";
        private List<Auto> listaAutos = new List<Auto>();
        public FormAuto()
        {
            InitializeComponent();
            CargarAutos();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            foreach (Auto a in listaAutos)
            {
                if (a.Placa == textBoxPlaca.Text)
                {
                    MessageBox.Show("La placa ya está registrada.");
                    return;
                }
            }

            Auto auto = new Auto
            {
                Placa = textBoxPlaca.Text,
                Marca = textBoxMarca.Text,
                Modelo = textBoxModelo.Text,
                Color = textBoxColor.Text,
                PrecioPorKm = decimal.Parse(textBoxPrecioKm.Text)
            };

            listaAutos.Add(auto);
            GuardarAutos();
            CargarAutos();
            textBoxPlaca.Clear();
            textBoxMarca.Clear();
            textBoxModelo.Clear();
            textBoxColor.Clear();
            textBoxPrecioKm.Clear();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {

        }


        //metodos

        private void CargarAutos()
        {
            if (!File.Exists(ArchivoAutos))
                File.WriteAllText(ArchivoAutos, "[]");

            using (StreamReader reader = File.OpenText(ArchivoAutos))
            {
                string json = reader.ReadToEnd();
                listaAutos = JsonConvert.DeserializeObject<List<Auto>>(json) ?? new List<Auto>();
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaAutos;
        }


        private void GuardarAutos()
        {
            string json = JsonConvert.SerializeObject(listaAutos, Formatting.Indented);
            File.WriteAllText(ArchivoAutos, json);
        }
    }
}
