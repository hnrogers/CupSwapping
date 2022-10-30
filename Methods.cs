using System;

namespace TempProjects
{
    class Working   
    {

    public string CupSwap (string[] cups)
    {
        
        string ball = "B";

        for (int i = 0; i < cups.Count(); i++)
        {
            if (cups[i][0] == cups[i][1])
            {
                continue;
            }
            
            else if (cups[i].Contains(ball))
            {
                ball = cups[i].Remove(cups[i].IndexOf(ball));
                
            }

        }

         return ball;

    }

    }
}