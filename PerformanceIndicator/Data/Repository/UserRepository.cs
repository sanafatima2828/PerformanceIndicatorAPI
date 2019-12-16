using Microsoft.EntityFrameworkCore;
using PerformanceIndicator.Data.Interface;
using PerformanceIndicator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceIndicator.Data.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(Context db) : base(db)
        {
            this.db = db;
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return db.Set<Role>().ToList();
        }

        public IEnumerable<User> GetUsersWithRole()
        {
            return db.Users.Include(u => u.Role).ToList();
        }

        public User GetUserWithRole(int id)
        {
            return db.Users.Include(u => u.Role).FirstOrDefault(u=>u.Id == id);
        }
    }
}
