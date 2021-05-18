using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineAuction.API.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineAuction.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LotController: Controller
    {
        private readonly SqlLotsRepository _repository;
        private readonly IMapper _mapper;
 
        public LotController(SqlLotsRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        //[HttpGet]
        //public ActionResult<IEnumerable<LotsReadDto>> GetAllLots()
        //{

        //}

    }
}
