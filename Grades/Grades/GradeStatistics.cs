using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeStatistics
    {
        public GradeStatistics()
        {
            highest = 0;
            lowest = float.MaxValue;
        }
        public float average;                     
        public float lowest;
        public float highest;
    }
}
