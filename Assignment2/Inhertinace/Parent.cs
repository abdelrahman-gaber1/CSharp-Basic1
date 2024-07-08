using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Inhertinace
{
    internal class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int _x , int _y)
        {
           X = _x;
           Y = _y; 
        }
        public Parent()
        {
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        public long proudct()
        {
            return X * Y;
        }
    } 
}
