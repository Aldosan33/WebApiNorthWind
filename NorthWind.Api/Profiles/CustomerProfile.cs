using AutoMapper;
using NorthWind.Api.Models;

namespace NorthWind.Api.Profiles
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Models.Dto.Customer, Customer>().ReverseMap();
        }
    }
}