﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace WindowsFormsApp1
{
    class Myrs232c : SerialPort
    {
        public Myrs232c()
        {
            PortName = "COM" + (SerialPort.GetPortNames().Length - 1).ToString();
            BaudRate = 9600;
            Parity = Parity.None;
            DataBits = 8;
            StopBits = StopBits.One;

        }

        public Myrs232c(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits) : base(portName, baudRate, parity, dataBits, stopBits) {
            //portName = base.PortName;
            //baudRate = base.BaudRate;
            //parity = base.Parity;
            //dataBits = base.DataBits;
            //stopBits = base.StopBits;
            


        }

        public void Open(Myrs232c MyObject)
        {
            if (!MyObject.IsOpen)
                MyObject.Open();
        }

        
    }
}
