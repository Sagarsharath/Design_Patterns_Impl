using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern.Abstraction
{
    public abstract class Character
    {
        public string name;
        public Weapon weapon;

        public void Fight()
        {
            Console.WriteLine(this.name + " is fighting with " + this.weapon.UseWeapon());
        }
    }
}
