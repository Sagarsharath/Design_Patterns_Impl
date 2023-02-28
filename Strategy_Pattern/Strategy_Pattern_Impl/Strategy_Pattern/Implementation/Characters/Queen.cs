using System;
using System.Collections.Generic;
using System.Text;
using Strategy_Pattern.Abstraction;
using Strategy_Pattern.Implementation.Weapons;

namespace Strategy_Pattern.Implementation.Characters
{
    public class Queen : Character
    {
        public Queen()
        {
            this.name = "Queen";
            this.weapon = new Sword();
        }
    }
}
