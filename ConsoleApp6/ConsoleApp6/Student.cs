using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    public class student 
    {
        public string FName;
        public string LName;
        public string Group;
        public double AvarageMark;
  
        public student(string FName, string LName, string Group, double AvarageMark)
        {
            this.FName = FName;
            this.LName = LName;
            this.Group = Group;
            this.AvarageMark = AvarageMark;
        }

        public int ShcolarShip = 0;
        public virtual int getSshcolarship()
        {
            if (AvarageMark == 5)
                ShcolarShip = 10000;
            else
                ShcolarShip = 8000;
            return ShcolarShip;

        }
        
    }
}
