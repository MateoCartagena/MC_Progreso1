using System.ComponentModel.DataAnnotations;

namespace MC_Progreso1.Models
{
    public class MCartagena
    {
        public int MC_Edad { get; set; }
        //[Range(5, 10)]
        public decimal MC_PromedioGlobal { get; set; }
        //[StringLength(10)]
        //ErrorMessage = "Last Name should be minimum 3 characters and a maximum of 50 characters")]
        public string? MC_SegundoNombre { get; set; }
        public Boolean MC_Soltero { get; set; }
        public DateTime MC_FechaHoy { get; set; }

    }
}
