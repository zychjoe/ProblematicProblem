using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        //static fields to use in Main()
        static string userAnswer;
        static Random rng = new Random();
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            //Welcome the user
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            userAnswer = Console.ReadLine();

            //If they do not want to do the program, exit
            if (userAnswer.ToLower() != "yes")
            {
                Console.WriteLine("GoodBye!");
                return;
            }

            Console.WriteLine();

            //Get their name
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();

            Console.WriteLine();

            //Get their age
            Console.Write("What is your age? ");
            int userAge = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Ask to see a list of activities from our array if not the start the generation of an activity
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            userAnswer = Console.ReadLine();

            if (userAnswer.ToLower() == "yes" || userAnswer.ToLower() == "sure")
            {
                //If they want to see actvities first we loop through them here
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }

                //Ask if they would like to add a custom activity to the list if so they can add as many as they wish
                Console.WriteLine();
                Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                string addToList = Console.ReadLine();
                Console.WriteLine();

                while (addToList.ToLower() != "no")
                {
                    Console.Write("What would you like to add? ");
                    string userAddition = Console.ReadLine();

                    activities.Add(userAddition);

                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.WriteLine("Would you like to add more? yes/no: ");
                    addToList = Console.ReadLine();
                }
            }

            do
            {
                //Random activity generation starts here
                Console.Write("Connecting to the database");

                for (int i = 0; i < 10; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                Console.Write("Choosing your random activity");

                for (int i = 0; i < 9; i++)
                {
                    Console.Write(". ");
                    Thread.Sleep(500);
                }

                Console.WriteLine();

                //Storing a random number
                //rng.Next can take one param that will be 1 less than the specified number passed in
                int randomNumber = rng.Next(activities.Count);

                //Choosing a string from the list based on the random index                
                //This will be overridden every iteration
                string randomActivity = activities[randomNumber];

                //If wine tasting was chosen and they aren't of age, it will choose again
                if (userAge > 21 && randomActivity == "Wine Tasting")
                {
                    Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
                    Console.WriteLine("Pick something else!");

                    //The activity is removed so it will not be selected again
                    activities.Remove(randomActivity);

                    randomNumber = rng.Next(activities.Count);

                    randomActivity = activities[randomNumber];
                }

                //Print the activity and ask if it is acceptable if not acceptable we loop again.
                Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");                
                userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() != "redo")
                {
                    cont = false;
                }

            } while (cont);

            //End main
        }
    }
}
