﻿using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FluxoCaixa.SFinanceiro.Controllers
{
    public class ActivityController : Controller
    {
        private readonly IActivityService _activityService;
        
        public ActivityController(IActivityService activityService)
        {
            _activityService = activityService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            //var obterGrid = _activityService.GetAllActivities();
            return View();
        }
        
        public ActionResult Create()
        {
            return View();
        } 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ActivityViewModel activityViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    activityViewModel.Status = true;
                    activityViewModel.UserIncluded = "fulano";
                    activityViewModel.DateIncluded = DateTime.Now;

                    _activityService.AddActivity(activityViewModel);

                    return RedirectToAction(nameof(Index));
                }

                return View(activityViewModel);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null){
                return NotFound();
            }

            var activity = _activityService.GetById(id);

            if(activity == null)
            {
                return NotFound();
            }

            return View(activity);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ActivityViewModel activityViewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    activityViewModel.UserChanged = "fulano";
                    activityViewModel.DateChanged = DateTime.Now;

                    _activityService.UpdateActivity(activityViewModel);

                    return RedirectToAction("Index");
                }

                return View(activityViewModel);
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    
                }
                var activity = _activityService.GetById(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<IActionResult> Visualize(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activity = _activityService.GetById(id);

            if (activity == null)
            {
                return NotFound();
            }

            return View(activity);
        }        
    }
}