using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputCredentials : Structure
    {

        public class InputCredentialsAndroidPay : InputCredentials
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputCredentialsAndroidPay";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("data")]
                public string Data { get; set; }

        }

    }

}