using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JournalNEOP.Models;
using JournalNOEP_DOMAIN;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JournalNEOP.Controllers
{
    public class MetaDataController : Controller
    {
        private readonly IRepository _repository;


        public MetaDataController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(Guid? idedition)
        {
            ViewBag.idedition = idedition ?? null;
            MainViewModel dataViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                DataEditionList = _repository.DataEdition,
                DataYearList = _repository.DataYear.OrderByDescending(x => x.Year)
            };
            return View(dataViewModel);
        }
        public IActionResult Articles(Guid? idedition)
        {

            var edition = _repository.DataEdition.Include(w => w.IdYearNavigation).FirstOrDefault(x => x.Id == idedition);


            var Article = _repository.Articles.Include(x => x.DataArticleAuthors).ThenInclude(c => c.Author).Where(x => x.EditionId == idedition);





            ViewBag.EditionNumber = edition.Edition;

            ViewBag.EditionYear = edition.IdYearNavigation.Year;
            ViewBag.EditionFile = edition.EdFile;
            return PartialView("Edition/Index", Article);
        }
        public IActionResult LastArticles()
        {
            int LastYear = _repository.DataYear.Max(x => x.Year);

            var LastEdition = _repository.DataEdition.FirstOrDefault(x => x.IdYear == _repository.DataYear.FirstOrDefault(z => z.Year == LastYear).Id);




            var Article = _repository.Articles.Include(x => x.DataArticleAuthors).ThenInclude(c => c.Author).Where(x => x.EditionId == LastEdition.Id);




            var edition = _repository.DataEdition.Include(w => w.IdYearNavigation).FirstOrDefault(x => x.Id == LastEdition.Id);

            ViewBag.EditionNumber = edition.Edition;

            ViewBag.EditionYear = edition.IdYearNavigation.Year;
            ViewBag.EditionFile = edition.EdFile;


            return PartialView("Edition/Index", Article);
        }
    }
}