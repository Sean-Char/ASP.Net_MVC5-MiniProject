
using AutoMapper;
using Renta_Flix.Dtos;
using Renta_Flix.Models;

namespace Renta_Flix.App_Start
{
	public class MappingProfile : Profile
	{
		public MappingProfile()
		{
			Mapper.CreateMap<Customer, CustomerDto>();
			Mapper.CreateMap<CustomerDto, Customer>();
		}
	}
	
}