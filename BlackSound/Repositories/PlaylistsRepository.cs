using BlackSound.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackSound.Repositories
{
    class PlaylistsRepository : BaseRepository<Playlist>
    {
        public PlaylistsRepository(string filePath) : base(filePath)
        {
        }

        protected override void PopulateEntity(StreamReader sr, Playlist item)
        {
            item.Id = Convert.ToInt32(sr.ReadLine());
            item.ParentUserId = Convert.ToInt32(sr.ReadLine());
            item.Name = sr.ReadLine();
            item.Description = sr.ReadLine();
            item.IsPublic = Convert.ToBoolean(sr.ReadLine());
        }

        protected override void WriteEntity(StreamWriter sw, Playlist item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.ParentUserId);
            sw.WriteLine(item.Name);
            sw.WriteLine(item.Description);
            sw.WriteLine(item.IsPublic);
        }
    }
}
