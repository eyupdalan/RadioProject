using System.Runtime.Serialization;

namespace RadyoTypes
{
    [DataContract]
    public class Record : IEntity
    {
        [DataMember]
        public int RecordId { get; set; }

        [DataMember]
        public int BookId { get; set; }

        [DataMember]
        public int TopicId { get; set; }

        [DataMember]
        public string BookName { get; set; }

        [DataMember]
        public string TopicName { get; set; }

        [DataMember]
        public string RecordPath { get; set; }

        [DataMember]
        public string RecordName { get; set; }

        [DataMember]
        public float? DurationInSec { get; set; }
    }
}
