namespace ApiKPITop500
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("KPI.Cbr_Items_Pasillos")]
    public partial class Cbr_Items_Pasillos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int ItemId { get; set; }

        public int? PasilloId { get; set; }

        public int Tienda { get; set; }
    }
}
