using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace sistemaAlquilerDonChusSA
{
    public partial class FormReporte : Form
    {
        private const string ArchivoClientes = "clientes.json";
        private const string ArchivoAutos = "autos.json";
        private const string ArchivoAlquileres = "alquileres.json";

        private List<Cliente> listaClientes = new List<Cliente>();
        private List<Auto> listaAutos = new List<Auto>();
        private List<Alquiler> listaAlquileres = new List<Alquiler>();

        public FormReporte()
        {
            InitializeComponent();
            CargarDatos();
            MostrarReporte();
            MostrarMayorRecorrido();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MostrarReporte();
            MostrarMayorRecorrido();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        //metodos


        private void CargarDatos()
        {
            listaClientes = JsonConvert.DeserializeObject<List<Cliente>>(File.ReadAllText(ArchivoClientes)) ?? new List<Cliente>();
            listaAutos = JsonConvert.DeserializeObject<List<Auto>>(File.ReadAllText(ArchivoAutos)) ?? new List<Auto>();
            listaAlquileres = JsonConvert.DeserializeObject<List<Alquiler>>(File.ReadAllText(ArchivoAlquileres)) ?? new List<Alquiler>();
        }

        private void MostrarReporte()
        {
            List<ReporteAlquiler> reporte = new List<ReporteAlquiler>();

            foreach (var alquiler in listaAlquileres)
            {
                var cliente = listaClientes.FirstOrDefault(c => c.Nit == alquiler.NitCliente);
                var auto = listaAutos.FirstOrDefault(a => a.Placa == alquiler.PlacaAuto);

                if (cliente != null && auto != null)
                {
                    reporte.Add(new ReporteAlquiler
                    {
                        NombreCliente = cliente.Nombre,
                        Placa = auto.Placa,
                        Marca = auto.Marca,
                        Modelo = auto.Modelo,
                        Color = auto.Color,
                        FechaDevolucion = alquiler.FechaDevolucion,
                        TotalPagar = alquiler.KilometrosRecorridos * auto.PrecioPorKm
                    });
                }
            }

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = reporte;
        }

        private void MostrarMayorRecorrido()
        {
            if (listaAlquileres.Count > 0)
            {
                int mayorKm = listaAlquileres.Max(a => a.KilometrosRecorridos);
                labelMayorKm.Text = $"Mayor recorrido: {mayorKm} km";
            }
        }

    }
}
