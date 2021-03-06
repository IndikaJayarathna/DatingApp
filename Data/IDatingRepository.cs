﻿using Dating.Helpers;
using Dating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dating.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class; // generic type method, T can be replaced with any class
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll(); // return true = all changes were saved. false = there are more changes to be saved.
        Task<PagedList<User>> GetUsers(UserParams userParams); //get all users
        Task<User> GetUser(int id); //get individual user from db
        Task<Photo> GetPhoto(int id);
        Task<Photo> GetMainPhotoForUser(int userId);
        Task<Like> GetLike(int userId, int recipientId); // checking the like already exists
        Task<Message> GetMessage(int id); // get the single message from the database
        Task<PagedList<Message>> GetMessagesForUser(MessageParams messageParams); // Inbox, Outbox or Unread Messages
        Task<IEnumerable<Message>> GetMessageThread(int userId, int recipientId); // conversation between two users

    }
}
