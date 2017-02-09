using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuofPlanets //Project name, folder, container

{ //Opening brace

    class Program //Name of your class

    { //Program class brace

        static void Main(string[] args) //Main method - start key of the program

        { //Static Main function brace

            //Print a greeting message

            Console.WriteLine("  Welcome to Weights by Planets!"); //Command line - writes into command window
            Console.WriteLine("  ======= == ======= == =======");

            Console.WriteLine(""); //Extra line for format and aesthetic purposes

            Console.WriteLine("   By: Programmer 'Faiza Razi'"); //Creater of the program name
            Console.WriteLine("   ==  ==========  ==========");

            Console.WriteLine(""); //Extra line for format and aesthetic purposes

            Console.WriteLine("        Menu of Planets      "); //List of menu
            Console.WriteLine("        ==== == =======      ");

            Console.WriteLine(""); //Extra line for format and aesthetic purposes

            //Planet names and screen format

            Console.WriteLine("1. Mercury" + "   " + "2. Venus" + "   " + "3. Mars      ");
            Console.WriteLine(""); //Extra line for format and aesthetic purposes
            Console.WriteLine("4. Jupiter" + "   " + "5. Saturn" + "  " + "6. Uranus");
            Console.WriteLine(""); //Extra line for format and aesthetic purposes
            Console.WriteLine("7. Neptune" + "   " + "8. Pluto" + "   " + "9. Quit");
            Console.WriteLine(""); //Extra line for format and aesthetic purposes

            //Loop function will run as long as condition is true.

            bool loop = true; //Loop condition

            while (loop == true) //While loop - IF condition = true

            { //While loop brace

                try //Start of the try function - exception handling

                { //try function brace

                    //Program will rely on switch function to look for the correct scenario user wishes to choose

                    Console.Write(" Enter your menu choice: "); //Message before input value
                    int MenuChoice = int.Parse(Console.ReadLine()); //converts string to integer value + readline
                    Console.WriteLine(); //Extra line for format and aesthetic purposes

                    switch (MenuChoice) //Switch function facilitates user options

                    { //switch function brace

                        //"If" condition is incorporated within cases to support individual choice and facilitate parameters

                        case 8: //input number 8 condition

                            { //Case 8 opening brace

                                Console.WriteLine("You choose Pluto whose factor is: 0.04 "); //Message before input value
                                double Num = 0.04; //Value of Pluto

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0")); //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 8 closing brace

                        case 7: //input number 7 condition

                            { //Case 7 opening brace

                                Console.WriteLine("You choose Neptune whose factor is: 1.12 "); //Message before input value
                                double Num = 1.12; //Value of Neptune

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0"));  //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 7 closing brace

                        case 6: //input number 6 condition

                            { //Case 6 opening brace

                                Console.WriteLine("You choose Uranus whose factor is: 1.15 "); //Message before input value
                                double Num = 1.15; //Value of Uranus

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0"));  //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 6 closing brace

                        case 5: //input number 5 condition

                            { //Case 5 opening brace

                                Console.WriteLine("You choose Saturn whose factor is: 1.15 "); //Message before input value
                                double Num = 1.15; //Value of Saturn

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0"));  //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 5 closing brace

                        case 4: //input number 4 condition

                            { //Case 4 opening brace

                                Console.WriteLine("You choose Jupiter whose factor is: 2.64 "); //Message before input value
                                double Num = 2.64; //Value of Jupiter

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0"));  //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 4 closing brace

                        case 3: //input number 3 condition

                            { //Case 3 opening brace

                                Console.WriteLine("You choose Mars whose factor is: 0.38 "); //Message before input value
                                double Num = 0.38; //Value of Mars

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0"));  //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 3 closing brace

                        case 2: //input number 2 condition

                            { //Case 2 opening brace

                                Console.WriteLine("You choose Venus whose factor is: 0.88 "); //Message before input value
                                double Num = 0.88; //Value of Venus

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0"));  //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 2 closing brace

                        case 1: //input number 1 condition 

                            { //Case 1 opening brace

                                Console.WriteLine("You choose Mercury whose factor is: 0.37 "); //Message before input value
                                double Num = 0.37; //Value of Mercury

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                Console.Write("Enter you weight on Earth: "); //Message before input value
                                double YourWeight = int.Parse(Console.ReadLine()); //converts string to interger value

                                Console.WriteLine(); //Extra line for format and aesthetic purposes

                                if (YourWeight < 1000) //Weight input paramater is less than 1000
                                {
                                    if (YourWeight > 0) //weight input parameter is greater than 0
                                    {

                                        double Cacl = YourWeight * Num; //Weight calculator using multiplier
                                        Console.WriteLine("your Weight is equal to: " + Cacl.ToString("0.0"));  //message displayed plus decimal limitation "+" concatinates condition and message
                                        Console.WriteLine(); //Extra line for format and aesthetic purposes
                                    }

                                    else //else function for input less than 0
                                        Console.WriteLine("You're too thin to exist!"); // Message when input weight is less than or equal to 0
                                }

                                else if (YourWeight >= 1000) //else if statement, when input weight is greater or equal to 1000

                                {
                                    Console.WriteLine("You are too fat to exist!"); //Display message when input is greater or equal to 1000
                                }

                                break; //Break out of case

                            } //Case 1 closing brace

                        //Quit funtion: IF condition = false, fall out of loop.

                        case 9: //input number 9 condition

                            {
                                loop = false; //case 9 = loop condition equals false, so quit the program
                            }

                            break; //break out of case

                        default: //Default is used when choice is ourside of input parameters

                            Console.WriteLine("Your Choice is invalid!"); //Default message is displayed when an invaid choice is made by user i.e 9+ number
                            Console.WriteLine(); //Extra line for format and aesthetic purposes

                            break;

                    } //Closing Switch function brace

                } //Closing try - excepting handling brace

                catch (System.FormatException E) //Will catch any format exceptions i.e. letter inputs instead of number inputs

                { //Opening catch brace

                    Console.WriteLine(); //Extra line for format and aesthetic purposes
                    Console.WriteLine("Invalid Entry! Please try again"); //When error is caught this message will be displayed
                    Console.WriteLine(); //Extra line for format and aesthetic purposes

                } //Closing catch brace

                catch (System.OverflowException O) //Will catch any over flow exceptions i.e. long digits.

                { //Opening catch brace

                    Console.WriteLine(); //Extra line for format and aesthetic purposes
                    Console.WriteLine("Invalid Entry! Please try again"); // When error is caught this message will be displayed
                    Console.WriteLine(); //Extra line for format and aesthetic purposes

                } //Closing catch brace

            } //Closing while loop brace

            Console.WriteLine("Thank you for playing 'Weights by Planets!' please visit again!"); //Program End Message

        } //Closing static Main (start key) brace

    } //Closing class brace

} // Closing brace

