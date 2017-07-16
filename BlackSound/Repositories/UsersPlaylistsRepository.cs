using BlackSound.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackSound.Repositories
{
    class UsersPlaylistsRepository : BaseRepository<UsersPlaylists>
    {
        public UsersPlaylistsRepository(string filePath) : base(filePath)
        {
        }
        protected override void PopulateEntity(StreamReader sr, UsersPlaylists item)
        {
            item.Id = Int32.Parse(sr.ReadLine());
            item.UserId = Int32.Parse(sr.ReadLine());
            item.PlaylistId = Int32.Parse(sr.ReadLine());
        }
        protected override void WriteEntity(StreamWriter sw, UsersPlaylists item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.UserId);
            sw.WriteLine(item.PlaylistId);
        }
    }
}
