using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace ClientServer_smc {
    class MyRs232 : SerialPort {
        public MyRs232() {

            PortName = SerialPort.GetPortNames()[SerialPort.GetPortNames().Length - 2];
            BaudRate = 9600;
            Parity = Parity.None;
            DataBits = 8;
            StopBits = StopBits.One;
            
        }

        public MyRs232(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName, baudRate, parity, dataBits, stopBits) {
            //portName = base.PortName;
            //baudRate = base.BaudRate;
            //parity = base.Parity;
            //dataBits = base.DataBits;
            //stopBits = base.StopBits;


        }

        public void Open(MyRs232 MyObject) {
            if (!MyObject.IsOpen)
                MyObject.Open();
        }

    }
}
