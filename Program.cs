using System;

namespace very_hard
{
    class Program
    {
        static void Main(string[] args)
        {
            //this condition is what dictates if the while loop should keep going 
            bool condition = true;

            //while loop keeps prompting user to convert 
            while (condition == true)
            {
                //prompts user to enter a number(brought in as a string), which is then parsed into a interger 
                Console.WriteLine("Please insert a number to convert it!");
                string response = Console.ReadLine();
                int numChoice = int.Parse(response);


                //ask the user what conversion type they want to use
                Console.WriteLine();
                Console.WriteLine("What conversion do you want to take place? The available types are:");
                Console.WriteLine();
                Console.WriteLine("I: Convert from inches to centimeters.");
                Console.WriteLine("G: Convert from gallons to liters.");
                Console.WriteLine("M: Convert from mile to kilometer.");
                Console.WriteLine("P: Convert from pound to kilogram.");
                Console.WriteLine();

                //the user enters the converstion type, it is set to a char and then set to all upper case
                string convert = Console.ReadLine();
                char conversionType = char.ToUpper(Convert.ToChar(convert));

                //the type 'double' is used so that numbers are allowed to have decimals
                double outcome;
                
                //switch case is used for each conversion type and takes the params 'conversionType', 
                switch(conversionType)
                {
                    //the number that the user chose is multiplied by the number that converts it to the other unit of measurement, which is displayed to the console along with a thank you message, the condition is changed to false so the while loop will stop, and finally the switch case is broken
                    case 'I':
                        outcome = numChoice * 2.54;
                        Console.WriteLine("You converted {0} inch(es) to {1} centimeter(s)", numChoice, outcome);
                        Console.WriteLine();
                        Console.WriteLine("Thank you for letting us help you!");
                        condition = false;
                        break;


                    //the number that the user chose is multiplied by the number that converts it to the other unit of measurement, which is displayed to the console along with a thank you message, the condition is changed to false so the while loop will stop, and finally the switch case is broken
                    case 'G':
                        outcome = numChoice * 3.785;
                        Console.WriteLine("You converted {0} gallon(s) to {1} liter(s)", numChoice, outcome);
                        Console.WriteLine();
                        Console.WriteLine("Thank you for letting us help you!");
                        condition = false;
                        break;

                    //the number that the user chose is multiplied by the number that converts it to the other unit of measurement, which is displayed to the console along with a thank you message, the condition is changed to false so the while loop will stop, and finally the switch case is broken
                    case 'M':
                        outcome = numChoice * 1.609;
                        Console.WriteLine("You converted {0} mile(s) to {1} kilometer(s)", numChoice, outcome);
                        Console.WriteLine();
                        Console.WriteLine("Thank you for letting us help you!");
                        condition = false;
                        break;

                    //the number that the user chose is multiplied by the number that converts it to the other unit of measurement, which is displayed to the console along with a thank you message, the condition is changed to false so the while loop will stop, and finally the switch case is broken
                    case 'P':
                        outcome = numChoice * 2.205;
                        Console.WriteLine("You converted {0} pound(s) to {1} kilogram(s)", numChoice,outcome);
                        Console.WriteLine();
                        Console.WriteLine("Thank you for letting us help you!");
                        condition = false;
                        break;

                    //the letter that that the user picked was not an option, therefore it is not recognizable. The user is told this, the switch case is broken, and the while loop allows for the user to try again
                    default:
                        Console.WriteLine("Sorry, this is not a valid conversion!");
                        Console.WriteLine();
                        condition = true;
                        break;
                }

                //FUTURE DEVELOPMENT !!!

                // void checkUserNumber()
                // {
                //     if (response == number)
                //     {
                //         startConvert();
                //     } else {
                //         Console.WriteLine("Please enter a NUMBER to convert it!");
                //         response = Console.ReadLine();
                //         checkUserNumber();
                //     }
                // }
            }
        }
    }
}
