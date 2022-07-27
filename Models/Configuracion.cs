using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Demo.Models
{
    public partial class Configuracion
    {
        public int Id { get; set; }
        public int? IdSolicitud { get; set; }
        public TimeSpan? Vencimiento { get; set; }
        [JsonIgnore]
        public virtual Solicitude? IdSolicitudNavigation { get; set; }
    }
}
