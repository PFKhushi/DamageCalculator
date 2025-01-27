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
                swordDamage.SetFlame(true);
            }
            else
            {
                swordDamage.SetFlame(false);
            }
            Update();
            
        }
        private void IsMagic(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;

            if (cb.IsChecked == true)
            {
                swordDamage.SetMagic(true);
            }
            else
            {
                swordDamage.SetMagic(false);
            }
            Update();
        }
        public void Update() 
        {
            Damage.Text = "You rolled " + swordDamage.Roll.ToString() + " for " + swordDamage.Damage.ToString() + "/dmg";
        }

        private void RollDamage(object sender, RoutedEventArgs e)
        {
            swordDamage.SetRoll();
            Update();
        }
    }
}
