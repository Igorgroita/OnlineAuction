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
    public class DeleteLotCommand : IRequest<LotReadDto>
    {
        public long Id { get; set; }

        public DeleteLotCommand(long id)
        {
            Id = id;
        }

        internal class DeleteLotCommandHandler : IRequestHandler<DeleteLotCommand, LotReadDto>
        {
            private readonly OnlineAuctionDbContext _ctx;
            private readonly IMapper _mapper;

            public DeleteLotCommandHandler(OnlineAuctionDbContext ctx, IMapper mapper)
            {
                _ctx = ctx;
                _mapper = mapper;
            }

            public Task<LotReadDto> Handle(DeleteLotCommand request, CancellationToken cancellationToken)
            {
                var lot = _ctx.Lots.FirstOrDefault(lot => lot.Id == request.Id);
                _ctx.Lots.Remove(lot);
                _ctx.SaveChanges();

                return Task.FromResult(_mapper.Map<LotReadDto>(lot));
            }
        }
    }
}
