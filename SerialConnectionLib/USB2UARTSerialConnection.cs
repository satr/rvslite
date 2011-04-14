using System.IO.Ports;

namespace SerialConnection{
    public class USB2UARTSerialConnection : SerialConnectionBase{
        public USB2UARTSerialConnection(string portName, int rate, Parity parity, int dataBits, StopBits stopBits, Handshake handshake, int readTimeout, int writeTimeout) : base(portName, rate, parity, dataBits, stopBits, handshake, readTimeout, writeTimeout){
        }

        public override string Name{
            get { return "USB-UART replicator"; }
        }
    }
}