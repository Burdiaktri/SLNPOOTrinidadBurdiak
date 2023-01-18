using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes.Entidades
{
    public class AutoElectrico : Vehiculo
    {
        public string Marca { get; set; }

        public override string Acelera()
        {
            return "Acelera rápido";
        }

        public override string Frena()
        {
            return "Frena rápido";
        }
        public AutoElectrico(string matricula, int kilometraje, string marca) : base(matricula, kilometraje)
        {
            Marca = marca;
        }
    }
}
