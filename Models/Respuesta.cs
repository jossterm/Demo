﻿using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Demo.Models
{
    public class Respuesta<T>
    {
        public int Ok { get; set; }
        public List<T> Data { get; set; } = new List<T>();
        public string? Message { get; set; }
    }

    public class Enlace
    {
        public string? Url { get; set; }
    }
}