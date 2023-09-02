namespace Tindall_A1_TicketingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TicketManager ticketManager = new TicketManager();

            string menu;
            string fileName = "tickets.csv";



            do
            {
                // Menu Structure for assignment
                Console.WriteLine("1. Write data to ticket");
                Console.WriteLine("2. Read data from ticket");
                Console.WriteLine("3. Exit");
                menu = Console.ReadLine();

                if (menu == "1")
                {
                    ticketManager.ticketWrite(fileName);
                }
                else if (menu == "2")
                {
                    if (File.Exists(fileName))
                    {
                        ticketManager.ticketRead(fileName);
                    }
                    else
                    {
                        Console.WriteLine("File does not exist");
                    }

                }

            } while (menu != "3");

        }
    }
}