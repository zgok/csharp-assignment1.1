using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1._1
{
    namespace Cricket
    {
        class TestCricketPlayer : CricketPlayer
        {
            //Test id of the player which only belongs to Test class
            public int testid;
            public string name;
            public int age;
            public string date;
            public int noofinnings;
            public int[] testscore = new int[10];



            //parameterized constructor creation



            public TestCricketPlayer(int ctestid, string cname, int cage, string cdate, int cnoofinnings, int[] cscore) : base(cname, cage, cdate)
            {
                testid = ctestid;
                name = cname;
                age = cage;
                date = cdate;
                noofinnings = cnoofinnings;
                testscore = cscore;
            }



            //creating method to find the average score



            public override double getAverage(int innings, int[] score)
            {
                double totalScore = getTotalScore(score);
                double avg = totalScore / innings;
                return avg;
            }



            //creating method to find the total score
            public override double getTotalScore(int[] score)
            {
                int totalScore = 0;
                for (int i = 0; i < score.Length; i++)
                {
                    totalScore += score[i];
                }
                return totalScore;
            }



            //creating method to find the highest score
            public override double getHighestScore(int[] score)
            {
                int max = score[0];
                for (int i = 1; i < score.Length; i++)
                {
                    if (max < score[i])
                    {
                        max = score[i];
                    }
                }
                return max;
            }



            //creating method to find the lowest score
            public override double getLowestScore(int noofinnings, int[] score)
            {
                int min = score[0];
                for (int i = 1; i < noofinnings; i++)
                {
                    if (score[i] < min)
                    {
                        min = score[i];
                    }
                }
                return min;
            }
        }
    }
}
