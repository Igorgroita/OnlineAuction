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
    public class DeleteBetCommand : IRequest<BetReadDto>
    {
        public long Id { get; set; }
        public DeleteBetCommand(long id)
        {
            Id = id;
        }
        internal class DeleteBetCommandHandler : IRequestHandler<DeleteBetCommand, BetReadDto>
        {
            private readonly OnlineAuctionDbContext _ctx;
            private readonly IMapper _mapper;

            public DeleteBetCommandHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }
            public  Task<BetReadDto> Handle(DeleteBetCommand request, CancellationToken cancellationToken)
            {
                var bet = _ctx.Bets.FirstOrDefault(bet => bet.Id == request.Id);
                _ctx.Bets.Remove(bet);
                _ctx.SaveChanges();
                return Task.FromResult(_mapper.Map<BetReadDto>(bet));
            }
        }
    }
}
