﻿using API_Hoteles.Models;
using API_Hoteles.Models.DTO;
using API_Hoteles.Models.Repository;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_Hoteles.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IHotelRepository _hotelRepository;

        public HotelController( IMapper mapper, IHotelRepository hotelRepository)
        {
            _mapper = mapper;
            _hotelRepository = hotelRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var HotelList = await _hotelRepository.GetListHotels();
                var HotelListDTO = _mapper.Map<IEnumerable<HotelDTO>>(HotelList);
                return Ok(HotelListDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get(int id)
        {
            try
            {
                var Hotel = await _hotelRepository.GetHotelById(id);
                if (Hotel == null)
                {
                    return NotFound();
                }
                var HotelDTO = _mapper.Map<HotelDTO>(Hotel);
                return Ok(HotelDTO);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]

        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var hotel = await _hotelRepository.GetHotelById(id);
                if(hotel == null)
                {
                    return NotFound();
                }

                await _hotelRepository.DeleteHotel(hotel);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]

        public async Task<IActionResult> Post(HotelDTO hotelDTO)
        {
            try
            {
                var hotel = _mapper.Map<Hotel>(hotelDTO);

                hotel.CreationDate = DateTime.Now;

                hotel = await _hotelRepository.AddHotel(hotel);

                var hotelItemDTO = _mapper.Map<HotelDTO>(hotel);

                return CreatedAtAction("Get", new { id = hotel.Id }, hotelItemDTO);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]

        public async Task<IActionResult> Put(int id, HotelDTO hotelDTO)
        {
            try
            {
                var hotel = _mapper.Map<Hotel>(hotelDTO);

                if(id != hotel.Id)
                {
                    return BadRequest();
                }

                var hotelValue = await _hotelRepository.GetHotelById(id);

                if(hotelValue == null)
                {
                    return BadRequest();
                }

                await _hotelRepository.UpdateHotel(hotel);

                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
