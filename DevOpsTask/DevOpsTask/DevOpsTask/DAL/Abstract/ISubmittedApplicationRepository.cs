using DevOpsTask.Models;

namespace DevOpsTask.DAL.Abstract
{
    public interface ISubmittedApplicationRepository : IRepository<SubmittedApplication>
    {
        IEnumerable<SubmittedApplication> GetData();
    }
}
