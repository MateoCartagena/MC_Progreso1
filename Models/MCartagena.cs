using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MC_Progreso1.Models
{
    //[Key]
    public class MCartagena
    {
        [Key]
        public int ID { get; set; }


        [Required]
        [StringLength(10)]
        public int McCedula { get; set; }

        [Display(Name = "Cuál es su promedio global?")]
        [Range(5, 10)]
        public decimal McPromedioGlobal { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Cuál es su segund nombre?")]
        //ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        public string? McSegundoNombre { get; set; }

        [Display(Name = "Es soltero?")]
        public Boolean McSoltero { get; set; }

        [Display(Name = "Qué día esta registrando")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime McFechaHoy { get; set; }

    }
}
