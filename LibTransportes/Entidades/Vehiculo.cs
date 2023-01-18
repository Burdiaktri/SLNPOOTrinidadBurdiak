using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Vehiculo
    {
        public string Matricula { get; set; }
        public int Kilometraje { get; set; }

        public virtual string Acelera()
        {
            return "Acelera...";
        }

        public virtual string Frena()
        {
            return "Frena...";
        }
        public Vehiculo(string matricula, int kilometraje)
        {
            Matricula = matricula;
            Kilometraje = kilometraje;
        }

    }
}
