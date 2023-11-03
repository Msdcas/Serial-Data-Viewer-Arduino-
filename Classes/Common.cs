using System.Collections.Generic;
using System.Drawing;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal static class Common
    {
        public struct stSerialMsg
        {
            public char paramOperat;
            public int numPainter;
            public int numCurve;
            public string msgTextParam;

            public stSerialMsg(char paramOperat, int numPainter = -1, int numCurve = -1, string msgTextParam = null)
            {
                this.paramOperat = paramOperat;
                this.numPainter = numPainter;
                this.numCurve = numCurve;
                this.msgTextParam = msgTextParam;
            }

            public stSerialMsg(char paramOperat, char numPainter, char numCurve, string msgTextParam = null)
            {
                this.paramOperat = paramOperat;
                this.numPainter = int.Parse(numPainter.ToString());
                this.numCurve = int.Parse(numCurve.ToString());
                this.msgTextParam = msgTextParam;
            }
        }

        public static List<Color> ContrastColor = new List<Color>()
            {   Color.Black,
                Color.Red,
                Color.Blue,
                Color.Green,
                Color.Orange,
                Color.Violet,
                Color.Honeydew,
                Color.Purple,
                Color.PaleGreen,
                Color.Brown
                };


        //public static void CollectContrastColor()
        //{
        //    // Получаем все цвета из пространства ColorKnown
        //    Color[] colors = Enum.GetValues(typeof(KnownColor))
        //        .Cast<KnownColor>()
        //        .Select(kc => Color.FromKnownColor(kc))
        //        .ToArray();

        //    // Создаем список для хранения контрастных цветов
        //    List<Color> contrastColors = new List<Color>();

        //    foreach (Color color in colors)
        //        if (IsContrastColor(color, Color.White))
        //            contrastColors.Add(color);

        //    // Сортируем список контрастных цветов по контрастности -- ошибка - мы получаем цвета только серого оттенка
        //    contrastColors.Sort((c1, c2) => GetContrastRatio(c2, Color.White).CompareTo(GetContrastRatio(c1, Color.White)));

        // -- !!! нужно добавить сортировку по контрастности между цветами

        //    // Выводим первые 20 контрастных цветов
        //    for (int i = 0; i < 20 && i < contrastColors.Count; i++)
        //    {
        //        ContrastColor.Add(contrastColors[i]);
        //        Console.WriteLine(contrastColors[i]);
        //    }
        //}

        //// Метод для проверки контрастности цвета на фоне
        //private static bool IsContrastColor(Color color, Color background)
        //{
        //    double contrastRatio = GetContrastRatio(color, background);
        //    return contrastRatio >= 4.5; // Минимальный контрастный коэффициент для доступности
        //}

        //// Метод для вычисления контрастного коэффициента между двумя цветами
        //private static double GetContrastRatio(Color color1, Color color2)
        //{
        //    double l1 = GetRelativeLuminance(color1);
        //    double l2 = GetRelativeLuminance(color2);
        //    return (Math.Max(l1, l2) + 0.05) / (Math.Min(l1, l2) + 0.05);
        //}

        //// Метод для вычисления относительной яркости цвета
        //private static double GetRelativeLuminance(Color color)
        //{
        //    double r = color.R / 255.0;
        //    double g = color.G / 255.0;
        //    double b = color.B / 255.0;

        //    r = (r <= 0.03928) ? r / 12.92 : Math.Pow((r + 0.055) / 1.055, 2.4);
        //    g = (g <= 0.03928) ? g / 12.92 : Math.Pow((g + 0.055) / 1.055, 2.4);
        //    b = (b <= 0.03928) ? b / 12.92 : Math.Pow((b + 0.055) / 1.055, 2.4);

        //    return 0.2126 * r + 0.7152 * g + 0.0722 * b;
        //}
    }
}
