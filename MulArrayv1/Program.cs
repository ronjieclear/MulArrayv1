using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace MulArrayv1
{
    internal class Program
    {


        public static void Shuffle(Random random, string[,] arr)
        {
            int height = arr.GetUpperBound(0) + 1; // Y
            int width = arr.GetUpperBound(1) + 1; // X

            for (int i = 0; i < height; i++) //loop Y Questions
            {
                int randomRow = random.Next(i, height); //select a random number
                for (int j = 0; j < width; ++j) //retrieve Y and add the to new array
                {
                    string tmp = arr[i, j]; //select rows
                    arr[i, j] = arr[randomRow, j];//add new rows
                    arr[randomRow, j] = tmp; //save to the new array rows
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Multidimensional Array");

            //Create mul array
            string[,] questions = new string[3,2];
            //long hand initialization 
            questions[0, 0] = "Q1";
            questions[1, 0] = "Q2";
            questions[2, 0] = "Q3";
            questions[0, 1] = "A";
            questions[1, 1] = "B";
            questions[2, 1] = "C";


            //create mul array & initialize value
            string[,] QA = new string[8, 6]
                {
                    //0    1   2   3   4   5
                    {"Q1","A","B","C","D","A"},
                    {"Q2","A","B","C","D","B"},
                    {"Q3","A","B","C","D","C"},
                    {"Language use in Prog 2","Python","C#","C++","HTML","C#"},
                    {"Q4","A","B","C","D","D"},
                    {"Q5","A","B","C","D","D"},
                    {"Q6","A","B","C","D","D"},
                    {"Q7","A","B","C","D","D"}
                };

            Random rnd = new Random(); //declare a randomizer
            
            Shuffle(rnd, QA);

            int Ysize=QA.GetLength(0);  //the value is 3 or no of rows
            int Xsize = QA.GetLength(1); //the valyue is 6 or no of cols
            string ca="";
            string ans = "";
            for (int y=0;y<Ysize;y++) ///loop for all rows
            {
                Console.WriteLine(QA[y,0]);
                for (int x = 1; x < Xsize; x++) //loop for cols
                {                   
                    if (x==5)//this is the correct answer
                    {
                         ca = QA[y,x];// correct answer
                    }
                    else
                    {
                        Console.Write(" "+QA[y, x]);                        
                    }                   
                }//end of loop for cols - choices
                Console.WriteLine();
                Console.Write("Answer: ");  //ask answer
                ans = Console.ReadLine();   //read answer
                //determine if the answer is correct
                if (ans == ca) //correct answer
                {
                    Console.WriteLine("Correct!");
                }
                else //wrong answer
                {
                    Console.WriteLine($"The correct answer is: {ca}");
                }                
            }//end of loop for rows - questions
            Console.ReadLine();

        }
    }
}
