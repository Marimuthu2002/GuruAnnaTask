using Azure;
using CURD_Operation.Model;
using CURD_Operation.Repositry;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.Command
{
    public class CreateEmployee:IRequest<Departments>
    {
        public int StudId { get; set; }
        public string StudName { get; set; }
        public int StudAge { get; set; }
        public int StudFees { get; set; }

        public CreateEmployee(int studId, string studName, int studAge, int studFees)
        {
            StudId = StudId;
            StudName = studName;
            StudAge = studAge;
            StudFees = studFees;
        }
    }
}
