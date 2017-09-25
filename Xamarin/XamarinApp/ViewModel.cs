using OxyPlot;

namespace XamarinApp
{
    public class ViewModel
    {
        public PlotModel PieModel { get; }

        public ViewModel()
        {
            this.PieModel = new OxyPlot.PlotModel { Title = Common.Pie.Title };
            this.PieModel.Series.Add( Common.Pie.Data );
        }
    }
}
