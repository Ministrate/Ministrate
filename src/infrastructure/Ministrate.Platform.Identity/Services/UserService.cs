using Ministrate.Platform.Application.Contracts.Identity;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Ministrate.Platform.Application.Models.Identity;
using Ministrate.Platform.Identity.Models;

namespace Ministrate.Platform.Identity.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHttpContextAccessor _contextAccessor;

        public UserService(UserManager<ApplicationUser> userManager, IHttpContextAccessor contextAccessor)
        {
            _userManager = userManager;
            _contextAccessor = contextAccessor;
        }

        public int UserId => int.Parse(_contextAccessor.HttpContext?.User?.FindFirstValue("uid") ?? "");

        public async Task<User> GetUserAsync(int userId)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());

            if (user is null)
            {
                return new User();
            }

            var userRoles = await _userManager.GetRolesAsync(user);
            
            return new User
            {
                Email = user.Email!,
                Id = user.Id,
                Firstname = user.FirstName,
                Lastname = user.LastName,
                Roles = userRoles
            };
        }

        public async Task<List<User>> GetUsersInRoleAsync(string role)
        {
            var users = await _userManager.GetUsersInRoleAsync(role);

            var userList = new List<User>();

            foreach (var user in users)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                userList.Add(new User
                {
                    Id = user.Id,
                    Email = user.Email!,
                    Firstname = user.FirstName,
                    Lastname = user.LastName,
                    Roles = userRoles
                        
                });
            }

            return userList;
        }
    }
}
