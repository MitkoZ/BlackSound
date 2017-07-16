using BlackSound.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackSound.Repositories
{
    class PlaylistsSongsRepository : BaseRepository<PlaylistsSongs>
    {
        public PlaylistsSongsRepository(string filePath) : base(filePath)
        {
        }

        protected override void PopulateEntity(StreamReader sr, PlaylistsSongs item)
        {
            item.Id = Int32.Parse(sr.ReadLine());
            item.PlaylistId = Int32.Parse(sr.ReadLine());
            item.SongId = Int32.Parse(sr.ReadLine());
           
        }
        protected override void WriteEntity(StreamWriter sw, PlaylistsSongs item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.PlaylistId);
            sw.WriteLine(item.SongId);
        }
    }
}
