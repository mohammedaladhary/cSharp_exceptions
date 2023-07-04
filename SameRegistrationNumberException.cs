using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class SameRegistrationNumberException: ApplicationException
    {
        Student A { get; set; }
        Student B { get; set; }

        public SameRegistrationNumberException(Student A, Student B)
        {
            this.A = A;
            this.B = B;
        }

        public override string ToString()
        {
            return $"{A.studentName} and {B.studentName} have the same studentID number ";
        }
    }
}
