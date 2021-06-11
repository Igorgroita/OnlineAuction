using MediatR;
using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Application.Queries
{
    public class GetBetsByLotQuery : IRequest<IList<Bet>>
    {
        public long LotId { get; set; }

        public GetBetsByLotQuery(long id)
        {
            LotId = id;
        }
        internal class GetBetsByLotQueryHandler : IRequestHandler<GetBetsByLotQuery, IList<Bet>>
        {
            private readonly OnlineAuctionDbContext _ctx;

            public GetBetsByLotQueryHandler(OnlineAuctionDbContext ctx)
            {
                _ctx = ctx;
            }
            public async Task<IList<Bet>> Handle(GetBetsByLotQuery request, CancellationToken cancellationToken)
            {
                var betByLot = _ctx.Bets.Where(bet => bet.LotId == request.LotId).ToList();

                return betByLot;
            }
        }

    }
}
