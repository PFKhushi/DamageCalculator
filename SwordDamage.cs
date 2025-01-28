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
        private const int _BASE_DAMAGE = 3;
        private const int _FLAME_DAMAGE = 2;
        private int _Roll = 0;
        private int _FlamingDamage = 0;
        private int _Damage = 0;
        private decimal _MagicMultiplier = 1M;
        private bool _IsMagic = false;
        private bool _IsFlaming = false;
        
        static Random rand = new Random();

        /// <summary>
        /// New rolls are triggered by trying to assign a value. 
        /// Ex: "Roll = 0;" will trigger the setter and "int temp = Roll;"
        /// will return the last roll or generate the first roll
        /// </summary>
        public int Roll
        { 
            get => _Roll == 0? _Roll = Enumerable.Range(0, 3).Sum(i => rand.Next(1,6)):_Roll; 
            set { _Roll = Enumerable.Range(0, 3).Sum(i => rand.Next(1, 6)); }
        }
        /// <summary>
        /// Returns the value of assigned to the magic multiplier
        /// based on the IsMagic checker
        /// </summary>
        private decimal MagicMultiplier 
            => _IsMagic ? _MagicMultiplier = 1.75M : _MagicMultiplier = 1M;
        /// <summary>
        /// Returns the value of assigned to the flaming multiplier
        /// based on the IsMagic checker
        /// </summary>
        private int FlamingDamage 
            => _IsFlaming ? _FlamingDamage = _FLAME_DAMAGE : _FlamingDamage = 0;
        /// <summary>
        /// Calculates the damage based on the values assigned
        /// to flame and magic buff checkers
        /// </summary>
        public int Damage 
        {
            get => _Damage; 
            set { _Damage = (int)(Roll * MagicMultiplier) + _BASE_DAMAGE + FlamingDamage; }
        }
        /// <summary>
        /// Sets the value for magic buff true or false
        /// </summary>
        public bool IsMagic
        {
            get { return _IsMagic; }
            set { _IsMagic = value; }
        }
        /// <summary>
        /// Sets the value for flaming buff true or false
        /// </summary>
        public bool IsFlaming
        {
            get { return _IsFlaming; }
            set { _IsFlaming = value; }
        }    
    }
}
