using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class GradeBook
    {
        public GradeBook()
        {
            grades = new List<float>();
        }
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();
            
            float sum = 0;
            foreach(float grade in grades)
            {
                stats.highest = Math.Max(grade, stats.highest);
                stats.lowest = Math.Min(grade, stats.lowest);
                sum += grade;
            }
            stats.average = sum / grades.Count;

            return stats;
        }
        private List<float> grades;
    }
}

