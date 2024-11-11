using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace FluxoCaixa.SFinanceiro.Controllers
{
    public class PaymentTypeController : Controller
    {
        private readonly IPaymentTypeService _PaymentTypeService;

        public PaymentTypeController(IPaymentTypeService paymentTypeService)
        {
            _PaymentTypeService = paymentTypeService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            var obterGrid = _PaymentTypeService.GetAll();
            return View(obterGrid);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PaymentTypeViewModel paymentTypeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _PaymentTypeService.Add(paymentTypeVM);

                    return RedirectToAction(nameof(Index));
                }

                return View(paymentTypeVM);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message,ex.InnerException);
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

                var paymentType = await _PaymentTypeService.GetById(id);

                if (paymentType == null)
                {
                    return NotFound();
                }

                return View(paymentType);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(PaymentTypeViewModel paymentTypeVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _PaymentTypeService.Update(paymentTypeVM);

                    return RedirectToAction(nameof(Index));
                }

                return View(paymentTypeVM);
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
                _PaymentTypeService.Delete(id);

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

                var paymentType = await _PaymentTypeService.GetById(id);

                return View(paymentType);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
    }
}