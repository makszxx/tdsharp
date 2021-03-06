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
        /// The text should be parsed in markdown-style
        /// </summary>
        public partial class TextParseMode : Object
        {
            /// <summary>
            /// The text should be parsed in markdown-style
            /// </summary>
            public class TextParseModeMarkdown : TextParseMode
            {
                /// <summary>
                /// Data type for serialization
                /// </summary>
                [JsonProperty("@type")]
                public override string DataType { get; set; } = "textParseModeMarkdown";

                /// <summary>
                /// Extra data attached to the message
                /// </summary>
                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                /// <summary>
                /// Version of the parser: 0 or 1 - Bot API Markdown parse mode, 2 - Bot API MarkdownV2 parse mode
                /// </summary>
                [JsonConverter(typeof(Converter))]
                [JsonProperty("version")]
                public int Version { get; set; }
            }
        }
    }
}