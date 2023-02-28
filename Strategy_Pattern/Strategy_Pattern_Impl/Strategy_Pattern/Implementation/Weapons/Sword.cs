using System;
using System.Collections.Generic;
using System.Text;
using Strategy_Pattern.Abstraction;

namespace Strategy_Pattern.Implementation.Weapons
{
    public class Sword : Weapon
    {
        public string UseWeapon()
        {
            return "Sword";
        }
    }
}
