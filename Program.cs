/* Author: Samkeliswe Gamede
 * Student number: ST10445767
 * References:
 * Max O'Didily (2023) How to Play Music In C# (Simple) Available at: https://www.youtube.com/watch?v=uZlz1SSisYY
 * Shea, S & Gillis, A.S. (no date) What is cybersecurity?: TechTarget. Available at:https://www.techtarget.com/searchsecurity/definition/cybersecurity#:~:text=Cybersecurity%20is%20the%20practice%20of,centers%20and%20other%20computerized%20systems. (Accessed 16 April 2025). 
 * 
 */

using System;
using System.Media;
namespace HEADACHE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling the Greeting class to welcome the user
            Greeting.Welcome();

            //Engaging the user in a conversation
            Console.WriteLine("Hello I am the Khulula Cybersecurity Chatbot!");
            Console.WriteLine("I would love it, if you could share your name with me");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, you can call me Khulu ");
            Console.WriteLine("How are you feeling today?");
            string feeling = Console.ReadLine();

            // Calling the Responses class to respond to the user's feelings
            Responses.Feeling(name, feeling);

            // Ask the user if they want to learn anything at all
            Console.WriteLine("Would like to learn more about cybersecurity? (Y/N)");
            string learn = Console.ReadLine();
            if (learn.ToLower().Contains("y"))
            {
                Console.WriteLine($"So, {name} would you like to learn more about" + 
                    "\n(1) Cybersecurity" +
                    "\n(2) Cybercrime?");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Responses.Cybersecurity(name);
                        break;
                    case 2:
                        Responses.Cybercrime(name);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else if (learn.ToLower().Contains("n"))
            {
                Console.WriteLine("That's okay, I am here if you need me.");
            }
            else
            {
                Console.WriteLine("I am sorry, I did not understand that.");
            }
        }

    }
}