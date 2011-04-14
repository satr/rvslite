using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.Threading;
using SerialConnection;

namespace RVSLiteCom {
    class Program {
        const int PORT_PARAM_INDEX = 0;
        const int RATE_PARAM_INDEX = 1;
        const int MESSAGE_PARAM_INDEX = 2;
        const int DEFAULT_RATE = 9600;
        const string DEFAULT_PORT = "COM3";

        static int Main(string[] args){
            if(args.Length == 0 
                || args[0].ToUpper() == "/H"
                || args[0].ToUpper() == "-H"){
                Console.Out.WriteLine("Send a message vie a serial port");
                Console.Out.WriteLine(string.Empty);
                Console.Out.WriteLine("Usage: RVSLiteCom <PortName> [<Rate>] [<Message>]");
                Console.Out.WriteLine(string.Empty);
                Console.Out.WriteLine("Default param values:");
                Console.Out.WriteLine("Rate - 9600");
                Console.Out.WriteLine("Message - Prog");
                return -1;
            }
            int rate = GetParam(args, RATE_PARAM_INDEX, DEFAULT_RATE);
            using(var con = new USB2UARTSerialConnection("NUL", rate, Parity.None, 8, 
                                                        StopBits.One, Handshake.None, 300, 300)){
                con.Port = GetParam(args, PORT_PARAM_INDEX, DEFAULT_PORT);
                try{
                    con.Connect();
                    Console.Out.WriteLine("Connected to a port {0}, boud rate {1}", con.Port, rate);
                    var message = GetParam(args, MESSAGE_PARAM_INDEX, "Prog");
                    con.WriteLine(message);
                    Console.Out.WriteLine("Message \"{0}\" was sent", message);
                }
                catch (Exception ex){
                    Console.WriteLine("Error on connection: {0}", ex.Message);
                }
            }
            Thread.Sleep(1000);
            Console.Out.WriteLine("Connection was closed");
            return 0;
        }

        static void con_OnAnswerReceived(SerialConnectionBase source) {
            Console.Out.WriteLine(source.LastReadLines);
        }

        private static int GetParam(string[] args, int paramIndex, int defaultValue){
            int value;
            int maxIndex = args.Length - 1;
            return (maxIndex >= paramIndex) && int.TryParse(args[paramIndex], out value)
                        ? value
                        : defaultValue;
        }

        private static string GetParam(string[] args, int paramIndex, string defaultValue){
            int maxIndex = args.Length - 1;
            return (maxIndex >= paramIndex)
                        ? args[paramIndex]
                        : defaultValue;
        }
    }
}
