using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using OnlineAuction.API.Application.Commands;
using OnlineAuction.API.Application.Queries;
using OnlineAuction.API.Dtos;
using OnlineAuction.API.Repositories.Implementations;
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
    public class LotController : Controller
    {
        private readonly IMediator _mediator;

        public LotController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IList<LotReadDto>> GetAllLots(CancellationToken cancelationToken)
        {
            return await _mediator.Send(new GetLotListQuery(), cancelationToken);
        }
        [HttpGet("{id}")]
        public async Task<LotReadDto> GetLotById(long id, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new GetLotByIdQuery(id), cancellationToken);
        }

        [HttpPost]
        public async Task<LotReadDto> CreateLot(LotReadDto lot, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new CreateLotCommand(lot), cancellationToken);
        }

        [HttpDelete("{id}")]
        public async Task<LotReadDto> DeleteLot(long id, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new DeleteLotCommand(id), cancellationToken);
        }

        [HttpPut]
        public async Task<Lot> UpdateLot(Lot lot, CancellationToken cancellationToken)
        {
            return await _mediator.Send(new UpdateLotCommand(lot), cancellationToken);
        }

    }
}
