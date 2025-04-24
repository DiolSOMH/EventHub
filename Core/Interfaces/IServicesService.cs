using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Event.Models;


namespace Event.Core.Interfaces
{
    public interface IServicesService
    {
        Task RegisterService(ServiceProposal service);
        Task<List<ServiceProposal>> GetAllServices();
    }
}