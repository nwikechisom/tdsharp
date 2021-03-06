using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class ValidateOrderInfo : Method<ValidatedOrderInfo>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "validateOrderInfo";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_id")]
        public long ChatId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("message_id")]
        public long MessageId { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("order_info")]
        public OrderInfo OrderInfo { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("allow_save")]
        public bool AllowSave { get; set; }

    }

}
