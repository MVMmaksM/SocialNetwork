﻿using SocialNetwork.BLL.Exceptions;
using SocialNetwork.BLL.Models;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialNetwork.BLL.Services
{
    public class FriendService
    {
        IUserRepository userRepository;
        IFriendRepository friendRepository;
        public FriendService()
        {
            userRepository = new UserRepository();
            friendRepository = new FriendRepository();
        }

        public void AddFriend(FriendAddData friendAddData)
        {          
            var findUserEntity = this.userRepository.FindByEmail(friendAddData.FriendEmail);
            if (findUserEntity is null) throw new UserNotFoundException();

            var friendEntity = new FriendEntity()
            {
                user_id = friendAddData.SenderId,
                friend_id = findUserEntity.id              
            };

            if (this.friendRepository.Create(friendEntity) == 0)
                throw new Exception();
        }
    }
}
