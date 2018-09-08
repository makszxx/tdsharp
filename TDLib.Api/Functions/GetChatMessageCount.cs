using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public class GetChatMessageCount : Function<Count>
        {
            [JsonProperty("@type")] public override string DataType { get; set; } = "getChatMessageCount";

            [JsonProperty("@extra")] public override string Extra { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("chat_id")]
            public long ChatId { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("filter")]
            public SearchMessagesFilter Filter { get; set; }

            [JsonConverter(typeof(Converter))]
            [JsonProperty("return_local")]
            public bool ReturnLocal { get; set; }
        }
    }
}