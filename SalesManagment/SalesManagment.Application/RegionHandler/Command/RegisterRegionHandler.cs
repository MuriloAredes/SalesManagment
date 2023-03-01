using MediatR;
using SalesManagment.Application.Interactor.interfaces;
using SalesManagment.Context.Persistence.interfaces;
using SalesManagment.Contract;
using SalesManagment.Contract.RegionContracts;
using SalesManagment.Domain.Dto;
using SalesManagment.Domain.Entitites;
using System.Linq;

namespace SalesManagment.Application.RegionHandler.Command
{
    public class RegisterRegionHandler : IRequestHandler<RegionRequest, SucessMessage>
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMicroRegionRepository _microRegionRepository;
        private readonly IMicroRegionRepository _microregionRepository;
        private readonly IRegionsIbgeInteractor _regionInteractor;
        public RegisterRegionHandler(IMicroRegionRepository microregionRepository,
                                     IRegionRepository regionRepository,
                                     IRegionsIbgeInteractor regionInteractor,
                                     IMicroRegionRepository microRegionRepository)
        {
            _regionRepository = regionRepository;
            _microregionRepository = microregionRepository;
            _regionInteractor = regionInteractor;
            _microRegionRepository = microRegionRepository;
        }

        public async Task<SucessMessage> Handle(RegionRequest request, CancellationToken cancellationToken)
        {
            var resultRegionsInteractor = await _regionInteractor.GetAllRegion();
            var resultMicroRegionContext = _microregionRepository.GetAll();
            var resultRegionContext = await _regionInteractor.GetAllRegion();

            var microRegions = resultRegionsInteractor.Select(o => new MicroRegion { Id = o.Id, Nome = o.Nome, Sigla = o.Sigla });
            var regions = resultRegionContext.Select(o => new RootDto { Id = o.Id, Nome = o.Nome, Sigla = o.Sigla });

            bool hasMicroRegion = resultMicroRegionContext.SequenceEqual(microRegions);
            bool hasRegion = resultRegionContext.SequenceEqual(regions);

            if (!hasMicroRegion && !hasRegion)
            {
                List<Region> regionList = new List<Region>();
                List<MicroRegion> microRegionList = new List<MicroRegion>();

                foreach (var regionMicro in resultRegionsInteractor)
                {
                    microRegionList.Add(
                        new MicroRegion
                        {
                            Id = regionMicro.Id,
                            Nome = regionMicro.Nome,
                            Sigla = regionMicro.Sigla,
                            RegionId = regionMicro.Regiao!.Id
                        });


                    await _regionRepository.Add(new Region
                    {
                        Id = regionMicro.Regiao.Id,
                        Nome = regionMicro.Regiao.Nome,
                        Sigla = regionMicro.Regiao.Sigla,
                        MicroRegions = microRegionList


                    });
                }

            }


            return new SucessMessage("Base de dados atualizada com sucesso");
        }
    }
}
