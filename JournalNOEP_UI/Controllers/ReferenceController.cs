using JournalNOEP_DOMAIN;
using JournalNOEP_UI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace JournalNOEP_UI.Controllers
{
    [Authorize]
    public class ReferenceController : Controller
    {
        private readonly IRepository _repository;

        public ReferenceController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }
        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Авторы]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public IActionResult Authors()
        {
            ReferenceViewModel model = new ReferenceViewModel()
            {
                SprJoiurnalAuthorsList = _repository.SprJoiurnalAuthors
            };
            return View("Authors/Index", model);
        }
        public IActionResult PartialEditAuthor(Guid? idauth)
        {
            Guid id = idauth ?? Guid.Empty;
            SprJoiurnalAuthors model = _repository.SprJoiurnalAuthors.FirstOrDefault(x => x.Id == id);
            return PartialView("Authors/PartialEditAuthor", model);
        }
        [HttpPost]
        public IActionResult EditAuthor(SprJoiurnalAuthors joiurnalAuthors)
        {
            if (joiurnalAuthors.Id == Guid.Empty)
            {
                joiurnalAuthors.Id = Guid.NewGuid();
                _repository.Insert(joiurnalAuthors);
            }
            else
            {
                _repository.Update(joiurnalAuthors);
            }
            return RedirectToAction("Authors");
        }
        public IActionResult PartialRemoveAuthor(Guid idauth)
        {
            Guid id = idauth;
            SprJoiurnalAuthors model = _repository.SprJoiurnalAuthors.FirstOrDefault(x => x.Id == id);
            return PartialView("Authors/PartialRemoveAuthor", model);

        }
        [HttpPost]
        public IActionResult RemoveAuthor(SprJoiurnalAuthors joiurnalAuthors)
        {
            SprJoiurnalAuthors sprJoiurnalAuthors = _repository.SprJoiurnalAuthors.FirstOrDefault(x => x.Id == joiurnalAuthors.Id);
            _repository.Delete(sprJoiurnalAuthors);
            return RedirectToAction("Authors");
        }
        #endregion
        #region [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[Разделы]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]
        public IActionResult Section()
        {
            ReferenceViewModel model = new ReferenceViewModel()
            {
                SprJournalSectionList = _repository.SprJournalSection
            };
            return View("Sections/Index", model);
        }
        public IActionResult PartialEditSection(Guid? idsect)
        {
            Guid id = idsect ?? Guid.Empty;
            SprJournalSection model = _repository.SprJournalSection.FirstOrDefault(x => x.Id == id);
            return PartialView("Sections/PartialEditSection", model);
        }
        [HttpPost]
        public IActionResult EditSection(SprJournalSection journalSection)
        {
            if (journalSection.Id == Guid.Empty)
            {
                journalSection.Id = Guid.NewGuid();
                _repository.Insert(journalSection);
            }
            else
            {
                _repository.Update(journalSection);
            }
            return RedirectToAction("Section");
        }
        public IActionResult PartialRemoveSection(Guid idauth)
        {
            Guid id = idauth;
            SprJournalSection model = _repository.SprJournalSection.FirstOrDefault(x => x.Id == id);
            return PartialView("Sections/PartialRemoveSection", model);

        }
        [HttpPost]
        public IActionResult RemoveSection(SprJournalSection journalSection)
        {
            SprJournalSection sprJournalSection = _repository.SprJournalSection.FirstOrDefault(x => x.Id == journalSection.Id);
            _repository.Delete(sprJournalSection);
            return RedirectToAction("Section");
        }
        #endregion
    }
}
  