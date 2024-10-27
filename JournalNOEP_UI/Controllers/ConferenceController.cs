using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using JournalNOEP_DOMAIN;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VURO.UI.Models;

namespace VURO.ADMIN.Controllers
{
    public class ConferenceController : Controller
    {
        private readonly IRepository _repository;
        IHostingEnvironment _appEnvironment;
        public ConferenceController(IHostingEnvironment appEnvironment, IRepository repository, IHostingEnvironment environment)
        {
            _appEnvironment = appEnvironment;
            _repository = repository;
        }
        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Редактирование года]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public IActionResult Index(Guid? idedition)
        {
            ViewBag.idedition = idedition ?? null;
            DataConferenceViewModel dataViewModel = new DataConferenceViewModel()
            {
                DataConferenceYearList = _repository.DataConferenceYears.Include(x=>x.DataConferenceEditions).OrderByDescending(x => x.Year)
            };
            return View(dataViewModel);
        }
        public IActionResult PartialEditYear(Guid? Id)
        {
            Guid id = Id ?? Guid.Empty;
            DataConferenceYear dataYear = _repository.DataConferenceYears.FirstOrDefault(x => x.Id == id);
            return View(dataYear);
        }
        public void EditYear(DataConferenceYear dataYear)
        {
            if (dataYear.Id == Guid.Empty)
            {
                dataYear.Id = Guid.NewGuid();
                _repository.Insert(dataYear);
                DataConferenceEdition dataEdition = new DataConferenceEdition()
                {
                    Id = Guid.NewGuid(),
                    DataConferenceYearId = dataYear.Id,
                    
                };
                _repository.Insert(dataEdition);
            }
            else
            {
                _repository.Update(dataYear);
            }
            RedirectToAction("Index");
        }

        public IActionResult PartialRemoveYear(Guid Id)
        {
            DataConferenceYear dataYear = _repository.DataConferenceYears.FirstOrDefault(x => x.Id == Id);
            return View(dataYear);
        }

        [HttpPost]
        public IActionResult RemoveYear(DataConferenceYear dataYear)
        {
            DeleteYear(dataYear);
            return RedirectToAction("Index");
        }
        #endregion

        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Редактирование выпуска]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public IActionResult PartialEditEdition(Guid? IdYear, Guid? IdEdition)
        {
            Guid idyear = IdYear ?? Guid.Empty;
            Guid idedition = IdEdition ?? Guid.Empty;
            DataConferenceEdition model;
            if (idyear != Guid.Empty)
            {
                var i = _repository.DataConferenceEditions.Where(x => x.DataConferenceYearId == idyear).Max(x => x.Edition);
                model = new DataConferenceEdition()
                {
                    DataConferenceYearId = idyear,
                    Edition = i + 1
                };
            }
            else
            {
                model = _repository.DataConferenceEditions.FirstOrDefault(x => x.Id == idedition);
            }

            return View(model);
        }
        [HttpPost]

        public IActionResult EditEdition(DataConferenceEdition dataEdition)
        {
            if (dataEdition.Id == Guid.Empty)
            {
                dataEdition.Id = Guid.NewGuid();
                _repository.Insert(dataEdition);
                return RedirectToAction("Index");
            }
            else
            {
                _repository.Update(dataEdition);
                return RedirectToAction("Index", new { idedition = dataEdition.Id });
            }
        }
        public IActionResult PartialRemoveEdition(Guid IdEdition)
        {

            var model = _repository.DataConferenceEditions.FirstOrDefault(x => x.Id == IdEdition);

            return View(model);
        }
        [HttpPost]
        public IActionResult RemoveEdition(DataConferenceEdition dataEdition)
        {
            DeleteEdition(dataEdition);
            return RedirectToAction("Index");
        }
        public IActionResult PartialEditEditionFile(Guid Id)
        {
            var model = _repository.DataEdition.FirstOrDefault(x => x.Id == Id);
            return PartialView("Edition/PartialEditEditionFile", model);
        }
        public async Task<IActionResult> EditEditionFile(DataEdition dedition, IFormFile EditionFileNew)
        {
            var _edition = _repository.DataConferenceEditions.Include(z => z.DataConferenceYear).FirstOrDefault(x => x.Id == dedition.Id);
            // путь к папке Files
            string fileName = _edition.DataConferenceYear.Year + "_" + _edition.Edition + Path.GetExtension(EditionFileNew.FileName);
            string path = Path.Combine("/Files", "EditionFiles", fileName);
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await EditionFileNew.CopyToAsync(fileStream);
            }
            _edition.EdFile = fileName;
            _repository.Update(_edition);
            return RedirectToAction("Index", new { idedition = _edition.Id });
        }
        public IActionResult PartialRemoveEditionFile(Guid Id)
        {
            var model = _repository.DataConferenceEditions.FirstOrDefault(x => x.Id == Id);
            return PartialView("Edition/PartialRemoveEditionFile", model);
        }
        public IActionResult RemoveEditionFile(DataEdition dedition)
        {
            var _edition = _repository.DataConferenceEditions.FirstOrDefault(x => x.Id == dedition.Id);
            _edition.EdFile = null;
            _repository.Update(_edition);
            return RedirectToAction("Index", new { idedition = dedition.Id });
        }

        #endregion

        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Редактирование статьи]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public IActionResult Edition(Guid? idedition)
        {

            var model = _repository.DataConferenceArticles.Include(z => z.DataConferenceEdition).ThenInclude(c => c.DataConferenceYear).Where(x => x.DataConferenceEditionId == idedition).Include(a => a.DataConferenceArticleAuthors).ThenInclude(b => b.SprJoiurnalAuthors).OrderBy(x => x.ArtPos).ToList();
            var edition = _repository.DataConferenceEditions.Include(w => w.DataConferenceYear).FirstOrDefault(x => x.Id == idedition);

            ViewBag.EditionNumber = edition.Edition;
            ViewBag.IdEdition = idedition;
            ViewBag.EditionYear = edition.DataConferenceYear.Year;
            ViewBag.EditionFile = edition.EdFile;


            return PartialView("Edition/Index", model);
        }
        public IActionResult PartialEditArticleFile(Guid Id)
        {
            var model = _repository.DataConferenceArticles.FirstOrDefault(x => x.Id == Id);
            return PartialView("Edition/PartialEditArticleFile", model);
        }
        [HttpPost]
        public async Task<IActionResult> EditArticleFile(Articles articless, IFormFile ArtFileNew)
        {

            var articles = _repository.DataConferenceArticles.FirstOrDefault(x => x.Id == articless.Id);
            // путь к папке Files
            string fileName = Guid.NewGuid() + Path.GetExtension(ArtFileNew.FileName);
            string path = Path.Combine("/Files", "ArticleFiles", fileName);
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await ArtFileNew.CopyToAsync(fileStream);
            }
            articles.ArtFile = fileName;
            _repository.Update(articles);
            return RedirectToAction("Index", new { idedition = articles.DataConferenceEditionId });
        }
        public IActionResult PartialEditArticle(Guid? Id, Guid IdEdition)
        {
            Guid id = Id ?? Guid.Empty;
            var model = _repository.DataConferenceArticles.Include(z => z.DataConferenceArticleAuthors).ThenInclude(w => w.SprJoiurnalAuthors).FirstOrDefault(x => x.Id == id);
            List<SprJoiurnalAuthors> allAuth = _repository.SprJoiurnalAuthors.OrderBy(x => x.AuthFio).ToList();
            if (model != null)
            {
                List<DataConferenceArticleAuthor> artAuthList = model.DataConferenceArticleAuthors.ToList();
                List<SprJoiurnalAuthors> artAuth = new List<SprJoiurnalAuthors>();
                foreach (var item in artAuthList)
                {
                    SprJoiurnalAuthors auth = _repository.SprJoiurnalAuthors.FirstOrDefault(x => x.Id == item.SprJoiurnalAuthorsId);
                    allAuth.Remove(auth);
                    artAuth.Add(auth);
                }
                ViewBag.AuthorsInArticle = artAuth;
            }
            ViewBag.AuthorsOutArticles = allAuth;
            //ViewBag.Sections = _repository.SprJournalSection.OrderBy(x => x.SectionName);
            ViewBag.IdEdition = IdEdition;
            return PartialView("Edition/PartialEditArticle", model);
        }
        [HttpPost]
        public async Task<IActionResult> EditArticle(DataConferenceArticle articles, IFormFile ArtFileNew, Guid[] ArtAuthors)
        {
            if (ArtFileNew != null)
            {
                // путь к папке Files
                string fileName = Guid.NewGuid() + Path.GetExtension(ArtFileNew.FileName);
                string path = Path.Combine("/Files", "ArticleFiles", fileName);
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await ArtFileNew.CopyToAsync(fileStream);
                }
                articles.ArtFile = fileName;
                articles.Id = Guid.NewGuid();
                try
                {
                    articles.ArtPos = _repository.DataConferenceArticles.Max(x => x.ArtPos) + 1;
                }
                catch
                {
                    articles.ArtPos = 1;
                }
                _repository.Insert(articles);
            }
            else
            {
                _repository.Update(articles);
                var oldAuthList = _repository.DataConferenceArticleAuthors.Where(x => x.DataConferenceArticleId == articles.Id).ToList();
                foreach (DataConferenceArticleAuthor articleAuthors in oldAuthList)
                {
                    DeleteAuthorInArticles(articleAuthors);
                }
            }
            List<DataConferenceArticleAuthor> dataArticleAuthors = new List<DataConferenceArticleAuthor>();
            DataConferenceArticleAuthor articleAuthor = new DataConferenceArticleAuthor();
            int i = 1;
            foreach (Guid g in ArtAuthors)
            {
                dataArticleAuthors.Add(new DataConferenceArticleAuthor { DataConferenceArticleId = articles.Id, SprJoiurnalAuthorsId = g, Id = Guid.NewGuid(), AuthorPos = i });
                i++;
            }
            _repository.Inserts(dataArticleAuthors);
            return RedirectToAction("Index", new { idedition = articles.DataConferenceEditionId });
        }
        public IActionResult PartialRemoveArticle(Guid Id)
        {
            var model = _repository.DataConferenceArticles.FirstOrDefault(x => x.Id == Id);
            return PartialView("Edition/PartialRemoveArticle", model);
        }
        [HttpPost]
        public IActionResult RemoveArticle(DataConferenceArticle articles)
        {
            DeleteArticles(articles);
            return RedirectToAction("Index", new { idedition = articles.DataConferenceEditionId });
        }

        void DeleteYear(DataConferenceYear dataYear)
        {
            if (dataYear != null)
            {
                var editionInYear = _repository.DataConferenceEditions.Where(x => x.DataConferenceYearId == dataYear.Id);
                if (editionInYear.Any())
                {
                    foreach (DataConferenceEdition dataEdition in editionInYear)
                    {
                        DeleteEdition(dataEdition);
                    }
                }

                _repository.Delete(dataYear);
            }
        }
        void DeleteEdition(DataConferenceEdition dataEdition)
        {
            var artInEdition = _repository.DataConferenceArticles.Where(x => x.DataConferenceEditionId == dataEdition.Id);
            if (artInEdition.Any())
            {
                foreach (DataConferenceArticle article in artInEdition)
                {
                    DeleteArticles(article);
                }
            }
            _repository.Delete(dataEdition);
        }
        void DeleteArticles(DataConferenceArticle articles)
        {
            var oldAuthList = _repository.DataConferenceArticleAuthors.Where(x => x.DataConferenceArticleId == articles.Id).ToList();
            if (oldAuthList.Any())
            {
                foreach (DataConferenceArticleAuthor articleAuthors in oldAuthList)
                {
                    DeleteAuthorInArticles(articleAuthors);
                }
            }
            _repository.Delete(articles);
        }
        void DeleteAuthorInArticles(DataConferenceArticleAuthor articleAuthors)
        {
            _repository.Delete(articleAuthors);
        }
        //public IActionResult
        #endregion

        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Отображение файла]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

        public IActionResult PartialShowFiles(Guid id)
        {
            string pathFile = _repository.DataConferenceEditions.FirstOrDefault(x => x.Id == id).EdFile;
            ViewBag.Path = "Files/EditionFiles/" + pathFile;
            return PartialView("Edition/PartialShowFiles");
        }
        #endregion
    }
}