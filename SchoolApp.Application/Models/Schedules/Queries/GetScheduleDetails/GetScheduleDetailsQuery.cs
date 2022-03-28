using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Schedules.Queries.GetScheduleDetails
{
    public class GetScheduleDetailsQuery : IRequest<IEnumerable<ScheduleDetailsVm>>
    {
        public int ID { get; set; }
    }
}
