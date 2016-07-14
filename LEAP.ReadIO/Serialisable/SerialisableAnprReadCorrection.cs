using System;
using LEAP.Core.Contracts;
using LEAP.Core.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprReadCorrection : IAnprReadCorrection
    {
        [JsonProperty]
        public DateTime CorrectionDate { get; set; }

        [JsonProperty]
        public string OriginalText { get; set; }

        [JsonProperty]
        public string CorrectedText { get; set; }

        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public AnprReadCorrectionStatusTypes Status { get; set; }

        [JsonProperty]
        public string Description { get; set; }

        [JsonProperty]
        public SerialisableAnprPersonnelSummary User { get; set; }

        IAnprPersonnelSummary IAnprReadCorrection.User => User;
    }
}
