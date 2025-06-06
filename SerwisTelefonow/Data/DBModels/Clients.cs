using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerwisTelefonow.DBModels
{
    [Table("klient")]
    public class Clients
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Required]
        [Column("imie")]
        [StringLength(150)]
        public string Imie { get; set; }
        [Required]
        [Column("nazwisko")]
        [StringLength(150)]
        public string Nazwisko { get; set; }

        [Column("telefon")]
        [StringLength(20)]
        public string? Telefon { get; set; }

        public ICollection<ServiceEntry> WpisySerwisowe { get; set; } = new List<ServiceEntry>();
    }
}

