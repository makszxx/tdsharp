using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class BotCommand : Structure
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "botCommand";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("description")]
        public string Description { get; set; }

    }

}