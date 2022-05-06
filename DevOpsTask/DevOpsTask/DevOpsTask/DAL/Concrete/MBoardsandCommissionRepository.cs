using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevOpsTask.Models;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.DAL.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Collections;

namespace DevOpsTask.DAL.Concrete
{
    public class MBoardsandCommissionRepository : Repository<MBoardsandCommissions>, IMBoardsandCommissionRepository
    {
        private BandcDbContext _ctx;
        public MBoardsandCommissionRepository(BandcDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<MBoardsandCommissions> GetData()
        {
            List<MBoardsandCommissions> results = new List<MBoardsandCommissions>();

            var commissions = _ctx.MBoardsandCommissions;

            foreach (var Data in commissions)
            {
                var newData = new MBoardsandCommissions();
                newData = Data;

                results.Add(newData);
            }

            return results;
        }
    }
}
