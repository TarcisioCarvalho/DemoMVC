using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace DemoMVC.Models
{
    public class Filme
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="O Campo Título é Obrigatório")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O Título deve ter entre 3 e 60 caracteres")]
        public string Titulo { get; set; }

        [DataType(DataType.DateTime,ErrorMessage = "Data em formato incorreto")]
        [Required(ErrorMessage = "O Campo Data é Obrigatório")]
        [Display(Name ="Data de Lançamento")]
        public DateTime DataLancamento { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\u00C0-\u00FF""'\w-]*$",ErrorMessage ="Genero em formato inválido")]
        [StringLength(60,MinimumLength =3,ErrorMessage = "O Genero deve ter entre 3 e 60 caracteres"),Required(ErrorMessage = "O Campo Genero é requirido")]
        public string Genero { get; set; }
        [Required(ErrorMessage = "Preencha o Campo Valor")]
        [Range(1,1000,ErrorMessage ="Valor de 1 a 1000")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Valor { get; set; }
        [Required(ErrorMessage ="Preencha o Campo Avaliação")]
        [Display(Name = "Avaliação")]
        [RegularExpression(@"^[0-5]*$",ErrorMessage ="Apenas números de 1 a 5")]
        public int Avaliacao { get; set; }


    }
}
