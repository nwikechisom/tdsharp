using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class EditInlineMessageReplyMarkup : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "editInlineMessageReplyMarkup";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("inline_message_id")]
        public string InlineMessageId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("reply_markup")]
        public ReplyMarkup ReplyMarkup { get; set; }

    }

}
