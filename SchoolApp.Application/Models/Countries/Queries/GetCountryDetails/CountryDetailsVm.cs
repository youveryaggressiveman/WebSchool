using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Countries.Queries.GetCountryDetails
{
    public class CountryDetailsVm : IMapWith<Country>
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Country, CountryDetailsVm>()
                .ForMember(country => country.ID,
                    opt => opt.MapFrom(countryVm => countryVm.ID))
                .ForMember(country => country.Name,
                    opt => opt.MapFrom(countryVm => countryVm.Name));
        }
    }
}
