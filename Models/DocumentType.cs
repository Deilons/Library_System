using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Library_System.Models
{

    [Table("document_ypes")]
    public class DocumentType
    {
        [Key]
        public int Id { get; set; }

        [Column("name")]
        [MaxLength(50, ErrorMessage = "Name cannot be longer than 50 characters")]
        public required string Name { get; set; }

        [Column("abbreviation")]
        [MinLength(1, ErrorMessage = "Abbreviation cannot be empty")]
        [MaxLength(10, ErrorMessage = "Abbreviation cannot be longer than 10 characters")]
        public required string Abbreviation { get; set; }

        [Column("description")]
        [MaxLength(100, ErrorMessage = "Description cannot be longer than 100 characters")]
        [RegularExpression(@"^[a-zA-Z0-9\s]+$", ErrorMessage = "Description can only contain letters, numbers, and spaces")]
        public string? Description { get; set; }

    }

}