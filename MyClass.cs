public class MyClass
{
 // TODO Guessing Game Function
    public void GuessingGame()
    {
        Random rnd = new Random();
        int radNum = rnd.Next(10);
        Console.WriteLine("I’ve picked a number between 1 and 10. Can you guess it ?");
        while (true)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int intInput))
            {


                if (radNum == intInput)
                {
                    Console.WriteLine(" ***** Correct!! 🎉 You guessed the number 🎉 *****");
                    break;
                }
                else if (radNum < intInput)
                {
                    Console.WriteLine("You’re over the number!! 😬. Try a smaller number.");
                }
                else if (radNum > intInput)
                {
                    Console.WriteLine("You’re under the number!! 😬 . Try a  larger number!");
                }
            }
            else
            {
                Console.WriteLine("Error!. Please enter just a valid number");
            }
        }

    }
}