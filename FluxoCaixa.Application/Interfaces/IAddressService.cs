using FluxoCaixa.Application.ViewModel;

namespace FluxoCaixa.Application.Interfaces
{
    public interface IAddressService
    {
        public Task<AddressViewModel> GetById(int Id);

        public void Add(AddressViewModel activity);

        public void Update(AddressViewModel activity);

        public void Delete(int id);
    }
}
