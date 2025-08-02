/* Author: Samkeliswe Gamede
 * Student number: ST10445767
 * References:
 * Max O'Didily (2023) How to Play Music In C# (Simple) Available at: https://www.youtube.com/watch?v=uZlz1SSisYY
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace HEADACHE
{
    internal class Greeting
    {
        public static void Welcome()
        {
            // Display ASCII art
            ASCIIArt();

            // Play music
            PlayMusic("Voice 009.wav");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        public static void PlayMusic(string filepath)
        {
            SoundPlayer musicPlayer = new SoundPlayer();
            musicPlayer.SoundLocation = filepath;
            musicPlayer.Play();

        }
        public static void ASCIIArt()
        {
            // Text colour
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            // Background colour
            Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine(" _  __  _           _        _");
            Console.WriteLine("| |/ / | |_   _  _ | | _  _ | | __ _");
            Console.WriteLine("| , <  | ' \\ | || || || || || |/ _' |");
            Console.WriteLine("|_|\\_\\ |_| |_|\\_,_||_| \\_,_||_|\\__,_|");
            Console.WriteLine("For your sleek and discreet cybersecurity needs");
            Console.WriteLine("");
            Console.WriteLine("       _______ ");
            Console.WriteLine("     / ______,\\");
            Console.WriteLine("   ,' /      \\_\\");
            Console.WriteLine("   | |         ");
            Console.WriteLine("   | |");
            Console.WriteLine(" __|_|______________");
            Console.WriteLine("|         __        |");
            Console.WriteLine("|        /'{>       |");
            Console.WriteLine("|    ____) (____    |");
            Console.WriteLine("|  //'--;   ;--'\\\\  |");
            Console.WriteLine("| ///////\\_/\\\\\\\\\\\\  |");
            Console.WriteLine("|        m m        |");
            Console.WriteLine("|___________________|");

            // Reset text and background colour
            Console.ResetColor();
        }
    }
}
