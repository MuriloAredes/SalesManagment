using MediatR;
using Microsoft.AspNetCore.Mvc;
using SalesManagment.Contract.SellerContracts.RegisterRequest;

namespace SalesManagment.Api.Controllers
{
    [Route("api/v1/Seller")]
    [ApiController]
    public class SellerController : Controller
    {
        private readonly IMediator _mediator;
        public SellerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register(RegisterSellerRequest request)
        {
            try 
            {
                var result = await _mediator.Send(request);
                return View(result);
            } 
            catch (Exception ex) 
            {
                return BadRequest( new { message = ex.Message } );
            }
        }
    }
}
