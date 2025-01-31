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
        ListBoxItem currentListBoxItem;
        TextBlock currentDamage;
        dynamic Weapon;

        public MainWindow()
        {
            
            sword = new Sword();
            bow = new Bow();
            axe = new Axe();
            InitializeComponent();

        }
        private void IsFlaming(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.IsChecked == true) 
            {
                Weapon.IsFlaming = true;
                switch (currentListBoxItem.Name)
                {
                    case "Bow":
                        FlamingBow.Visibility = Visibility.Visible;
                        break;
                    case "Sword":
                        FlamingSword.Visibility = Visibility.Visible;
                        break;
                    case "Axe":
                        FlamingAxe.Visibility = Visibility.Visible;
                        break;

                }

            }
            else
            {
                Weapon.IsFlaming = false;
                switch (currentListBoxItem.Name)
                {
                    case "Bow":
                        FlamingBow.Visibility = Visibility.Hidden;
                        break;
                    case "Sword":
                        FlamingSword.Visibility = Visibility.Hidden;
                        break;
                    case "Axe":
                        FlamingAxe.Visibility = Visibility.Hidden;
                        break;

                }
            }
            Update();
            
        }
        private void IsMagic(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.IsChecked == true)
            {
                Weapon.IsMagic = true;
                switch (currentListBoxItem.Name)
                {
                    case "Bow":
                        MagicBow.Visibility = Visibility.Visible;
                        break;
                    case "Sword":
                        MagicSword.Visibility = Visibility.Visible;
                        break;
                    case "Axe":
                        MagicAxe.Visibility = Visibility.Visible;
                        break;

                }
            }
            else
            {
                Weapon.IsMagic = false;
                switch (currentListBoxItem.Name)
                {
                    case "Bow":
                        MagicBow.Visibility = Visibility.Hidden;
                        break;
                    case "Sword":
                        MagicSword.Visibility = Visibility.Hidden;
                        break;
                    case "Axe":
                        MagicAxe.Visibility = Visibility.Hidden;
                        break;

                }
            }
            Update();
        }
        public void Update() 
        {
            Weapon.Damage = 0;
            Damage.Text = "You rolled " + Weapon.Roll.ToString() + " for " + Weapon.Damage.ToString() + "/dmg";
            Console.WriteLine(
                $"\nRoll {Weapon.Roll }" +
                $"\nDamage {Weapon.Damage}" +
                $"\nIs Magic Bichin {Weapon.IsMagic}" +
                $"\nIs FlamingMulti {Weapon.IsFlaming}");
        }

        private void RollDamage(object sender, RoutedEventArgs e)
        {
            if (Weapon == null) return;
            Weapon.Roll = 0;
            Update();
        }



        private void Selected(object sender, RoutedEventArgs e)
        {
            Console.WriteLine(sender);

            ListBoxItem lbi = sender as ListBoxItem;

            Console.WriteLine(lbi.Name);
            
            currentListBoxItem = lbi;
            switch (lbi.Name) 
            {
                case "Bow":
                    Weapon = bow;
                    break;
                case "Sword":
                    Weapon = sword;
                    break;
                case "Axe":
                    Weapon = axe;
                    break;

            }
            Flaming.IsChecked = false;
            Magic.IsChecked = false;
            Weapon.IsMagic = false;
            Weapon.IsFlaming = false;
            RemoveBuffs();
            Update();
        }
        private void RemoveBuffs() 
        {
            MagicBow.Visibility = Visibility.Hidden;
            MagicAxe.Visibility = Visibility.Hidden;
            MagicSword.Visibility = Visibility.Hidden;
            FlamingAxe.Visibility = Visibility.Hidden;
            FlamingBow.Visibility = Visibility.Hidden;
            FlamingSword.Visibility = Visibility.Hidden;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
