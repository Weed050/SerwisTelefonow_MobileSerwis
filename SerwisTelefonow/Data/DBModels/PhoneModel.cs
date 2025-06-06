using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SerwisTelefonow.DBModels
{
    [Table("model_kod")]
    public class PhoneModel
    {
        [Key]
        [Column("kod_modelu")]
        [StringLength(100)]
        public string KodModelu { get; set; }

        [Column("marka")]
        [StringLength(100)]
        public string Marka { get; set; }



        [Column("pelna_nazwa")]
        [StringLength(200)]
        public string PelnaNazwa { get; set; }

        public ICollection<ServiceEntry> WpisySerwisowe { get; set; } = new List<ServiceEntry>();
    }
}
