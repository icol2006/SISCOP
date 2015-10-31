using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SistemaSISCOP.Models
{
    public class ViewEtapaTarea
    {
        [Display(Name = "Id")]
        public int id_tarea { get; set; }
        [Display(Name = "Descripcion")]
        public string descripcion { get; set; }
        [Display(Name = "Fecha Inicio")]
        public string fecha_inicio { get; set; }
        [Display(Name = "Fecha Final")]
        public string fecha_final { get; set; }
        [Display(Name = "Estado")]
        public string estado { get; set; }
        [Display(Name = "Id")]
        public int id_usuario { get; set; }
        [Display(Name = "Usuario-Id")]
        public string nombre_usuario { get; set; }
        [Display(Name = "Prioridad")]
        public string prioridad { get; set; }

    }
}