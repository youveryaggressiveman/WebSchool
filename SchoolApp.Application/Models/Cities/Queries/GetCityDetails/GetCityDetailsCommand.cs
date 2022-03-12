using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Cities.Queries.GetCityDetails
{
    public class GetCityDetailsCommand : IRequest<ICollection<CityDetailsVm>>
    {
        public int ID { get; set; }
    }
}
