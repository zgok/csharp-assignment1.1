using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1._1
{
    namespace Cricket
    {
        class ODICricketPlayer : CricketPlayer
        {
            //odi id of the player which only belongs to odi class
            public int odiid;
            public string name;
            public int age;
            public string date;
            public int noofinnings;
            public int[] odiscore = new int[10];



            //parameterized constructor creation



            public ODICricketPlayer(int codiId, string cname, int cage, string cdate, int cnoofinnings, int[] cscore) : base(cname, cage, cdate)
            {
                odiid = codiId;
                name = cname;
                age = cage;
                date = cdate;
                noofinnings = cnoofinnings;
                odiscore = cscore;
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