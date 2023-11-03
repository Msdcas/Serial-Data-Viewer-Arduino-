using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using ZedGraph;
using static Arduino_Serial_Data_Viewer.Classes.Common;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal static class CSerialDataHandler
    {
        public delegate void MsgIncomingHandler(stSerialMsg message);
        public static event MsgIncomingHandler OnMsgIncoming;

        public delegate void ErrorDescriptionDelegate(string errorDescript);
        public static event ErrorDescriptionDelegate ErrorOccurred;
        public static event ErrorDescriptionDelegate SerialDataIncoming;

        // первый символ инструкции для Label и Кривой
        private static readonly List<char> lInstrLabel = new List<char>() { 'V', 'P' };
        private static readonly List<char> lInstrCurve = new List<char>() { 't', 'c', 's' };

        //private static Queue<string> _MsgsBuf = new Queue<string>();

        private static char _Sep = '*';

        private static string sBuf = null;

        public static void AssembleSerialData(byte[] data)
        {
            string msg = Encoding.UTF8.GetString(data);
            SerialDataIncoming?.Invoke(msg);

            for (int i = 0; i < msg.Length; i++)
            {
                if (msg[i] == _Sep)
                {
                    if (sBuf != null) CheckAndPassToHandler(sBuf);
                    sBuf = null;
                }
                else
                {
                    sBuf += msg[i];
                }

            }
        }

        /// <summary>
        /// Проверяет сообщение на целостность согласно жестко заданным критериям, присущим данному
        /// типу входящего сообщения. Если ок, то передает обработчку
        /// </summary>
        /// <param name="msg"></param>
        private static void CheckAndPassToHandler(string msg)
        {
            //Console.WriteLine(msg);

            stSerialMsg sdata = new stSerialMsg('~');
            var serialData = TakeParameters(msg);
            if (serialData != null) sdata = (stSerialMsg)serialData; // если данные ок, то избавл от nullable типа

            if (sdata.paramOperat == '+')
                OnMsgIncoming.Invoke(sdata);
            else
                switch (sdata.paramOperat)
                {
                    case 't':
                        CPaintManager.SetCurveTittle(sdata.numPainter,
                            sdata.numCurve, sdata.msgTextParam);
                        break;
                    case 'c':
                        var color = Color.FromName(sdata.msgTextParam);
                        if (color != null && color != Color.Empty)
                            CPaintManager.SetColorCurve(sdata.numPainter,
                                sdata.numCurve, color);
                        break;
                    case 's':
                        var symbolType = SymbolType.None;
                        symbolType = (SymbolType)Enum.Parse(typeof(SymbolType), sdata.msgTextParam, true);
                        CPaintManager.SetCurveSymbolType(sdata.numPainter, sdata.numCurve, symbolType);
                        break;
                    case 'P':
                        CLabelParams.SetLabelPreamble(sdata.numCurve, sdata.msgTextParam);
                        break;
                    case 'V':
                        CLabelParams.SetLabelValue(sdata.numCurve, sdata.msgTextParam);
                        break;
                }
        }

        private static stSerialMsg? TakeParameters(string msg)
        {
            /* full format message: *ij_abc*
             * in this class we got next data: ij_abc
             * where i - num of ZedGraphControl. Must be 0 or 1
             * where j - num of pane on ZedGraphControl. Must be beetwin 0 - 9
             * abc - payload = double type
             * 
             * we can display CPanePainter.MaxCountCurve = 5 curves on one graph
             */

            var param = msg.Split(new char[] { '_' }, StringSplitOptions.RemoveEmptyEntries);

            // предполагаем, что пришло сообщение для графика
            if (param == null)
            {
                ErrorOccurred?.Invoke($"Нет данных в сообщении :: {msg}");
                return null;
            }
            if (param.Length < 2)
            {
                ErrorOccurred?.Invoke($"Мало данных в сообщении :: {msg}");
                return null;
            }
            if (param[0].Length < 2)
            {
                ErrorOccurred?.Invoke($"Не полная инструкция :: {msg}");
                return null;
            }
            // жестко заданная проверка на кол-во CPaintManager.cGraphPainters.Count - т.е. на кол-во областей отрисовки
            if (param[0][0] != '0' || param[0][0] != '1') 
            {
                if (param[0].Length == 2)
                    if (lInstrLabel.Contains(param[0][0]) )
                        return new stSerialMsg(param[0][0], '0', param[0][1], param[1]);

                if (param[0].Length == 3)
                    if (lInstrCurve.Contains(param[0][0]) )
                        return new stSerialMsg(param[0][0], param[0][1], param[0][2], param[1]);

                //Console.WriteLine($"Попытка использовать больше областей отрисовки чем есть на форме :: {msg}");
                //return null;
            }

            if (!int.TryParse(param[0], out _) || !double.TryParse(param[1], out _))
            {
                ErrorOccurred?.Invoke($"Не число :: {msg}");
                return null;
            }
            else
                return new stSerialMsg('+', param[0][0], param[0][1], param[1]);
        }

        public static void SetStart_Separator(char separator)
        {
            _Sep = separator;
        }

    }
}
