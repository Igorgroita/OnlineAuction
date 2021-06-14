using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using OnlineAuction.API.Dtos;
using OnlineAuction.API.Models;

namespace OnlineAuction.API.Profiles
{
    public class LotsProfile : Profile
    {
        public LotsProfile()
        {
            CreateMap<Lot, LotReadDto>();

            CreateMap<LotReadDto, Lot>();


        }
    }
}
