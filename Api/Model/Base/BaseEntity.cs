using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Model.Base
{
    // Contrato entre atributos e classes
    // [DataContract]
    public class BaseEntity
    {
        [Column("id")]
        public long? Id { get; set; }
    }
}
