using System;

namespace inluppg5_3A
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] questions = new string[] { "1. Vem är bättre, Hugo eller Emil?", "2. Vem vann fotbolls-VM 2023", "3. Hur mycket är 2 minus 1", "4. Va?"};
            string[] trueAnswers = new string[] { "emil", "argentina", "1", "ja"};

            Console.WriteLine("Välj en fråga");
            foreach (string question in questions)
            {
                Console.WriteLine(question);
            }
            int questionIndex = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine("Svara på fråga " + (questionIndex+1));
            string answer = Console.ReadLine();
            

            if (answer.ToLower() == trueAnswers[questionIndex])
            {
                Console.WriteLine("Mycket bra svar");
            }
            else
            {
                Console.WriteLine("Helt fel");
            }
        }   
    }
}