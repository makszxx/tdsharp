using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class UserPrivacySettingRule : Structure
    {

        public class UserPrivacySettingRuleRestrictAll : UserPrivacySettingRule
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "userPrivacySettingRuleRestrictAll";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}