using FluxoCaixa.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FluxoCaixa.SFinanceiro.Controllers
{
    public class CashFlowController : Controller
    {
        private readonly ICashFlowService _cashFlowService;
        private readonly ICollaboratorTypeService _collaboratorTypeService;
        private readonly ICollaboratorService _collaboratorService;
        private readonly IActivityService _activityService;
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly IFlowTypeService _flowTypeService;

        public CashFlowController(ICashFlowService cashFlowService, ICollaboratorTypeService collaboratorTypeService, ICollaboratorService collaboratorService, IActivityService activityService, IPaymentTypeService paymentTypeService, IFlowTypeService flowTypeService)
        {
            _cashFlowService = cashFlowService;
            _collaboratorTypeService = collaboratorTypeService;
            _collaboratorService = collaboratorService;
            _activityService = activityService;
            _paymentTypeService = paymentTypeService;
            _flowTypeService = flowTypeService;
        }

        public ActionResult Index()
        {
            var obterGrid = _cashFlowService.GetAll();
            return View(obterGrid);
        }

        public ActionResult Details(int id)
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CashFlowController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CashFlowController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
