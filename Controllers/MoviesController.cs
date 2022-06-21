using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using movieguideAPI.Data;
using movieguideAPI.Dtos;
using movieguideAPI.Models;

namespace movieguideAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    { 
        private IAppRepository _appRepository;
        private IMapper _mapper;

        public MoviesController(IAppRepository appRepository, IMapper mapper)
        {
            _appRepository = appRepository;
            _mapper = mapper;
        }

        public IActionResult GetMovies()
        {
            var movies = _appRepository.GetMovies();
            var moviesMapper = _mapper.Map<List<MovieForListDto>>(movies);
            return Ok(moviesMapper);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult Add([FromBody] Movie movie)
        {
            _appRepository.Add(movie);
            _appRepository.SaveAll();
            return Ok(movie);
        }

        [HttpGet]
        [Route("details")]

        public IActionResult GetMoviesById(int movieId)
        {
            var movie =_appRepository.GetMovieById(movieId);
            var movieToReturn = _mapper.Map<MovieForDetailsDto>(movie);
            return Ok(movie);
        }
    }
}
