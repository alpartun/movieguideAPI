using System.Linq;
using AutoMapper;
using movieguideAPI.Dtos;
using movieguideAPI.Models;

namespace movieguideAPI.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Movie, MovieForListDto>()
                .ForMember(dest=> dest.PhotoUrl, opt =>
                {
                    opt.MapFrom(src=>src.Photos.FirstOrDefault(p=>p.IsMain).Url);
                });
            CreateMap<Movie, MovieForDetailsDto>();
        }
        
    }
}