using System;

namespace Assignment1._1
{
    class TestMain
    {
        static void Main(string[] args)
        {
            //array for storing odiscores



            int[] ODIscores = new int[10];



            //array for storing Testscores



            int[] Testscores = new int[10];
            Cricket.ODICricketPlayer[] ob = new Cricket.ODICricketPlayer[10];
            Cricket.TestCricketPlayer[] ob2 = new Cricket.TestCricketPlayer[10];



            //taking ODICricketPlayer class Inputs
            Console.WriteLine("-------ODI Details-------");
            Console.WriteLine("Enter the No of players to be inserted in ODI : ");
            int odiLimit = int.Parse(Console.ReadLine());
            for (int i = 0; i < odiLimit; i++)
            {
                Console.WriteLine("Enter the ODIID : ");
                int odiid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Name of player : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the age : ");
                int age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Debue date : ");
                string date = Console.ReadLine();
                Console.WriteLine("Enter the No of Innings played in ODI : ");
                int noofinnings = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the score of each innings :");
                for (int j = 0; j < noofinnings; j++)
                {
                    ODIscores[j] = int.Parse(Console.ReadLine());
                }
                ob[i] = new Cricket.ODICricketPlayer(odiid, name, age, date, noofinnings, ODIscores);

                Console.WriteLine("\n\n");

            }
            //taking TestCricketPlayer class Inputs
            Console.WriteLine("-------Test Details-------");
            Console.WriteLine("Enter the No of players to be inserted in Test : ");
            int testLimit = int.Parse(Console.ReadLine());
            for (int i = 0; i < testLimit; i++)
            {
                Console.WriteLine("Enter the TestId : ");
                int Testid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Name of player : ");
                string testname = Console.ReadLine();
                Console.WriteLine("Enter the age : ");
                int testage = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Debue date : ");
                string testdate = Console.ReadLine();
                Console.WriteLine("Enter the No of Innings played in Test : ");
                int nofinningsTest = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the score of each innings :");
                for (int j = 0; j < nofinningsTest; j++)
                {
                    Testscores[j] = int.Parse(Console.ReadLine());
                }
                ob2[i] = new Cricket.TestCricketPlayer(Testid, testname, testage, testdate, nofinningsTest, Testscores);
                Console.WriteLine("\n\n");
            }



            Console.WriteLine("------------ODI------------");
            //object creation for ODICricketPlayer class
            //  Cricket.CricketPlayer ob = new Cricket.ODICricketPlayer(odiname, odiage, odidate);
            for (int i = 0; i < odiLimit; i++)
            {
                Console.WriteLine($"------Player : {i + 1}-----\n");
                Console.WriteLine($"Player Name    : {ob[i].name}");
                Console.WriteLine($"Player Age     : {ob[i].age}");
                Console.WriteLine($"Debue Date     : {ob[i].debue_date}");
                Console.WriteLine($"Total Score    : {ob[i].getTotalScore(ob[i].odiscore)}");
                Console.WriteLine($"Highest Score  : {ob[i].getHighestScore(ob[i].odiscore)}");
                Console.WriteLine($"Lowest Score   : {ob[i].getLowestScore(ob[i].noofinnings, ob[i].odiscore)}");
                Console.WriteLine($"Average Score  : {ob[i].getAverage(ob[i].noofinnings, ob[i].odiscore)}");
            }
            Console.WriteLine("\n\n-----------Test-----------");
            //object creation for TestCricketPlayer class
            for (int i = 0; i < testLimit; i++)
            {
                Console.WriteLine($"\n------Player : {i + 1}-----\n\n");
                Console.WriteLine($"Player Name    : {ob2[i].name}");
                Console.WriteLine($"Player Age     : {ob2[i].age}");
                Console.WriteLine($"Debue Date     : {ob2[i].debue_date}");
                Console.WriteLine($"Total Score    : {ob2[i].getTotalScore(ob2[i].testscore)}");
                Console.WriteLine($"Highest Score  : {ob2[i].getHighestScore(Testscores)}");
                Console.WriteLine($"Lowest Score   : {ob2[i].getLowestScore(ob2[i].noofinnings, ob2[i].testscore)}");
                Console.WriteLine($"Average Score  : {ob2[i].getAverage(ob2[i].noofinnings, Testscores)}");
            }

        }
    }
}
