using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Models;

namespace WindowsEFDatos.Dac
{
    public static class AbmAvion
    {
        private static DBLineaAereaContext context = new DBLineaAereaContext();

        public static List<Avion> SelectAll()
        {
            return context.Aviones.ToList();
        }

        public static int Insert(Avion aviones)
        {
            context.Aviones.Add(aviones);
            return context.SaveChanges();
        }

        public static Avion SelectById(int id)
        {
            return context.Aviones.Find(id);
        }

        public static int Update(Avion aviones)
        {
            Avion avionOrigen = context.Aviones.Find(aviones.IdAvion);
            avionOrigen.Capacidad = aviones.Capacidad;

            return context.SaveChanges();
        }

        public static int Delete(Avion aviones)
        {
            Avion avionOrigen = context.Aviones.Find(aviones.IdAvion);
            if (avionOrigen != null)
            {
                context.Aviones.Remove(avionOrigen);
                return context.SaveChanges();
            }
            return 0;

        }
    }
}
