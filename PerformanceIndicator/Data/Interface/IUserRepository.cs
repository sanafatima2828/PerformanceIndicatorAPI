using PerformanceIndicator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerformanceIndicator.Data.Interface
{
    public interface IUserRepository:IRepository<User>
    {
        IEnumerable<Role> GetAllRoles();
        IEnumerable<User> GetUsersWithRole();
        User GetUserWithRole(int id);
    }
}
