using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class PassportElementType : Object
        {
            public class PassportElementTypeTemporaryRegistration : PassportElementType
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementTypeTemporaryRegistration";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}