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
        SwordDamage swordDamage;
        public MainWindow()
        {   
            swordDamage = new SwordDamage();
            InitializeComponent();
            
        }
        private void IsFlaming(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb.IsChecked == true) 
            {
                swordDamage.IsFlaming = true;
            }
            else
            {
                swordDamage.IsFlaming = false;
            }
            Update();
            
        }
        private void IsMagic(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.IsChecked == true)
            {
                swordDamage.IsMagic = true;
            }
            else
            {
                swordDamage.IsMagic = false;
            }
            Update();
        }
        public void Update() 
        {
            swordDamage.Damage = 0;
            Damage.Text = "You rolled " + swordDamage.Roll.ToString() + " for " + swordDamage.Damage.ToString() + "/dmg";
            Console.WriteLine(
                $"\nRoll { swordDamage.Roll }" +
                $"\nDamage {swordDamage.Damage}" +
                $"\nIs Magic Bichin {swordDamage.IsMagic}" +
                $"\nIs FlamingMulti {swordDamage.IsFlaming}");
        }

        private void RollDamage(object sender, RoutedEventArgs e)
        {
            swordDamage.Roll = 0;
            Update();
        }
    }
}
