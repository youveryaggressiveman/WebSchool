using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using SchoolApp.Application.Models.DaysOfWeeks.Queries.GetDayOfWeekDetails;

namespace SchoolApp.Application.Models.DaysOfWeeks.Queries.GetDayOfWeek
{
    public class GetDayOfWeekQuery : IRequest<IEnumerable<DayOfWeekDetailsVm>>
    {
    }
}
