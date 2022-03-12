using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolApp.Application.Models.Groups.Commands.UpdateGroup
{
    public class UpdateGroupCommand : IRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Guid CuratorID { get; set; }

    }
}
