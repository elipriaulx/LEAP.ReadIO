using System;
using LEAP.Core.Contracts;
using Newtonsoft.Json;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprSyntaxSummary : IAnprSyntaxSummary
    {
        [JsonProperty]
        public Guid SyntaxId { get; set; }

        [JsonProperty]
        public string SyntaxName { get; set; }

        [JsonProperty]
        public string SyntaxDescription { get; set; }

        [JsonProperty]
        public string SyntaxVersion { get; set; }
    }
}
