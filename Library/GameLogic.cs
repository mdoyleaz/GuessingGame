using System;

namespace GuessingGame.Library
{
    public class GameLogic
    {
        public static int RandomNumber(int roundNum)
        {
            var random = new Random();
            return random.Next(1, roundNum * 10);
        }
    }
}