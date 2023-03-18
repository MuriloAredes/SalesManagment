using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Moq;
using NUnit.Framework;
using SalesManagment.Application.RegionHandler.Command;
using SalesManagment.Contract.RegionContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.Managment.Teste.RegionTestes
{
    [TestFixture]
    public class RegionTestes
    {

        private IMediator _mediator;

       
            public RegionTestes(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Test]
        public async void RegisterRegions() 
        {
            var request = new Mock<RegionRequest> ();

            
            var result = await _mediator.Send(request);

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual("Base de dados atualizada com sucesso", result);
        }

        [Test]
        public void testando () 
        {
            bool status = true;

            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(status);
        }


    }
}
