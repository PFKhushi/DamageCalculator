using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculator
{
    internal class Axe :  WeaponDamage
    {
        public Axe() 
        {
            Rolls = 2;
            Dice = 9;
        }
        new private const int _BASE_DAMAGE = 10;
    }
}
