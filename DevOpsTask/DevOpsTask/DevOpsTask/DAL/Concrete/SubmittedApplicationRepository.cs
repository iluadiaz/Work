using DevOpsTask.DAL.Abstract;
using DevOpsTask.Models;
//using DevOpsTask.Models.DbModels;


namespace DevOpsTask.DAL.Concrete
{
    public class SubmittedApplicationRepository : Repository<SubmittedApplication>, ISubmittedApplicationRepository
    {
        private BandcDbContext _ctx;

        public SubmittedApplicationRepository(BandcDbContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public IEnumerable<SubmittedApplication> GetData()
        {
            List<SubmittedApplication> results = new List<SubmittedApplication>();

            var submittedApplication = _ctx.SubmittedApplications;

            foreach (var Data in submittedApplication)
            {
                var newData = new SubmittedApplication();
                newData = Data;

                results.Add(newData);
            }

            return results;
        }
    }
}
