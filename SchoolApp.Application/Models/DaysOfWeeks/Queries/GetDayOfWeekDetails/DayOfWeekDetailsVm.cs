using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using DayOfWeek = SchoolApp.Domain.DayOfWeek;

namespace SchoolApp.Application.Models.DaysOfWeeks.Queries.GetDayOfWeekDetails
{
    public class DayOfWeekDetailsVm : IMapWith<DayOfWeek>
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<DayOfWeek, DayOfWeekDetailsVm>()
                .ForMember(dayOfWeek => dayOfWeek.ID,
                    opt => opt.MapFrom(dayOfWeekVm => dayOfWeekVm.ID))
                .ForMember(dayOfWeek => dayOfWeek.Name,
                    opt => opt.MapFrom(dayOfWeekVm => dayOfWeekVm.Name));
        }
    }
}
