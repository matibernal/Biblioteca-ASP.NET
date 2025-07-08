using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaAsp.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100,MinimumLength = 3, ErrorMessage = "Debe tener entre 3 y 100 caracteres.")]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
