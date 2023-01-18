using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class Remolque
    {

        public int CargaMaxima { get; set; }

        public Remolque(int cargaMaxima)
        {
            CargaMaxima = cargaMaxima;
        }
    }
}
