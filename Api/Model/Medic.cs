

using Api.Model.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model
{
    [Table("medics")]
    public class Medic : BaseEntity
    {
        [Column("Nome")]
        public string Name { get; set; }

        [Column("CRM")]
        public string CRM { get; set; }

        [Column("Especialidade")]
        public string Specialty { get; set; }

        [Column("Genero")]
        public char Gender { get; set; }
    }
}
