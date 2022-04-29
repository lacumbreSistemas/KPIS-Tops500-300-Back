namespace ApiKPITop500
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("KPI.Cbr_Item_Top500_Pasillo")]
    public partial class Cbr_Item_Top500_Pasillo
    {
        public int id { get; set; }

        [StringLength(50)]
        public string Pasillo { get; set; }
    }
}
