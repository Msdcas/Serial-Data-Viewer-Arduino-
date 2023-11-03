using System.Drawing;
using System.Linq;
using ZedGraph;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal class CCurve
    {
        public string Name;
        //public LineItem Curve;
        public Color Color;
        public SymbolType SymbolType = SymbolType.None;

        public int NumTotalPointsAdded { get; private set; } = 0;
        public PointPairList points {  get; private set; } = new PointPairList();

        private int _capacity;
        public int Capacity
        {
            get { return _capacity; }
            set { 
                _capacity = value;
                if (points.Capacity > value)
                    points.RemoveRange(0, points.Capacity - value);
            }
        }

        private int FreqUpdateMaxMin = 5;
        public double MaxValue { get; private set; }
        public double MinValue { get; private set; }

        private int countUpdateMaxMin = 0;
        private double XStep = 1;
        public double currX { get; private set; } = 0;

        //  -----------------------порблема - при прерывании получения данных т.е. не срабатывает метод AddPoint
        // вновь полученные данные будут рисоваться со старой позиции, хотя должны рисоваться с новой.
        //нужно добавить глобальный Тикер для обновления значений Х или добавлять пустые данные

        public CCurve(string name, Color color, int sizePointsList)
        {
            Color = color;
            Name = name;
            Capacity = sizePointsList;
        }

        public void AddPoint(double val)
        {
            points.Add(currX, val);
            currX += XStep;

            if (points.Count > Capacity) points.RemoveAt(0);

            if (countUpdateMaxMin == FreqUpdateMaxMin)
            {
                MaxValue = points.Select(p => p.Y).Max();
                MinValue = points.Select(p => p.Y).Min();
                countUpdateMaxMin = 0;
            }
            else countUpdateMaxMin += 1;

            NumTotalPointsAdded++;
        }


    }
}



