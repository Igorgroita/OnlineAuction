using AutoMapper;
using MediatR;
using OnlineAuction.API.Dtos;
using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Application.Queries
{
    public class GetLotByIdQuery : IRequest<LotReadDto>
    {
        public long Id { get; set; }
        public GetLotByIdQuery(long id)
        {
            Id = id;
        }
        internal class GetLotByIdQueryHandler : IRequestHandler<GetLotByIdQuery, LotReadDto>
        {
            private readonly OnlineAuctionDbContext _ctx;
            private readonly IMapper _mapper;
            public GetLotByIdQueryHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }

            public Task<LotReadDto> Handle(GetLotByIdQuery request, CancellationToken cancellationToken)
            {
                var lot = _ctx.Lots.FirstOrDefault(lot => lot.Id == request.Id);

                var lotDto = _mapper.Map<LotReadDto>(lot);

                return Task.FromResult(lotDto);
            }
        }
    }
}
