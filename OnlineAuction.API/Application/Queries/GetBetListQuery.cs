using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Application.Queries
{
    public class GetBetListQuery : IRequest<IList<Bet>>
    {

        internal class GetBetListQueryHandler : IRequestHandler<GetBetListQuery, IList<Bet>>
        {
            private readonly OnlineAuctionDbContext _ctx;

            public GetBetListQueryHandler(OnlineAuctionDbContext ctx)
            {
                _ctx = ctx;
            }
            public async Task<IList<Bet>> Handle(GetBetListQuery request, CancellationToken cancellationToken)
            {
                var bets = await _ctx.Bets.AsNoTracking().ToListAsync(cancellationToken);
                return bets;
            }
        }

    }
}
