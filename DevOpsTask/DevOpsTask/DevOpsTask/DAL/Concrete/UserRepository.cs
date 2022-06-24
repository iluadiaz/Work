using DevOpsTask.Models.DbModels;
using DevOpsTask.Models;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.Areas.Identity.Data;
using DevOpsTask.DAL.Concrete;

namespace DevOpsTask.DAL.Concrete
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private DevOpsTaskIdentityDbContext _ctx;

        public UserRepository(DevOpsTaskIdentityDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<UserRepository> GetData()
        {
            List<UserRepository> results = new List<UserRepository>();

            var user = _ctx.Users;

            foreach (var Data in user)
            {
                var newData = new User();
                newData.Id = Data.Id;


            }

            return results;
        }
    }
}
