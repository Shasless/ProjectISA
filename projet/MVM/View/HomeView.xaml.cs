using System.Reflection;
using System.Windows.Controls;
using projet.APIcontroler;

namespace projet.MVM.View
{
    public partial class HomeView : UserControl
    {
        public HomeView()
        {
            InitializeComponent();
            var control = new APIcontrol();
            control.GetRanking();

            s.Text = control.ranking.data[0].getLimitedSymbol();
            s2.Text = control.ranking.data[1].getLimitedSymbol();
            s3.Text = control.ranking.data[2].getLimitedSymbol();
            s4.Text = control.ranking.data[3].getLimitedSymbol();
            s5.Text = control.ranking.data[4].getLimitedSymbol();
            s6.Text = control.ranking.data[5].getLimitedSymbol();
            s7.Text = control.ranking.data[6].getLimitedSymbol();
            s8.Text = control.ranking.data[7].getLimitedSymbol();
            s9.Text = control.ranking.data[8].getLimitedSymbol();
            
            gs.Text = control.ranking.data[0].gs.ToString();
            gs2.Text = control.ranking.data[1].gs.ToString();
            gs3.Text = control.ranking.data[2].gs.ToString();
            gs4.Text = control.ranking.data[3].gs.ToString();
            gs5.Text = control.ranking.data[4].gs.ToString();
            gs6.Text = control.ranking.data[5].gs.ToString();
            gs7.Text = control.ranking.data[6].gs.ToString();
            gs8.Text = control.ranking.data[7].gs.ToString();
            gs9.Text = control.ranking.data[8].gs.ToString();
            
            p.Text = control.ranking.data[0].getLimitedPrice();
            p2.Text = control.ranking.data[1].getLimitedPrice();
            p3.Text = control.ranking.data[2].getLimitedPrice();
            p4.Text = control.ranking.data[3].getLimitedPrice();
            p5.Text = control.ranking.data[4].getLimitedPrice();
            p6.Text = control.ranking.data[5].getLimitedPrice();
            p7.Text = control.ranking.data[6].getLimitedPrice();
            p8.Text = control.ranking.data[7].getLimitedPrice();
            p9.Text = control.ranking.data[8].getLimitedPrice();
            
            pb.Text = control.ranking.data[0].getLimitedPriceBtc();
            pb2.Text = control.ranking.data[1].getLimitedPriceBtc();
            pb3.Text = control.ranking.data[2].getLimitedPriceBtc();
            pb4.Text = control.ranking.data[3].getLimitedPriceBtc();
            pb5.Text = control.ranking.data[4].getLimitedPriceBtc();
            pb6.Text = control.ranking.data[5].getLimitedPriceBtc();
            pb7.Text = control.ranking.data[6].getLimitedPriceBtc();
            pb8.Text = control.ranking.data[7].getLimitedPriceBtc();
            pb9.Text = control.ranking.data[8].getLimitedPriceBtc();

            if (control.ranking.data[0].getLimitedMC() == "1")
            {
                mc.Text = "N/A";
            }
            else
            {
                mc.Text = control.ranking.data[0].getLimitedMC();}
            if (control.ranking.data[1].getLimitedMC() == "1")
            {
                mc2.Text = "N/A";
            }
            else
            {
                mc2.Text = control.ranking.data[1].getLimitedMC();}

            if (control.ranking.data[2].getLimitedMC() == "1")
            {
                mc3.Text = "N/A";
            }
            else
            {
                mc3.Text = control.ranking.data[2].getLimitedMC();}
            if (control.ranking.data[3].getLimitedMC() == "1")
            {
                mc4.Text = "N/A";
            }
            else
            {
                mc4.Text = control.ranking.data[3].getLimitedMC();}
            if (control.ranking.data[5].getLimitedMC() == "1")
            {
                mc6.Text = "N/A";
            }
            else
            {
                mc6.Text = control.ranking.data[5].getLimitedMC();}
            if (control.ranking.data[6].getLimitedMC() == "1")
            {
                mc7.Text = "N/A";
            }
            else
            {
                mc7.Text = control.ranking.data[6].getLimitedMC();}
            if (control.ranking.data[7].getLimitedMC() == "1")
            {
                mc8.Text = "N/A";
            }
            else
            {
                mc8.Text = control.ranking.data[7].getLimitedMC();}
            if (control.ranking.data[8].getLimitedMC() == "1")
            {
                mc9.Text = "N/A";
            }
            else
            {
                mc9.Text = control.ranking.data[8].getLimitedMC();}

            if (control.ranking.data[4].getLimitedMC() == "1")
            {
                mc5.Text = "N/A";
            }
            else
            {
                mc5.Text = control.ranking.data[4].getLimitedMC();}

        }
    }
}