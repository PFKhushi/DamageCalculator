using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculator
{
    internal class Sword :  WeaponDamage
    {
        public Sword() 
        {
            Rolls = 3;
            Dice = 7;
        }

        new private const int _BASE_DAMAGE = 9;
    }
}
