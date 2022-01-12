using System;
using System.Collections.Generic;



    class Program
    {
        static void Main()
        {

        //  array of strings
        string[] strArray = { "Hello", "Goodbye", "Yes", "No", "Maybe" };
        //  displays message for user to choose a number
        Console.WriteLine("Please pick a number between 0 - 4.");
        //  converts number in string to int
        int pickedNumber = Convert.ToInt32(Console.ReadLine());
        //  displays the array at the index the user selected
        Console.WriteLine(strArray[pickedNumber]);
        Console.ReadLine();
        
        // array of int
        int[] intArray = { 500, 2000, 55, 68, 99 };
        Console.WriteLine("Please enter a number.");
        int userNumber = Convert.ToInt32(Console.ReadLine());
        //  if the number is less than length of the array, the selected index will display
        if (userNumber < intArray.Length)
        {
            Console.WriteLine(intArray[userNumber]);
        }
        else
        {
            // if the number is greater than the length of the array, this message will display
            Console.WriteLine("That index does not exist.");
        }

        //  Lists
        List<string> strList = new List<string>();
        //  adds element to List
        strList.Add("One");
        strList.Add("Two");
        strList.Add("Three");
        strList.Add("Four");
        strList.Add("Five");

        Console.WriteLine("Please choose a number between 0 - 4.");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(strList[number]);
        Console.ReadLine();
    }
    }
