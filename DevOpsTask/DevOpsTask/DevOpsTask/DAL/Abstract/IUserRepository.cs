using DevOpsTask.DAL.Concrete;
using DevOpsTask.Models.DbModels;

namespace DevOpsTask.DAL.Abstract
{
    public interface IUserRepository : IRepository<User>
    {
        public IEnumerable<UserRepository> GetData();
    }
}
