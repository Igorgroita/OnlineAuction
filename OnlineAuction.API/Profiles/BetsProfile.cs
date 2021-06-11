using AutoMapper;
using OnlineAuction.API.Dtos;
using OnlineAuction.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Profiles
{
    public class BetsProfile : Profile
    {
        public BetsProfile()
        {
            CreateMap<Bet, BetReadDto>();
            CreateMap<BetReadDto, Bet>();
        }
    }
}
