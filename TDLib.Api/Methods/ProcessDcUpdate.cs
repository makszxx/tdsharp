using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ProcessDcUpdate : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "processDcUpdate";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("dc")]
        public string Dc { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("addr")]
        public string Addr { get; set; }

    }

}