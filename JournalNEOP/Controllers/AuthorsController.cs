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
    public class AuthorsController : Controller
    {
        private readonly IRepository _repository;


        public AuthorsController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            MainViewModel authViewModel = new MainViewModel()
            {
                ArticleList = _repository.Articles
                .Include(x => x.DataArticleAuthors).ThenInclude(x => x.Author)
                .Include(x => x.Edition).ThenInclude(x => x.IdYearNavigation).ToList(),
                DataInfoList = _repository.DataInfo.OrderBy(x => x.InfoPageNum)
            };
            return View(authViewModel);


        }
        public IActionResult Articles(Guid authId)
        {
            MainViewModel model = new MainViewModel()
            {
                DataArticleAuthorsList =  _repository.DataArticleAuthors.Where(x=>x.AuthorId == authId).Include(x=>x.Author).Include(x=>x.Article).ThenInclude(x=>x.Edition).ThenInclude(x=>x.IdYearNavigation).Include(x=>x.Article).ThenInclude(x=>x.DataArticleAuthors).ThenInclude(x=>x.Author),
                SprJoiurnalAuthor = _repository.SprJoiurnalAuthors.FirstOrDefault(x=>x.Id == authId)
            };
            return PartialView("Authors/Index", model);


        }
        
    }
}