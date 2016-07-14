using System;
using LEAP.Core.Contracts;
using Newtonsoft.Json;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprReadSource : IAnprReadSource
    {
        [JsonProperty]
        public Guid DeviceId { get; set; }

        [JsonProperty]
        public string DeviceName { get; set; }

        [JsonProperty]
        public Guid LaneId { get; set; }

        [JsonProperty]
        public string LaneName { get; set; }

        [JsonProperty]
        public Guid ZoneId { get; set; }

        [JsonProperty]
        public string ZoneName { get; set; }

        [JsonProperty]
        public Guid SiteId { get; set; }

        [JsonProperty]
        public string SiteName { get; set; }

        [JsonProperty]
        public Guid CollectionId { get; set; }

        [JsonProperty]
        public string CollectionName { get; set; }
    }
}
