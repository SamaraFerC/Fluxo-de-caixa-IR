using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SFinanceiro.Controllers
{

    public class CollaboratorTypeController : Controller
    {
        private readonly ICollaboratorTypeService _collaboratorTypeService;

        public CollaboratorTypeController(ICollaboratorTypeService collaboratortypeService)
        {
            _collaboratorTypeService = collaboratortypeService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var obterGrid = _collaboratorTypeService.GetAll();
            return View(obterGrid);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CollaboratorTypeViewModel collaboratortypeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _collaboratorTypeService.Add(collaboratortypeVM);

                    return RedirectToAction(nameof(Index));
                }

                return View(collaboratortypeVM);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<IActionResult> Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var collaboratortype = await _collaboratorTypeService.GetById(id);

                if (collaboratortype == null)
                {
                    return NotFound();
                }

                return View(collaboratortype);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CollaboratorTypeViewModel collaboratorTypeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _collaboratorTypeService.Update(collaboratorTypeVM);

                    return RedirectToAction(nameof(Index));
                }

                return View(collaboratorTypeVM);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                _collaboratorTypeService.Delete(id);

                return Json(new { success = true });

            }
            catch (Exception ex)
            {
                return Json(new { success = false });
            }
        }

        public async Task<IActionResult> Visualize(int? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var collaboratorType = await _collaboratorTypeService.GetById(id);

                return View(collaboratorType);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
