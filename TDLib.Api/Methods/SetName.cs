using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public class SetName : Method<Ok>
    {

        [JsonProperty("@type")]
        public override string DataType { get; set; } = "setName";

        [JsonProperty("@extra")]
        public override string Extra { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonConverter(typeof(Converter))]
        [JsonProperty("last_name")]
        public string LastName { get; set; }

    }

}
