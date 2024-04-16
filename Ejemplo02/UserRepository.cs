using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo02
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>();

        public async Task AddUserAsync(User user)
        {
            await Task.Delay(100);
            _users.Add(user);
        }

        public async Task DeleteUserAsync(int userId)
        {
            await Task.Delay(100);
            var userToRemove = await GetUserByIdAsync(userId);
            if (userToRemove != null)
                _users.Remove(userToRemove);
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            await Task.Delay(100);
            return _users;
        }

        public async Task<User> GetUserByIdAsync(int userId)
        {
            await Task.Delay(100);
            return _users.FirstOrDefault(u => u.Id == userId);
        }

        public async Task UpdateUserAsync(User user)
        {
            await Task.Delay(100);
            var existingUser = await GetUserByIdAsync(user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Email = user.Email;
            }
        }
    }
}
