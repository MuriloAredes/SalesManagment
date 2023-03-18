using MediatR;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using NUnit.Framework.Internal;
using SalesManagment.Contract.RegionContracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace SalesManagment.testes.RegionsTestes
{
    [TestClass]
    public class RegionTeste
    {
        private readonly IMediator _mediator;
        public RegionTeste(IMediator mediator)
        {
            _mediator = mediator;
        }
        [Fact]
        public async void TestarRegions()
        {
           
            
            var request = new RegionRequest(true);

            var result = await _mediator.Send(request);

            NUnit.Framework.Assert.Equals("Base de dados atualizada com sucesso", result);
        }
    }
}
