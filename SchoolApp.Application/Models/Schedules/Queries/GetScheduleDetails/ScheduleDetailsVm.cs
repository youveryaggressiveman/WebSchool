using AutoMapper;
using SchoolApp.Application.Common.Mappings;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolApp.Application.Models.DaysOfWeeks;
using DayOfWeek = SchoolApp.Domain.DayOfWeek;

namespace SchoolApp.Application.Models.Schedules.Queries.GetScheduleDetails
{
    public class ScheduleDetailsVm : IMapWith<Schedule>
    {
        public int ID { get; set; }

        public int GroupID { get; set; }
        public Guid EmployeeID { get; set; }
        public int DayOfWeekID { get; set; }
        public int TimeSubjectID { get; set; }
        public int SubjectID { get; set; }

        public Group Group { get; set; }
        public Employee Employee { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public TimeSubject TimeSubject { get; set; }
        public Subject Subject { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Schedule, ScheduleDetailsVm>()
                .ForMember(schedule => schedule.ID,
                opt => opt.MapFrom(scheduleVm => scheduleVm.ID))
                .ForMember(schedule => schedule.GroupID,
                opt => opt.MapFrom(scheduleVm => scheduleVm.GroupID))
                .ForMember(schedule => schedule.EmployeeID,
                opt => opt.MapFrom(scheduleVm => scheduleVm.EmployeeID))
                .ForMember(schedule => schedule.DayOfWeekID,
                opt => opt.MapFrom(scheduleVm => scheduleVm.DayOfWeekID))
                .ForMember(schdule => schdule.TimeSubjectID,
                opt => opt.MapFrom(scheduleVm => scheduleVm.TimeSubjectID))
                .ForMember(schedule => schedule.SubjectID,
                opt => opt.MapFrom(scheduleVm => scheduleVm.SubjectID))
                .ForMember(schedule => schedule.Group,
                opt => opt.MapFrom(scheduleVm => scheduleVm.Group))
                .ForMember(schedule => schedule.Employee,
                opt => opt.MapFrom(scheduleVm => scheduleVm.Employee))
                .ForMember(schedule => schedule.DayOfWeek,
                opt => opt.MapFrom(scheduleVm => scheduleVm.DayOfWeek))
                .ForMember(schedule => schedule.TimeSubject,
                opt => opt.MapFrom(scheduleVm => scheduleVm.TimeSubject))
                .ForMember(schedule => schedule.Subject,
                opt => opt.MapFrom(scheduleVm => scheduleVm.Subject));
        }
    }
}
