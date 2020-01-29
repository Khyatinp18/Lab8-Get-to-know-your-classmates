using System;

namespace Get_to_know_your_classmates
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentName = {"Shamita", "Erwin", "Clay"};
            string[] studentFavouriteFood = {"Pad Thai", "Pizza", "Potato Curry"};
            string[] studentFavouriteColor = {"Blue", "Green", "Green"};
            string[] studentHomeTown = { "Hyderabad", "Troy", "Trenton" };

            bool wantToContinue = true;
            string continueEntry = null;

            // dispaly the welcome message and list of students
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? (enter a number 0 - 2):");

            DisplayName(studentName);

            while (wantToContinue)
            {
                wantToContinue = true;
                continueEntry = null;
                
                string userChoice = GetUserInput("Enter Selection:");

                int index = ParseInt(userChoice);
                Console.Write($"Great selection, What would you like to know about {studentName[index]}?");


                userChoice = GetUserInput($"(enter 'hometown', 'favourite food', or 'favourite color':");

                if (userChoice == "favourite food")
                {
                    Console.WriteLine($"{studentName[index]} likes {studentFavouriteFood[index]}.");
                }
                else if (userChoice == "hometown")
                {
                    Console.WriteLine($"{studentName[index]} is from {studentHomeTown[index]}.");
                }
                else if (userChoice == "favourite color")
                {
                    Console.WriteLine($"{studentName[index]} likes {studentFavouriteColor[index]}.");
                }
                else
                {
                    Console.WriteLine("Invalid Entry, please try again.");
                }

                // Ask the user if he/she wants to like to know more about other student
                while (continueEntry != "y" && continueEntry != "n")
                {
                    Console.WriteLine("Would you like to know about other student (y/n)?");
                    continueEntry = (Console.ReadLine().ToLower());


                    // check if user has entered correct input i.e.y or n; if not, ask user for another input
                    if (continueEntry == "y")
                    {
                        wantToContinue = true;

                    }
                    else if (continueEntry == "n")
                    {
                        wantToContinue = false;
                    }
                    else
                    {
                        Console.Write("Invalid Entry, ");
                    }

                }
            }
                   Console.WriteLine("Thank you for your time, Goodbye!");

        }
 
 


        // Display selection numbers and names of the students
        public static void DisplayName(string [] name)
        {
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine($"{i} : {name[i]}");
            }

        }

        // get user selection number for the student
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        // conver the user selection number to an integer
        public static int ParseInt(string input)
        {
            return int.Parse(input);
        }
    }
}
