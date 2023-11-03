using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using ZedGraph;

// вопрос: есть ли разница между кривой в массиве_Curvs и в кривой в массиве _GraphPane.CurveList ???
// значения точек и их кол-во при обновлении _GraphPane подтягивает, но не значение цвета и название графика

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal class CPainter
    {
        private const int MaxCountCurve = 5;

        private ZedGraphControl _ZedGraph = new ZedGraphControl();
        private List<CCurve> _Curvs = new List<CCurve>();


        private const int _CapacityPoints = 500;
        // массив: в какое время пришли данные по точке
        private List<DateTime> dateTimes = new List<DateTime>();

        private double CountVisiblePoint = 0;

        /// <summary>
        /// Массив для сопоставления точек i-го графика между j-м Классом, который эти точки хранит
        /// нужен в виду того, что данные могут прийти непоследовательно, от чего возникает обращение
        /// к элементу массива, которого еще не существует
        /// </summary>
        private struct stСoncordance
        {
            public int curvsIndex;
            public int pointNumCurve;

            public stСoncordance(int curvsListIndex, int pointNumCurve)
            {
                this.curvsIndex = curvsListIndex;
                this.pointNumCurve = pointNumCurve;
            }
        }
        private List<stСoncordance> lConcordance = new List<stСoncordance>();

        #region Propertyes
        public string PictureName
        {
            get { return _GraphPane.Title.Text; }
            set { _GraphPane.Title.Text = value; RedrawGraph(); }
        }

        public string XAxisName
        {
            get { return _GraphPane.XAxis.Title.Text; }
            set { _GraphPane.XAxis.Title.Text = value; RedrawGraph(); }
        }

        public string YAxisName
        {
            get { return _GraphPane.YAxis.Title.Text; }
            set { _GraphPane.YAxis.Title.Text = value; RedrawGraph(); }
        }

        public int CountCurves
        {
            get { return _GraphPane.CurveList.Count; }
        }

        private GraphPane _GraphPane
        {
            get { if (_ZedGraph != null) return _ZedGraph.GraphPane; else return null; }
        }

        #endregion

        public CPainter(ZedGraphControl zedGraphControl)
        {
            _ZedGraph = zedGraphControl;

            // Включим сетку
            _GraphPane.XAxis.MajorGrid.IsVisible = true;
            _GraphPane.YAxis.MajorGrid.IsVisible = true;
            // Установим цвет для сетки
            _GraphPane.XAxis.MajorGrid.Color = Color.Black;
            _GraphPane.YAxis.MajorGrid.Color = Color.Black;

            // Установим шаг основных меток, равным 5
            _GraphPane.XAxis.Scale.MajorStep = 5;

            // значения оси Х могут выходить за грницы графика
            _GraphPane.IsBoundedRanges = false;

            // Устанавливаем интересующий нас интервал по оси X
            //_GraphPane.XAxis.Scale.Min = -1;
            //_GraphPane.XAxis.Scale.Max = _capacity;

            //_GraphPane.XAxis.Scale.MaxAuto = false;
            //_GraphPane.YAxis.Scale.MaxAuto = false;
            //_GraphPane.XAxis.Scale.MinAuto = false;
            //_GraphPane.YAxis.Scale.MinAuto = false;

            // Немного уменьшим шрифт меток, чтобы их больше умещалось
            _GraphPane.XAxis.Scale.FontSpec.Size = 10;

            // Подпишемся на событие, которое будет вызываться при выводе каждой отметки на оси
            _GraphPane.XAxis.ScaleFormatEvent += new Axis.ScaleFormatHandler(XAxis_ScaleFormatEvent);

            // Подпишемся на сообщение, уведомляющее о том, что пользователь изменяет масштаб графика
            _ZedGraph.ZoomEvent += new ZedGraphControl.ZoomEventHandler(zedGraph_ZoomEvent);

            // Задаем массив сопоставлений для входящих инструкций numCurve метода AddPoint и номером кривой
            //для этих точек в массиве _Curvs (т.к. инструкции могут начать приходить непоследовательно)
            for (int i = 0; i < MaxCountCurve; i++) lConcordance.Add(new stСoncordance(-1, i));
        }

        public void AddPoint(int numCurve, double val)
        {
            if (numCurve > MaxCountCurve)
            {
                //превышено допустимое число кривых на графике
                return;
            }
            // ищем обработчик _Curvs для кривой numCurve через массив сопоставления lConcordance и рисуем график
            for (int i = 0; i < MaxCountCurve; i++)
            {
                if (lConcordance[i].pointNumCurve == numCurve)
                    if (lConcordance[i].curvsIndex == -1)
                    {
                        // добавляем новую кривую в массив всех кривых
                        _Curvs.Add(new CCurve($"Graph number {numCurve}", Common.ContrastColor[numCurve], _CapacityPoints));

                        // записываем данные о сопоставлении между номером этой кривой в массиве и инструкцией numCurve
                        stСoncordance item = lConcordance[i];
                        item.curvsIndex = _Curvs.Count -1;
                        lConcordance[i] = item;
                        
                        // добавляем значение val к нужной кривой
                        _Curvs[item.curvsIndex].AddPoint(val);
                        //добавляем эту кривую в область отображения
                        _GraphPane.AddCurve(_Curvs[item.curvsIndex].Name, _Curvs[item.curvsIndex].points,
                           _Curvs[item.curvsIndex].Color, _Curvs[item.curvsIndex].SymbolType); //LineItem = ...
                    }
                    else _Curvs[lConcordance[i].curvsIndex].AddPoint(val);
            }

            // + проработать вариант добавления точки в элемент _Curvs или _GraphPane.CurveList[i]

            // метод для перерисовывания окна видимости по точкам которые видны на экране
            // + обработчик чтобы брать данные извне от кнопок на форме → сможем добавить больше точек

            //var x_vis = _Curvs.Select(p => p.points.Count).Max();
            _GraphPane.XAxis.Scale.Min = _Curvs[0].currX - 100;
            _GraphPane.XAxis.Scale.Max = _Curvs[0].currX;

            _GraphPane.YAxis.Scale.Min = _Curvs.Select(p => p.MinValue).Min() - 5;
            _GraphPane.YAxis.Scale.Max = _Curvs.Select(p => p.MaxValue).Max() + 5;
            _ZedGraph.AxisChange();

            RedrawGraph();
        }

        public void zedGraph_ZoomEvent(ZedGraphControl sender, ZoomState oldState, ZoomState newState)
        {
            //ZoomState zoomState = new ZoomState(_GraphPane, ZoomState.StateType.Scroll);
            
            // получаем количество отображаемых точек в поле видимости
            //for (int i = 0; i < _GraphPane.CurveList.Count; i++)
            //{
            //    if (_GraphPane.CurveList[i].IsVisible)
            //    {
            //        // Получаем диапазон значений X, отображаемых в окне видимости
            //        double xMin = _GraphPane.XAxis.Scale.Min;
            //        double xMax = _GraphPane.XAxis.Scale.Max;

            //        // Получаем диапазон индексов точек, отображаемых в окне видимости
            //        double startIndex, endIndex;
            //        _GraphPane.CurveList[i].GetRange(out xMin, out xMax, out startIndex, out endIndex, false, true, _GraphPane);

            //        // Увеличиваем счетчик на количество точек кривой, отображаемых в окне видимости
            //        CountVisiblePoint = xMax - xMin + 1;

            //        Console.WriteLine($"visible point on graph for curve {i} = "+ CountVisiblePoint);
            //    }
            //}

        }


        private string XAxis_ScaleFormatEvent(GraphPane pane, Axis axis, double val, int index)
        {
            return index.ToString();

            //DateTime dataTime = GetDataTime(index);
            //string formattedTime = dataTime.ToString("m:s");
            //return formattedTime;
        }

        public void DeleteCurve(int numCurve)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
            {
                _Curvs.RemoveAt(numCurve);
                _GraphPane.CurveList.RemoveAt(numCurve);
                var item = lConcordance.Where(p => p.curvsIndex == numCurve).First();
                lConcordance.Remove(item);
                _ZedGraph.Invalidate();
            }
        }

        public void CleanPane()
        {
            if (_GraphPane != null)
            {
                _GraphPane.CurveList.Clear();
            }
        }

        private void RedrawGraph()
        {
            // Очистим список кривых от прошлых рисунков (кадров)
            //_GraphPane.CurveList.Clear();
            _ZedGraph.Invalidate();
        }

        #region Properties methods

        public string GetCurveTittle(int numCurve)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
                return _GraphPane.CurveList[numCurve].Label.Text;
            return null;
        }

        public void SetCurveTittle(int numCurve, string tittle)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
            {
                _GraphPane.CurveList[numCurve].Label.Text = tittle;
                RedrawGraph();
            }
        }

        public SymbolType GetCurveSymbolType(int numCurve)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
                return _Curvs[numCurve].SymbolType;
            return SymbolType.None;
        }

        /// <summary>
        /// При изменении параметров кривой этот метод вызывать последним так как обновляет
        /// массив удалением и добавлением в отрисовщик
        /// </summary>
        /// <param name="numCurve"></param>
        /// <param name="symbolType"></param>
        public void SetCurveSymbolType(int numCurve, SymbolType symbolType)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
            {
                var item = _GraphPane.CurveList[numCurve] as LineItem;
                if (item != null) item.Symbol.Type = symbolType;

                RedrawGraph();
            }
        }

        public Color GetColorCurve(int numCurve)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
                return _GraphPane.CurveList[numCurve].Color;
            return Color.Empty;
        }

        public void SetColorCurve(int numCurve, Color color)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
            {
                _GraphPane.CurveList[numCurve].Color = color;
                RedrawGraph();
            }
        }

        public int GetCountPointsCurve(int numCurve)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
                return _Curvs[numCurve].Capacity;
            return -1;
        }

        public void SetCountPointCurve(int numCurve, int points)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
                _Curvs[numCurve].Capacity = points;
        }

        public void SetCurveProperties(int numCurve, string tittle,
             Color color = default, SymbolType symbolType = SymbolType.None)
        {
            if (numCurve < _GraphPane.CurveList.Count && numCurve >= 0)
            {
                if (color != Color.Empty)
                    _GraphPane.CurveList[numCurve].Color = color;

                if (!string.IsNullOrEmpty(tittle))
                    _GraphPane.CurveList[numCurve].Label.Text = tittle;

                var item = _GraphPane.CurveList[numCurve] as LineItem;
                if (item != null) item.Symbol.Type = symbolType;

                RedrawGraph();
            }

        }

        public int GetCurveTotalAddedPoints(int numCurve)
        {
            if (numCurve < _Curvs.Count && numCurve >= 0)
                return _Curvs[numCurve].NumTotalPointsAdded;
            return -1;
        }

        #endregion

    }
}