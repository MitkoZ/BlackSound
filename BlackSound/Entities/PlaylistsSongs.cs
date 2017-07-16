using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSound.Entities
{
    class PlaylistsSongs : BaseEntity
    {
        public PlaylistsSongs(Song songDb, Playlist playlistDb)
        {
            this.SongId = songDb.Id;
            this.PlaylistId = playlistDb.Id;
        }
        public PlaylistsSongs(Playlist playlistDb)
        {
            this.PlaylistId = playlistDb.Id;
        }
        public PlaylistsSongs()
        {

        }

        public int PlaylistId { get; set; }
        public int SongId { get; set; }
    }
}
