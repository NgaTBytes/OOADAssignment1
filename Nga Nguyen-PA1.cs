/*Nga Nguyen
CIDM 4360-70
September 4, 2019
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
        static string ReadExpression(string x)
        {
            string readBack=x;
            return readBack;
        }
        static float FirstNumber(string x)
        {   
            string[] expPart1=x.Split('*');
            string[] expPart2=expPart1[1].Split('=');
            string[] answer=expPart2[1].Split(' ');
            float num1 = float.Parse(expPart1[0]);
            float num2 = float.Parse(expPart2[0]);
            float num3 = float.Parse(answer[0]);
            return num1;
        }
        static float SecondNumber(string x)
        {
            string[] expPart1=x.Split('*');
            string[] expPart2=expPart1[1].Split('=');
            string[] answer=expPart2[1].Split(' ');
            float num1 = float.Parse(expPart1[0]);
            float num2 = float.Parse(expPart2[0]);
            float num3 = float.Parse(answer[0]);
            return num2;   
        }
        static float UserAnswer(string x)
        {
            string[] expPart1=x.Split('*');
            string[] expPart2=expPart1[1].Split('=');
            string[] answer=expPart2[1].Split(' ');
            float num1 = float.Parse(expPart1[0]);
            float num2 = float.Parse(expPart2[0]);
            float num3 = float.Parse(answer[0]);
            return num3;

        }
        static float CheckAnswer(float x, float y, float z)
        {
            float first=x;
            float second=y;
            float third=z;
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
            string rawUserEntry="";
            float rawNum1;
            float rawNum2;
            float rawUserAnswer;
            int expressionsCounter=0;
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
                    //Prompt user to enter expression
                    Console.WriteLine("Please enter a two numbers to multiply and your answer. ");
                    rawUserEntry=Console.ReadLine();
                    Console.WriteLine("You entered: "+ReadExpression(rawUserEntry));
                    expressionsCounter++;
                    rawNum1=FirstNumber(rawUserEntry);
                    rawNum2=SecondNumber(rawUserEntry);
                    rawUserAnswer=UserAnswer(rawUserEntry);
                    oneOrZero=(CheckAnswer(rawNum1, rawNum2, rawUserAnswer));
                    if (oneOrZero==1)
                    {
                        userScore++;
                    }
                    else
                    {
                        compScore++;
                    }
                    break;

                    case 'b':
                    
                    rawNum1=FirstNumber(rawUserEntry);
                    rawNum2=SecondNumber(rawUserEntry);
                    rawUserAnswer=UserAnswer(rawUserEntry);
                    oneOrZero=(CheckAnswer(rawNum1, rawNum2, rawUserAnswer));
                    if (oneOrZero==1)
                    {
                        Console.WriteLine("Your answer is correct. {0} x {1} = {2}", rawNum1, rawNum2, rawUserAnswer);
                    }
                    else
                    {
                        Console.WriteLine("Your answer is incorrect. {0} x {1} = {2}", rawNum1, rawNum2, rawUserAnswer);   
                    }
                    break;

                    case 'c':
                    DisplayScore(userScore, compScore);
                    Console.WriteLine("You have played {0} games.", expressionsCounter);
                    break;
                }
            }
            while(ch!='d');
        }
    }
}
