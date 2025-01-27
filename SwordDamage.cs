using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DamageCalculator
{
    internal class SwordDamage
    {
        public const int BASE_DAMAGE = 3;
        public const int FLAME_DAMAGE = 2;
        public int Roll;
        public decimal MagicMultiplier = 1M; 
        public int FlamingDamage = 0; 
        public int Damage;
        Random rand = new Random();

        public void CalculateDamage() 
        {

            Damage = (int) (Roll * MagicMultiplier) + BASE_DAMAGE + FlamingDamage;

            
        }
        public void SetMagic(bool isMagic) 
        {
            if (isMagic)
            {
                MagicMultiplier = 1.75M;
            }
            else
            {
                MagicMultiplier = 1M;
            }
            CalculateDamage();

        }
        public void SetFlame(bool isFlame) 
        {
            if (isFlame)
            {
                FlamingDamage = FLAME_DAMAGE;
            }
            else
            {
                FlamingDamage = 0;
            }
            CalculateDamage();
        }
        public void SetRoll() 
        {
            Roll = 0;
            for (int i = 0; i < 3; i++)
            {
                Roll += rand.Next(6) + 1;
            }
            CalculateDamage();
        }

    }
}
