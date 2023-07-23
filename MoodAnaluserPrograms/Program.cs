using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnaluserPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mood Analyser Program");
            MoodAnalyser moodAnalyser = new MoodAnalyser("Iam in Happy mood");
            Console.WriteLine(moodAnalyser.CheckMoodAnalyser());
            Console.ReadLine();
        }
    }
}
