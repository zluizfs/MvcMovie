using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [StringLength(60)]
        [MinLength(3)]
        public string Title { get; set; }

        [Display(Name = "Data do Lançamento")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [MaxLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Genre { get; set; }

        [Range(1,100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal Price { get; set; }

        [StringLength(5)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        [Required]
        public string Rating {get;set;}
    }
}