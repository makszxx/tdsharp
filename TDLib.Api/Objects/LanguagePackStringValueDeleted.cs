using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class LanguagePackStringValue : Object
        {
            public class LanguagePackStringValueDeleted : LanguagePackStringValue
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "languagePackStringValueDeleted";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}