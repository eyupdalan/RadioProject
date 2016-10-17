using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadyoTypes
{
    public class Casette : IEntity
    {
        public int CasetteId { get; set; }
        public int TopicId { get; set; }
        public string TopicName { get; set; }
        public string CasetteName { get; set; }
        public string Path { get; set; }
        public float Duration { get; set; }
    }
}
