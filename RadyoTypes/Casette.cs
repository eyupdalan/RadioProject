using System.Runtime.Serialization;

namespace RadyoTypes
{
    [DataContract]
    public class Casette : IEntity
    {
        [DataMember]
        public int CasetteId { get; set; }

        [DataMember]
        public int TopicId { get; set; }

        [DataMember]
        public string TopicName { get; set; }

        [DataMember]
        public string CasetteName { get; set; }

        [DataMember]
        public string Path { get; set; }

        [DataMember]
        public float Duration { get; set; }
    }
}
