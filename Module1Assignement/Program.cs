using System.Collections;

namespace Module1Assignement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();


            InputGatherer inputGatherer = new InputGatherer();
            zoo = inputGatherer.GenerateData();

            foreach (var thing in zoo)
            {
                PrintOut(thing);
            }

            //NOTE: I have completed everything except for putting the information into a text document

        }
        public static void PrintOut(ITalkable p)
        {
            Console.WriteLine(p.GetName() + " says=" + p.Talk());
        }
    } 
}
