using DevOpsTask.Models;

namespace DevOpsTask.DAL.Abstract
{
    public interface IMBoardsandCommissionRepository : IRepository<MBoardsandCommissions>
    {
        IEnumerable<MBoardsandCommissions> GetData();
    }
}
