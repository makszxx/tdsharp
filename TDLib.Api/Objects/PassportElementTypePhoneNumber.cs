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
            public class PassportElementTypePhoneNumber : PassportElementType
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "passportElementTypePhoneNumber";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}