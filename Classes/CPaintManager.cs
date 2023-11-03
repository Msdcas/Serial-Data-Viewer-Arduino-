using System.Collections.Generic;
using System.Drawing;
using ZedGraph;
using static Arduino_Serial_Data_Viewer.Classes.Common;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal static class CPaintManager
    {
        //private struct stPainter
        //{
        //    public int numOfZedGraph;
        //    public int numOfCurve;
        //    public CPanePainter Painter;

        //    public stPainter(int numOfZedGraph, int numOfCurve, CPanePainter cPanePainter) : this()
        //    {
        //        this.numOfZedGraph = numOfZedGraph;
        //        this.numOfCurve = numOfCurve;
        //        this.Painter = cPanePainter;
        //    }
        //}
        //private static List<ZedGraphControl> lzedGraph = new List<ZedGraphControl>();

        //private static List<stPainter> lPainters = new List<stPainter>();

        //public static int CountGraphPainters
        //{
        //    get { return cGraphPainters.Count; }
        //}

        private static List<CPainter> cGraphPainters = new List<CPainter>();

        public static void ProcessMessage(stSerialMsg serialMsg)
        {
            //var stPainter = GetOrCreatePainter(numOfGraph);  // - для динамического массива объектов ZedGraphControl
            CPainter stPainter = serialMsg.numPainter == 0 ? cGraphPainters[0] : cGraphPainters[1];
            // добавляем точку в график → перерисовка графика
            stPainter.AddPoint(serialMsg.numCurve, int.Parse(serialMsg.msgTextParam));
        }

        public static void AddZedGraphControl(ZedGraphControl graphControl)
        {
            cGraphPainters.Add(new CPainter(graphControl));
        }

        //private static CPanePainter GetOrCreatePainter(int numOfGraph, int numOfCurve)
        //{
        //    var painter = lPainters.Where(p => p.numOfZedGraph == numOfGraph &&
        //    p.numOfCurve == numOfCurve).FirstOrDefault().Painter;

        //    if (painter == null && lPainters.Count < MaxCountOfZedGraphElem)
        //    {
        //        Console.WriteLine($"painter was created for graph {numOfGraph} ");
        //        painter = new CPanePainter(lzedGraph[numOfGraph]);
        //        lPainters.Add(new stPainter(numOfGraph, numOfCurve, painter));
        //    }
        //    return painter;
        //}

        #region Methods for Curve properties and settings
        public static void DeleteCurve(int numPainter, int numCurve)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                cGraphPainters[numPainter].DeleteCurve(numCurve);
        }

        public static void DeleteAllCurvesOnAllPlots()
        {
            foreach (var gp in cGraphPainters)
                for (int i = 0; i < gp.CountCurves; i++)
                    gp.DeleteCurve(i);
        }

        public static int GetCountCurveOnPainter(int numPainter)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                return cGraphPainters[numPainter].CountCurves;
            return -1;
        }

        public static List<string> GetPaintersNames()
        {
            var res = new List<string>();
            foreach (var p in cGraphPainters)
                res.Add(p.PictureName); 
            return res;
        }

        public static void SetPainterName(int numPainter, string name)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                cGraphPainters[numPainter].PictureName = name;
        }

        public static string GetNameAxis(int numPainter, char axis)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                if (axis == 'x' || axis == 'X')
                    return cGraphPainters[numPainter].XAxisName;
                 if (axis == 'y' || axis == 'Y')
                    return cGraphPainters[numPainter].YAxisName;
            return null;
        }

        public static void SetNameAxis(int numPainter, char axis, string name)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
            {
                if (axis == 'x' || axis == 'X')
                    cGraphPainters[numPainter].XAxisName = name;

                if (axis == 'y' || axis == 'Y')
                    cGraphPainters[numPainter].YAxisName = name;
            }
        }

        public static string GetCurveTittle(int numPainter, int numCurve)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                if (numCurve < cGraphPainters[numPainter].CountCurves)
                    return cGraphPainters[numPainter].GetCurveTittle(numCurve);
            return null;
        }

        public static void SetCurveTittle(int numPainter, int numCurve, string name)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                if (numCurve < cGraphPainters[numPainter].CountCurves)
                    cGraphPainters[numPainter].SetCurveTittle(numCurve, name);
                
        }

        public static SymbolType GetCurveSymbolType(int numPainter, int numCurve)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                return cGraphPainters[numPainter].GetCurveSymbolType(numCurve);
            return SymbolType.None;
        }

        public static void SetCurveSymbolType(int numPainter, int numCurve, SymbolType symbolType)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                cGraphPainters[numPainter].SetCurveSymbolType(numCurve, symbolType);
        }

        public static Color GetCurveColor(int numPainter, int numCurve)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                return cGraphPainters[numPainter].GetColorCurve(numCurve);
            return Color.Empty;
        }

        public static void SetColorCurve(int numPainter, int numCurve, Color color)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                cGraphPainters[numPainter].SetColorCurve(numCurve, color);
        }

        public static int GetCountCurvePoints(int numPainter, int numCurve)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                return cGraphPainters[numPainter].GetCountPointsCurve(numCurve);
            return -1;
        }

        public static void SetCountPoints4Curve(int numPainter, int numCurve, int newCount)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                cGraphPainters[numPainter].SetCountPointCurve(numCurve, newCount);
        }

        public static void SetCurveSettings(int numPainter, int numCurve, string tittle,
             Color color, SymbolType symbolType = SymbolType.None)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                cGraphPainters[numPainter].SetCurveProperties(numCurve, tittle, color, symbolType);
        }

        public static int GetTotalNumCurveAddedPoint(int numPainter, int numCurve)
        {
            if (numPainter < cGraphPainters.Count && numPainter >= 0)
                return cGraphPainters[numPainter].GetCurveTotalAddedPoints(numCurve);
            return -1;
        }

        #endregion


    }
}
