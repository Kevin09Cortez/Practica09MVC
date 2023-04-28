using System.ComponentModel.DataAnnotations;

namespace Practica09MVC.Models
{
    public class estados_equipo
    {
        [Key]
        [Display(Name = "ID")]
        public int id_estados_equipo { get; set; }
        [Display(Name = "Descripcion")]
        public string? descripcion { get; set; }
        [Display(Name = "Estado")]
        public string? estado { get; set; }
    }
}
