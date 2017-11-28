using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            SpeechSynthesizer syn = new SpeechSynthesizer();
            syn.Speak("have a nice day");
            GradeBook book=new GradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.average);
            Console.WriteLine(stats.lowest);
            Console.WriteLine(stats.highest);
            Console.ReadLine();
            
            
        }
    }
}
