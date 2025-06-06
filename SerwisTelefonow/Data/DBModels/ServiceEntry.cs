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

        [StringLength(17, MinimumLength = 15)]
        [RegularExpression(@"^\d{15,17}$", ErrorMessage = "IMEI musi składać się z 15-17 cyfr")]
        [Column("imei")]
        public string? IMEI { get; set; }

        [Column("opis")]
        public string? Opis { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Cena musi być większa od 0.")]
        [Column("cena_wstepna")]
        public decimal? CenaWstepna { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Cena musi być większa od 0.")]
        [Column("cena_koncowa")]
        public decimal? CenaKoncowa { get; set; }
    


}
}
