using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface IPaymentTypeRepository
    {
        IEnumerable<PaymentType> GetAll();

        public Task<PaymentType> GetById(int? id);

        void Add(PaymentType activity);

        void Update(PaymentType activity);

        void Delete(PaymentType activity);
    }
}
