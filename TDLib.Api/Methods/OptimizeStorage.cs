using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class OptimizeStorage : Method<StorageStatistics>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "optimizeStorage";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("size")]
        public long Size { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("ttl")]
        public int Ttl { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("immunity_delay")]
        public int ImmunityDelay { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("file_types")]
        public FileType[] FileTypes { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_ids")]
        public long[] ChatIds { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("exclude_chat_ids")]
        public long[] ExcludeChatIds { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("chat_limit")]
        public int ChatLimit { get; set; }

    }

}
