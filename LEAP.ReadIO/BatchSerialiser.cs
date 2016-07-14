using LEAP.Core.Contracts;
using LEAP.ReadIO.Serialisable;
using Newtonsoft.Json;

namespace LEAP.ReadIO
{
    public static class BatchSerialiser
    {
        public static string Serialise(IAnprReadBatch value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static string Serialise(SerialisableAnprReadBatch value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static SerialisableAnprReadBatch Deserialise(string value)
        {
            return JsonConvert.DeserializeObject<SerialisableAnprReadBatch>(value);
        }
    }
}
