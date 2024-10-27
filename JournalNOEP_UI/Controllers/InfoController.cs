using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JournalNOEP_DOMAIN;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JournalNOEP_UI.Controllers
{
    [Authorize]
    public class InfoController : Controller
    {
        private readonly IRepository _repository;

        public InfoController(IRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Index()
        {
            var model = _repository.DataInfo.OrderBy(x => x.InfoPageNum);
            return View(model);
        }
        public IActionResult PartialEditInfo(Guid? id)
        {
            if (id != Guid.Empty)
            {
                var model = _repository.DataInfo.FirstOrDefault(x => x.Id == id);
                return PartialView(model);
            }
            return PartialView();
        }
        public IActionResult EditInfo(DataInfo dataInfo)
        {
            if (dataInfo.Id != Guid.Empty)
            {
                _repository.Update(dataInfo);
            }
            else
            {
                dataInfo.Id = Guid.NewGuid();
                _repository.Insert(dataInfo);
            }
            return RedirectToAction("Index");
        }
        public IActionResult PartialRemoveInfo(Guid id)
        {
                var model = _repository.DataInfo.FirstOrDefault(x => x.Id == id);
                return PartialView(model);
        }
        public IActionResult RemoveInfo(DataInfo dataInfo)
        {
            var datainf = _repository.DataInfo.FirstOrDefault(x => x.Id == dataInfo.Id);
            _repository.Delete(datainf);
            return RedirectToAction("Index");
        }
    }
}