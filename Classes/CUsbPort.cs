using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Management;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal static class CUsbPort
    {
        public struct stUsbPort
        {
            public string DeviceID;
            public string PNPDeviceID;
            public string Description;
            public override string ToString()
            {
                return $"{Description}---{DeviceID}---{PNPDeviceID}";
            }
        }
        private static List<stUsbPort> _Ports = new List<stUsbPort>();

        public static List<stUsbPort> ScanPorts()
        {
            _Ports.Clear();

            ManagementObjectSearcher device_searcher = new ManagementObjectSearcher("SELECT * FROM Win32_USBHub");
            foreach (ManagementObject usb_device in device_searcher.Get())
            {
                stUsbPort temp;
                temp.DeviceID = usb_device.Properties["DeviceID"].Value.ToString();
                temp.PNPDeviceID = usb_device.Properties["PNPDeviceID"].Value.ToString();
                temp.Description = usb_device.Properties["Description"].Value.ToString();

                _Ports.Add(temp);
            }
            return _Ports;
        }

        public static CResult Send(string msg)
        {
            // some code

            return new CResult(false, $"USB send: {null}");
        }

        public static void Open(string usbParams)
        {
            var usbParam = usbParams.Split(new[] { "---" }, StringSplitOptions.RemoveEmptyEntries);
            // where usbParam[0] = DeviceID
            // usbParam[1] = PNPDeviceID
            // Description[2] = Description

            // some code
        }

    }
}
