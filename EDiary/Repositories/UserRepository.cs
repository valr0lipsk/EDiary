using EDiary.IRepositories;
using EDiary.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EDiary.Repositories
{
    public class UserRepository : IUserRepository
    {
        EDContext context;
        DbSet<IdentityUser> users;

        public UserRepository(EDContext context)
        {
            this.context = context;
            this.users = context.Set<IdentityUser>();
        }

        //создание пользователя
        public async Task createUserAsync(IdentityUser user)
        {
            await users.AddAsync(user);
            await context.SaveChangesAsync();
        }

        //обновление пользователя
        public async Task updateUserAsync(IdentityUser user)
        {
            users.Update(user);
            await context.SaveChangesAsync();
        }

        //удаление пользователя
        public async Task removeUserAsync(IdentityUser user)
        {
            users.Remove(user);
            await context.SaveChangesAsync();
        }
    }

}
