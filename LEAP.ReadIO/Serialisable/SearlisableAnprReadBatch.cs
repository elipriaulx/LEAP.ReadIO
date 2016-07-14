using System;
using System.Collections.Generic;
using System.Linq;
using LEAP.Core.Contracts;
using Newtonsoft.Json;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SearlisableAnprReadBatch : IAnprReadBatch
    {
        [JsonProperty]
        public Guid Id { get; }

        [JsonProperty]
        public string Name { get; }

        [JsonProperty]
        public string Description { get; }

        [JsonProperty]
        public DateTime Created { get; }

        [JsonProperty]
        public DateTime Updated { get; }

        [JsonProperty]
        public List<SerialisableAnprRead> Reads { get; set; }

        IEnumerable<IAnprRead> IAnprReadBatch.Reads => Reads?.Select(x => x);
    }
}
