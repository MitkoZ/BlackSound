using BlackSound.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackSound.Repositories
{
    class SongsRepository : BaseRepository<Song>
    {
        public SongsRepository(string filePath) : base(filePath)
        {
        }
        protected override void PopulateEntity(StreamReader sr, Song item)
        {
            item.Id = Int32.Parse(sr.ReadLine());
            item.Title = sr.ReadLine();
            item.ArtistName = sr.ReadLine();
            item.Year = Int32.Parse(sr.ReadLine());
        }
        protected override void WriteEntity(StreamWriter sw, Song item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.Title);
            sw.WriteLine(item.ArtistName);
            sw.WriteLine(item.Year);
        }
    }
}
