using MediatR;
using SalesManagment.Contract.RegionContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Managment.Teste.RegionTestes
{
    [TestClass]
    public class RegionTestes
    {
        private readonly IMediator _mediator;

        public RegionTestes(IMediator mediator)
        {
            _mediator = mediator;
        }
        [TestMethod]
        public  void UpdateRegion() 
        {
            var request = new RegionRequest(true);

            var result =  _mediator.Send(request);

            Assert.AreEqual("Base de dados atualizada com sucesso", result);
        }
    }
}
