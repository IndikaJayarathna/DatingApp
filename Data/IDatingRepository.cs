using Dating.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Dating.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T entity) where T : class; // generic type method
        void Delete<T>(T entity) where T : class;
        Task<bool> SaveAll(); // return true = all changes were saved. false = there are more changes to be saved.
        Task<IEnumerable<User>> GetUsers(); //get all users
        Task<User> GetUser(int id); //get individual user from db

    }
}
