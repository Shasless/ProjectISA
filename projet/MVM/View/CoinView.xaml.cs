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
            title.Text = mw.Searchstr;
            var p = new APIcontrol();
            p.GetInfo("BTC");
            a.Text= p.objectRes.data[0].price.ToString();
            aa.Text= p.objectRes.data[0].symbol.ToString();





        }
    }
}