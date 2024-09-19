namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            //Generating the answer for the puzzle.
            var rand = new Random();
            int correctAnswer = rand.Next(1, 21);

            //A loop that asks user for input and calls the CheckGuess method using the input and the correct answer 5 times.
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Ange din gissning: ");
                int userGuess = Int32.Parse(Console.ReadLine());
                bool checkResult = CheckGuess(userGuess, correctAnswer);

                //Uses the returned boolean from the method CheckGuess to either break the user out of the loop or display the losing message.
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

        //A simple method which compares two variables to output a fitting message to the user.
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
