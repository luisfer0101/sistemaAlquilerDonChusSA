using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace sistemaAlquilerDonChusSA
{
    public partial class FormAlquiler : Form
    {
        private const string ArchivoClientes = "clientes.json";
        private const string ArchivoAutos = "autos.json";
        private const string ArchivoAlquileres = "alquileres.json";

        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Auto> listaAutos = new List<Auto>();
        private List<Alquiler> listaAlquileres = new List<Alquiler>();
        public FormAlquiler()
        {
            InitializeComponent();
            CargarDatos();
            LlenarComboBoxs();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (comboBoxNit.SelectedItem == null || comboBoxPlaca.SelectedItem == null)
            {
                MessageBox.Show("Debés seleccionar un NIT y una placa.");
                return;
            }

            Alquiler alquiler = new Alquiler
            {
                NitCliente = comboBoxNit.SelectedItem.ToString(),
                PlacaAuto = comboBoxPlaca.SelectedItem.ToString(),
                FechaAlquiler = dateTimePickerFInicio.Value,
                FechaDevolucion = dateTimePickerFFinal.Value,
                KilometrosRecorridos = int.Parse(textBoxQkm.Text)
            };

            listaAlquileres.Add(alquiler);
            GuardarAlquileres();
            MessageBox.Show("Alquiler guardado correctamente.");

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {

        }


        //metodos

        private void CargarDatos()
        {
            if (File.Exists(ArchivoClientes))
                listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(File.ReadAllText(ArchivoClientes)) ?? new List<Cliente>();

            if (File.Exists(ArchivoAutos))
                listaAutos = JsonConvert.DeserializeObject<List<Auto>>(File.ReadAllText(ArchivoAutos)) ?? new List<Auto>();

            if (!File.Exists(ArchivoAlquileres))
                File.WriteAllText(ArchivoAlquileres, "[]");

            listaAlquileres = JsonConvert.DeserializeObject<List<Alquiler>>(File.ReadAllText(ArchivoAlquileres)) ?? new List<Alquiler>();
        }

        private void LlenarComboBoxs()
        {
           //meter nit en combobox
            comboBoxNit.Items.Clear();
            foreach (var cliente in listaClientes)
            {
                comboBoxNit.Items.Add(cliente.Nit);
            }

            //meter placas
            comboBoxPlaca.Items.Clear();
            foreach (var auto in listaAutos)
            {
                comboBoxPlaca.Items.Add(auto.Placa);
            }
        }

        private void GuardarAlquileres()
        {
            string json = JsonConvert.SerializeObject(listaAlquileres, Formatting.Indented);
            File.WriteAllText(ArchivoAlquileres, json);
        }

    }
}
