using System;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaAsp.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Summary { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }

        // Relación
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
