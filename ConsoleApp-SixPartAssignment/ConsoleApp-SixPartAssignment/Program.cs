using System;
using System.Collections.Generic;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        //  Part 1
        //  one-dimensional array of strings
        string[] arrayNames = { "John", "Jacob", "Jesse", "Jessica", "Julia" };

        //  prompts user to enter a noun
        Console.WriteLine("Type a noun.");
        //  user input is save to string variable
        string noun = Console.ReadLine();

        //  iterates through the array
        for (int i = 0; i < arrayNames.Length; i++)
        {
            //  will add the user input to the current string in the array
            arrayNames[i] = arrayNames[i] + "'s " + noun;
        }

        //  iterates through the array and prints to console
        for (int i = 0; i < arrayNames.Length; i++)
        {
            Console.WriteLine(arrayNames[i]);
        }
        //  keeps console running until user exits
        Console.ReadLine();

        //  Part 2
        int num = 0;

        //  will result in an infinite loop
        //while (true)
        //{
        //    Console.WriteLine(num);
        //    num++;
        //}

        //  loop will run as long as condition is true
        while (num < 10)
        {
            Console.WriteLine(num);
            //  adds 1 to num
            num++;
        }

        Console.ReadLine();

        //  Part 3
        int k = 0;
        //  will loop until k is 9
        while (k < 10)
        {
            Console.WriteLine(k);
            k++;
        }
        Console.ReadLine();

        int l = 0;
        //  will loop until l is 10
        while (l <= 10)
        {
            Console.WriteLine(l);
            l++;
        }
        Console.ReadLine();

        //  Part 4
        //  creates a List of string and initializes it
        List<string> listNames = new List<string>();

        //  adds string to List
        listNames.Add("John");
        listNames.Add("Timothy");
        listNames.Add("Jacob");
        listNames.Add("Terry");
        listNames.Add("Amber");
        listNames.Add("Jessica");
        listNames.Add("Julie");
        listNames.Add("Betty");
        listNames.Add("Michael");
        listNames.Add("Jerry");

        //  displays message on console
        Console.WriteLine("Guess a name.");
        //  saves user input to a string variable
        string nameGuessed = Console.ReadLine();

        //  for loop, will loop through the List
        for (int i = 0; i < listNames.Count; i++)
        {
            //  if the name the user input matches a name in the List
            if (nameGuessed == listNames[i])
            {
                //  will print this message on the console
                Console.WriteLine(nameGuessed + " is part the list at index " + listNames.IndexOf(nameGuessed));
                //  will end the loop
                break;
            }
            //  else if the string does not match a string in the list AND the loop has reached the end of the List
            else if (nameGuessed != listNames[i] && i == listNames.Count - 1)
            {
                //  console will print a message and have user input another string
                Console.WriteLine(nameGuessed + " is not part the list.");
                Console.WriteLine("Guess again.");
                nameGuessed = Console.ReadLine();
                //  this will reset the counter to negative one, the for loop will add 1 to i and so i is back to 0 to begin the loop again
                i = -1;
            }
        }
        Console.ReadLine();

        //  Part 5
        //  creates a list of string and initializes it
        List<string> Letters = new List<string>();

        //  adds string to List
        Letters.Add("a");
        Letters.Add("b");
        Letters.Add("c");
        Letters.Add("d");
        Letters.Add("a");
        Letters.Add("a");
        Letters.Add("b");
        Letters.Add("e");
        Letters.Add("f");
        Letters.Add("c");

        //  displays message on console
        Console.WriteLine("Enter a letter: ");
        //  saves user input to variable
        string letterInput = Console.ReadLine();
        //  counter, used to determine how often the user inputted string matches string from the List
        int count = 0;
        //  empty List for integers to keep trap of the indices
        List<int> indexofLetter = new List<int>();

        //  for loop, to iterate through the List
        for (int i = 0; i < Letters.Count; i++)
        {
            //  if the string matches with the string in the List, will add 1 to the counter and save the index to int List
            if (letterInput == Letters[i])
            {
                count++;
                indexofLetter.Add(i);
            }
            //  if loop has been completed and the counter is at 0, this will break the loop and display that the string is not part of the list
            else if (count == 0 && i == Letters.Count - 1)
            {
                Console.WriteLine("That letter is not on the list");
                break;
            }
            //  if the loop has reached the end of the List and the counter is greater than or equal to 2
            else if (count >= 2 && i == Letters.Count - 1)
            {
                Console.WriteLine(letterInput + " occurs at index: ");
                //  this will display each element in the int List
                foreach (int j in indexofLetter)
                {
                    Console.WriteLine(j);
                }
            }
        }
        Console.ReadLine();

        //  Part 6
        //  creates a list of string
        List<string> verbList = new List<string>();
        //  adds string to list
        verbList.Add("run");
        verbList.Add("bike");
        verbList.Add("fly");
        verbList.Add("sing");
        verbList.Add("walk");
        verbList.Add("run");
        verbList.Add("sing");
        verbList.Add("jump");
        verbList.Add("skip");
        verbList.Add("ski");
        verbList.Add("bike");
        verbList.Add("bike");
        verbList.Add("bike");

        //  creates a second list of string; new element will get added to this List depending on the condition
        List<string> newList = new List<string>();
        //  will iterate through each element in verbList
        foreach (string verb in verbList)
        {
            //  if newList is empty, this will add verb from verbList to newList
            if (newList.Count == 0)
            {
                newList.Add(verb);
            }
            //  else if newList is not empty and verb (string) does not exist in newList; verb will be added to newList
            else if (newList.Count > 0 && !newList.Contains(verb))
            {
                newList.Add(verb);
            }
            //  else if newList is not empty and verb does exist in newList; verb will be added along with a message to newList
            else if (newList.Count > 0 && newList.Contains(verb))
            {
                newList.Add(verb + " is a duplicate");
            }
        }
        //  will iterate through each elemen in newList and print out to console.
        foreach (string list in newList)
        {
            Console.WriteLine(list);
        }  
        
        Console.ReadLine();

    }
}

