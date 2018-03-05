using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputInlineQueryResult : Structure
    {

        public partial class inputInlineQueryResultPhoto : InputInlineQueryResult
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "inputInlineQueryResultPhoto";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string id_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string title_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("description")]
                public string description_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_url")]
                public string thumbnail_url_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo_url")]
                public string photo_url_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo_width")]
                public int? photo_width_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("photo_height")]
                public int? photo_height_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup reply_markup_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_message_content")]
                public InputMessageContent input_message_content_;

        }

    }

}