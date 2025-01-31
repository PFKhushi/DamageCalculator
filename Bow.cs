using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculator
{
    internal class Bow :  WeaponDamage
    {
        public Bow()
        {
            Rolls = 5;
            Dice = 5;
        }

        new private const int _BASE_DAMAGE = 4;
    }
}
