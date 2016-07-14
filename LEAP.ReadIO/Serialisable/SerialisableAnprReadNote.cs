using System;
using LEAP.Core.Contracts;
using Newtonsoft.Json;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprReadNote : IAnprReadNote
    {
        [JsonProperty]
        public DateTime Created { get; set; }

        [JsonProperty]
        public SerialisableAnprPersonnelSummary Reporter { get; set; }

        IAnprPersonnelSummary IAnprReadNote.Reporter => Reporter;

        [JsonProperty]
        public string Note { get; set; }
    }
}
