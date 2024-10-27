using JournalNOEP_DOMAIN;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VURO.UI.Models;

namespace VURO.UI.Controllers
{
    public class EditionsController : Controller
    {
        private readonly IRepository _repository;


        public EditionsController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(Guid? idedition)
        {
            @ViewData["Title"] = "Архив";
            ViewBag.idedition = idedition ?? null;
            MainViewModel dataViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                DataYearList = _repository.DataYear.Include(x=>x.DataEdition).OrderByDescending(x => x.Year)
            };
            return View(dataViewModel);
        }
        public IActionResult Articles(Guid? idedition)
        {
            var model = _repository.Articles.Where(x => x.EditionId == idedition).Include(xx=>xx.Section).Include(x=>x.DataArticleAuthors).ThenInclude(x=>x.Author).OrderBy(x=>x.ArtPos);
            var edition = _repository.DataEdition.Include(w => w.IdYearNavigation).FirstOrDefault(x => x.Id == idedition);
            ViewBag.EditionNumber = edition.Edition;

            ViewBag.EditionYear = edition.IdYearNavigation.Year;
            ViewBag.EditionFile = edition.EdFile;
            return PartialView("Edition/Index", model);
        }
        public IActionResult LastArticles()
        {
            try
            {
                int LastYear = _repository.DataYear.Max(x => x.Year);

                var LastEdition = _repository.DataEdition.FirstOrDefault(x => x.IdYear == _repository.DataYear.FirstOrDefault(z => z.Year == LastYear).Id);
                var model = _repository.Articles.Where(x => x.EditionId == LastEdition.Id).Include(xx => xx.Section).Include(x => x.DataArticleAuthors).ThenInclude(x => x.Author).OrderBy(x => x.ArtPos);
                var edition = _repository.DataEdition.Include(w => w.IdYearNavigation).FirstOrDefault(x => x.Id == LastEdition.Id);

                ViewBag.EditionNumber = edition.Edition;

                ViewBag.EditionYear = edition.IdYearNavigation.Year;
                ViewBag.EditionFile = edition.EdFile;


                return PartialView("Edition/Index", model);
            }
            catch
            {
                return PartialView("Edition/Index");
            }
        }
        public IActionResult PartialAnnotationView(Guid? articleId)
        {

            MainViewModel articleViewModel = new MainViewModel()
            {
                Article = _repository.Articles.FirstOrDefault(x => x.Id == articleId),
                DataArticleAuthorsList = _repository.DataArticleAuthors.Where(x => x.ArticleId == articleId).Include(x => x.Author)
        };


            return PartialView("Edition/PartialArticleAnnotation", articleViewModel);
        }
    }
}