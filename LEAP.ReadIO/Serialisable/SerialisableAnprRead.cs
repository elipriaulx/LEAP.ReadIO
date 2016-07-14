using System;
using System.Collections.Generic;
using System.Linq;
using LEAP.Core.Contracts;
using LEAP.Core.Types;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LEAP.ReadIO.Serialisable
{
    [JsonObject(MemberSerialization.OptIn)]
    public class SerialisableAnprRead : IAnprRead
    {
        [JsonProperty]
        public Guid Id { get; set; }

        [JsonProperty]
        public DateTime Captured { get; set; }

        [JsonProperty]
        public GeoSummary? Location { get; set; }

        [JsonProperty]
        public Guid? LocationId { get; set; }

        [JsonProperty]
        public string PlateText { get; set; }

        [JsonProperty]
        public double Confidence { get; set; }

        [JsonProperty]
        public double[] CharacterConfidence { get; set; }

        IEnumerable<double> IAnprRead.CharacterConfidence => CharacterConfidence;

        [JsonProperty]
        [JsonConverter(typeof(StringEnumConverter))]
        public AnprReadVehicleViewTypes VehicleView { get; set; }

        [JsonProperty]
        public string PatchImageString
        {
            get { return PatchImageBytes != null ? Convert.ToBase64String(PatchImageBytes) : null; }
            set { PatchImageBytes = value != null ? Convert.FromBase64String(value) : null; }
        }
        public byte[] PatchImageBytes { get; set; }

        [JsonProperty]
        public RectangularPoint PatchSize { get; set; }

        [JsonProperty]
        public string ResultImageString
        {
            get { return ResultImageBytes != null ? Convert.ToBase64String(ResultImageBytes) : null; }
            set { ResultImageBytes = value != null ? Convert.FromBase64String(value) : null; }
        }
        public byte[] ResultImageBytes { get; set; }

        [JsonProperty]
        public RectangularPoint ResultSize { get; set; }

        [JsonProperty]
        public RectangularQuadrilateral? ResultPatchRegion { get; set; }

        [JsonProperty]
        public RectangularQuadrilateral? ResultPatchArea { get; set; }

        [JsonProperty]
        public string OverviewImageString
        {
            get { return OverviewImageBytes != null ? Convert.ToBase64String(OverviewImageBytes) : null; }
            set { OverviewImageBytes = value != null ? Convert.FromBase64String(value) : null; }
        }
        public byte[] OverviewImageBytes { get; set; }

        [JsonProperty]
        public List<SerialisableAnprReadNote> Notes { get; set; }
        IEnumerable<IAnprReadNote> IAnprRead.Notes => Notes?.Select(x => x);

        [JsonProperty]
        public List<SerialisableAnprReadTag> Tags { get; set; }
        IEnumerable<IAnprReadTag> IAnprRead.Tags => Tags?.Select(x => x);

        [JsonProperty]
        public SerialisableAnprEngineSummary Engine { get; set; }
        IAnprEngineSummary IAnprRead.Engine => Engine;

        [JsonProperty]
        public SerialisableAnprSyntaxSummary Syntax { get; set; }
        IAnprSyntaxSummary IAnprRead.Syntax => Syntax;

        [JsonProperty]
        public SerialisableAnprReadSource Source { get; set; }
        IAnprReadSource IAnprRead.Source => Source;

        [JsonProperty]
        public SerialisableAnprReadCorrection Correction { get; set; }
        IAnprReadCorrection IAnprRead.Correction => Correction;

        [JsonProperty]
        public Dictionary<string, string> Meta { get; set; }
        IEnumerable<KeyValuePair<string, string>> IAnprRead.Meta => Meta.AsEnumerable();
    }
}
