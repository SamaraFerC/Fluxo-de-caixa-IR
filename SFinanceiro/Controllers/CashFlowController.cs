using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FluxoCaixa.SFinanceiro.Controllers
{
    public class CashFlowController : Controller
    {
        private readonly ICashFlowService _cashFlowService;
        private readonly ICollaboratorService _collaboratorService;
        private readonly IActivityService _activityService;
        private readonly IPaymentTypeService _paymentTypeService;
        private readonly IFlowTypeService _flowTypeService;

        public CashFlowController(ICashFlowService cashFlowService, ICollaboratorService collaboratorService, IActivityService activityService, IPaymentTypeService paymentTypeService, IFlowTypeService flowTypeService)
        {
            _cashFlowService = cashFlowService;
            _collaboratorService = collaboratorService;
            _activityService = activityService;
            _paymentTypeService = paymentTypeService;
            _flowTypeService = flowTypeService;
        }

        public ActionResult Index()
        {
            CreateViewBags();
            var obterGrid = _cashFlowService.GetAll();

            return View(obterGrid);
        }

        private void CreateViewBags()
        {
            ViewBag.flowType = new SelectList(_flowTypeService.GetAll(), "Id", "Name");
            ViewBag.activity = new SelectList(_activityService.GetAllActives(),"Id", "Name");
            ViewBag.collaborator = new SelectList(_collaboratorService.GetAllActives(), "Id", "FullName");
            ViewBag.paymentType = new SelectList(_paymentTypeService.GetAllActives(), "Id", "Name");            
        }
        public ActionResult Create()
        {
            CreateViewBags();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CashFlowViewModel cashFlowVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _cashFlowService.Add(cashFlowVM);

                }
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
        public ActionResult Edit(CashFlowViewModel cashFlowVM)
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

        public async Task<IActionResult> Visualize(int id)
        {
            try
            {
                if (id == 0)
                {
                    return NotFound();
                }

                var cashFlow = _cashFlowService.FindCashFlow(id);
                ViewBagEdit(cashFlow);

                return View(cashFlow);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }

        private void ViewBagEdit(CashFlowViewModel cashFlowVM)
        {
            ViewBag.flowType = new SelectList(_flowTypeService.GetAll().Where(x => x.Id == cashFlowVM.FlowTypeId), "Id", "Name");
            ViewBag.activity = new SelectList(_activityService.GetAllActivities().Where(x =>x.Id == cashFlowVM.ActivityId), "Id", "Name");
            ViewBag.collaborator = new SelectList(_collaboratorService.GetAll().Where(x =>x.Id.Equals(cashFlowVM.CollaboratorId)), "Id", "FullName");
            ViewBag.paymentType = new SelectList(_paymentTypeService.GetAll().Where(x =>x.Id == cashFlowVM.PaymentTypeId), "Id", "Name");
        }

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
