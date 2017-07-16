using BlackSound.Entities;
using BlackSound.Repositories;
using BlackSound.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackSound.Service
{
    class AuthenticationService
    {
        public static User LoggedUser { get; private set; }

        public static void AuthenticateUser(string username, string password)
        {
            UsersRepository userRepo = new UsersRepository(Constants.UsersDirectory);
            AuthenticationService.LoggedUser = userRepo.GetByUsernameAndPassword(username, password);
        }
    }
}
