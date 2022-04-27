using DevOpsTask.DAL.Abstract;
using DevOpsTask.Models;


namespace DevOpsTask.DAL.Concrete
{
    public class DbService : IDbService
    {
        public string GetApplicants()
        {
            return "hello";
        }
    }
}
