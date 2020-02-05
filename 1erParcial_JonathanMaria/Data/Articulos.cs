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
        [Required(ErrorMessage ="La descripcion no puede estar vacia!...")]
        public string Descripcion { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 999999999, ErrorMessage = "El costo debe estar comprendido entre 1 y 999,999,999")]
        public float Costo { get; set; }
        [Required]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "El costo debe estar comprendido entre 1 y 10,000")]
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
