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

            ThrowAwayGradeBook book=new ThrowAwayGradeBook();
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
            book.NameChanged += onNameChanged;
            Console.WriteLine("Write your name");
            try
            {
                book.name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            GradeStatistics stats = book.ComputeStatistics();

            WriteResult("Average",stats.average);
            WriteResult("Lowest",stats.lowest);
            WriteResult("Highest",stats.highest);
            Console.ReadLine();
            
            
        }

        private static GradeBook CreateGradeBook()
        {
            return new ThrowAwayGradeBook();
        }

        static void onNameChanged(string existing, string newname)
        {
            Console.WriteLine($"Grade book changing name from {existing} to {newname}");
        }
        static void WriteResult(string description, float stat)
        {
            Console.WriteLine("{0} : {1}",description,stat);
        }
    }
}
