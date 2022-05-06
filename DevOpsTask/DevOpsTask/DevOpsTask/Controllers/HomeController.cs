using DevOpsTask.Models;
//using DevOpsTask.Models.DbModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DevOpsTask.DAL.Abstract;
using DevOpsTask.DAL.Concrete;
namespace DevOpsTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly BandcDbContext ctx;
        private readonly IPersonApplicationRepository personAppRepository;
        private readonly IMBoardsandCommissionRepository mBoardsandCommissionRepository;
        private readonly ISubmittedApplicationRepository submittedApplicationRepository;
        private readonly IPersonRepository personRepository;
        public HomeController(ILogger<HomeController> logger, BandcDbContext bandcDbContext, IPersonApplicationRepository personApp,
            IMBoardsandCommissionRepository mBoardsandCommission, IPersonRepository person, ISubmittedApplicationRepository _submittedApplicationRepository)
        {
            _logger = logger;
            ctx = bandcDbContext;
            personAppRepository = personApp;
            mBoardsandCommissionRepository = mBoardsandCommission;
            personRepository = person;
            submittedApplicationRepository = _submittedApplicationRepository;
        }

        public IActionResult Index()
        {
            HelperViewModel model = new HelperViewModel();
            model.PersonApplications = personAppRepository.GetData().ToList();
            model.MBoardsandCommissions = mBoardsandCommissionRepository.GetData().ToList();
            model.Person = personRepository.GetData().ToList();
            model.SubmittedApplications = submittedApplicationRepository.GetData();

            var requirements = new RequirementsModel();
            model.Requirements = model.GetData(model.Person.ToList(), model.MBoardsandCommissions.ToList(), model.PersonApplications.ToList(), 
                                 model.SubmittedApplications.ToList());

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}