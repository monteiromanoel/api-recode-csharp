using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiAgenciaRecode.Model
{
    [Table("Reserva")]
    public class Reserva
    {

        public Reserva() 
        {
        
        }

        [Key]
        public int ReservaId { get; set; }

        public int NumPassageiros { get; set; }

        [Required]
        public DateTime DataReserva { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Preco { get; set; }

        [ForeignKey("Cliente")]
        public int ClienteId { get; set; }

        [ForeignKey("Destino")]
        public int DestinoId { get; set; }
    }
}
