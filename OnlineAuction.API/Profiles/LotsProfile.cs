using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineAuction.API.Dtos;
using OnlineAuction.Domain.Models;

namespace OnlineAuction.API.Profiles
{
    public class LotsProfile : Profile
    {
        public LotsProfile()
        {
            CreateMap<Lot, LotReadDto>();

            CreateMap<Lot, LotCreateDto>();

            CreateMap<LotCreateDto, Lot>();

        }
    }
}
