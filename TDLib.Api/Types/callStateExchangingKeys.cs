using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class CallState : Structure
    {

        public partial class callStateExchangingKeys : CallState
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "callStateExchangingKeys";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}