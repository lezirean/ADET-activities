using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// for experimentation: what if i used enums or something to make a more structured code for the switch cases? then based on that enum, every case in switch statement would be referring to some kind of template in C#
// Note: actual namespace depends on the project name.
namespace ADET_activities {  
    public class Program {
        static bool validateArg(int arg) { 
            return ((arg > 3) && (arg % 2) != 0) ? true : false;
        }

        public static void Main(string[] args) {
            int choice = 0;
            int arg = 0;

            do {
                Console.WriteLine("Shape Drawing");
                Console.WriteLine("Choose a number between 1 and 13 (inclusive):");
                Console.WriteLine("1 - Parallelogram");
                Console.WriteLine("2 - Triangle");
                Console.WriteLine("3 - Reverse Triangle");
                Console.WriteLine("4 - Isosceles Triangle");
                Console.WriteLine("5 - Reverse Isosceles Triangle");
                Console.WriteLine("6 - Hourglass");
                Console.WriteLine("7 - Diamond");
                Console.WriteLine("8 - Zero");
                Console.WriteLine("9 - Arrow Up");
                Console.WriteLine("10 - Arrow Down");
                Console.WriteLine("11 - X");
                Console.WriteLine("12 - Bow Tie");
                Console.WriteLine("13 - EXIT PROGRAM");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice) {
                    case 1:                   
                        do {
                            Console.WriteLine("Enter the total number of lines for your PARALLELOGRAM (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if (validateArg(arg)) {
                                act_two_functions.drawParallelogram(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 2:
                        do {
                            Console.WriteLine("Enter the total number of lines for your TRIANGLE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawTriangle(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 3:
                        do {
                            Console.WriteLine("Enter the total number of lines for your REVERSE TRIANGLE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawReverseTriangle(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 4:
                        do {
                            Console.WriteLine("Enter the total number of asterisks as the base for your ISOSCELES TRIANGLE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if (validateArg(arg)) {
                                act_two_functions.drawIsoscelesTriangle(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 5:
                        do {
                            Console.WriteLine("Enter the total number of asterisks as the top for your REVERSED ISOSCELES TRIANGLE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if (validateArg(arg)) {
                                act_two_functions.drawReversedIsoscelesTriangle(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 6:
                        do {
                            Console.WriteLine("Enter the total number of rows for your HOURGLASS FIGURE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawHourglass(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 7:
                        do {
                            Console.WriteLine("Enter the total number of rows for your DIAMOND FIGURE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawDiamond(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 8:
                        do {
                            Console.WriteLine("Enter the total number of rows for your ZERO FIGURE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawZero(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 9:
                        do {
                            Console.WriteLine("Enter the total number of rows for your ARROW UP FIGURE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawArrowUp(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 10:
                        do {
                            Console.WriteLine("Enter the total number of rows for your ARROW UP FIGURE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawArrowDown(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 11:
                        do {
                            Console.WriteLine("Enter the total number of rows for your X FIGURE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawX(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 12:
                        do {
                            Console.WriteLine("Enter the total number of rows for your BOWTIE FIGURE (odd and must be greater than 3)");
                            arg = Convert.ToInt32(Console.ReadLine());

                            if(validateArg(arg)) {
                                act_two_functions.drawBowTie(arg);
                            }
                            else {
                                Console.WriteLine("Invalid input.");
                            }
                        } while(!validateArg(arg));
                        break;
                    case 13:
                        Console.WriteLine("Program Terminated.");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;

                }

            } while(choice >= 1 && choice <= 12);
        }
    }
}