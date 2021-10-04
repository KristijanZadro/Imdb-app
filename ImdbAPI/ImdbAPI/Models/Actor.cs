using ImdbAPI.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImdbAPI.Models
{
    public class Actor : BaseEntity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public IEnumerable<MovieActor> Cast { get; set; }
    }
}
