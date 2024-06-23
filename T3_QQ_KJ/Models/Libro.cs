using System.ComponentModel.DataAnnotations;

namespace T3_QQ_KJ.Models
{
    public class Libro
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El título es requerido.")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "El autor es requerido.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "El tema es requerido.")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "La editorial es requerida.")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "El año de publicación es requerido.")]
        [Range(1900, 3000, ErrorMessage = "El año de publicación debe estar entre 1900 y 3000.")]
        public int? AnioPublicacion { get; set; }

        [Required(ErrorMessage = "El número de páginas es requerido.")]
        [Range(10, 1000, ErrorMessage = "El número de páginas debe estar entre 10 y 1000.")]
        public int? Paginas { get; set; }

        [Required(ErrorMessage = "La categoría es requerida.")]
        public string Categoria { get; set; }
    }
}
