using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Demo.Models
{
    public partial class Solicitude
    {
        public Solicitude()
        {
            Configuracions = new HashSet<Configuracion>();
        }

        public int Id { get; set; }
        public int? Status { get; set; }
        public TimeSpan? FechaCreacion { get; set; }
        public DateTime? FechaCancelacion { get; set; }
        [JsonIgnore]
        public virtual ICollection<Configuracion> Configuracions { get; set; }
    }
}
