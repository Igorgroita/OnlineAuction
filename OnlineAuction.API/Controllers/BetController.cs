using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineAuction.API.Application.Commands;
using OnlineAuction.API.Application.Queries;
using OnlineAuction.API.Dtos;
using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize()]
    public class BetController : Controller
    {
        private readonly IMediator _mediator;
        
        public BetController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IList<Bet>> GetAllBets(CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetBetListQuery(), cancellationToken);
        }

        [HttpGet("{id}")]
        public async Task<Bet> GetBetById(long id, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetBetByIdQuery(id), cancellationToken);
        }

        [HttpPost]
        public async Task<BetReadDto> CreateBet(BetReadDto bet, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new CreateBetCommand(bet), cancellationToken);
        }

        [HttpDelete("{id}")]
        public async Task<BetReadDto> DeleteBet(long id, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new DeleteBetCommand(id), cancellationToken);
        }

    }
}
