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
    public class CreateLotCommand : IRequest<LotReadDto>
    {
        public LotReadDto Lot { get; set; }

        public CreateLotCommand(LotReadDto lot)
        {
            Lot = lot;
        }
        internal class CreateLotCommandHandler : IRequestHandler<CreateLotCommand, LotReadDto>
        {
            private readonly OnlineAuctionDbContext _ctx;
            private readonly IMapper _mapper;

            public CreateLotCommandHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }
            
            public Task<LotReadDto> Handle(CreateLotCommand request, CancellationToken cancellationToken)
            {
                var lot = _mapper.Map<Lot>(request.Lot);
                _ctx.Lots.Add(lot);
                _ctx.SaveChanges();
                LotReadDto lotDto = _mapper.Map<LotReadDto>(lot);
                return Task.FromResult(lotDto);
            }
        }

    }
}
