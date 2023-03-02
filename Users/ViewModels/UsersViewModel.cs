using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.Models;
using Users.Services;

namespace Users.ViewModels
{
    public partial class UsersViewModel : BaseViewModel
    {
        IUserService userService;
        public ObservableCollection<User> Users { get; } = new();

        public UsersViewModel(IUserService userService)
        {
            this.userService = userService;
            Title = "Users";
        }

        [RelayCommand]
        public void GetUsers()
        {
            Users.Clear();
            var users = userService.GetUsers();
            foreach (var user in users)
            {
                Users.Add(user);
            }
        }
    }
}
