using System;
using System.Collections.Generic;


class Program
{ 
    static void Main(string[] args)
    {
        int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        for (int i = 0; i < testScores.Length; i++)
        {
            if (testScores[i] > 85)
            {
                Console.WriteLine("Passing test score: " + testScores[i]);
            }
        }
        Console.ReadLine();

        string[] names = { "Jesse", "Erik", "Daniel", "Adam" };

        for (int j = 0; j < names.Length; j++)
        {
            //to print all to the console
            Console.WriteLine(names[j]);
        }
        Console.ReadLine();

        string[] names1 = { "Jane", "Erin", "Danielle", "Ada" };

        for (int k = 0; k < names1.Length; k++)
        //to print an individual to the console
        if (names1 [k] == "Jane")
            {
                Console.WriteLine(names1[k]);
            }
            Console.ReadLine();

        List<int> testScores1 = new List<int>();
        testScores1.Add(98);
        testScores1.Add(99);
        testScores1.Add(81);
        testScores1.Add(72);
        testScores1.Add(70);
        testScores1.Add(35);

        foreach (int score in testScores1)
        {
            if (score > 85)
            {
                Console.WriteLine("Passing test score:" + score);
            }
        }
        Console.ReadLine();

        List<string> names2 = new List<string>() { "HTML", "JS", "Python", "CSS" };

        foreach (string name in names2)
        {
            //to print all to the console
            Console.WriteLine(name);
        }
        Console.ReadLine();

        List<string> names3 = new List<string>() { "bootstrap", "node", "json", "jquery" };

        foreach (string name in names3)
        {
            //to print an individual
            if (name == "bootstrap")
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();

            List<int> testScores2 = new List<int>() { 98, 99, 85, 70, 82, 34, 91, 90, 94 };
            List<int> passingScores = new List<int>(); // this is an empty list so we can populate it with the qualifying info from the above list 

            foreach (int score in testScores2)


            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }
            Console.WriteLine(passingScores.Count); //tells us how many passing scores there were
            Console.ReadLine();
        }
    }
}

