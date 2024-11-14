using Microsoft.AspNetCore.Mvc;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;

namespace SFinanceiro.Controllers
{
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
            var collaboratorTypes = _collaboratorTypeService.GetAllActives();
            ViewBag.collaboratorTypes = new SelectList(collaboratorTypes, "Id", "Name");
            
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
                    Validar(collaboratorVM);
                    _collaboratorService.Add(collaboratorVM);

                    return RedirectToAction(nameof(Index));
                }

                return RedirectToAction(nameof(Create));
            }
            catch (Exception ex)
            {
                CreateViewBags();
                throw new Exception(ex.Message);
            }
        }

        public async Task<IActionResult> Edit(string? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var collaborator = _collaboratorService.FindCollaborator(id);
                ViewBagEdicao(collaborator);

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

        private void ViewBagEdicao(CollaboratorViewModel collaborator)
        {
            var collaboratorTypes = _collaboratorTypeService.GetAllActives().Where(x => x.Id == collaborator.CollaboratorTypeID);

            ViewBag.collaboratorTypes = new SelectList(collaboratorTypes, "Id", "Name");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CollaboratorViewModel collaboratorVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Validar(collaboratorVM);
                    _collaboratorService.Update(collaboratorVM, true);

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
        public ActionResult Delete(string id)
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

        public async Task<IActionResult> Visualize(string? id)
        {
            try
            {
                if (id == null)
                {
                    return NotFound();
                }

                var collaborator =  _collaboratorService.FindCollaborator(id);
                ViewBagEdicao(collaborator);

                return View(collaborator);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void Validar(CollaboratorViewModel collaboratorVM)
        {
            if (!collaboratorVM.IsAddress && (string.IsNullOrEmpty(collaboratorVM.addressVM.CEP) || string.IsNullOrEmpty(collaboratorVM.addressVM.Street) ||
                                                string.IsNullOrEmpty(collaboratorVM.addressVM.City) || string.IsNullOrEmpty(collaboratorVM.addressVM.State)))
            {
                collaboratorVM.addressVM = null;
                ///trartar erro em tela
            }

            if (!collaboratorVM.IsAddress)
            {
                collaboratorVM.addressVM = null;
            }

            collaboratorVM.Id = Regex.Replace(collaboratorVM.Id, @"[./-]", "");
            //var existeColaborador = _collaboratorService.GetById(collaboratorVM.Id) != null ? true : false;
            //if (existeColaborador)
            //{
            //    var mensagem = "existe";
            //} ///aruumar questao ded transação
        }
    }
}
