using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Camion : Vehiculo
    {
        public int CargaMaxima { get; set; }

        public Remolque Remolque { get; set; }

        public virtual string QuitarRemolque()
        {
            Remolque = null;
            return "Quita remolque";
        }
        public override string Acelera()
        {
            return "Acelera despacio";
        }

        public override string Frena()
        {
            return "Frena despacio";
        }
        public Camion(string matricula, int kilometraje, int cargaMaxima, Remolque remolque) : base(matricula, kilometraje)
        {
            CargaMaxima = cargaMaxima;
            Remolque = remolque;

        }
    }
}
