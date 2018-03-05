using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ReplyMarkup : Structure
    {

        public partial class replyMarkupShowKeyboard : ReplyMarkup
        {

                [JsonProperty("@type")]
                public override string Type { get; set; } = "replyMarkupShowKeyboard";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

                [JsonConverter(typeof(Converter))]
                [JsonProperty("rows")]
                public KeyboardButton.keyboardButton[][] rows_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("resize_keyboard")]
                public bool? resize_keyboard_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("one_time")]
                public bool? one_time_;

                [JsonConverter(typeof(Converter))]
                [JsonProperty("is_personal")]
                public bool? is_personal_;

        }

    }

}