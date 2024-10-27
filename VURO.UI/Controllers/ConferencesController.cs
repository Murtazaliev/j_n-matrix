using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JournalNOEP_DOMAIN;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VURO.UI.Models;

namespace GIS.UI.Controllers
{
    public class ConferencesController : Controller
    {
        private readonly IRepository _repository;


        public ConferencesController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index(Guid? idedition)
        {
            @ViewData["Title"] = "Сборник конференций";
            ViewBag.idedition = idedition ?? null;
            MainViewModel dataViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                DataConferenceYear = _repository.DataConferenceYears.Include(x=>x.DataConferenceEditions).OrderByDescending(x => x.Year)
            };
            return View(dataViewModel);
        }
        public IActionResult Articles(Guid? idedition)
        {
            var model = _repository.DataConferenceArticles.Where(x => x.DataConferenceEditionId == idedition).Include(x => x.DataConferenceArticleAuthors).ThenInclude(x => x.SprJoiurnalAuthors).OrderBy(x => x.ArtPos);
            var edition = _repository.DataConferenceEditions.Include(w => w.DataConferenceYear).FirstOrDefault(x => x.Id == idedition);
            ViewBag.EditionNumber = edition.Edition;

            ViewBag.EditionYear = edition.DataConferenceYear.Year;
            ViewBag.EditionFile = edition.EdFile;
            return PartialView("Edition/Index", model);
        }
        public IActionResult LastArticles()
        {
            try
            {
                int LastYear = _repository.DataConferenceYears.Max(x => x.Year);

                var LastEdition = _repository.DataConferenceEditions.FirstOrDefault(x => x.DataConferenceYearId == _repository.DataConferenceYears.FirstOrDefault(z => z.Year == LastYear).Id);
                var model = _repository.DataConferenceArticles.Where(x => x.DataConferenceEditionId == LastEdition.Id).Include(x => x.DataConferenceArticleAuthors).ThenInclude(x => x.SprJoiurnalAuthors).OrderBy(x => x.ArtPos);
                var edition = _repository.DataConferenceEditions.Include(w => w.DataConferenceYear).FirstOrDefault(x => x.Id == LastEdition.Id);

                ViewBag.EditionNumber = edition.Edition;

                ViewBag.EditionYear = edition.DataConferenceYear.Year;
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
                DataConferenceArticle = _repository.DataConferenceArticles.FirstOrDefault(x => x.Id == articleId),
                DataConferenceArticleAuthor = _repository.DataConferenceArticleAuthors.Where(x => x.DataConferenceArticleId == articleId).Include(x => x.SprJoiurnalAuthors)
            };


            return PartialView("Edition/PartialArticleAnnotation", articleViewModel);
        }
        
        public IActionResult NewConferences()
        {
            MainViewModel dataViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                DataInfo = _repository.DataInfo.FirstOrDefault(x => x.InfoNameEn.ToUpper().Contains("CONFERENCE"))
            };
            return PartialView("Edition/PartialNewConference", dataViewModel);
        }
        
        public IActionResult ApplicationConference()
        {
            MainViewModel dataViewModel = new MainViewModel()
            {
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum),
                DataInfo = _repository.DataInfo.FirstOrDefault(x => x.InfoNameEn.ToUpper().Contains("PAYMENT"))
            };
            return PartialView("Edition/PartialPayment", dataViewModel);
        }
    }
}