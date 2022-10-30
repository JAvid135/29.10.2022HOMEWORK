using System;
using System.Collections.Generic;
using System.Text;

namespace _29._10._2022Homework.Models
{
    public class Shark : Fish
    {
        public int TeethCount { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Shark eating");
        }
    }
}
