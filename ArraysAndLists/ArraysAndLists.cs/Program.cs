using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {
        //creating arrays
        //first way of initializing an array. Long method
        int[] numArray = new int[5]; //the 5 means length is set. can never do more than 5 numbers
        numArray[0] = 5;
        numArray[1] = 2;
        numArray[2] = 10;
        numArray[3] = 200;
        numArray[4] = 5000;

        Console.WriteLine(numArray[3]);
        Console.ReadLine();

        //second way of initializing an array. Shorter
        //no new int number in the [] so the length is not set until initializing is run
        int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        Console.WriteLine(numArray1[3]);
        Console.ReadLine();

        //third way of initializing an array. Even shorter
        int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        //even though you cannot change the length of the array after initializing, you can change the value of the items within.
        numArray2[5] = 650;
        Console.WriteLine(numArray2[5]);
        Console.ReadLine();


        //creating lists

        List<int> intList = new List<int>(); //in lists you do not declare a length
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        Console.WriteLine(intList[0]);
        Console.ReadLine();



        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("Jesse");
        stringList.Remove("Jesse");

        Console.WriteLine(stringList[0]);
        Console.ReadLine();
    }
}

