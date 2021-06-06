using AutoMapper;
using MediatR;
using OnlineAuction.API.Dtos;
using OnlineAuction.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace OnlineAuction.API.Application.Commands
{
    public class CreateLotCommand: IRequest<LotReadDto>
    {
        public LotCreateDto Lot { get; set; }

        public CreateLotCommand(LotCreateDto lot)
        {
            Lot = lot;
        }

        internal class CreateLotCommandHandler : IRequestHandler<CreateLotCommand, LotCreateDto>
        {
            public readonly OnlineAuctionDbContext _ctx;
            public readonly IMapper _mapper;

            public CreateLotCommandHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }
            public async Task<LotCreateDto> Handle(CreateLotCommand request, CancellationToken cancellationToken)
            {
                var lot = _mapper.Map<Lot>(request.Lot);
                _ctx.Lots.Add(lot);

                return lot;
            }


        }

    }
}
