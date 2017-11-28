using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public class GradeBook
    {
        public GradeBook()
        {
            _name = "Empty";
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
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name Cannot Be Null");
                }
                if (!String.IsNullOrEmpty(value))
                {
                    if (_name != value)
                    {
                        NameChanged(_name, value);
                    }
                    _name = value;
                }
            }
        }
        public event NameChangedDelegate NameChanged;
        private string _name;
        private List<float> grades;
    }
}

