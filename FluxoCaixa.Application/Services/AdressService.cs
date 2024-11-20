using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class AddressService : IAddressService
    {
        private readonly IAddressRepository _AddressRepository;
        private readonly IMapper _mapper;

        public AddressService(IAddressRepository AddressRepository, IMapper mapper )
        {
            _AddressRepository = AddressRepository;
            _mapper = mapper;
        }

        public async Task<AddressViewModel> GetById(int id) 
        {
            var address = await _AddressRepository.GetById(id);
            return _mapper.Map<AddressViewModel>(address);
        }

        public void Add(AddressViewModel activity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }        

        public void Update(AddressViewModel activity)
        {
            throw new NotImplementedException();
        }
    }
}
