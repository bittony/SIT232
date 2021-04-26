using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1
                    double[] myArray = new double [10];
                    
                    myArray[0] = 1.0;
                    myArray[1] = 1.1;
                    myArray[2] = 1.2;
                    myArray[3] = 1.3;
                    myArray[4] = 1.4;
                    myArray[5] = 1.5;
                    myArray[6] = 1.6;
                    myArray[7] = 1.7;
                    myArray[8] = 1.8;
                    myArray[9] = 1.9;

                    Console.WriteLine("The element at index 0 iun the array is " + myArray[0]);
            
            //Question 2
                    int[] myArray2 = new int [10];

                    for (int i = 0; i < 10; i++)
                    {
                        myArray2[i] = i;
                    }

                    for (int i = 0; i < 10; i++)
                    {
                        Console.WriteLine("The element at position " + i + " in the array is " + myArray2[i]);
                    }
          
            //Question 3
                    int[] studentArray = {87, 68, 94, 100, 83, 78, 85, 91, 76, 87};
                    int total = 0;
            
                    for (int i = 0; i < studentArray.Length; i++)
                    {
                        total += studentArray[i];
                    }

                    Console.WriteLine("The total marks for the student is: " + total);
                    Console.WriteLine("This consist of " + studentArray.Length + " marks");
                    Console.WriteLine("Therefore the average mark is " + (total / studentArray.Length)); 
            
            //Question 4
                    string[] studentNames = new string[6];
                    Console.WriteLine("Please enter 6 student names: ");

                    for (int i = 0; i < studentNames.Length; i++)
                    {
                        studentNames[i] += Console.ReadLine();
                    }
                    for (int i = 0; i < studentNames.Length; i++)
                    {
                        Console.WriteLine(studentNames[i]); 
                    } 
            
            //Question 5
                    double[] myData = new double[10];
                    double currentLargest, currentSmallest;

                    Console.WriteLine("Please Enter 10 values: ");
                    for (int i = 0; i < myData.Length; i++)
                    {
                        myData[i] = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Number at array " + i + " is " + myData[i]);
                    }
                    currentLargest = myData[0];
                    currentSmallest = myData[0];
            
                    for (int i = 0; i < myData.Length; i++)
                    {
                        if (myData[i] > currentLargest)
                        {
                            currentLargest = myData[i];
                        }
                        if (myData[i] < currentSmallest)
                        {
                            currentSmallest = myData[i];
                        }
                        Console.WriteLine("Value in array " + i + " is " + myData[i]);
                    }
                    Console.WriteLine("Current Largest value in the array is: " + currentLargest);
                    Console.WriteLine("Current Smallest value in the array is: " + currentSmallest);
                    
            //Question 6
                    int[,] myArray3 = new int[3, 4] { {1,2,3,4 }, {1,1,1,1,}, {2,2,2,2} };

                    for (int i = 0; i < myArray.GetLength(0); i++)
                    {
                        for (int j = 0; j < myArray.GetLength(1); j++)
                        {
                            Console.WriteLine(myArray3[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

            //Question 7
                    List<string> myStudentList = new List<string>();
                    Random randomValue = new Random();
                    int randomNumber = randomValue.Next(1, 12);

                    Console.WriteLine("You now need to add " + randomNumber + " students to your class list");
                    for (int i = 0; i < randomNumber; i++)
                    {
                        Console.Write("Please enter the name of student " + (i + 1) + ": ");
                        myStudentList.Add(Console.ReadLine());
                        Console.WriteLine();
                    }
            
                    Console.WriteLine("Students in the list are: ");
            
                    for (int i = 0; i < randomNumber; i++)
                    {
                        Console.WriteLine(myStudentList[i]);
                    }
          
            FuncOne();
            FuncTwo();
            FuncThree();
            FuncFour();
        }

        static void FuncOne()
        {
            int oddElements = 0;
            int evenElements = 0;
            Console.WriteLine("Please enter the size of array: ");
            int[] FuncOne = new int[Convert.ToInt32(Console.ReadLine())];

            for (int i = 0; i <= FuncOne.Length; i++)
            {
                if (FuncOne.Length > 10 && i % 2 != 0)
                {
                    oddElements++;
                }
                if (FuncOne.Length <= 10 && i % 2 == 0)
                {
                    evenElements += i;
                }
            }
            
            if (FuncOne.Length > 10)
            {
                Console.WriteLine("The number of odd elements are: " + oddElements);
            }
            else 
                Console.WriteLine("The total product of even elements are: " + evenElements);
        }
        static void FuncTwo()
        {
            List<double> FuncTwoList = new List<double>();
            double total = 0;
            double average;
            FuncTwoList.Add(1);
            FuncTwoList.Add(2);
            FuncTwoList.Add(3);
            FuncTwoList.Add(4);
            FuncTwoList.Add(5);

            for (int i = 0; i < FuncTwoList.Count; i++)
            {
                total += FuncTwoList[i];
            }
            
            average = total / FuncTwoList.Count;
            
            for (int i = 0; i < FuncTwoList.Count; i++)
            {
                FuncTwoList[i] -= average;
            }

            for (int i = 0; i < FuncTwoList.Count; i++)
            {
                Console.WriteLine(FuncTwoList[i]);
            }
        }

        static void FuncThree()
        {
            int[,] myArray = new int[2, 4] { { 6, 3, 3, 4 }, { 9, 2, 12, 1 } };
            List<int> TempList = new List<int>();

            for (int i = 0; i < myArray.GetLength(1); i++)
            {
                for (int j = 0; j < myArray.GetLength(0); j++)
                {
                    if (myArray[j,i] % 3 == 0)
                    {
                        TempList.Add(myArray[j, i]);
                    }
                }
            }
            int[] newArray = TempList.ToArray(); 

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.WriteLine(newArray[i]);
            }
        }   

        public static void FuncFour()
        {
            int[] myArray = new int[4] { 1, 3, 4, 8 };
            int[,] secondArray = new int[myArray.Length, myArray.Length];

            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    secondArray[i, j] = myArray[i] * myArray[j];
                    Console.Write(secondArray[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
