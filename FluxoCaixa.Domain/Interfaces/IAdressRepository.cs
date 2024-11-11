using FluxoCaixa.Domain.Entities;

namespace FluxoCaixa.Domain.Interfaces
{
    public interface IAddressRepository
    {
        public Task<Address> GetById(int Id);

        public void Add(Address address);

        public void Update(Address address);

        public void Delete(Address address);
    }
}
