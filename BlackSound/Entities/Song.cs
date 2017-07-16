using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSound.Entities
{
    class Song : BaseEntity
    {
        public string Title { get; set; }
        public string ArtistName { get; set; }
        public int Year { get; set; }
    }
}
