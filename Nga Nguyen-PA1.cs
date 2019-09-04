/*Nga Nguyen
CIDM 4360-70
September 9, 2019
Assignment 1 */

using System;
using System.Collections.Generic;
using System.IO;
/*Write a program that tests the user skills in multiplication by allowing him to enter multiplication
expression form the console in the form: Number1 * Number2 = UserAnswer (e.g. 5.5*6.5=35.75, or
3*5=10). Then the program should evaluate the user expression by calculating the correct answer as
(correctAnswer = Number1 * Number2) and compare it with the user’s answer. The program should keep
track of the count of expressions entered and the count of correct user answers to them. The user gets 1
point if his answer was correct, and 0 points if it was not. The program should repeatedly display a menu
of choices until the user chooses to exit the program.
 */
namespace Assignment_1
{
    class Program
    {
        static char Menu()
        {
            Console.WriteLine("Please select an option.");
            Console.WriteLine("a. Enter expression \nb. Check the answer \nc. Display the score \nd. Exit");
            string rawUserSelection=Console.ReadLine();
            char userSelection=char.Parse(rawUserSelection); 
            return userSelection;           
        }
        static void ReadExpression(string x, string y, string z)
        {             
            Console.WriteLine("The expression you entered is: {0} x {1} = {2}", x, y,z);
        }
        static float CheckAnswer(string x, string y, string z)
        {
            float first=float.Parse(x);
            float second=float.Parse(y);
            float third=float.Parse(z);
            float correctAnswer=first * second;
            if(third==correctAnswer)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }      
        
        
        static void DisplayScore(int x, int y)
        {
            Console.WriteLine("User Score: "+x);
            Console.WriteLine("Computer Score: "+y);
        }
        static void Main(string[] args)
        {   
            //variables to store user entry for first and second number to multiply
            //and user's answer         
            string rawNum1="";
            string rawNum2="";
            string rawUserAnswer="";
            float oneOrZero;
            int userScore=0;
            int compScore=0;
            
            char ch;         
            do
            {
                ch=Menu();
                switch(ch)
                {
                    case 'a':
                    //Prompt user to enter the expression:
                    //first number
                    Console.WriteLine("You will need to enter two numbers to multiply. Please enter the first number:");
                    //reading the user's first entry and storing it as a string value
                    rawNum1=Console.ReadLine();
                    //second number
                    Console.WriteLine("Please enter the second number:");
                    //reading the user's second entry and storing it as a string value
                    rawNum2=Console.ReadLine();
                    //user answer
                    Console.WriteLine("Please enter the answer:");
                    //reading the user's answer entry and storing it as a string value
                    rawUserAnswer=Console.ReadLine();
                    
                    ReadExpression(rawNum1, rawNum2, rawUserAnswer); 

                    break;

                    case 'b':
                    //Console.WriteLine(CheckAnswer(rawNum1, rawNum2, rawUserAnswer));
                    oneOrZero=(CheckAnswer(rawNum1, rawNum2, rawUserAnswer));
                    if (oneOrZero==1)
                    {
                        Console.WriteLine("Your answer is correct. {0} x {1} = {2}", rawNum1, rawNum2, rawUserAnswer);
                        userScore++;
                    }
                    else
                    {
                        Console.WriteLine("Your answer is correct. {0} x {1} = {2}", rawNum1, rawNum2, rawUserAnswer);
                        compScore++;
                    }
                    break;

                    case 'c':
                    DisplayScore(userScore, compScore);
                    
                    break;
                }
            }
            while(ch!='d');
        }
    }
}
