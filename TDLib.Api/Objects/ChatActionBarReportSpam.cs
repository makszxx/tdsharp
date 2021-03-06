using System;
using Newtonsoft.Json;

namespace TdLib
{
    /// <summary>
    /// Autogenerated TDLib APIs
    /// </summary>
    public static partial class TdApi
    {
        /// <summary>
        /// The chat can be reported as spam using the method reportChat with the reason chatReportReasonSpam
        /// </summary>
        public partial class ChatActionBar : Object
        {
            /// <summary>
            /// The chat can be reported as spam using the method reportChat with the reason chatReportReasonSpam
            /// </summary>
            public class ChatActionBarReportSpam : ChatActionBar
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatActionBarReportSpam";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }
            }
        }
    }
}