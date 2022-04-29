namespace ApiKPITop500
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("KPI.Cbr_Items_Top500")]
    public partial class Cbr_Items_Top500
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        public int ItemId { get; set; }

        public int StoreId { get; set; }

        public bool Top500 { get; set; } = true;

        public bool Top300 { get; set; }
    }
}
