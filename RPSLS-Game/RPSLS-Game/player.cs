using System;
using System.Collections.Generic;

namespace RPSLSGame
{
    public class Player
    {
        // member variables (has a)
        public string name;
        public List<string> Gestures = new List<string>();
        public string gesture;

        // constructor
        public Player()
        {
            
        }

        // member methods (can do)
        // inform the user if wins
        public void Win()
        {
            Console.WriteLine($"{name} won!");
        }

        // inform the user if loses
        public void Lose()
        {
            Console.WriteLine($"{name} lose!");
        }

        // user play
        //public void Play()
        //{
        //    Console.WriteLine($"{name} played {gesture}");
        //}

        // generate random number
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        // add gestures to gestures List
        public void AddGestures()
        {
            Gestures.Add("rock");
            Gestures.Add("paper");
            Gestures.Add("scissors");
            Gestures.Add("lizard");
            Gestures.Add("spock");
        }

        public void Play()
        {
            Console.WriteLine($"{name} played {gesture}");
        }
    }
}
