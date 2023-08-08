using CURD_Operation.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CURD_Operation.Command
{
    public class UpdateEmployee : IRequest<int>
    { 
        public int StudId { get; set; }
        public string StudName { get; set; }
        public int StudAge { get; set; }
        public int StudFees { get; set; }

        public UpdateEmployee(int studId, string studName, int studAge, int studFees)
        {
            StudId = studId;
            StudName = studName;
            StudAge = studAge;
            StudFees = studFees;
        }
    }
}
