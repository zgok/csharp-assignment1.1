using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1._1
{
    namespace Cricket
    {
        abstract class CricketPlayer
        {
            public string name { get; set; }
            public int age { get; set; }
            public string debue_date { get; set; }



            //Default constructor creation



            public CricketPlayer()
            {
                Console.WriteLine("Default constructor called");
            }



            //parameterized constructor creation
            public CricketPlayer(string cname, int cage, string cdate)
            {
                name = cname;
                age = cage;
                debue_date = cdate;
            }



            //creating abstract methods
            public abstract double getAverage(int nofinnings, int[] score);
            public abstract double getTotalScore(int[] score);
            public abstract double getHighestScore(int[] score);
            public abstract double getLowestScore(int noofinnings, int[] score);



        }
    }
}
