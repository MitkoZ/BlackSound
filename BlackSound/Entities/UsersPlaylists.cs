using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSound.Entities
{
    class UsersPlaylists : BaseEntity
    {
        public UsersPlaylists(int userId, int playlistId)
        {
            this.UserId = userId;
            this.PlaylistId = playlistId;
        }

        public UsersPlaylists()
        {

        }
        public int UserId { get; set; }
        public int PlaylistId { get; set; }
    }
}
