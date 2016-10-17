using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadyoTypes
{
    public class Record : IEntity
    {
        public int RecordId { get; set; }
        public int BookId { get; set; }
        public int TopicId { get; set; }
        public string BookName { get; set; }
        public string TopicName { get; set; }
        public string RecordPath { get; set; }
        public string RecordName { get; set; }
        public float DurationInSec { get; set; }
    }
}
