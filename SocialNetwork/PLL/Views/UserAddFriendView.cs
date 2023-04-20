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
        public void Show(User user)
        {
            var friendAddData = new FriendAddData();
            
            Console.Write("Введите почтовый адрес друга: ");
            friendAddData.FriendEmail = Console.ReadLine();

            friendAddData.SenderId = user.Id;
            
            try
            {
                friendService.AddFriend(friendAddData);

                SuccessMessage.Show("Пользователь успешно добавлен в друзья!");                
            }
            catch (Exception ex) { }
        }
    }
}
