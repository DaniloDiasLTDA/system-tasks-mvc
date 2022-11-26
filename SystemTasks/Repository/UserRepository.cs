using Microsoft.EntityFrameworkCore;
using SystemTasks.Data;
using SystemTasks.Models;
using SystemTasks.Repository.Interface;

namespace SystemTasks.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly SystemTasksDBcontext _dbContext;
        public UserRepository(SystemTasksDBcontext systemTasksDBcontext)
        {
            _dbContext = systemTasksDBcontext;
        }

        public async Task<UserModel> SearchById(int id)
        {
            return await _dbContext.User.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<List<UserModel>> SearchAllUseres()
        {
            return await _dbContext.User.ToListAsync();
        }

        public async Task<UserModel> AddUser(UserModel user)
        {
           await _dbContext.User.AddAsync(user);
           await _dbContext.SaveChangesAsync();

            return user;
        }
        public async Task<UserModel> AttUser(UserModel user, int id)
        {
           UserModel UserForId = await SearchById(id);
            if(UserForId== null)
            {
                throw new Exception($"This id: ({id}) was not found");
            }
            UserForId.Name = user.Name;
            UserForId.Email = user.Email;

            _dbContext.User.Update(UserForId);
           await _dbContext.SaveChangesAsync();

            return UserForId;
        }

        public async Task<bool> EraserUser(int id)
        {
            UserModel UserForId = await SearchById(id);
            if (UserForId == null)
            {
                throw new Exception($"This ID: ({id}) was not found");
            }
            _dbContext.User.Remove(UserForId);
           await _dbContext.SaveChangesAsync();
            return true;    
        }


    }
}
