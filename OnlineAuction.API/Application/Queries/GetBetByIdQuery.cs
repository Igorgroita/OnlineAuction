using MediatR;
using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Application.Queries
{
    public class GetBetByIdQuery : IRequest<Bet>
    {
        public long Id { get; set; }

        public GetBetByIdQuery(long id)
        {
            Id = id;
        }

        internal class GetBetByIdQueryHandler : IRequestHandler<GetBetByIdQuery, Bet>
        {
            private readonly OnlineAuctionDbContext _ctx;
            public GetBetByIdQueryHandler(OnlineAuctionDbContext ctx)
            {
                _ctx = ctx;
            }

            public Task<Bet> Handle(GetBetByIdQuery request, CancellationToken cancellationToken)
            {
                var bet = _ctx.Bets.FirstOrDefault(bet => bet.Id == request.Id);
                return Task.FromResult(bet);
            }
        }

    }
}
