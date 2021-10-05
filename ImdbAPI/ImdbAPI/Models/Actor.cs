using ImdbAPI.Models.Base;
using System.Collections.Generic;

namespace ImdbAPI.Models
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<MediaActor> Cast { get; set; }
    }
}
