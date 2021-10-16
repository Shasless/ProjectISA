using System;
using System.Windows;
using System.Windows.Controls;
using projet.MVM.ViewWodel;
using projet.APIcontroler;

namespace projet.MVM.View
{
    public partial class CoinView : UserControl
    {
        public CoinView()
        {
            InitializeComponent();
            var rand = new Random();
            MainWindow mw = (MainWindow) Application.Current.MainWindow;
            
            var p = new APIcontrol();
            p.GetInfo(mw.Searchstr);
            title.Text = p.objectRes.data[0].name;
            a.Text= p.objectRes.data[0].price.ToString();
            aa.Text= p.objectRes.data[0].symbol;
            mw.coin.Content = p.objectRes.data[0].name;





        }
    }
}