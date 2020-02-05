using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace _1erParcial_JonathanMaria.Data
{
    public class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public float Costo { get; set; }
        public float Ganancia { get; set; }
        public float Precio { get; set; }

        public Articulos()
        {
            ArticuloId = 0;
            Fecha = DateTime.Now;
            Descripcion = string.Empty;
            Costo = 0;
            Ganancia = 0;
            Precio = 0;
        }
    }
}
