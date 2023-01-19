using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Models;

namespace WindowsEFDatos
{
    public partial class frmAvion : Form
    {
        public frmAvion()
        {
            InitializeComponent();
        }

        private void frmAvion_Load(object sender, EventArgs e)
        {
            MostrarAviones();
        }


        private void MostrarAviones()
        {
            GridAvion.DataSource = AbmAvion.SelectAll();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { Capacidad = Convert.ToInt32(txtCapacidad.Text), Denominacion = txtDenominacion.Text };
            int filasAfectadas = AbmAvion.Insert(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Insert ok");
                MostrarAviones();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() {IdAvion= Convert.ToInt32(txtId.Text), Capacidad = Convert.ToInt32(txtCapacidad.Text), Denominacion = txtDenominacion.Text };
            int filasAfectadas = AbmAvion.Update(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Update ok");
                MostrarAviones();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion() { IdAvion = Convert.ToInt32(txtId.Text), Capacidad = Convert.ToInt32(txtCapacidad.Text), Denominacion = txtDenominacion.Text };
            int filasAfectadas = AbmAvion.Delete(avion);
            if (filasAfectadas > 0)
            {
                MessageBox.Show("Delete ok");
                MostrarAviones();
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            Avion avion = AbmAvion.SelectById(id);
            MessageBox.Show(Convert.ToString(avion.Capacidad) + " " + avion.Denominacion);
        }
    }
}
