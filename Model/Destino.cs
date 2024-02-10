using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgenciaRecode.Model
{
    [Table("Destino")]
    public class Destino
    {
        

        [Key]
        public int DestinoId { get; set; }

        [Required]
        [StringLength(150)]
        public string destino {  get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal preco { get; set; }

        [Required]
        public DateTime data_ida { get; set; }

        [Required]
        public DateTime data_volta { get; set; }

        [StringLength(200)]
        public string descricao_curta { get; set; }

        [Column(TypeName = "longtext")]
        public string descricao_longa { get; set; }

        [StringLength(150)]
        public string adicional {  get; set; }

        [Required]
        [StringLength(150)]
        public string localidade { get; set; }

        [Required]
        [Column(TypeName = "longtext")]
        public string imagem { get; set; }

        [StringLength(150)]
        public string tipo_pacote { get; set; }

        [Column(TypeName = "longtext")]
        public string? imagem2 { get; set; }

        [Column(TypeName = "longtext")]
        public string? imagem3 { get; set; }

        [Column(TypeName = "longtext")]
        public string? imagem4 { get; set;}

        [Column(TypeName = "decimal(10,2)")]
        public decimal? preco_antigo { get; set; }

        [StringLength(100)]
        public string? label_promocao { get; set; }
    }
}
