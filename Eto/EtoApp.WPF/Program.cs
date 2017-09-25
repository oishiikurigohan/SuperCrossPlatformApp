using System;
using Eto.Forms;
using Eto.OxyPlot;

namespace EtoApp.WPF
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var platform = new Eto.Wpf.Platform();
            platform.Add(typeof(Plot.IHandler), () => new Eto.OxyPlot.Wpf.PlotHandler());
            new Application(platform).Run(new MainForm());
        }
    }
}
