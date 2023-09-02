using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tindall_A1_TicketingSystem
{
    public class TicketManager
    {
        public void ticketWrite(string ticketName)
        {
            int watchCount;
            bool isValidInput = false;
            string[] watchingArray = new string[100];

            StreamWriter sw = new StreamWriter(ticketName, true);

            Console.WriteLine("Enter TicketID");
            var ticketID = Console.ReadLine();

            Console.WriteLine("Enter Summary");
            var summary = Console.ReadLine();

            Console.WriteLine("Enter Status");
            var status = Console.ReadLine();

            Console.WriteLine("Priority");
            var priority = Console.ReadLine();

            Console.WriteLine("Submitter");
            var submitter = Console.ReadLine();

            Console.WriteLine("Assigned");
            var assigned = Console.ReadLine();

            while (true)
            {
                do
                {
                    Console.Write("How many people are watching? ");
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out watchCount))
                    {
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid integer.");
                    }
                } while (!isValidInput);

                for (int i = 0; i < watchCount; i++)
                {
                    Console.WriteLine($"Watching {i + 1}:");
                    watchingArray[i] = Console.ReadLine();
                }
                break;
            }

            var x = 0;
            sw.Write($"{ticketID},{summary},{status},{priority},{submitter},{assigned},");
            for (int i = 0; i < watchCount - 1; i++)
            {
                sw.Write($"{watchingArray[i]}|");
                x++;

            }
            sw.Write(watchingArray[x]);
            sw.WriteLine();

            sw.Close();

        }

        public void ticketRead(string ticketName)
        {
            StreamReader sr = new StreamReader(ticketName);

            // reads the first line to bypass the header
            sr.ReadLine();
            Console.WriteLine();
            while (sr.EndOfStream != true)
            {
                var line = sr.ReadLine();
                Console.WriteLine($"Your line is {line}");
                var lineArray = line.Split(',');

                Console.WriteLine($"TicketID:{lineArray[1]} Summary:{lineArray[2]} Status:{lineArray[3]} Submitter{lineArray[4]} Assigned:{lineArray[5]} Watching:{lineArray[6]} ");
                Console.WriteLine();
            }
            sr.Close();
        }

    }
}
