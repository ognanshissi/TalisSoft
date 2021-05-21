using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList;

namespace TalisSoft.Octopus.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController: ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator _mediator)
        {
            this._mediator = _mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CustomerListVm>>> GetAll()
        {
            var customers = await _mediator.Send(new GetCustomerListQuery());
            return Ok(customers);
        }
        
    }
}