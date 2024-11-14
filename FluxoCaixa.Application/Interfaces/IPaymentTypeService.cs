using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface IPaymentTypeService
    {
        IEnumerable<PaymentTypeViewModel> GetAll();

        public Task<PaymentTypeViewModel> GetById(int? id);
        public IEnumerable<PaymentTypeViewModel> GetAllActives();

        void Add(PaymentTypeViewModel activity);

        void Update(PaymentTypeViewModel activity);

        void Delete(int id);
    }
}
