using JournalNOEP_DOMAIN;
using JournalNOEP_UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JournalNOEP_UI.Controllers
{
    [Authorize]
    public class JournalController : Controller
    {
        private readonly IRepository _repository;
        IHostingEnvironment _appEnvironment;


        public JournalController(IHostingEnvironment appEnvironment, IRepository repository, IHostingEnvironment environment)
        {
            _appEnvironment = appEnvironment;
            _repository = repository;
        }
        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Редактирование года]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public IActionResult Index(Guid? idedition)
        {
            ViewBag.idedition = idedition ?? null;
            DataViewModel dataViewModel = new DataViewModel()
            {
                DataYearList = _repository.DataYear.Include(x=>x.DataEdition).OrderByDescending(x => x.Year)
            };
            return View(dataViewModel);
        }
        public IActionResult PartialEditYear(Guid? Id)
        {
            Guid id = Id ?? Guid.Empty;
            DataYear dataYear = _repository.DataYear.FirstOrDefault(x => x.Id == id);
            return View(dataYear);
        }
        public void EditYear(DataYear dataYear)
        {
            if (dataYear.Id == Guid.Empty)
            {
                dataYear.Id = Guid.NewGuid();
                _repository.Insert(dataYear);
                DataEdition dataEdition = new DataEdition()
                {
                    Id = Guid.NewGuid(),
                    IdYear = dataYear.Id,
                    Edition = 1
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
            DataYear dataYear = _repository.DataYear.FirstOrDefault(x => x.Id == Id);
            return View(dataYear);
        }

        [HttpPost]
        public IActionResult RemoveYear(DataYear dataYear)
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
            DataEdition model;
            if (idyear != Guid.Empty)
            {
                var i = _repository.DataEdition.Where(x => x.IdYear == idyear).Max(x => x.Edition);
                model = new DataEdition()
                {
                    IdYear = idyear,
                    Edition = i + 1
                };
            }
            else
            {
                model = _repository.DataEdition.FirstOrDefault(x => x.Id == idedition);
            }

            return View(model);
        }
        [HttpPost]

        public IActionResult EditEdition(DataEdition dataEdition)
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
            
              var  model = _repository.DataEdition.FirstOrDefault(x => x.Id == IdEdition);
            
            return View(model);
        }
        [HttpPost]
        public IActionResult RemoveEdition(DataEdition dataEdition)
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
            var _edition = _repository.DataEdition.Include(z=>z.IdYearNavigation).FirstOrDefault(x => x.Id == dedition.Id);
            // путь к папке Files
            string fileName = _edition.IdYearNavigation.Year + "_" + _edition.Edition + Path.GetExtension(EditionFileNew.FileName);
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
            var model = _repository.DataEdition.FirstOrDefault(x => x.Id == Id);
            return PartialView("Edition/PartialRemoveEditionFile", model);
        }
        public IActionResult RemoveEditionFile(DataEdition dedition)
        {
            var _edition = _repository.DataEdition.FirstOrDefault(x => x.Id == dedition.Id);
            _edition.EdFile = null;
            _repository.Update(_edition);
            return RedirectToAction("Index", new { idedition = dedition.Id });
        }

        #endregion

        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Редактирование статьи]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public IActionResult Edition(Guid? idedition)
        {

            var model = _repository.Articles.Include(z => z.Edition).ThenInclude(c => c.IdYearNavigation).Where(x => x.EditionId == idedition).Include(a=>a.DataArticleAuthors).ThenInclude(b=>b.Author).OrderBy(x=>x.ArtPos);
            var edition = _repository.DataEdition.Include(w=>w.IdYearNavigation).FirstOrDefault(x => x.Id == idedition);

            ViewBag.EditionNumber = edition.Edition;
            ViewBag.IdEdition = idedition;
            ViewBag.EditionYear = edition.IdYearNavigation.Year;
            ViewBag.EditionFile = edition.EdFile;


            return PartialView("Edition/Index", model);
        }
        public IActionResult PartialEditArticleFile(Guid Id)
        {
            var model = _repository.Articles.FirstOrDefault(x => x.Id == Id);
            return PartialView("Edition/PartialEditArticleFile", model);
        }
        [HttpPost]
        public async Task<IActionResult> EditArticleFile(Articles articless, IFormFile ArtFileNew)
        {

            var articles = _repository.Articles.FirstOrDefault(x => x.Id == articless.Id);
            // путь к папке Files
            string fileName = Guid.NewGuid() + Path.GetExtension(ArtFileNew.FileName);
            string path = Path.Combine("/Files", "ArticleFiles", fileName);
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
            {
                await ArtFileNew.CopyToAsync(fileStream);
            }
            articles.ArtFile = fileName;
            _repository.Update(articles);
            return RedirectToAction("Index", new { idedition = articles.EditionId });
        }
        public IActionResult PartialEditArticle(Guid? Id, Guid IdEdition)
        {
            Guid id = Id ?? Guid.Empty;
            var model = _repository.Articles.Include(z => z.DataArticleAuthors).ThenInclude(w => w.Author).FirstOrDefault(x => x.Id == id);
            List<SprJoiurnalAuthors> allAuth = _repository.SprJoiurnalAuthors.OrderBy(x => x.AuthFio).ToList();
            if (model != null)
            {
                List<DataArticleAuthors> artAuthList = model.DataArticleAuthors.ToList();
                List<SprJoiurnalAuthors> artAuth = new List<SprJoiurnalAuthors>();
                foreach (var item in artAuthList)
                {
                    SprJoiurnalAuthors auth = _repository.SprJoiurnalAuthors.FirstOrDefault(x => x.Id == item.AuthorId);
                    allAuth.Remove(auth);
                    artAuth.Add(auth);
                }
                ViewBag.AuthorsInArticle = artAuth;
            }
            ViewBag.AuthorsOutArticles = allAuth;
            ViewBag.Sections = _repository.SprJournalSection.OrderBy(x => x.SectionName);
            ViewBag.IdEdition = IdEdition;
            return PartialView("Edition/PartialEditArticle", model);
        }
        [HttpPost]
        public async Task<IActionResult> EditArticle(Articles articles, IFormFile ArtFileNew, Guid[] ArtAuthors)
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
                articles.ArtPos = (_repository.Articles.Max(x => x.ArtPos) ?? 0) + 1;
                _repository.Insert(articles);
            }
            else
            {
                _repository.Update(articles);
                var oldAuthList = _repository.DataArticleAuthors.Where(x => x.ArticleId == articles.Id).ToList();
                foreach (DataArticleAuthors articleAuthors in oldAuthList)
                {
                   DeleteAuthorInArticles(articleAuthors);
                }
            }
            List<DataArticleAuthors> dataArticleAuthors = new List<DataArticleAuthors>();
            DataArticleAuthors articleAuthor = new DataArticleAuthors();
          int i = 1;
            foreach (Guid g in ArtAuthors) 
            {                
                dataArticleAuthors.Add(new DataArticleAuthors { ArticleId = articles.Id, AuthorId = g, Id = Guid.NewGuid(), AuthorPos = i });
                i++;
            }
            _repository.Inserts(dataArticleAuthors);
            return RedirectToAction("Index", new { idedition = articles.EditionId });
        }
        public IActionResult PartialRemoveArticle(Guid Id)
        {
            var model = _repository.Articles.FirstOrDefault(x => x.Id == Id);
            return PartialView("Edition/PartialRemoveArticle", model);
        }
        [HttpPost]
        public IActionResult RemoveArticle(Articles articles)
        {
            DeleteArticles(articles);
            return RedirectToAction("Index", new { idedition = articles.EditionId });
        }

        void DeleteYear(DataYear dataYear)
        {
            var editionInYear = _repository.DataEdition.Where(x => x.IdYear == dataYear.Id);
            foreach (DataEdition dataEdition in editionInYear)
            {
                DeleteEdition(dataEdition);
            }
            _repository.Delete(dataYear);
        }
        void DeleteEdition(DataEdition dataEdition)
        {
            var artInEdition = _repository.Articles.Where(x => x.EditionId == dataEdition.Id);
            foreach (Articles article in artInEdition)
            {
                DeleteArticles(article);
            }
            _repository.Delete(dataEdition);
        }
        void DeleteArticles(Articles articles)
        {
            var oldAuthList = _repository.DataArticleAuthors.Where(x => x.ArticleId == articles.Id).ToList();
            foreach (DataArticleAuthors articleAuthors in oldAuthList)
            {
                DeleteAuthorInArticles(articleAuthors);
            }
            _repository.Delete(articles);
        }
        void DeleteAuthorInArticles(DataArticleAuthors articleAuthors)
        {
            _repository.Delete(articleAuthors);
        }
        //public IActionResult
        #endregion

        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Отображение файла]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

        public IActionResult PartialShowFiles(Guid id)
        {
            string pathFile = _repository.DataEdition.FirstOrDefault(x => x.Id == id).EdFile;
            ViewBag.Path = "Files/EditionFiles/" + pathFile;
            return PartialView("Edition/PartialShowFiles");
        }
        #endregion
    }
}