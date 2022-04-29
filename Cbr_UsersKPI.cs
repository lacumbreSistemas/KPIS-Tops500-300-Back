namespace ApiKPITop500
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("KPI.Cbr_UsersKPI")]
    public partial class Cbr_UsersKPI
    {
        [Key]
        public int userID { get; set; }

        [StringLength(50)]
        public string NombreCompleto { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string Usuario { get; set; }


        public int Rol { get; set; }

        public bool IsLogged { get; set; }

        public int StoreId { get; set; }

        public bool State { get; set; }
    }
}
