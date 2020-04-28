using Dating.Helpers;
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

    }
}
