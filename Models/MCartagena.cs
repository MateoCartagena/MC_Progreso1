using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace MC_Progreso1.Models
{
    //[Key]
    public class MCartagena
    {
        [Key]
        public int McID { get; set; }
        [Range(5, 10)]
        public decimal McPromedioGlobal { get; set; }
        //[StringLength(10)]
        //ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        public string? McSegundoNombre { get; set; }
        public Boolean McSoltero { get; set; }
        public DateTime McFechaHoy { get; set; }

    }
}
