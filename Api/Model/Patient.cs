using Api.Model.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Model
{
    public class Patient : BaseEntity
    {
        [Column("Nome")]
        public string Name { get; set; }

        [Column("Idade")]
        public int Age { get; set; }

        [Column("Telefone")]
        public string Phone { get; set; }

        [Column("Genero")]
        public char Gender { get; set; }

        [Column("Endereco")]
        public string Address { get; set; }
    }
}
