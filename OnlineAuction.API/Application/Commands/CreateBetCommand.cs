using AutoMapper;
using MediatR;
using OnlineAuction.API.Dtos;
using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Application.Commands
{
    public class CreateBetCommand : IRequest<BetReadDto>
    {
        public BetReadDto Bet { get; set; }
        public CreateBetCommand(BetReadDto bet)
        {
            Bet = bet; 
        }
        internal class CreateBetCommandHandler : IRequestHandler<CreateBetCommand, BetReadDto>
        {
            private readonly OnlineAuctionDbContext _ctx;
            private readonly IMapper _mapper;
            public CreateBetCommandHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }
            public Task<BetReadDto> Handle(CreateBetCommand request, CancellationToken cancellationToken)
            {
                var bet = _mapper.Map<Bet>(request.Bet);
                _ctx.Bets.Add(bet);
                _ctx.SaveChanges();

                return Task.FromResult(request.Bet);
            }
        }

    }
}
