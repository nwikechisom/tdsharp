using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthenticationCodeType : Structure
    {

        public partial class authenticationCodeTypeFlashCall : AuthenticationCodeType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "authenticationCodeTypeFlashCall";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("pattern")]
                public string pattern_;

        }

    }

}