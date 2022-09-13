using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp6
{
    class Aspirant : student
    {
        public Aspirant(string FName, string LName, string Group, double AvarageMark) : base (FName,LName,Group,AvarageMark)
        {
            this.FName = FName;
            this.LName = LName;
            this.Group = Group;
            this.AvarageMark = AvarageMark;
        }
        public override int getSshcolarship()
        {
            if (AvarageMark == 5)
                ShcolarShip = 20000;
            else
                ShcolarShip = 18000;
            return ShcolarShip;
        }

    }
}
