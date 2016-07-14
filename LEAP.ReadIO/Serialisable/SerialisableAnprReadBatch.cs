using System;
using System.Collections.Generic;
using LEAP.Core.Contracts;
using Newtonsoft.Json;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprReadBatch : IAnprReadBatch
    {
        [JsonProperty]
        public Guid Id { get; set; }

        [JsonProperty]
        public string Name { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public DateTime Created { get; set; }

        [JsonProperty]
        public DateTime Updated { get; set; }

        [JsonProperty]
        public List<SerialisableAnprRead> Reads { get; set; }
        IEnumerable<IAnprRead> IAnprReadBatch.Reads => Reads;
    }
}
