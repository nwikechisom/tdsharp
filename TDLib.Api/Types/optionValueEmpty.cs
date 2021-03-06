using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class OptionValue : Structure
    {

        public class OptionValueEmpty : OptionValue
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "optionValueEmpty";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
