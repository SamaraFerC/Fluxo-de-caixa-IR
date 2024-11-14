﻿using AutoMapper;
using FluxoCaixa.Application.Interfaces;
using FluxoCaixa.Application.ViewModel;
using FluxoCaixa.Domain.Entities;
using FluxoCaixa.Domain.Interfaces;

namespace FluxoCaixa.Application.Services
{
    public class CollaboratorService : ICollaboratorService
    {
        private readonly ICollaboratorRepository _collaboratorRepository;
        private readonly IAddressRepository _addressRepository;
        private readonly IMapper _mapper;

        public CollaboratorService(ICollaboratorRepository collaboratorRepository, IMapper mapper, IAddressRepository addressRepository)
        {
            _collaboratorRepository = collaboratorRepository;
            _mapper = mapper;
            _addressRepository = addressRepository;
        }

        public async Task<CollaboratorViewModel> GetById(string id)
        {
            var objCollaborator = await _collaboratorRepository.GetById(id);

            return _mapper.Map<CollaboratorViewModel>(objCollaborator);
        }

        public IEnumerable<CollaboratorViewModel> GetAll()
        {
            var objCollaborator = _collaboratorRepository.GetAll();

            return _mapper.Map<IEnumerable<CollaboratorViewModel>>(objCollaborator);
        }

        public IEnumerable<CollaboratorViewModel> GetAllActives()
        {
            var objCollaborator = _collaboratorRepository.GetAll().Where(x =>x.Status);

            return _mapper.Map<IEnumerable<CollaboratorViewModel>>(objCollaborator);
        }

        public CollaboratorViewModel FindCollaborator(string id)
        {
            var collaborator = _collaboratorRepository.FindCollaborator(id);

            var addresVM = _mapper.Map<AddressViewModel>(collaborator.Address);
            var collaboratorVM = _mapper.Map<CollaboratorViewModel>(collaborator);

            collaboratorVM.addressVM = addresVM;

            return collaboratorVM;
        }

        public void Add(CollaboratorViewModel collaborator)
        {
            collaborator.UserIncluded = "fulano";
            collaborator.DateIncluded = DateTime.Now;
            var newCollaborator = _mapper.Map<Collaborator>(collaborator);

            if (collaborator.IsAddress)
            {
                AddAddress(collaborator, newCollaborator);
            }
            else
            {
                newCollaborator.AddressID = null;
            }

            _collaboratorRepository.Add(newCollaborator);
        }

        private void AddAddress(CollaboratorViewModel collaborator, Collaborator newCollaborator)
        {
            var newAddress = _mapper.Map<Address>(collaborator.addressVM);
            newAddress.UserIncluded = "fulano";
            newAddress.DateIncluded = DateTime.Now;
            _addressRepository.Add(newAddress);
            newCollaborator.AddressID = newAddress.Id;
        }

        public void Delete(string CollaboratorID)
        {
            var coll = _collaboratorRepository.GetById(CollaboratorID).Result;

            _collaboratorRepository.Delete(coll);
        }

        public void Update(CollaboratorViewModel collaborator)
        {
            collaborator.UserChanged = "fulano";
            collaborator.DateChanged = DateTime.Now;

            var newColl = _mapper.Map<Collaborator>(collaborator);

            if (collaborator.addressVM != null)
            {
                AddAddress(collaborator, newColl);
            }
            else
            {
                //updateAddres();
            }

            _collaboratorRepository.Update(newColl);
        }
    }
}
