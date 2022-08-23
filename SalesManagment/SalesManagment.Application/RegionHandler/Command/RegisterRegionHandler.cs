using MediatR;
using SalesManagment.Application.Interactor.interfaces;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract;
using SalesManagment.Contract.RegionContracts;
using SalesManagment.Domain.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagment.Application.RegionHandler.Command
{
    public class RegisterRegionHandler : IRequestHandler<RegionRequest, SucessMessage>
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMicroRegionRepository _microregionRepository;
        private readonly IRegionsIbgeInteractor _regionInteractor;
        public RegisterRegionHandler(IMicroRegionRepository microregionRepository ,
                                     IRegionRepository regionRepository,
                                     IRegionsIbgeInteractor regionInteractor)
        {
            _regionRepository = regionRepository;
            _microregionRepository = microregionRepository;
            _regionInteractor = regionInteractor;
        }

        public async Task<SucessMessage> Handle(RegionRequest request, CancellationToken cancellationToken)
        {
            var result = await _regionInteractor.GetAllRegion();

            foreach (var region in result) 
            {
               
            }
            throw new NotImplementedException();
        }
    }
}
