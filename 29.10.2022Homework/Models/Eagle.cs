using System;
using System.Collections.Generic;
using System.Text;

namespace _29._10._2022Homework.Models
{
    public class Eagle : Bird
    {
        public Eagle()
        {
            Console.WriteLine("Eagle");
        }
        public string Color { get; set; }
        public override void Eat()
        {
            Console.WriteLine("Eagle eating");
        }
    }
}
