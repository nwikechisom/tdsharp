using System;
using Newtonsoft.Json;

namespace TD {

    /// <summary>
    /// AUTOGENERATED: DO NOT EDIT!
    /// </summary>
    public partial class ChatEventAction : Structure
    {

        public class ChatEventMemberLeft : ChatEventAction
        {

                [JsonProperty("@type")]
                public override string DataType { get; set; } = "chatEventMemberLeft";

                [JsonProperty("@extra")]
                public override string Extra { get; set; }

        }

    }

}
