using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Título é obrigatório")]
        [Display(Name = "Título")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O título precisa ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O campo Data de Lançamento é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data em formato incorreto")]
        [Display(Name = "Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "O campo Gênero é obrigatório")]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF]""'\w-]*$", ErrorMessage = "Gênero em formato inválido")]
        [StringLength(30, ErrorMessage = "Máximo de 30 caracteres")]
        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório")]
        [Range(1, 1000, ErrorMessage = "Valor de 1 a 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo Avaliação é obrigatório")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$", ErrorMessage = "Somente números")]
        public int Avaliacao { get; set; }
    }
}