using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProject.Models
{
    public class UserRepository
    {
        protected AplicationContext appDb { get; }        

        public UserRepository(AplicationContext context)
        {
            appDb = context;
        }
        public IEnumerable<User> GetAll()
        {
            return appDb.Users.ToList();
        }

        public User Get(int id)
        {
            return appDb.Users.Find(id);
        }

        public void Create(User item)
        {
            appDb.Users.Add(item);
        }

        public void Update(User item)
        {
            appDb.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            User user = appDb.Users.Find(id);
            if (user != null)
                appDb.Users.Remove(user);
        }

        public void Save()
        {
            appDb.SaveChanges();
        }
    }

}
