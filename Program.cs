using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to store the phone book entries
            const int maxEntries = 100;
            PhoneBookEntry[] phoneBook = new PhoneBookEntry[maxEntries];
            int numEntries = 0;

            while (true)
            {
                Console.WriteLine("1. Add entry");
                Console.WriteLine("2. Search for entry");
                Console.WriteLine("3. List all entries");
                Console.WriteLine("4. Quit");
                Console.Write("Enter a choice: ");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    // Add an entry to the phone book
                    if (numEntries == maxEntries)
                    {
                        Console.WriteLine("Phone book is full");
                    }
                    else
                    {
                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();

                        Console.Write("Enter phone number: ");
                        string phoneNumber = Console.ReadLine();

                        phoneBook[numEntries] = new PhoneBookEntry(name, phoneNumber);
                        numEntries++;
                    }
                }
                else if (choice == 2)
                {
                    // Search for an entry in the phone book
                    Console.Write("Enter name to search for: ");
                    string name = Console.ReadLine();

                    bool found = false;
                    for (int i = 0; i < numEntries; i++)
                    {
                        if (phoneBook[i].Name == name)
                        {
                            Console.WriteLine("Phone number: " + phoneBook[i].PhoneNumber);
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Entry not found");
                    }
                }
                else if (choice == 3)
                {
                    // List all entries in the phone book
                    for (int i = 0; i < numEntries; i++)
                    {
                        Console.WriteLine(phoneBook[i].Name + ": " + phoneBook[i].PhoneNumber);
                    }
                }
                else if (choice == 4)
                {
                    // Quit the program
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                }
            }
        }
    }

    class PhoneBookEntry
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }

        public PhoneBookEntry(string name, string phoneNumber)
        {
            Name = name;
            PhoneNumber = phoneNumber;
        }
    }
}
