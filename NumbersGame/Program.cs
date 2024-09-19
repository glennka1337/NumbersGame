namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            var rand = new Random();
            int correctAnswer = rand.Next(1, 21);
            int userGuess;
            bool checkResult;


            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ange din gissning: ");
                userGuess = Int32.Parse(Console.ReadLine());
                checkResult = CheckGuess(userGuess, correctAnswer);
                if (checkResult == true)
                {
                    break;
                }
                else if (i == 5)
                {
                    Console.WriteLine("Tyvärr du lyckades inte gissa talet på fem försök!");

                }

            }

            Console.ReadKey();

        }

        internal static bool CheckGuess(int userGuess, int correctAnswer)
        {
            if (userGuess == correctAnswer)
            {
                Console.WriteLine("Woohoo! Du gjorde det!");
                return true;
            }
            else if (userGuess < correctAnswer)
            {
                Console.WriteLine("Tyvärr du gissade för lågt!");
            }
            else if (userGuess > correctAnswer)
            {
                Console.WriteLine("Tyvärr du gissade för högt!");
            }
            return false;
        }
    }
}
