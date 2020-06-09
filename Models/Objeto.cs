﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using CYBERTRACK_DESKTOP.Models;
//
//    var temperatures = Temperatures.FromJson(jsonString);

namespace CYBERTRACK_DESKTOP.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Objeto
    {
        [JsonProperty("codigo")]
        public string Codigo { get; set; }

        [JsonProperty("host")]
        public string Host { get; set; }

        [JsonProperty("eventos")]
        public List<Evento> Eventos { get; set; }

        [JsonProperty("time")]
        public double Time { get; set; }

        [JsonProperty("quantidade")]
        public long Quantidade { get; set; }

        [JsonProperty("servico")]
        public string Servico { get; set; }

        [JsonProperty("ultimo")]
        public DateTimeOffset Ultimo { get; set; }
    }

    public partial class Evento
    {
        [JsonProperty("data")]
        public string Data { get; set; }

        [JsonProperty("hora")]
        public string Hora { get; set; }

        [JsonProperty("local")]
        public string Local { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("subStatus")]
        public List<string> SubStatus { get; set; }
    }

    public partial class Objeto
    {
        public static Objeto FromJson(string json) => JsonConvert.DeserializeObject<Objeto>(json, CYBERTRACK_DESKTOP.Models.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Objeto self) => JsonConvert.SerializeObject(self, CYBERTRACK_DESKTOP.Models.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
