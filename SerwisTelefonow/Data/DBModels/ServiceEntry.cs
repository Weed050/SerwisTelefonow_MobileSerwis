using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerwisTelefonow.DBModels
{
    [Table("wpis_serwisowy")]
    public class ServiceEntry
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [ForeignKey("Client")]
        [Column("klient_id")]
        public int KlientId { get; set; }

        public Clients Client { get; set; }

        [Column("kod_modelu")]
        [StringLength(100)]
        public string KodModelu { get; set; }

        [ForeignKey("KodModelu")]
        public PhoneModel Model { get; set; }

        [Column("imei")]
        [StringLength(50)]
        public string? IMEI { get; set; }

        [Column("opis")]
        public string? Opis { get; set; }

        [Column("cena_wstepna")]
        public decimal? CenaWstepna { get; set; }

        [Column("cena_koncowa")]
        public decimal? CenaKoncowa { get; set; }
    


}
}
