using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DamageCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WeaponDamage weaponDamage;

        Axe axe;
        Sword sword;
        Bow bow;
        public MainWindow()
        {
            weaponDamage = new  WeaponDamage();
            sword = new Sword();
            bow = new Bow();
            axe = new Axe();
            InitializeComponent();
            bow.Tester();
            axe.Tester();
            sword.Tester();

            
        }
        private void IsFlaming(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.IsChecked == true) 
            {
                weaponDamage.IsFlaming = true;
            }
            else
            {
                weaponDamage.IsFlaming = false;
            }
            Update();
            
        }
        private void IsMagic(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.IsChecked == true)
            {
                weaponDamage.IsMagic = true;
            }
            else
            {
                weaponDamage.IsMagic = false;
            }
            Update();
        }
        public void Update() 
        {
            weaponDamage.Damage = 0;
            Damage.Text = "You rolled " + weaponDamage.Roll.ToString() + " for " + weaponDamage.Damage.ToString() + "/dmg";
            Console.WriteLine(
                $"\nRoll {weaponDamage.Roll }" +
                $"\nDamage {weaponDamage.Damage}" +
                $"\nIs Magic Bichin {weaponDamage.IsMagic}" +
                $"\nIs FlamingMulti {weaponDamage.IsFlaming}");
        }

        private void RollDamage(object sender, RoutedEventArgs e)
        {
            weaponDamage.Roll = 0;
            Update();
        }

        private void Selesctesd(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(1);
        }

        private void ChosenWeapon(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(1);
        }
    }
}
