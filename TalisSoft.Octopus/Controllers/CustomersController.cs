using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TalisSoft.Octopus.Application.Features.Customers.Commands.CreateCustomer;
using TalisSoft.Octopus.Application.Features.Customers.Queries.GetCustomerList;

namespace TalisSoft.Octopus.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomersController: ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CustomerListVm>>> GetAll()
        {
            var customers = await _mediator.Send(new GetCustomerListQuery());
            return Ok(customers);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateCustomerVm>> Create([FromBody] CreateCustomerCommand request)
        {
            var customer = await _mediator.Send(request);
            return Ok(customer);
        }
        
    }
}