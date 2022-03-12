using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Cities.Queries.GetCityDetails
{
    public class CityDetailsVm : IMapWith<City>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<City, CityDetailsVm>()
                .ForMember(city => city.ID,
                    opt => opt.MapFrom(cityVm => cityVm.ID))
                .ForMember(city => city.Name,
                    opt => opt.MapFrom(cityVm => cityVm.Name));
        }
    }
}
