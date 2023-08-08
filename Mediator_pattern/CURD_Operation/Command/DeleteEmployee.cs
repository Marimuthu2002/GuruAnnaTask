using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.Command
{
    public class DeleteEmployee : IRequest<int>
    {
        public int StudId { get; set; }
    }
}
