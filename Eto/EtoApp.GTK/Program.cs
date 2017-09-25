using System;
using Eto.Forms;
using Eto.OxyPlot;

// GTK
namespace EtoApp.GTK
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            var platform = new Eto.GtkSharp.Platform();
            platform.Add(typeof(Plot.IHandler), () => new Eto.OxyPlot.Gtk.PlotHandler());
            new Application(platform).Run(new MainForm());
        }
    }
}
