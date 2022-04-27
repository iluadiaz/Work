using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsTask.Models;
namespace DevOpsTask.DAL.Abstract
{
    public interface IPersonApplicationRepository : IRepository<PersonApplication>
    {
        IEnumerable<HelperViewModel> GetData();
    }
}
