using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;

namespace SchoolApp.Application.Models.TimeSubjects.Queries.GetTimeSubjectDetails
{
    public class TimeSubjectDetailsVm : IMapWith<TimeSubject>
    {
        public int ID { get; set; }

        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<TimeSubject, TimeSubjectDetailsVm>()
                .ForMember(timeSubject => timeSubject.ID,
                    opt => opt.MapFrom(timeSubjectVm => timeSubjectVm.ID))
                .ForMember(timeSubject => timeSubject.Begin,
                    opt => opt.MapFrom(timeSubjectVm => timeSubjectVm.Begin))
                .ForMember(timeSubject => timeSubject.End,
                    opt => opt.MapFrom(timeSubjectVm => timeSubjectVm.End));
        }
    }
}
