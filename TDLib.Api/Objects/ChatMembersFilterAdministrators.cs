using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class TdApi
    {
        public partial class ChatMembersFilter : Object
        {
            public class ChatMembersFilterAdministrators : ChatMembersFilter
            {
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatMembersFilterAdministrators";

                [JsonProperty("@extra")] public override string Extra { get; set; }
            }
        }
    }
}