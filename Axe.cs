using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamageCalculator
{
    internal class Axe :  WeaponDamage
    {
        new private const int _BASE_DAMAGE = 10;
        public string str = "AXE";
        public void Tester()
        {
            Console.WriteLine(
                $"\n\nName: {str}\n" +
                $"Base Damage: {_BASE_DAMAGE}\n" +
                $"Flaming Damage: {_FLAME_DAMAGE}\n" +
                $"Roll: {Roll}\n" +
                $"Damage: {_Damage}\n" +
                $"Magic Damage: {_MagicMultiplier}\n" +
                $"Is Magic? {_IsMagic}\n" +
                $"Is Flaming? {_IsFlaming}");
        }

    }
}
