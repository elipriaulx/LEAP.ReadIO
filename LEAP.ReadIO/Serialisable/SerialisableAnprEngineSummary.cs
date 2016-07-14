using System;
using LEAP.Core.Contracts;
using Newtonsoft.Json;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprEngineSummary : IAnprEngineSummary
    {
        [JsonProperty]
        public Guid EngineId { get; set; }

        [JsonProperty]
        public string EngineName { get; set; }

        [JsonProperty]
        public string EngineVersion { get; set; }

        [JsonProperty]
        public string EngineDescription { get; set; }
    }
}
