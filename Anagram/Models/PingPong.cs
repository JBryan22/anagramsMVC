using System.Collections.Generic;

namespace PingPongApp.Models
{
    public class PingPong
    {
        public static List<string> CountToNumber(int number)
        {
            List<string> listOfNumbers = new List<string> {};
            for (int i = 1; i <= number; i++)
            {
                if (i % 15 == 0)
                {
                    listOfNumbers.Add("pingpong");
                }
                else if (i % 3 == 0)
                {
                    listOfNumbers.Add("ping");
                }
                else if (i % 5 == 0)
                {
                    listOfNumbers.Add("pong");
                }
                else
                {
                    listOfNumbers.Add(i.ToString());
                }
            }

            return listOfNumbers;
        }

    }
}
