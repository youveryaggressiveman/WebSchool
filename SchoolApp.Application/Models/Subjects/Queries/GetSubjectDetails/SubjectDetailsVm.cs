using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;

namespace SchoolApp.Application.Models.Subjects.Queries.GetSubjectDetails
{
    public class SubjectDetailsVm : IMapWith<Subject>
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Subject, SubjectDetailsVm>()
                .ForMember(subject => subject.ID,
                    opt => opt.MapFrom(subjectVm => subjectVm.ID))
                .ForMember(subject => subject.Name,
                    opt => opt.MapFrom(subjectVm => subjectVm.Name));
        }
    }
}
