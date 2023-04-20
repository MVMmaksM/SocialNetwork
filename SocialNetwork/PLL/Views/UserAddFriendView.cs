using SocialNetwork.BBL.Services;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.PLL.Views
{
    public class UserAddFriendView
    {
        FriendService friendService;
        public UserAddFriendView(FriendService friendService)
        {
            this.friendService = friendService;
        }
        public void Show()
        {
            var frinedAddData = new FriendAddData();
            
            Console.Write("Введите почтовый адрес друга: ");
            frinedAddData.FriendEmail = Console.ReadLine();


        }
    }
}
