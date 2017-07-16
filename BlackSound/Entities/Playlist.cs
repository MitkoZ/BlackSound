using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSound.Entities
{
    class Playlist : BaseEntity
    {
        public int ParentUserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }
    }
}
