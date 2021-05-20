using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineAuction.API.Dtos;
using OnlineAuction.API.Repositories.Implementations;
using OnlineAuction.Domain.Models;
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

        [HttpGet]
        public ActionResult<IEnumerable<LotReadDto>> GetAllLots() 
        {
            var lotItems = _repository.GetAllLots();

            return Ok(_mapper.Map<IEnumerable<LotReadDto>>(lotItems));

        }

        [HttpGet("{id}")]
        public ActionResult<LotReadDto> GetLotById(int id)
        {
            var lotItem = _repository.GetLotById(id);
            if(lotItem != null)
            {
                return Ok(_mapper.Map<LotReadDto>(lotItem));
            }
            return NotFound();
        }

        //[HttpPost]
        //public ActionResult<LotReadDto> CreateLot(LotCreateDto lotReadDto)
        //{
        //    var lotModel = _mapper.Map<Lot>(lotReadDto);

        //    _repository.CreateLot(lotModel);
        //    _repository.SaveChanges();
                    
        //}




    }
}
