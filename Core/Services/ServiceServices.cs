using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Core.Interfaces;
using Event.Models;

namespace Event.Core.Services
{
    public class ServiceServices : IServicesService
    {
        private readonly IServiceRepository _serviceRepository;
        public ServiceServices(IServiceRepository serviceRepository)
        {
            _serviceRepository = serviceRepository;
        }

        public async Task RegisterService(ServiceProposal service)
        {
            await _serviceRepository.AddAsync(service);
        }

        public async Task<List<ServiceProposal>> GetAllServices()
        {
            return await _serviceRepository.GetAllAsync();
        }

    
    }
}