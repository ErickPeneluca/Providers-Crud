using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DivTech.Models
{
    [Table("Fornecedor")]
    public class Fornecedor
    {
        [Key]
        [Column("Id")]
        [Display(Name = "Código do fornecedor")]
        public int Id { get; set; }
        [Required]
        [StringLength(30,MinimumLength =3,ErrorMessage ="Insira um nome válido por favor")]
        [Column("Name")]
        [Display(Name = "Nome")]
        public string ?Name { get; set; }
        [Required]
        [StringLength(14,MinimumLength =14,ErrorMessage ="O CNPJ DEVE CONTER 14 DIGITOS")]
        [Column("CNPJ")]
        [Display(Name = "CNPJ")]
        public string ?CNPJ { get; set; }

        [Column("Specialty")]
        [Display(Name = "Especialidade")]
        public string ?Specialty { get; set; }
    }
}
