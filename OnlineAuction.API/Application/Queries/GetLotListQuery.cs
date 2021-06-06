using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using OnlineAuction.API.Dtos;
using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Application.Queries
{
    public class GetLotListQuery : IRequest<IList<LotReadDto>>
    {
         internal class GetLotListQueryHandler : IRequestHandler<GetLotListQuery, IList<LotReadDto>>
        {
            private readonly OnlineAuctionDbContext _ctx;
            private readonly IMapper _mapper;
            public GetLotListQueryHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }
            public async Task<IList<LotReadDto>> Handle(GetLotListQuery request, CancellationToken cancellationToken)
            {
                var lots = await _ctx.Lots.AsNoTracking().ToListAsync(cancellationToken);

                return _mapper.Map<IList<LotReadDto>>(lots);
            }
        }

    }

}
