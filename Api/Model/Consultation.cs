
using Api.Model.Base;
using System;

namespace Api.Model
{
    public class Consultation : BaseEntity
    {
        public DateTime Data { get; set; }
        public Medic Medic { get; set; }
        public Patient Patient { get; set; }

    }
}
