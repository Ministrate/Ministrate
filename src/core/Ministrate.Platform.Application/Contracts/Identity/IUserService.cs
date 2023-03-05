using Ministrate.Platform.Application.Models.Identity;

namespace Ministrate.Platform.Application.Contracts.Identity;

public interface IUserService
{
    public int UserId { get; }

    public Task<User> GetUserAsync(int userId);

    public Task<List<User>> GetUsersInRoleAsync(string role);
}