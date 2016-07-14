using System;
using LEAP.Core.Contracts;
using LEAP.ReadIO.Exceptions;
using LEAP.ReadIO.Serialisable;
using Newtonsoft.Json;

namespace LEAP.ReadIO
{
    public static class BatchSerialiser
    {
        public static string Serialise(IAnprReadBatch value)
        {
            try
            {
                return JsonConvert.SerializeObject(value);
            }
            catch (Exception e)
            {
                throw new LeapSerialisationException("Serialisation Failed.", e);
            }
        }

        public static string Serialise(SerialisableAnprReadBatch value)
        {
            try
            {
                return JsonConvert.SerializeObject(value);
            }
            catch (Exception e)
            {
                throw new LeapSerialisationException("Serialisation Failed.", e);
            }
        }

        public static SerialisableAnprReadBatch Deserialise(string value)
        {
            try
            {
                return JsonConvert.DeserializeObject<SerialisableAnprReadBatch>(value);
            }
            catch (Exception e)
            {
                throw new LeapSerialisationException("Deserialisation Failed.", e);
            }
        }
    }
}
