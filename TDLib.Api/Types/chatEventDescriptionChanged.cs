using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public partial class chatEventDescriptionChanged : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "chatEventDescriptionChanged";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("old_description")]
                public string old_description_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("new_description")]
                public string new_description_;

        }

    }

}