using JournalNOEP_DOMAIN;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VURO.UI.Models;

namespace VURO.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IRepository _repository;
        public HomeController(ILogger<HomeController> logger, IRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        public async Task<IActionResult> MyAction(string returnUrl, string Lang)
        {
            MainViewModel.Language = Lang;
            return LocalRedirect(returnUrl);
        }

        public IActionResult Index()
        {
            @ViewData["Title"] = "Главная";
            MainViewModel mainViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                SprJournalSectionList = _repository.SprJournalSection
            };
            return View(mainViewModel);
        }

        public IActionResult Journal(Guid? infoId)
        {
            ViewBag.InfoId = infoId;
            MainViewModel mainViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                DataInfo = _repository.DataInfo.OrderBy(x => x.InfoPageNum).FirstOrDefault(x => x.Id == infoId)
            };
            return View(mainViewModel);
        }
        public IActionResult PrintInfo(Guid? infoId)
        {
            ViewBag.InfoId = infoId;
            MainViewModel mainViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                DataInfo = _repository.DataInfo.OrderBy(x => x.InfoPageNum).FirstOrDefault(x => x.Id == infoId)
            };
            return View("PrintInfo", mainViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
