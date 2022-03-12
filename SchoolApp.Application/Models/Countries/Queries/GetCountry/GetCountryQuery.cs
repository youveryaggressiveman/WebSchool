using MediatR;
using SchoolApp.Application.Models.Countries.Queries.GetCountryDetails;
using SchoolApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Countries.Queries.GetCountry
{
    public class GetCountryQuery : IRequest<IEnumerable<CountryDetailsVm>>
    {
    }
}
