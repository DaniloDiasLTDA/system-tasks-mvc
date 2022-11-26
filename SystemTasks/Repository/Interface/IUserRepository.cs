using SystemTasks.Models;

namespace SystemTasks.Repository.Interface
{
    public interface IUserRepository
    {
            Task<List<UserModel>> SearchAllUseres();
            Task<UserModel> SearchById(int id);
            Task<UserModel> AddUser(UserModel user);
            Task<UserModel> AttUser(UserModel user, int id);
            Task<bool> EraserUser(int id);  
    }
}

