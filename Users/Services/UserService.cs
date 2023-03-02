using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Models;

namespace Users.Services
{
    public class UserService : IUserService
    {
        public ObservableCollection<User> Users { get; set; }

        public ObservableCollection<User> GetUsers()
        {
            Users = new ObservableCollection<User>() {
                new User() { UserName = "r0835830", FirstName = "Jefke", LastName = "Jes" },
                new User() { UserName = "r0835830", FirstName = "Jafke", LastName = "Jas" },
                new User() { UserName = "r0835830", FirstName = "Jofke", LastName = "Jos" },
                new User() { UserName = "r0835830", FirstName = "Jifke", LastName = "Jis" }
            };
            
            return Users;
        }
    }
}
