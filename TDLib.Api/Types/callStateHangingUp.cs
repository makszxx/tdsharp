using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class CallState : Structure
    {

        public class CallStateHangingUp : CallState
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "callStateHangingUp";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}