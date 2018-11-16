using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    public class MyRs232c : SerialPort
    {
        public MyRs232c()
        {
            string[] port = 
            SerialPort.GetPortNames();
            string porta=SerialPort.GetPortNames()[SerialPort.GetPortNames().Length -1];
            PortName = porta;
            BaudRate = 9600;
            Parity = Parity.None;
            DataBits = 8;
            StopBits = StopBits.One;

        }

        public MyRs232c(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName, baudRate, parity, dataBits, stopBits) {
            //portName = base.PortName;
            //baudRate = base.BaudRate;
            //parity = base.Parity;
            //dataBits = base.DataBits;
            //stopBits = base.StopBits;
            


        }

        public void Open(MyRs232c MyObject)
        {
            if (!MyObject.IsOpen)
                MyObject.Open();
        }

        
    }
}
