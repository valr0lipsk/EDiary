using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using EDiary.Models;
using Microsoft.AspNetCore.Identity;

namespace EDiary.IRepositories
{
    public interface IUserRepository
    {
        Task createUserAsync(IdentityUser user);
        Task removeUserAsync(IdentityUser user);
        Task updateUserAsync(IdentityUser user);
    }
}
