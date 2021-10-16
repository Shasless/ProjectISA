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
using projet.Core;
using projet.MVM.ViewWodel;

namespace projet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        public string Searchstr
        {
            get
            {
                return MainCoin;

            }
            
            
        }

        public string MainCoin = "Bitcoin";
        

        
       

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void searchclick(object sender, RoutedEventArgs e)
        {
            if (searchbar.Text.Length >= 1)
            {
                coin.Content = searchbar.Text;
                MainCoin = searchbar.Text;
               
            }
            coin.IsChecked = true;
            
            
        }
    }
}