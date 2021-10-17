using System;
using System.Printing;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using projet.MVM.ViewWodel;
using projet.APIcontroler;

namespace projet.MVM.View
{
    public partial class CoinView : UserControl
    {
        public CoinView()
        
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(ShowMetric));
            t.Start();
           




        }

        public async void ShowMetric()
        {
            
           
            this.Dispatcher.BeginInvoke(new Action(() =>  
            {  
                MainWindow mw = (MainWindow) Application.Current.MainWindow;
         
                var p = new APIcontrol();
            
                p.GetInfo(mw.Searchstr);
                title.Text = p.objectRes.data[0].name;
                price.Text= p.objectRes.data[0].price +" $";
                mw.coin.Content = p.objectRes.data[0].name;
                dayex.Text = p.objectRes.data[0].percent_change_24h +"% 24h";
                montheex.Text = p.objectRes.data[0].percent_change_30d +"% 30d";
                weekex.Text = p.objectRes.data[0].percent_change_7d +"% 7d";
                dayex.Foreground = p.objectRes.data[0].percent_change_24h > 0 ? Brushes.GreenYellow: Brushes.Red;
                montheex.Foreground = p.objectRes.data[0].percent_change_30d > 0 ? Brushes.GreenYellow: Brushes.Red;
                weekex.Foreground = p.objectRes.data[0].percent_change_7d > 0 ? Brushes.GreenYellow: Brushes.Red;
                bitprice.Text = p.objectRes.data[0].price_btc+" BTC";
                sigle.Text = p.objectRes.data[0].symbol;

                if (p.objectRes.data[0].market_cap > 1000000)
                {
                    CapMarket.Text = p.objectRes.data[0].market_cap > 1000000000
                        ? ((int) (p.objectRes.data[0].market_cap / 1000000000)) + "B"
                        : ((int) (p.objectRes.data[0].market_cap / 1000000)) + "M";
                }else if (p.objectRes.data[0].market_cap == null)
                {
                    CapMarket.Text = "N/A";

                }
                else
                {
                    CapMarket.Text = p.objectRes.data[0].market_cap.ToString();
                    
                }
                if (p.objectRes.data[0].volume > 1000000)
                {
                    VolMarket.Text = p.objectRes.data[0].volume > 1000000000
                        ? ((int)(p.objectRes.data[0].volume / 1000000000))+ "B"
                        : ((int)(p.objectRes.data[0].volume / 1000000))+ "M";
                }else
                {
                    VolMarket.Text = p.objectRes.data[0].volume.ToString();}

                GalaxySc.Text = p.objectRes.data[0].galaxy_score.ToString();
                altrank.Text = p.objectRes.data[0].alt_rank.ToString();
                //BitmapImage img = new BitmapImage(new Uri("https://dkhpfm5hits1w.cloudfront.net/" + p.objectRes.data[0].name + ".png"));
                //Image.Source = img;
  
            })); 
           
           
            

        }
    }
}