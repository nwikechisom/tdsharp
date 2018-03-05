using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InlineQueryResult : Structure
    {

        public partial class inlineQueryResultVideo : InlineQueryResult
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inlineQueryResultVideo";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("video")]
                public Video.video video_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string description_;

        }

    }

}