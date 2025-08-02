using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEADACHE
{
    internal class Responses
    {
        public static void Feeling(string name, string feeling)
        {
            // Check if the user is feeling good or bad
            string[] positiveresponses = {"good", "fine", "well", "okay", "awesome", "excellent", "not bad", "alright", "ok" };
            string[] negativeresponses = { "bad", "sad", "angry", "mad", "upset", "frustrated", "disappointed", "unhappy", "not good" };
            string[] neutralresponses = { "neutral", "meh", "indifferent", "whatever", "so-so", "average", "mediocre" };
            string[] response = feeling.ToLower().Split(' ');

            // Search the string of the user to find a possible match and give a personalised response
            bool foundMatch = false;
                foreach (string word in response)
                {
                    if (positiveresponses.Contains(word))
                    {
                        int index = Array.IndexOf(positiveresponses, word);
                        Console.WriteLine($"That's great to hear, {name}! I'm glad you're feeling {positiveresponses[index]}.");
                        foundMatch = true;
                        break;
                    }
                    else if (negativeresponses.Contains(word))
                    {
                        int index = Array.IndexOf(negativeresponses, word);
                        Console.WriteLine($"I'm sorry to hear that, {name}. It's okay to feel {negativeresponses[index]} sometimes.");
                        foundMatch = true;
                        break;
                    }
                    else if (neutralresponses.Contains(word))
                    {
                        int index = Array.IndexOf(neutralresponses, word);
                        Console.WriteLine($"You are so real for that, {name}. Sometimes we all feel a bit {neutralresponses[index]}.");
                        foundMatch = true;
                        break;
                    }
                }
            // If no match is found, provide a generic response
            if (!foundMatch)
            {
                Console.WriteLine($"Thanks for sharing, {name}. How can I assist you today?");
            }

        }

        public static void Cybersecurity(string name)
        {
            Console.WriteLine($"I am glad you have chosen to learn about Cybersecurity {name}." +
                "\nWhich of the following topics interests you the most:" +
                "\n(1) What is cybersecurity?" +
                "\n(2) Why is cybersecurity important?" +
                "\n(3) Cybersecurity best practices." +
                "\n(4) Cyberseucurity tools." +
                "\n(5) Popular Cybersecurity companies in South Africa.");

            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Cybersecurity is the practice of protecting internet-connected systems such as hardware, software, and data from cyberthreats and unauthorized access.");
                    break;
                case 2:
                    Console.WriteLine("Cybersecurity is vital to preventing cyberthreats, and attacks aimed at disabling or disrupting a system's operations.");
                    break;
                case 3:
                    Console.WriteLine("Some cybersecurity best practices include having multiple layers of protecting data, hardware and connected netwoks." +
                        "Keeping software up to date and installing firewalls " +
                        "Using strong passwords in conjunction with unigue usernames." +
                        "Using multifactor authentication and access management systems" +
                        "Train users on proper security awareness and disaster recovery processes.");
                    break;
                case 4:
                    Console.WriteLine("Some popular cybersecurity tools include, but are not limited to:" +
                        "Firewalls and Endpoint protection" +
                        "Antimalware and antivirus software" +
                        "Intrusion prevention and detection systems" +
                        "Encryption and vulnerability scanners.");
                    break;
                case 5:
                    Console.WriteLine("Some popular cybersecurity companies in South Africa include SensePost, Cyber Sentinel, and SecureData.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
        public static void Cybercrime(string name)
        {
            Console.WriteLine($"Hey {name} What exactly do you want to know about cybercrime?" +
                "(1) Do you want ot know what cybercrime is?" +
                "(2) Do you want to know the different types of cybercrime?");
            int option = Convert.ToInt32(Console.ReadLine());
            if (option == 1)
            {
                Console.WriteLine("Cybercrime is a crime that either targets or uses computers, networks, or network devices to " +
                    "casue damage, steal inforation, or prevent access to your own devices/data.");
            }
            else if (option == 2)
            {
                Console.WriteLine("These are the different types of cybercrime that i can tell you about, which one interests you most?:" +
                    "\n(1) Malware attacks" +
                    "\n(2) Phishing" +
                    "\n(3) Distributed DoS attacks" +
                    "\n(4) Social engineering" +
                    "\n(5) Advanced persistent threats" +
                    "\n(6) Identity fraud");
                int type = Convert.ToInt32(Console.ReadLine());
                switch(type)
                {
                    case 1:
                        Console.WriteLine("A malware attack is one where a computer system or network is infected with a virus or otehr type of malware" +
                            "\n(usually through downloading suspicious files or clicking on unverified links) +" +
                            "Cybercriminals use the infected computer to carry out various attacks, stealing information, or damage the computer network. ");
                        break;
                    case 2:
                        Console.WriteLine("Phishing is a type of cybercrime where a cybercriminal impersonates a trusted entity to trick the victim into revealing sensitive information, such as passwords or credit card numbers or business secrets.");
                        break;
                    case 3:
                        Console.WriteLine("A distributed denial-of-service (DDoS) attack is a malicious attempt to disrupt the normal functioning of a targeted server, service, or network by overwhelming it with a flood of traffic.");
                        break;
                    case 4:
                        Console.WriteLine("Social engineering is a type of cybercrime that relies on human interaction to trick users into breaking normal security procedures " +
                            "\n to gain sensitive or protected information.");
                        break;
                    case 5:
                        Console.WriteLine("An advanced persistent threat (APT) is a prolonged and targeted cyberattack in which an intruder infiltrates a network and remains undetected for an extended period." +
                            "\n The goal of API is to steal information without detection.");
                        break;
                    case 6:
                        Console.WriteLine("Identity fraud is a type of cybercrime where a cybercriminal impersonates another person to commit fraud or other crimes." +
                            "\n This can include stealing personal information, such as identity numbers, credit card numbers, and bank account information.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
            }
        }
    }
}
