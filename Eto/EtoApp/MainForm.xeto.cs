using Eto.Forms;
using Eto.Serialization.Xaml;
using OxyPlot;
using Eto.OxyPlot;

namespace EtoApp
{
    public class MainForm : Form
    {
        Plot MyPlot = null;

        public MainForm()
        {
            XamlReader.Load(this);

            MyPlot.Model = new PlotModel { Title = Common.Pie.Title };
            MyPlot.Model.Series.Add(Common.Pie.Data);
        }
    }
}
