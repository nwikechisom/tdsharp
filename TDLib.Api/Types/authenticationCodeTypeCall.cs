using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class AuthenticationCodeType : Structure
    {

        public partial class authenticationCodeTypeCall : AuthenticationCodeType
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "authenticationCodeTypeCall";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("length")]
                public int? length_;

        }

    }

}