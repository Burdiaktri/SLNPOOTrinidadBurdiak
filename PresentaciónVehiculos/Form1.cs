using LibTransportes.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentaciónVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Camion camion = new Camion("AAA123", 12000, 9000, null);
            MessageBox.Show("Matricula: " + camion.Matricula + " " +
                            "Kilometraje: " + camion.Kilometraje + " " +
                            "Carga Maxima: " + camion.CargaMaxima + " " +
                            "Frena: " + camion.Frena() + " " +
                            "Acelera: " + camion.Acelera());

            Remolque remolque = new Remolque(3000);
            MessageBox.Show(remolque.CargaMaxima.ToString());
        }
    }
}
