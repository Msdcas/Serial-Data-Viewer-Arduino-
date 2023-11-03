using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Management;

namespace Arduino_Serial_Data_Viewer.Classes
{
    internal class SerialPorts
    {
        public delegate void OnSerialDataReceive(byte[] data);
        public event OnSerialDataReceive OnSerialDataReceiveHandler;

        private SerialPort _SerialPort;

        public static List<CSerialPortInfo> GetSerialPortsInfo()
        {
            var retList = new List<CSerialPortInfo>();

            // System.IO.Ports.SerialPort.GetPortNames() returns port names from Windows Registry
            var registryPortNames = SerialPort.GetPortNames().ToList();

            var managementObjectSearcher = new ManagementObjectSearcher(@"SELECT * FROM Win32_PnPEntity");
            var managementObjectCollection = managementObjectSearcher.Get();

            foreach (var n in registryPortNames)
            {
                //Console.WriteLine($"Searching for {n}");
                foreach (var p in managementObjectCollection)
                {
                    if (p["Caption"] != null)
                    {
                        string caption = p["Caption"].ToString();
                        string pnpdevid = p["PnPDeviceId"].ToString();

                        //if (caption.Contains("(" + n + ")")) - work good, but ignore virtual ports 
                        if (caption.Contains(n)) 
                        {
                            //Console.WriteLine($"PnPEntity port found: {n}---{caption}---{pnpdevid}");
                            //var props = p.Properties.Cast<PropertyData>().ToArray();
                            retList.Add(new CSerialPortInfo(n, caption, pnpdevid)); // replace null to pnpdevid                               
                            break;
                        }
                    }
                }
            }
            retList.Sort();
            return retList;
        }

        public CResult Send(string message)
        {
            try
            {
                if (_SerialPort != null)
                {
                    _SerialPort.Write(message);
                    return new CResult(true, $"Serial send: msg is sended successully");
                }
            }
            catch (Exception ex) { return new CResult(false, "Failure serial send: " + ex.ToString()); }
            return new CResult(false, $"Port is closed or not set");
        }

        public CResult Open(string portName, int BaudRare, Parity parity, int dataBits,
            StopBits stopBits, Handshake handshake = Handshake.None)
        {
            _SerialPort = new SerialPort();

            _SerialPort.PortName = portName;
            _SerialPort.BaudRate = BaudRare;
            _SerialPort.Parity = parity;
            _SerialPort.DataBits = dataBits;
            //_SerialPort.StopBits = stopBits;   // dont work
            _SerialPort.Handshake = handshake;

            _SerialPort.ReadTimeout = 500;
            _SerialPort.WriteTimeout = 500;

            //if (!_SerialPort.IsOpen)   // dont work
            //    return new CResult(false, $"Access to port {portName} is closed.");

            try {
                _SerialPort.Open();
                Console.WriteLine($"serial port {portName} is opened");

                _SerialPort.DataReceived +=
                    new SerialDataReceivedEventHandler(SerialPort_DataReceived);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return new CResult(false, $"Can't connect: access to port {portName} is closed");
            }
            return new CResult(true, $"Port {portName} successfully is open and listening");
        }

        public CResult Close()
        {
            try
            {
                if (_SerialPort != null)
                    if (_SerialPort.IsOpen)
                    {
                        _SerialPort.Close();
                        return new CResult(true, $"Port {_SerialPort.PortName} is closed");
                    }

            }
            catch (Exception ex) { return new CResult(false, ex.ToString()); }
            return new CResult(false, $"Port is closed or not set");
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int dataLength = _SerialPort.BytesToRead;
            byte[] data = new byte[dataLength];
            int nbrDataRead = _SerialPort.Read(data, 0, dataLength);
            if (nbrDataRead == 0)
                return;

            OnSerialDataReceiveHandler?.Invoke(data);
            //Console.WriteLine(System.Text.Encoding.UTF8.GetString(data));

            // Send data to whom ever interested
            //if (NewSerialDataRecieved != null)
            //    NewSerialDataRecieved(this, new SerialDataEventArgs(data));
        }

    }
}
