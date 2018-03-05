using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class Methods : object
    {

        public partial class searchChatRecentLocationMessages : Method<Messages>
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "searchChatRecentLocationMessages";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("chat_id")]
                public long? chat_id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("limit")]
                public int? limit_;

        }

    }

}