using System;
using LEAP.Core.Contracts;
using Newtonsoft.Json;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprPersonnelSummary : IAnprPersonnelSummary
    {
        [JsonProperty]
        public Guid Id { get; set; }

        [JsonProperty]
        public string DisplayName { get; set; }

        [JsonProperty]
        public string Description { get; set; }
    }
}
