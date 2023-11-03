using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal class CSerialPortInfo : IComparable
    {
        public CSerialPortInfo() { }

        public CSerialPortInfo(string name, string caption, string pnpdeviceid)
        {
            Name = name;
            Caption = caption;
            PNPDeviceID = pnpdeviceid;

            // build shorter version of PNPDeviceID for better reading
            // from this: BTHENUM\{00001101-0000-1000-8000-00805F9B34FB}_LOCALMFG&0000\7&11A88E8E&0&000000000000_0000000C
            // to this:  BTHENUM\{00001101-0000-1000-8000-00805F9B34FB}_LOCALMFG&0000
            try
            {
                // split by "\" and take 2 elements
                PNPDeviceIDShort = string.Join($"\\", pnpdeviceid.Split('\\').Take(2));
            }
            // todo: check if it can be split instead of using Exception
            catch (Exception)
            {
                // or just take 32 characters if split by "\" is impossible
                PNPDeviceIDShort = pnpdeviceid.Substring(0, 32) + "...";
            }
        }

        public static CSerialPortInfo Parse(string str)
        {
            var param = str.Split(new[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
            return new CSerialPortInfo(param[0], param[1], param[2]);
        }

        /// <summary>
        /// COM port name, "COM3" for example
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// COM port caption from device manager
        /// "Intel(R) Active Management Technology - SOL (COM3)" for example
        /// </summary>
        public string Caption { get; }
        /// <summary>
        /// PNPDeviceID from device manager
        /// "PCI\VEN_8086&DEV_A13D&SUBSYS_224D17AA&REV_31\3&11583659&0&B3" for example
        /// </summary>
        public string PNPDeviceID { get; }
        /// <summary>
        /// Shorter version of PNPDeviceID
        /// "PCI\VEN_8086&DEV_A13D&SUBSYS_224D17AA&REV_31" for example
        /// </summary>
        public string PNPDeviceIDShort { get; }

        /// <summary>
        /// Comparer required to sort by COM port properly (number as number, not string (COM3 before COM21))
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public int CompareTo(object obj)
        {
            try
            {
                int a, b;
                string sa, sb;

                sa = Regex.Replace(Name, "[^0-9.]", "");
                sb = Regex.Replace(((CSerialPortInfo)obj).Name, "[^0-9.]", "");

                if (!int.TryParse(sa, out a))
                    throw new ArgumentException(nameof(CSerialPortInfo) + ": Cannot convert {0} to int32", sa);
                if (!int.TryParse(sb, out b))
                    throw new ArgumentException(nameof(CSerialPortInfo) + ": Cannot convert {0} to int32", sb);

                return a.CompareTo(b);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public override string ToString()
        {
            //return string.Join(Environment.NewLine, Name, Caption, PNPDeviceID);
            return $"{Name}---{Caption}---{PNPDeviceID}";
        }
    }
    
}
