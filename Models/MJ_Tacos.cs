using System.ComponentModel.DataAnnotations;

namespace MJPruebaProgreso1.Models
{
    public class MJ_Tacos
    {
        [Key]
        public int TacoID { get; set; }


        [Required(ErrorMessage ="Debe ingresar el nombre para su taco")]
        public string? MJ_NombreTaco { get; set; }
        [Required(ErrorMessage ="Debe ingresar una descripcion para el producto")]
        [MinLength(10, ErrorMessage ="La descripcion del producto debe ser de almenos 10 caracteres")]
        public string? MJ_DescripcionDelTaco { get; set; }
        [Required(ErrorMessage ="El taco debe tener un precio")]
        [Range(1,25, ErrorMessage ="El taco debe tener un precio entre $1 y $25")]
        public decimal MJ_PrecioTaco { get; set; }

        public DateTime MJ_Fecha { get; set; }

        public bool MJ_Guacamole { get; set; }
    }
}
