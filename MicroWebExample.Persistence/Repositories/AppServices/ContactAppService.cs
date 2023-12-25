using AutoMapper;
using MicroWebExample.Application.Dto.BlogDto;
using MicroWebExample.Application.Dto.ContactDto;
using MicroWebExample.Application.Interfaces;
using MicroWebExample.Application.Interfaces.Repositories;
using MicroWebExample.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MicroWebExample.Persistence.Repositories.AppServices
{
    public class ContactAppService : ApplicationService,IContactAppService
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactAppService(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        public async Task Create(CreateContactInput input)
        {
            Contact contact = _mapper.Map<CreateContactInput, Contact>(input);
            await _contactService.AddAsync(contact);
        }


        public async Task Delete(DeleteContactInput input)
        {

            Contact removeContact = await _contactService.GetByIdAsync(input.Id);
            if (removeContact != null)
            {
                await _contactService.RemoveAsync(removeContact);
            }
        }

        public async Task<GetContactOutPut> GetContactById(int id)
        {
            var getContact = await _contactService.GetByIdAsync(id);
            GetContactOutPut outPut = _mapper.Map<Contact,GetContactOutPut>(getContact);
            return outPut;
        }

        public async Task<List<GetContactOutPut>> ListAllAsync()
        {
            var getAllContact = await _contactService.GetAllAsync();
            List<GetContactOutPut> outPut = _mapper.Map<List<Contact>, List<GetContactOutPut>>(getAllContact);

            return outPut;
        }

        public void Update(UpdateContactInput input)
        {
            Contact updateContact = _mapper.Map<UpdateContactInput, Contact>(input);
            _contactService.UpdateAsync(updateContact);
        }
    }

}
