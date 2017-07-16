using BlackSound.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSound.Repositories
{
    class UsersRepository : BaseRepository<User>
    {
        public UsersRepository(string filePath) : base(filePath)
        {
        }

        protected override void PopulateEntity(StreamReader sr, User item)
        {
            item.Id = Int32.Parse(sr.ReadLine());
            item.Username = sr.ReadLine();
            item.Password = sr.ReadLine();
            item.Email = sr.ReadLine();
            item.IsAdmin = Convert.ToBoolean(sr.ReadLine());
        }

        protected override void WriteEntity(StreamWriter sw, User item)
        {
            sw.WriteLine(item.Id);
            sw.WriteLine(item.Username);
            sw.WriteLine(item.Password);
            sw.WriteLine(item.Email);
            sw.WriteLine(item.IsAdmin);
        }
        public User GetByUsernameAndPassword(string username, string password)
        {
            FileStream fs = new FileStream(this.filePath, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);

            try
            {
                while (!sr.EndOfStream)
                {
                    User user = new User();
                    user.Id = Convert.ToInt32(sr.ReadLine());
                    user.Username = sr.ReadLine();
                    user.Password = sr.ReadLine();
                    user.Email = sr.ReadLine();
                    user.IsAdmin = Convert.ToBoolean(sr.ReadLine());

                    if (user.Username == username && user.Password == password)
                    {
                        return user;
                    }
                }
            }
            finally
            {
                sr.Close();
                fs.Close();
            }

            return null;
        }
    }
}
