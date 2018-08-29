
using AutoMapper;
using Renta_Flix.Dtos;
using Renta_Flix.Models;

namespace Renta_Flix.App_Start
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			// Domain to Dto
			Mapper.CreateMap<Customer, CustomerDto>();
			Mapper.CreateMap<Movie, MovieDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
			Mapper.CreateMap<Genre, GenreDto>();

            // Dto to Domain
            Mapper.CreateMap<CustomerDto, Customer>()
				.ForMember(c => c.Id, opt => opt.Ignore());

			Mapper.CreateMap<MovieDto, Movie>()
				.ForMember(c => c.Id, opt => opt.Ignore());
		}
	}
	
}