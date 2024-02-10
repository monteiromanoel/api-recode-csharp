using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgenciaRecode.Model
{
    [Table("Cliente")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        [StringLength(100)]
        public string nome { get; set; }

        [Required]
        [StringLength(100)]
        public string email { get; set; }

        [Required]
        [StringLength(20)]
        public string senha { get; set;}

        [StringLength(100)]
        public string? documento { get; set; }

        [StringLength(20)]
        public string? telefone { get; set; }

        [StringLength(200)]
        public string? logradouro { get; set; }

        [StringLength(10)]
        public string? cep { get; set; }

        [StringLength(10)]
        public string? uf { get; set; }

        public DateTime dataNasc { get; set; }
    }
}
