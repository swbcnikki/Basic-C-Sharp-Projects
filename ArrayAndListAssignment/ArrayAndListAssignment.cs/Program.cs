using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {
        //The string array
        string[] rainbowArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };
        //Question for the user
        Console.WriteLine("Enter a number between 0 and 6 to display a color of the rainbow");
        //Set up for to enter the index to display the color
        int color = Convert.ToInt32(Console.ReadLine());
        if (color <= 6)
        {
            Console.WriteLine(rainbowArray[color]); //going into the array and pulling out the color of the index entered by the user
            Console.ReadLine();// to prevent the screen from closing
        }
        else
        {
            Console.WriteLine("You have entered a number that is not within this index array.");
            Console.ReadLine();
        }



        //Selecting an index of the int array
        int[] numArray = { 7, 8, 9 };
        //Question for the user
        Console.WriteLine("Input 0 or 1 or 2 to reveal the number at that index");
        //display the number associated with the index        
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 2) // bool if else
        {
            Console.WriteLine(numArray[number]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("You have entered a number that is not within this index array.");
            Console.ReadLine();
        }

        //list of strings
        List<string> stateList = new List<string>();
        stateList.Add("North Carolina");
        stateList.Add("South Carolina");
        stateList.Add("North Dakota");
        stateList.Add("South Dakota");
        stateList.Add("West Virginia");

        //question to user
        Console.WriteLine("Select an number between 0 and 4 to reveal a state with a cardinal direction in it's name");
        int state = Convert.ToInt32(Console.ReadLine()); //int is referring to the index

        //display the string associated with the index entered
        Console.WriteLine(stateList[state]);
        Console.ReadLine(); //keep console open to display result
    }
}

