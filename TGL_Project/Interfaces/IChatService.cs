﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TGL_Project.Models;
using TGL_Project.ViewModels.ChatRelated;

namespace TGL_Project.Interfaces
{
    public interface IChatService
    {

        Task<Chat> CreateChat(User user1, User user2);
        Task<Chat> CreateChat(string userId1, string userId2);

        void DeleteChat(Chat chat);
        void DeleteChat(int chatId);

        Task<Chat> GetOrCreateChat(User user1, User user2);
        Task<Chat> GetOrCreateChat(string userId1, string userId2);

        Chat GetChat(User user1, User user2);
        Chat GetChat(string userId1, string userId2);
        List<Message> GetMessagesByChat(Chat chat);

        Task<Message> AddMessage(Chat chat, MessageViewModel model);

    }
}
