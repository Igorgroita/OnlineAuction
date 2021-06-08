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
    public class UpdateLotCommand : IRequest<Lot>
    {
        public Lot Lot { get; set; }

        public UpdateLotCommand(Lot lot)
        {
            Lot = lot;
        }
        internal class UpdateLotCommandHandler : IRequestHandler<UpdateLotCommand, Lot>
        {
            private readonly OnlineAuctionDbContext _ctx;
            private readonly IMapper _mapper;

            public UpdateLotCommandHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }
            Task<Lot> IRequestHandler<UpdateLotCommand, Lot>.Handle(UpdateLotCommand request, CancellationToken cancellationToken)
            {
                var oldLot = _ctx.Lots.FirstOrDefault(lot => lot.Id == request.Lot.Id);
                oldLot.AuctioneerId = request.Lot.AuctioneerId;
                oldLot.Description = request.Lot.Description;
                oldLot.LotName = request.Lot.LotName;
                
                _ctx.Lots.Update(oldLot);
                _ctx.SaveChanges();
                return Task.FromResult(request.Lot);
            }
        }
    }
}
