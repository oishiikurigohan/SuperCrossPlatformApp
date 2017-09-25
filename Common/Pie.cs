using OxyPlot.Series;

namespace Common
{
    public static class Pie
    {
        public static string Title { get; private set; }
        public static PieSeries Data { get; private set; }

        static Pie()
        {
            Title = "Favorite Ramen";
            Data = new PieSeries { StrokeThickness = 0.8, InsideLabelPosition = 0.8, AngleSpan = 360, StartAngle = 270 };
            Data.Slices.Add(new PieSlice("Soy Sauce", 30) { IsExploded = true });
            Data.Slices.Add(new PieSlice("Miso", 20) { IsExploded = true });
            Data.Slices.Add(new PieSlice("Solt", 15) { IsExploded = true });
            Data.Slices.Add(new PieSlice("Pork Broth", 10) { IsExploded = true });
            Data.Slices.Add(new PieSlice("Seaweed", 5) { IsExploded = true });
            Data.Slices.Add(new PieSlice("Other", 3) { IsExploded = true });
        }
    }
}
