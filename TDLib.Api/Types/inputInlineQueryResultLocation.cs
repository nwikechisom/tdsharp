using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class InputInlineQueryResult : Structure
    {

        public class InputInlineQueryResultLocation : InputInlineQueryResult
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "inputInlineQueryResultLocation";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("id")]
                public string Id { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("location")]
                public Location Location { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("live_period")]
                public int LivePeriod { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("title")]
                public string Title { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_url")]
                public string ThumbnailUrl { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_width")]
                public int ThumbnailWidth { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("thumbnail_height")]
                public int ThumbnailHeight { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("reply_markup")]
                public ReplyMarkup ReplyMarkup { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("input_message_content")]
                public InputMessageContent InputMessageContent { get; set; }

        }

    }

}
