using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Ventas_MVC.Models
{
    public class Autos
    {
        [DisplayName("Codigo del auto")]
        [Required]
        public int Codigo { get; set; }

        [Required(ErrorMessage ="La marca es requerida")]
        public string Marca { get; set; }

        public string Modelo { get; set; }

        [DisplayName("Año")]
        [Required]
        [Range(2010,2022,ErrorMessage ="Rango de autos es del 2010 al 2022")]
        public string anio { get; set; }

        [DisplayName("Fecha del auto")]
        [DataType(DataType.Date)]
        public DateTime FechaAuto { get; set; }

        [DisplayName("Color del auto")]
        public string Color { get; set; }

        [DisplayName("Observaciones del auto")]
        [DataType(DataType.MultilineText)]
        [StringLength(15,ErrorMessage ="Maximo 15 caracteres")]
        public string Observaciones { get; set; }

        public bool Nuevo { get; set; }
        
    }
}