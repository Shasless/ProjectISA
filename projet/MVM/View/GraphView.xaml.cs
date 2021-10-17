using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using projet.APIcontroler;

namespace projet.MVM.View
{
    public partial class GraphView : UserControl
    {
        public GraphView()
        {
            InitializeComponent();
            MainWindow mw = (MainWindow) Application.Current.MainWindow;
            double? resHigh0,resHigh1,resLow0,resLow1,maxHigh,minHigh,ratioHigh,maxLow,minLow,ratioLow;
            APIcontrol r = new APIcontrol();
            r.GetInfo(mw.Searchstr);
            GraphTitle.Text = r.objectRes.data[0].name;
            
            List<double?> highL = new List<double?>();
            foreach (var t in r.objectRes.data[0].timeSeries)
            {
                highL.Add(t.high);
            }
            
            List<double?> lowL = new List<double?>();
            foreach (var t in r.objectRes.data[0].timeSeries)
            {
                lowL.Add(t.low);
            }

            maxHigh = highL.Max();
            minHigh = highL.Min();
            ratioHigh = 130 / (maxHigh - minHigh);

            maxLow = lowL.Max();
            minLow = lowL.Min();
            ratioLow = 130 / (maxLow - minLow);

            highMaxAmount.Text = r.objectRes.data[0].getLimitedHigh(highL.IndexOf(maxHigh))+"$";
            highMinAmount.Text = r.objectRes.data[0].getLimitedHigh(highL.IndexOf(minHigh))+"$";
            lowMaxAmount.Text = r.objectRes.data[0].getLimitedLow(lowL.IndexOf(maxLow))+"$";
            lowMinAmount.Text = r.objectRes.data[0].getLimitedLow(lowL.IndexOf(minLow))+"$";

            Path pHigh,pLow;

            LineGeometry lHigh,lLow;
            
            
            for (int i = 0; i < 23; i++)
            {
                pHigh = new Path();
                pHigh.Stroke = System.Windows.Media.Brushes.Red;
                pHigh.StrokeThickness = 3;
                pLow = new Path();
                pLow.Stroke = System.Windows.Media.Brushes.Blue;
                pLow.StrokeThickness = 3;
                
                lHigh = new LineGeometry();
                lLow = new LineGeometry();
                
                resHigh0 = r.objectRes.data[0].timeSeries[i].high;
                resLow0 = r.objectRes.data[0].timeSeries[i].low;
                resHigh1 = r.objectRes.data[0].timeSeries[i+1].high;
                resLow1 = r.objectRes.data[0].timeSeries[i+1].low;
                
                
                lHigh.StartPoint = new Point(i*20, ((resHigh0 - minHigh) * ratioHigh + 10).GetValueOrDefault());
                lHigh.EndPoint = new Point((i + 1) * 20,((resHigh1 - minHigh) * ratioHigh + 10).GetValueOrDefault());
                lLow.StartPoint = new Point(i*20,((resLow0 - minLow) * ratioLow + 10).GetValueOrDefault());
                lLow.EndPoint = new Point((i + 1) * 20,((resLow1 - minLow) * ratioLow + 10).GetValueOrDefault());
                
                pHigh.Data = lHigh;
                pLow.Data = lLow;
                GraphHigh.Children.Add(pHigh);
                GraphLow.Children.Add(pLow);

            }

        }
    }
}