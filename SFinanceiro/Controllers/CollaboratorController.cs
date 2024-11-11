using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;

namespace SFinanceiro.Controllers
{
    [Authorize]
    public class CollaboratorController : Controller
    {
        private readonly ICollaboratorService _collaboratorService;
        private readonly ICollaboratorTypeService _collaboratorTypeService;
        public CollaboratorController(ICollaboratorService collaboratorService, ICollaboratorTypeService collaboratorTypeService)
        {
            _collaboratorService = collaboratorService;
            _collaboratorTypeService = collaboratorTypeService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            CreateViewBags();
            var obterGrid = _collaboratorService.GetAll();


            return View(obterGrid);
        }

        private void CreateViewBags()
        {
            ViewBag.collaboratorTypes = _collaboratorTypeService.GetAllActives();
        }

        public ActionResult Create()
        {
            CreateViewBags();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CollaboratorViewModel collaboratorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _collaboratorService.Add(collaboratorVM);

                    return RedirectToAction(nameof(Index));
                }

                return View(collaboratorVM);
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

                var collaborator = await _collaboratorService.GetById(id);

                if (collaborator == null)
                {
                    return NotFound();
                }

                return View(collaborator);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CollaboratorViewModel collaboratorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _collaboratorService.Update(collaboratorVM);

                    return RedirectToAction(nameof(Index));
                }

                return View(collaboratorVM);
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
                _collaboratorService.Delete(id);

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

                var collaborator = await _collaboratorService.GetById(id);

                return View(collaborator);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}
