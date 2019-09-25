using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using UnityDIMVC.Model;
using UnityDIMVC.Service.Interfaces;

namespace UnityDIMVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IcategoryService _iService;
        public CategoryController(IcategoryService icategoryService)
        {
            _iService = icategoryService;
        }

        public async Task<ActionResult> Index()
        {
            return View(await _iService.Get());
        }
        [ActionName("Create")]
        public ActionResult Add()
        {
            return View("Add");
        }

        [ActionName("Create")]
        [HttpPost]
        public async Task<ActionResult> Add(CategoryVM category)
        {
            await _iService.Add(category);
            return RedirectToAction("Index");
        }

        public async Task<ActionResult> Details(int ID)
        {
            return View(await _iService.GetByID(ID));
        }

        public async Task<ActionResult> Edit(int ID)
        {
            return View(await _iService.GetByID(ID));
        }

        [HttpPost]
        public async Task<ActionResult> Edit(CategoryVM category)
        {
            await _iService.Update(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<ActionResult> Delete(int ID)
        {
            await _iService.Detete(ID);
            return RedirectToAction("Index");
        }
        //
        //public async Task<ActionResult> Delete(int ID)
        //{
        //    await _iService.Detete(ID);
        //    return RedirectToAction("Index");
        //}



    }
}